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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_empleado));
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
            label2 = new Label();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(886, 180);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.BackColor = Color.LightCyan;
            btnEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.Location = new Point(516, 362);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.LightBlue;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.Location = new Point(172, 319);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(109, 24);
            txtNombre.TabIndex = 3;
            // 
            // maskedTxtCedula
            // 
            maskedTxtCedula.Anchor = AnchorStyles.Top;
            maskedTxtCedula.BackColor = Color.LightBlue;
            maskedTxtCedula.BorderStyle = BorderStyle.FixedSingle;
            maskedTxtCedula.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            maskedTxtCedula.Location = new Point(172, 362);
            maskedTxtCedula.Mask = "000-0000000-0";
            maskedTxtCedula.Name = "maskedTxtCedula";
            maskedTxtCedula.Size = new Size(109, 24);
            maskedTxtCedula.TabIndex = 6;
            // 
            // maskedtxtTelefono
            // 
            maskedtxtTelefono.Anchor = AnchorStyles.Top;
            maskedtxtTelefono.BackColor = Color.LightBlue;
            maskedtxtTelefono.BorderStyle = BorderStyle.FixedSingle;
            maskedtxtTelefono.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            maskedtxtTelefono.Location = new Point(172, 442);
            maskedtxtTelefono.Mask = "(999) 000-0000";
            maskedtxtTelefono.Name = "maskedtxtTelefono";
            maskedtxtTelefono.Size = new Size(109, 24);
            maskedtxtTelefono.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 319);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label_cedula
            // 
            label_cedula.Anchor = AnchorStyles.Top;
            label_cedula.AutoSize = true;
            label_cedula.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_cedula.Location = new Point(47, 362);
            label_cedula.Name = "label_cedula";
            label_cedula.Size = new Size(69, 18);
            label_cedula.TabIndex = 9;
            label_cedula.Text = "Cédula:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 404);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 10;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(47, 446);
            label4.Name = "label4";
            label4.Size = new Size(82, 18);
            label4.TabIndex = 11;
            label4.Text = "Teléfono:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.Anchor = AnchorStyles.Top;
            comboBoxCargo.BackColor = Color.LightBlue;
            comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCargo.FlatStyle = FlatStyle.Popup;
            comboBoxCargo.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(172, 403);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(152, 25);
            comboBoxCargo.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top;
            btnFiltrar.BackColor = Color.LightCyan;
            btnFiltrar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnFiltrar.Location = new Point(666, 362);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(152, 34);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "FILTRAR DATOS";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Top;
            btnGuardarCambios.BackColor = Color.LightCyan;
            btnGuardarCambios.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(516, 422);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(176, 40);
            btnGuardarCambios.TabIndex = 14;
            btnGuardarCambios.Text = "GUARDAR DATOS";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(275, 73);
            label2.Name = "label2";
            label2.Size = new Size(369, 35);
            label2.TabIndex = 15;
            label2.Text = "CONSULTA UN EMPLEADO";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(902, 8);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(27, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 36;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-3, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 38);
            panel1.TabIndex = 39;
            // 
            // Consulta_empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 494);
            Controls.Add(panel1);
            Controls.Add(label2);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consulta_empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta_empleado";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            panel1.ResumeLayout(false);
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
        private Label label2;
        private PictureBox btn_Cerrar;
        private Panel panel1;
    }
}