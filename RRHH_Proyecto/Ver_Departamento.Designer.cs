namespace RRHH_Proyecto
{
    partial class Ver_Departamento
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
            dataGridView1 = new DataGridView();
            buttonEliminar = new Button();
            buttonGuardar = new Button();
            buttonEditar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 240);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(794, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Top;
            buttonEliminar.BackColor = Color.LightCyan;
            buttonEliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(116, 635);
            buttonEliminar.Margin = new Padding(4, 5, 4, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(154, 65);
            buttonEliminar.TabIndex = 16;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top;
            buttonGuardar.BackColor = Color.LightCyan;
            buttonGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(313, 583);
            buttonGuardar.Margin = new Padding(4, 5, 4, 5);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(154, 77);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top;
            buttonEditar.BackColor = Color.LightCyan;
            buttonEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(116, 542);
            buttonEditar.Margin = new Padding(4, 5, 4, 5);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(154, 65);
            buttonEditar.TabIndex = 14;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(276, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(480, 52);
            label1.TabIndex = 17;
            label1.Text = "VER DEPARTAMENTOS";
            // 
            // Ver_Departamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 750);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Ver_Departamento";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Ver_Departamento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonEliminar;
        private Button buttonGuardar;
        private Button buttonEditar;
        private Label label1;
    }
}