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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(663, 161);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(157, 344);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(494, 32);
            buttonEliminar.TabIndex = 16;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(157, 315);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(494, 32);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(157, 286);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(494, 32);
            buttonEditar.TabIndex = 14;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 39);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 17;
            label1.Text = "VER DEPARTAMENTOS";
            // 
            // Ver_Departamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            Name = "Ver_Departamento";
            Text = "Ver_Departamento";
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