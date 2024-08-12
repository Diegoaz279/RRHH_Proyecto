namespace RRHH_Proyecto
{
    partial class Consulta_empleado
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
            btnEditar = new Button();
            txtNombre = new TextBox();
            maskedTxtCedula = new MaskedTextBox();
            maskedtxtTelefono = new MaskedTextBox();
            label1 = new Label();
            label_cedula = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxCargo = new ComboBox();
            btnFiltrar = new Button();
            btnGuardarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(528, 295);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(502, 385);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar ";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 328);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // maskedTxtCedula
            // 
            maskedTxtCedula.Location = new Point(199, 357);
            maskedTxtCedula.Mask = "000-0000000-0";
            maskedTxtCedula.Name = "maskedTxtCedula";
            maskedTxtCedula.Size = new Size(100, 23);
            maskedTxtCedula.TabIndex = 6;
            // 
            // maskedtxtTelefono
            // 
            maskedtxtTelefono.Location = new Point(199, 415);
            maskedtxtTelefono.Mask = "(999) 000-0000";
            maskedtxtTelefono.Name = "maskedtxtTelefono";
            maskedtxtTelefono.Size = new Size(100, 23);
            maskedtxtTelefono.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 336);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre ";
            // 
            // label_cedula
            // 
            label_cedula.AutoSize = true;
            label_cedula.Location = new Point(108, 365);
            label_cedula.Name = "label_cedula";
            label_cedula.Size = new Size(44, 15);
            label_cedula.TabIndex = 9;
            label_cedula.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 394);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Cargo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 423);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Telefono";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(199, 385);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(121, 23);
            comboBoxCargo.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(502, 414);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "filtrar datos";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(502, 356);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(152, 23);
            btnGuardarCambios.TabIndex = 14;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click_1;
            // 
            // Consulta_empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarCambios);
            Controls.Add(btnFiltrar);
            Controls.Add(comboBoxCargo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label_cedula);
            Controls.Add(label1);
            Controls.Add(maskedtxtTelefono);
            Controls.Add(maskedTxtCedula);
            Controls.Add(txtNombre);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView1);
            Name = "Consulta_empleado";
            Text = "Consulta_empleado";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEditar;
        private TextBox txtNombre;
        private MaskedTextBox maskedTxtCedula;
        private MaskedTextBox maskedtxtTelefono;
        private Label label1;
        private Label label_cedula;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxCargo;
        private Button btnFiltrar;
        private Button btnGuardarCambios;
    }
}