namespace rilo
{
    partial class loading
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
            this.loader = new System.Windows.Forms.Label();
            this.loading_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loader
            // 
            this.loader.AutoSize = true;
            this.loader.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loader.ForeColor = System.Drawing.Color.White;
            this.loader.Location = new System.Drawing.Point(37, 59);
            this.loader.MaximumSize = new System.Drawing.Size(460, 15);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(140, 15);
            this.loader.TabIndex = 0;
            this.loader.Text = "Creating backups...";
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loading_label.ForeColor = System.Drawing.Color.White;
            this.loading_label.Location = new System.Drawing.Point(37, 59);
            this.loading_label.MaximumSize = new System.Drawing.Size(460, 15);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(140, 15);
            this.loading_label.TabIndex = 0;
            this.loading_label.Text = "Creating backups...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rilo.Properties.Resources.Eclipse_1x_11;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(20, 20);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(509, 140);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loading";
            this.Text = "loading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loading_label;
    }
}