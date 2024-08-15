namespace RRHH_Proyecto
{
    partial class VerAusencias
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
            comboBoxAusencia = new ComboBox();
            comboBoxEmpleado = new ComboBox();
            maskedTextBoxinicio = new MaskedTextBox();
            btnEditar = new Button();
            btnGuardar = new Button();
            maskedTextBoxFin = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(231, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(557, 294);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // comboBoxAusencia
            // 
            comboBoxAusencia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAusencia.FormattingEnabled = true;
            comboBoxAusencia.Location = new Point(45, 188);
            comboBoxAusencia.Name = "comboBoxAusencia";
            comboBoxAusencia.Size = new Size(121, 23);
            comboBoxAusencia.TabIndex = 1;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(45, 239);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(121, 23);
            comboBoxEmpleado.TabIndex = 2;
            // 
            // maskedTextBoxinicio
            // 
            maskedTextBoxinicio.Location = new Point(45, 268);
            maskedTextBoxinicio.Mask = "00/00/0000";
            maskedTextBoxinicio.Name = "maskedTextBoxinicio";
            maskedTextBoxinicio.Size = new Size(100, 23);
            maskedTextBoxinicio.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.Location = new Point(166, 361);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 36);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(166, 403);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 36);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // maskedTextBoxFin
            // 
            maskedTextBoxFin.Location = new Point(45, 297);
            maskedTextBoxFin.Mask = "00/00/0000";
            maskedTextBoxFin.Name = "maskedTextBoxFin";
            maskedTextBoxFin.Size = new Size(100, 23);
            maskedTextBoxFin.TabIndex = 9;
            // 
            // VerAusencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBoxFin);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(maskedTextBoxinicio);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(comboBoxAusencia);
            Controls.Add(dataGridView1);
            Name = "VerAusencias";
            Text = " n  ";
            Load += VerAusencias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxAusencia;
        private ComboBox comboBoxEmpleado;
        private MaskedTextBox maskedTextBoxinicio;
        private Button btnEditar;
        private Button btnGuardar;
        private MaskedTextBox maskedTextBoxFin;
    }
}