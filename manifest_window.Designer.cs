namespace rilo
{
    partial class manifest_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manifest_window));
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.install = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.MaximumSize = new System.Drawing.Size(500, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(113, 41);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.description.Location = new System.Drawing.Point(9, 13);
            this.description.MaximumSize = new System.Drawing.Size(567, 70);
            this.description.MinimumSize = new System.Drawing.Size(567, 70);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(567, 70);
            this.description.TabIndex = 1;
            this.description.Text = resources.GetString("description.Text");
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(496, 166);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(126, 23);
            this.install.TabIndex = 2;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.author.Location = new System.Drawing.Point(16, 46);
            this.author.MaximumSize = new System.Drawing.Size(300, 14);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(63, 14);
            this.author.TabIndex = 3;
            this.author.Text = "By Wjozq";
            // 
            // open
            // 
            this.open.AutoSize = true;
            this.open.Checked = true;
            this.open.CheckState = System.Windows.Forms.CheckState.Checked;
            this.open.Location = new System.Drawing.Point(292, 170);
            this.open.MaximumSize = new System.Drawing.Size(198, 17);
            this.open.MinimumSize = new System.Drawing.Size(198, 17);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(198, 17);
            this.open.TabIndex = 4;
            this.open.Text = "Open Roblox Studio after Installation";
            this.open.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Location = new System.Drawing.Point(19, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // manifest_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.author);
            this.Controls.Add(this.install);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 240);
            this.Name = "manifest_window";
            this.Text = "Manifest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button install;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label description;
        public System.Windows.Forms.Label author;
        public System.Windows.Forms.CheckBox open;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}