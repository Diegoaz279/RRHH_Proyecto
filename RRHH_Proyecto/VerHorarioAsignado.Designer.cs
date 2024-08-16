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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 222);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(777, 337);
            dataGridView1.TabIndex = 0;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.LightCyan;
            buttonEditar.Cursor = Cursors.Hand;
            buttonEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEditar.Location = new Point(63, 585);
            buttonEditar.Margin = new Padding(4, 5, 4, 5);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(169, 68);
            buttonEditar.TabIndex = 11;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.LightCyan;
            buttonGuardar.Cursor = Cursors.Hand;
            buttonGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(294, 627);
            buttonGuardar.Margin = new Padding(4, 5, 4, 5);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(149, 80);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.LightCyan;
            buttonEliminar.Cursor = Cursors.Hand;
            buttonEliminar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(63, 680);
            buttonEliminar.Margin = new Padding(4, 5, 4, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(169, 68);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(533, 52);
            label1.TabIndex = 18;
            label1.Text = "VER HORARIO ASIGNADO";
            // 
            // VerHorarioAsignado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 810);
            Controls.Add(label1);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "VerHorarioAsignado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += VerHorarioAsignado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonEditar;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private Label label1;
    }
}