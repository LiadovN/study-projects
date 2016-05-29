using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using TaskGraphicsEditor.Properties;

namespace TaskGraphicsEditor
{
    public partial class Form1 : Form
    {
        #region Constructors
        public Form1()
        {
            InitializeComponent();
            InitializeBitmap();
        }
        #endregion

        #region Fields
        private bool cancel_Flag = false;
        private int shape_Mode;
        private int mode;
        private Point motion_Point;
        private Point first_Point;
        private Point null_Point = new Point(int.MaxValue, 0);
        private Pen pen = new Pen(Color.Black);
        private SolidBrush fill_Brush = new SolidBrush(Color.White);
        private bool equal_Dimension;
        private Items.Item CurrentItem;
        private Bitmap _bitmap;
        private event Action<int> ProcessChanging;
        private event Action<bool> InvertComplete;
        #endregion

        #region Methods
        /// <summary>
        /// Launch ProcessChanging and InvertComplete delegates.
        /// Launch the counter for progressBar
        /// </summary>
        private void VisualizationProgressInverting()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (cancel_Flag)
                    break;
                Thread.Sleep(25);
                ProcessChanging(i);
            }
            InvertComplete(cancel_Flag);
        }
        /// <summary>
        /// The primary Bitmap object initialization 
        /// </summary>
        private void InitializeBitmap()
        {
            try
            {
                _bitmap = (Bitmap)Bitmap.FromFile(@"..\..\Resources\01.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = _bitmap;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(Resources.error1);
            }
        }
        /// <summary>
        /// Drawing shape, accepting parameters Rectangle and Graphics
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        private void DrawShape(Rectangle r, Graphics g)
        {
            switch (shape_Mode)
            {
                case 0:
                    if (CurrentItem == Items.Item.Rectangle)
                        g.FillRectangle(fill_Brush, r);
                    g.DrawRectangle(pen, r);
                    break;
                case 1:
                    if (CurrentItem == Items.Item.Circle)
                        g.FillEllipse(fill_Brush, r);
                    g.DrawEllipse(pen, r);
                    break;
            }
        }
        /// <summary>
        /// Rectangle drawing method,
        /// accepting parameters two points, returns new Rectangle
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        private Rectangle DrawRectMethod(Point p1, Point p2)
        {
            if (equal_Dimension)
            {
                int dx = p2.X - p1.X, dy = p2.Y - p1.Y;
                if (Math.Abs(dx) > Math.Abs(dy))
                    p2.X = p1.X + Math.Sign(dx) * Math.Abs(dy);
                else
                    p2.Y = p1.Y + Math.Sign(dy) * Math.Abs(dx);
            }
            int x = Math.Min(p1.X, p2.X),
                y = Math.Min(p1.Y, p2.Y),
                w = Math.Abs(p2.X - p1.X),
                h = Math.Abs(p2.Y - p1.Y);
            return new Rectangle(x, y, w, h);
        }
        private void DrawMode()
        {
            Point p1 = pictureBox1.PointToScreen(first_Point),
                p2 = pictureBox1.PointToScreen(motion_Point);
            if (mode == 1)
                ControlPaint.DrawReversibleLine(p1, p2, Color.Black);
            else
                ControlPaint.DrawReversibleFrame(DrawRectMethod(p1, p2), Color.Black, (FrameStyle)((shape_Mode + 1) % 2));

        }
        /// <summary>
        /// Setting the property Value of progressBar control
        /// Sending the Action delegate to the Invoke method
        /// Launch Invoke method
        /// </summary>
        /// <param name="progress"></param>
        private void ProcessChange(int progress)
        {
            Action action = () =>
            {
                progressBar.Value = progress;
            };
            try
            {
                Invoke(action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Image invertion, restoring the property Enabled for the button InvertButton4
        /// Sending the Action delegate to the Invoke method
        /// Launch Invoke method
        /// </summary>
        /// <param name="cenceled"></param>
        private void Completed(bool cenceled)
        {
            Action action = () =>
            {
                InvertButton4.Enabled = true;
                _bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = _bitmap;
            };
            try
            {
                Invoke(action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region EventHandlers
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            motion_Point = first_Point = e.Location;
            if (Control.ModifierKeys == Keys.Alt)
            {
                Color c = (pictureBox1.Image as Bitmap).GetPixel(e.X, e.Y);
                if (e.Button == MouseButtons.Left)
                    pictureBox4.BackColor = c;
                else
                    pictureBox3.BackColor = c;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X,Y:{0},{1}", e.X, e.Y);
            if (first_Point == null_Point)
                return;
            if (e.Button == MouseButtons.Left)
                switch (mode)
                {
                    case 0:
                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.DrawLine(pen, first_Point, e.Location);
                        g.Dispose();
                        first_Point = e.Location;
                        pictureBox1.Invalidate();
                        break;
                    case 1:
                    case 2:
                        DrawMode();
                        motion_Point = e.Location;
                        equal_Dimension = Control.ModifierKeys == Keys.Control;
                        DrawMode();
                        break;
                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (first_Point == null_Point)
                return;
            if (mode >= 1)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                switch (mode)
                {
                    case 1:
                        g.DrawLine(pen, first_Point, motion_Point);
                        break;
                    case 2:
                        DrawShape(DrawRectMethod(first_Point, motion_Point), g);
                        break;
                }
                g.Dispose();
                pictureBox1.Invalidate();

            }
        }
        private void PencilButton5_Click(object sender, EventArgs e)
        {
            CurrentItem = Items.Item.Pencil;
            mode = 0;
        }
        private void LineButton6_Click(object sender, EventArgs e)
        {
            CurrentItem = Items.Item.Line;
            mode = 1;
        }

        private void RectButton7_Click(object sender, EventArgs e)
        {
            CurrentItem = Items.Item.Rectangle;
            mode = 2;
            shape_Mode = 0;
        }

        private void CircleButton8_Click(object sender, EventArgs e)
        {
            CurrentItem = Items.Item.Circle;
            mode = 2;
            shape_Mode = 1;
        }
        private void DeleteButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить рисунок?", "Очистка", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
 == DialogResult.Yes)
            {
                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.Clear(Color.White);
                }
                pictureBox1.Invalidate();
            }
        }

        private void SaveBbutton2_Click(object sender, EventArgs e)
        {
            first_Point = null_Point;

            string s0 = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog.FileName;
                if (s.ToUpper() == s0.ToUpper())
                {
                    s0 = Path.GetDirectoryName(s0) + ".png";
                    pictureBox1.Image.Save(s0);
                    pictureBox1.Image.Dispose();
                    File.Delete(s);
                    File.Move(s0, s);
                    pictureBox1.Image = new Bitmap(s);
                }
                else
                    pictureBox1.Image.Save(s);
                Text = "Graphics Editor-" + s;
            }
        }

        private void OpenButton1_Click(object sender, EventArgs e)
        {
            first_Point = null_Point;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog.FileName;
                try
                {
                    Image im = new Bitmap(s);
                    Graphics g = Graphics.FromImage(im);
                    g.Dispose();
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = im;
                }
                catch
                {
                    MessageBox.Show("File" + s + " has a wrong format.", "Error");
                    return;
                }
                Text = "Image Editor-" + s;
                saveFileDialog.FileName = Path.ChangeExtension(s, "png");
                openFileDialog.FileName = "";
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            colorDialog1.Color = pb.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pb.BackColor = colorDialog1.Color;
            pen.Color = pictureBox4.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            colorDialog1.Color = pb.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pb.BackColor = colorDialog1.Color;
            fill_Brush.Color = pictureBox3.BackColor;
        }

        private void InvertButton4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ProcessChanging += ProcessChange;
            f.InvertComplete += Completed;
            InvertButton4.Enabled = false;
            Thread th = new Thread(f.VisualizationProgressInverting);
            th.Start();
        }

        #endregion
    }
}
