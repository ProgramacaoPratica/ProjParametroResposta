namespace ProjParametroResposta
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.forma1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forma2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forma3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forma1ToolStripMenuItem,
            this.forma2ToolStripMenuItem,
            this.forma3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // forma1ToolStripMenuItem
            // 
            this.forma1ToolStripMenuItem.Name = "forma1ToolStripMenuItem";
            this.forma1ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.forma1ToolStripMenuItem.Text = "Forma 1";
            this.forma1ToolStripMenuItem.Click += new System.EventHandler(this.forma1ToolStripMenuItem_Click);
            // 
            // forma2ToolStripMenuItem
            // 
            this.forma2ToolStripMenuItem.Name = "forma2ToolStripMenuItem";
            this.forma2ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.forma2ToolStripMenuItem.Text = "Forma 2";
            this.forma2ToolStripMenuItem.Click += new System.EventHandler(this.forma2ToolStripMenuItem_Click);
            // 
            // forma3ToolStripMenuItem
            // 
            this.forma3ToolStripMenuItem.Name = "forma3ToolStripMenuItem";
            this.forma3ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.forma3ToolStripMenuItem.Text = "Forma 3";
            this.forma3ToolStripMenuItem.Click += new System.EventHandler(this.forma3ToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem forma1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forma2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forma3ToolStripMenuItem;
    }
}

