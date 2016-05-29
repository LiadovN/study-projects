namespace TaskGraphicsEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InvertButton4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CircleButton8 = new System.Windows.Forms.Button();
            this.RectButton7 = new System.Windows.Forms.Button();
            this.LineButton6 = new System.Windows.Forms.Button();
            this.PencilButton5 = new System.Windows.Forms.Button();
            this.DeleteButton3 = new System.Windows.Forms.Button();
            this.SaveBbutton2 = new System.Windows.Forms.Button();
            this.OpenButton1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(589, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            // 
            // InvertButton4
            // 
            this.InvertButton4.Location = new System.Drawing.Point(180, 12);
            this.InvertButton4.Name = "InvertButton4";
            this.InvertButton4.Size = new System.Drawing.Size(114, 30);
            this.InvertButton4.TabIndex = 7;
            this.InvertButton4.Text = "Инвертирование";
            this.InvertButton4.UseVisualStyleBackColor = true;
            this.InvertButton4.Click += new System.EventHandler(this.InvertButton4_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // CircleButton8
            // 
            this.CircleButton8.Image = global::TaskGraphicsEditor.Properties.Resources.ellip;
            this.CircleButton8.Location = new System.Drawing.Point(468, 12);
            this.CircleButton8.Name = "CircleButton8";
            this.CircleButton8.Size = new System.Drawing.Size(50, 30);
            this.CircleButton8.TabIndex = 11;
            this.CircleButton8.UseVisualStyleBackColor = true;
            this.CircleButton8.Click += new System.EventHandler(this.CircleButton8_Click);
            // 
            // RectButton7
            // 
            this.RectButton7.Image = global::TaskGraphicsEditor.Properties.Resources.rect;
            this.RectButton7.Location = new System.Drawing.Point(412, 12);
            this.RectButton7.Name = "RectButton7";
            this.RectButton7.Size = new System.Drawing.Size(50, 30);
            this.RectButton7.TabIndex = 10;
            this.RectButton7.UseVisualStyleBackColor = true;
            this.RectButton7.Click += new System.EventHandler(this.RectButton7_Click);
            // 
            // LineButton6
            // 
            this.LineButton6.Image = global::TaskGraphicsEditor.Properties.Resources.line;
            this.LineButton6.Location = new System.Drawing.Point(356, 12);
            this.LineButton6.Name = "LineButton6";
            this.LineButton6.Size = new System.Drawing.Size(50, 30);
            this.LineButton6.TabIndex = 9;
            this.LineButton6.UseVisualStyleBackColor = true;
            this.LineButton6.Click += new System.EventHandler(this.LineButton6_Click);
            // 
            // PencilButton5
            // 
            this.PencilButton5.Image = global::TaskGraphicsEditor.Properties.Resources.pencil;
            this.PencilButton5.Location = new System.Drawing.Point(300, 12);
            this.PencilButton5.Name = "PencilButton5";
            this.PencilButton5.Size = new System.Drawing.Size(50, 30);
            this.PencilButton5.TabIndex = 8;
            this.PencilButton5.UseVisualStyleBackColor = true;
            this.PencilButton5.Click += new System.EventHandler(this.PencilButton5_Click);
            // 
            // DeleteButton3
            // 
            this.DeleteButton3.Image = global::TaskGraphicsEditor.Properties.Resources.Delete;
            this.DeleteButton3.Location = new System.Drawing.Point(124, 12);
            this.DeleteButton3.Name = "DeleteButton3";
            this.DeleteButton3.Size = new System.Drawing.Size(50, 30);
            this.DeleteButton3.TabIndex = 6;
            this.DeleteButton3.UseVisualStyleBackColor = true;
            this.DeleteButton3.Click += new System.EventHandler(this.DeleteButton3_Click);
            // 
            // SaveBbutton2
            // 
            this.SaveBbutton2.Image = global::TaskGraphicsEditor.Properties.Resources.Save;
            this.SaveBbutton2.Location = new System.Drawing.Point(68, 12);
            this.SaveBbutton2.Name = "SaveBbutton2";
            this.SaveBbutton2.Size = new System.Drawing.Size(50, 30);
            this.SaveBbutton2.TabIndex = 5;
            this.SaveBbutton2.UseVisualStyleBackColor = true;
            this.SaveBbutton2.Click += new System.EventHandler(this.SaveBbutton2_Click);
            // 
            // OpenButton1
            // 
            this.OpenButton1.Image = global::TaskGraphicsEditor.Properties.Resources.Open;
            this.OpenButton1.Location = new System.Drawing.Point(12, 12);
            this.OpenButton1.Name = "OpenButton1";
            this.OpenButton1.Size = new System.Drawing.Size(50, 30);
            this.OpenButton1.TabIndex = 4;
            this.OpenButton1.UseVisualStyleBackColor = true;
            this.OpenButton1.Click += new System.EventHandler(this.OpenButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(623, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 46);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(653, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 46);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::TaskGraphicsEditor.Properties.Resources._011;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(570, 381);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(570, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 381);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(524, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(183, 30);
            this.progressBar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 441);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.CircleButton8);
            this.Controls.Add(this.RectButton7);
            this.Controls.Add(this.LineButton6);
            this.Controls.Add(this.PencilButton5);
            this.Controls.Add(this.InvertButton4);
            this.Controls.Add(this.DeleteButton3);
            this.Controls.Add(this.SaveBbutton2);
            this.Controls.Add(this.OpenButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(735, 480);
            this.MinimumSize = new System.Drawing.Size(545, 370);
            this.Name = "Form1";
            this.Text = "Graphics Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenButton1;
        private System.Windows.Forms.Button SaveBbutton2;
        private System.Windows.Forms.Button DeleteButton3;
        private System.Windows.Forms.Button InvertButton4;
        private System.Windows.Forms.Button PencilButton5;
        private System.Windows.Forms.Button LineButton6;
        private System.Windows.Forms.Button RectButton7;
        private System.Windows.Forms.Button CircleButton8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

