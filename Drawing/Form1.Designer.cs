namespace Drawing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.triangleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.pentagonButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 311);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(503, 39);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(121, 23);
            this.triangleButton.TabIndex = 1;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(503, 82);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(121, 23);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(503, 127);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(121, 23);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(503, 174);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(121, 23);
            this.lineButton.TabIndex = 4;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // pentagonButton
            // 
            this.pentagonButton.Location = new System.Drawing.Point(503, 223);
            this.pentagonButton.Name = "pentagonButton";
            this.pentagonButton.Size = new System.Drawing.Size(121, 23);
            this.pentagonButton.TabIndex = 5;
            this.pentagonButton.Text = "Pentagon";
            this.pentagonButton.UseVisualStyleBackColor = true;
            this.pentagonButton.Click += new System.EventHandler(this.pentagonButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(503, 275);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(121, 23);
            this.circleButton.TabIndex = 6;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 353);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.pentagonButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button pentagonButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

