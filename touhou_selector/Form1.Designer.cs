namespace touhou_selector {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.gameTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CtrBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Game:";
            this.label1.Visible = false;
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.gameTitle.Location = new System.Drawing.Point(12, 98);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(31, 13);
            this.gameTitle.TabIndex = 2;
            this.gameTitle.Text = "TEXT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Touhou Game Selection";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CtrBox
            // 
            this.CtrBox.AutoSize = true;
            this.CtrBox.BackColor = System.Drawing.Color.Silver;
            this.CtrBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CtrBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrBox.ForeColor = System.Drawing.Color.White;
            this.CtrBox.Location = new System.Drawing.Point(12, 181);
            this.CtrBox.Name = "CtrBox";
            this.CtrBox.Size = new System.Drawing.Size(202, 92);
            this.CtrBox.TabIndex = 4;
            this.CtrBox.Text = "Z - Launch \r\nX - Exit\r\nUp/Down - Choose";
            this.CtrBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CtrBox.Click += new System.EventHandler(this.CtrBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::touhou_selector.Properties.Resources.TH01;
            this.pictureBox1.Location = new System.Drawing.Point(529, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 256);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CtrBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Touhou Game Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CtrBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

