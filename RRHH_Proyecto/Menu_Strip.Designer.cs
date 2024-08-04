namespace RRHH_Proyecto
{
    partial class Menu_Strip
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
            menuStrip1 = new MenuStrip();
            eNTRADAToolStripMenuItem = new ToolStripMenuItem();
            cONSULTAToolStripMenuItem = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem = new ToolStripMenuItem();
            aCERToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, cONSULTAToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1252, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            eNTRADAToolStripMenuItem.Size = new Size(107, 29);
            eNTRADAToolStripMenuItem.Text = "ENTRADA";
            // 
            // cONSULTAToolStripMenuItem
            // 
            cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            cONSULTAToolStripMenuItem.Size = new Size(115, 29);
            cONSULTAToolStripMenuItem.Text = "CONSULTA";
            // 
            // sISTEMAToolStripMenuItem
            // 
            sISTEMAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCERToolStripMenuItem });
            sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            sISTEMAToolStripMenuItem.Size = new Size(99, 29);
            sISTEMAToolStripMenuItem.Text = "SISTEMA";
            // 
            // aCERToolStripMenuItem
            // 
            aCERToolStripMenuItem.Name = "aCERToolStripMenuItem";
            aCERToolStripMenuItem.Size = new Size(207, 34);
            aCERToolStripMenuItem.Text = "ACERCA DE";
            aCERToolStripMenuItem.Click += aCERToolStripMenuItem_Click;
            // 
            // Menu_Strip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 743);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu_Strip";
            Text = "Menu_Strip";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem eNTRADAToolStripMenuItem;
        private ToolStripMenuItem cONSULTAToolStripMenuItem;
        private ToolStripMenuItem sISTEMAToolStripMenuItem;
        private ToolStripMenuItem aCERToolStripMenuItem;
    }
}