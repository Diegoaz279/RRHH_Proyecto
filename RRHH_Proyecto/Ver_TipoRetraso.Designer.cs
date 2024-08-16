namespace RRHH_Proyecto
{
    partial class Ver_TipoRetraso
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
            label1 = new Label();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            buttonEditar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(512, 52);
            label1.TabIndex = 22;
            label1.Text = "VER TIPOS DE RETRASO";
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.LightCyan;
            buttonEliminar.Cursor = Cursors.Hand;
            buttonEliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(100, 697);
            buttonEliminar.Margin = new Padding(4, 5, 4, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(126, 65);
            buttonEliminar.TabIndex = 21;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.LightCyan;
            buttonGuardar.Cursor = Cursors.Hand;
            buttonGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(294, 638);
            buttonGuardar.Margin = new Padding(4, 5, 4, 5);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(139, 87);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.LightCyan;
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(100, 595);
            buttonEditar.Margin = new Padding(4, 5, 4, 5);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(126, 65);
            buttonEditar.TabIndex = 19;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 256);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(393, 268);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ver_TipoRetraso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 837);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Ver_TipoRetraso";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Ver_TipoRetraso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Button buttonEditar;
        private DataGridView dataGridView1;
    }
}