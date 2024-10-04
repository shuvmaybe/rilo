namespace rilo
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloadThemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unloadJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadJSONToolStripMenuItem,
            this.unloadThemesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            this.contextMenuStrip1.Text = "rilo";
            // 
            // loadJSONToolStripMenuItem
            // 
            this.loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
            this.loadJSONToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.loadJSONToolStripMenuItem.Text = "Load .JSON";
            // 
            // unloadThemesToolStripMenuItem
            // 
            this.unloadThemesToolStripMenuItem.Name = "unloadThemesToolStripMenuItem";
            this.unloadThemesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.unloadThemesToolStripMenuItem.Text = "Unload Themes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riloToolStripMenuItem
            // 
            this.riloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadJSONToolStripMenuItem1,
            this.unloadJSONToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.riloToolStripMenuItem.Name = "riloToolStripMenuItem";
            this.riloToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.riloToolStripMenuItem.Text = "rilo";
            // 
            // loadJSONToolStripMenuItem1
            // 
            this.loadJSONToolStripMenuItem1.Name = "loadJSONToolStripMenuItem1";
            this.loadJSONToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadJSONToolStripMenuItem1.Text = "Load .JSON";
            this.loadJSONToolStripMenuItem1.Click += new System.EventHandler(this.loadJSONToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::rilo.Properties.Resources.rilo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // unloadJSONToolStripMenuItem
            // 
            this.unloadJSONToolStripMenuItem.Name = "unloadJSONToolStripMenuItem";
            this.unloadJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unloadJSONToolStripMenuItem.Text = "Unload .JSON";
            this.unloadJSONToolStripMenuItem.Click += new System.EventHandler(this.unloadJSONToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 310);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(469, 349);
            this.Name = "Form1";
            this.Text = "rilo";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloadThemesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadJSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unloadJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

