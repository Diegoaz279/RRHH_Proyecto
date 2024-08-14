namespace RRHH_Proyecto
{
    partial class VerHorarioAsignado
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
            buttonEditar = new Button();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(702, 236);
            dataGridView1.TabIndex = 0;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(178, 322);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(494, 32);
            buttonEditar.TabIndex = 11;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(178, 351);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(494, 32);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(178, 380);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(494, 32);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // VerHorarioAsignado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            Name = "VerHorarioAsignado";
            Text = "VerHorarioAsignado";
            Load += VerHorarioAsignado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonEditar;
        private Button buttonGuardar;
        private Button buttonEliminar;
    }
}