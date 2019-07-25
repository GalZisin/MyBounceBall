namespace MyBounceBall
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BallPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.HitCountLbl = new System.Windows.Forms.Label();
            this.WinLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BallPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BallPicBox
            // 
            this.BallPicBox.Image = ((System.Drawing.Image)(resources.GetObject("BallPicBox.Image")));
            this.BallPicBox.Location = new System.Drawing.Point(0, 75);
            this.BallPicBox.Name = "BallPicBox";
            this.BallPicBox.Size = new System.Drawing.Size(55, 54);
            this.BallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BallPicBox.TabIndex = 0;
            this.BallPicBox.TabStop = false;
            this.BallPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BallPicBox_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            //this.panel1.Controls.Add(this.BallPicBox);
            //this.panel1.Controls.Add(this.WinLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 426);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(231, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Ball";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HitCountLbl
            // 
            this.HitCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HitCountLbl.AutoSize = true;
            this.HitCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HitCountLbl.Location = new System.Drawing.Point(63, 444);
            this.HitCountLbl.Name = "HitCountLbl";
            this.HitCountLbl.Size = new System.Drawing.Size(139, 31);
            this.HitCountLbl.TabIndex = 2;
            this.HitCountLbl.Text = "Hit Points:";
            this.HitCountLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HitCountLbl.Click += new System.EventHandler(this.HitCountLbl_Click);
            // 
            // WinLbl
            // 
            this.WinLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WinLbl.AutoSize = true;
            this.WinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WinLbl.Location = new System.Drawing.Point(3, 149);
            this.WinLbl.Name = "WinLbl";
            this.WinLbl.Size = new System.Drawing.Size(499, 152);
            this.WinLbl.TabIndex = 1;
            this.WinLbl.Text = "Congratulations\r\n      You Win!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(537, 484);
            this.Controls.Add(this.HitCountLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BallPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BallPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label HitCountLbl;
        private System.Windows.Forms.Label WinLbl;
    }
}

