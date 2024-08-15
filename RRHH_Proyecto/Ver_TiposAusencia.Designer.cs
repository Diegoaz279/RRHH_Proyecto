namespace RRHH_Proyecto
{
    partial class Ver_TiposAusencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_TiposAusencia));
            label1 = new Label();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            buttonEditar = new Button();
            dataGridView1 = new DataGridView();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 80);
            label1.Name = "label1";
            label1.Size = new Size(361, 35);
            label1.TabIndex = 27;
            label1.Text = "VER TIPOS DE AUSENCIA";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Top;
            buttonEliminar.BackColor = Color.LightCyan;
            buttonEliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(76, 404);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 39);
            buttonEliminar.TabIndex = 26;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top;
            buttonGuardar.BackColor = Color.LightCyan;
            buttonGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(206, 370);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(97, 52);
            buttonGuardar.TabIndex = 25;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top;
            buttonEditar.BackColor = Color.LightCyan;
            buttonEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(76, 350);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(88, 39);
            buttonEditar.TabIndex = 24;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(249, 166);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(1115, 8);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(27, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 36;
            btn_Cerrar.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 38);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Ver_TiposAusencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 481);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ver_TiposAusencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver_TiposAusencia";
            Load += Ver_TiposAusencia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Button buttonEditar;
        private DataGridView dataGridView1;
        private PictureBox btn_Cerrar;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}