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
            aGREGARUSToolStripMenuItem = new ToolStripMenuItem();
            aGREGARUSUARIOToolStripMenuItem = new ToolStripMenuItem();
            eLIMINARUSUARIOToolStripMenuItem = new ToolStripMenuItem();
            eDITARUSUARIOToolStripMenuItem = new ToolStripMenuItem();
            aUSENCIAToolStripMenuItem = new ToolStripMenuItem();
            aGREGARAUSENCIAToolStripMenuItem = new ToolStripMenuItem();
            cONSULTAToolStripMenuItem = new ToolStripMenuItem();
            sISTEMAToolStripMenuItem = new ToolStripMenuItem();
            aCERToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.YellowGreen;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { eNTRADAToolStripMenuItem, cONSULTAToolStripMenuItem, sISTEMAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1371, 41);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // eNTRADAToolStripMenuItem
            // 
            eNTRADAToolStripMenuItem.BackColor = Color.YellowGreen;
            eNTRADAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aGREGARUSToolStripMenuItem, aUSENCIAToolStripMenuItem });
            eNTRADAToolStripMenuItem.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            eNTRADAToolStripMenuItem.Name = "eNTRADAToolStripMenuItem";
            eNTRADAToolStripMenuItem.Size = new Size(155, 37);
            eNTRADAToolStripMenuItem.Text = "ENTRADA";
            // 
            // aGREGARUSToolStripMenuItem
            // 
            aGREGARUSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aGREGARUSUARIOToolStripMenuItem, eLIMINARUSUARIOToolStripMenuItem, eDITARUSUARIOToolStripMenuItem });
            aGREGARUSToolStripMenuItem.Name = "aGREGARUSToolStripMenuItem";
            aGREGARUSToolStripMenuItem.Size = new Size(270, 42);
            aGREGARUSToolStripMenuItem.Text = "USUARIO";
            // 
            // aGREGARUSUARIOToolStripMenuItem
            // 
            aGREGARUSUARIOToolStripMenuItem.Name = "aGREGARUSUARIOToolStripMenuItem";
            aGREGARUSUARIOToolStripMenuItem.Size = new Size(378, 42);
            aGREGARUSUARIOToolStripMenuItem.Text = "AGREGAR USUARIO";
            aGREGARUSUARIOToolStripMenuItem.Click += aGREGARUSUARIOToolStripMenuItem_Click;
            // 
            // eLIMINARUSUARIOToolStripMenuItem
            // 
            eLIMINARUSUARIOToolStripMenuItem.Name = "eLIMINARUSUARIOToolStripMenuItem";
            eLIMINARUSUARIOToolStripMenuItem.Size = new Size(378, 42);
            eLIMINARUSUARIOToolStripMenuItem.Text = "ELIMINAR USUARIO";
            // 
            // eDITARUSUARIOToolStripMenuItem
            // 
            eDITARUSUARIOToolStripMenuItem.Name = "eDITARUSUARIOToolStripMenuItem";
            eDITARUSUARIOToolStripMenuItem.Size = new Size(378, 42);
            eDITARUSUARIOToolStripMenuItem.Text = "EDITAR USUARIO";
            // 
            // aUSENCIAToolStripMenuItem
            // 
            aUSENCIAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aGREGARAUSENCIAToolStripMenuItem });
            aUSENCIAToolStripMenuItem.Name = "aUSENCIAToolStripMenuItem";
            aUSENCIAToolStripMenuItem.Size = new Size(270, 42);
            aUSENCIAToolStripMenuItem.Text = "AUSENCIA";
            // 
            // aGREGARAUSENCIAToolStripMenuItem
            // 
            aGREGARAUSENCIAToolStripMenuItem.Name = "aGREGARAUSENCIAToolStripMenuItem";
            aGREGARAUSENCIAToolStripMenuItem.Size = new Size(382, 42);
            aGREGARAUSENCIAToolStripMenuItem.Text = "AGREGAR AUSENCIA";
            // 
            // cONSULTAToolStripMenuItem
            // 
            cONSULTAToolStripMenuItem.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            cONSULTAToolStripMenuItem.Size = new Size(168, 37);
            cONSULTAToolStripMenuItem.Text = "CONSULTA";
            // 
            // sISTEMAToolStripMenuItem
            // 
            sISTEMAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCERToolStripMenuItem });
            sISTEMAToolStripMenuItem.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            sISTEMAToolStripMenuItem.Name = "sISTEMAToolStripMenuItem";
            sISTEMAToolStripMenuItem.Size = new Size(146, 37);
            sISTEMAToolStripMenuItem.Text = "SISTEMA";
            // 
            // aCERToolStripMenuItem
            // 
            aCERToolStripMenuItem.Name = "aCERToolStripMenuItem";
            aCERToolStripMenuItem.Size = new Size(263, 42);
            aCERToolStripMenuItem.Text = "ACERCA DE";
            aCERToolStripMenuItem.Click += aCERToolStripMenuItem_Click;
            // 
            // Menu_Strip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1371, 781);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Menu_Strip";
            Text = "Menu_Strip";
            Load += Menu_Strip_Load;
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
        private ToolStripMenuItem aGREGARUSToolStripMenuItem;
        private ToolStripMenuItem aGREGARUSUARIOToolStripMenuItem;
        private ToolStripMenuItem eLIMINARUSUARIOToolStripMenuItem;
        private ToolStripMenuItem eDITARUSUARIOToolStripMenuItem;
        private ToolStripMenuItem aUSENCIAToolStripMenuItem;
        private ToolStripMenuItem aGREGARAUSENCIAToolStripMenuItem;
    }
}