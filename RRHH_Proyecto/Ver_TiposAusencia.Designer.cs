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
            label1.Location = new Point(322, 57);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 27;
            label1.Text = "VER TIPOS DE AUSENCIA";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(154, 362);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(494, 32);
            buttonEliminar.TabIndex = 26;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(154, 333);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(494, 32);
            buttonGuardar.TabIndex = 25;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(154, 304);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(494, 32);
            buttonEditar.TabIndex = 24;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(663, 161);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ver_TiposAusencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            Name = "Ver_TiposAusencia";
            Text = "Ver_TiposAusencia";
            Load += Ver_TiposAusencia_Load;
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