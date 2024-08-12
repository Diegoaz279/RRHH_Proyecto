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
            btn_Minimizar = new PictureBox();
            btn_Maximizar = new PictureBox();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 196);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1265, 300);
            dataGridView1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.Location = new Point(737, 603);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 60);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.LightBlue;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.Location = new Point(246, 531);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 33);
            txtNombre.TabIndex = 3;
            // 
            // maskedTxtCedula
            // 
            maskedTxtCedula.Anchor = AnchorStyles.Top;
            maskedTxtCedula.BackColor = Color.LightBlue;
            maskedTxtCedula.BorderStyle = BorderStyle.FixedSingle;
            maskedTxtCedula.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            maskedTxtCedula.Location = new Point(246, 603);
            maskedTxtCedula.Margin = new Padding(4, 5, 4, 5);
            maskedTxtCedula.Mask = "000-0000000-0";
            maskedTxtCedula.Name = "maskedTxtCedula";
            maskedTxtCedula.Size = new Size(155, 33);
            maskedTxtCedula.TabIndex = 6;
            // 
            // maskedtxtTelefono
            // 
            maskedtxtTelefono.Anchor = AnchorStyles.Top;
            maskedtxtTelefono.BackColor = Color.LightBlue;
            maskedtxtTelefono.BorderStyle = BorderStyle.FixedSingle;
            maskedtxtTelefono.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            maskedtxtTelefono.Location = new Point(246, 737);
            maskedtxtTelefono.Margin = new Padding(4, 5, 4, 5);
            maskedtxtTelefono.Mask = "(999) 000-0000";
            maskedtxtTelefono.Name = "maskedtxtTelefono";
            maskedtxtTelefono.Size = new Size(155, 33);
            maskedtxtTelefono.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 531);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label_cedula
            // 
            label_cedula.Anchor = AnchorStyles.Top;
            label_cedula.AutoSize = true;
            label_cedula.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_cedula.Location = new Point(67, 603);
            label_cedula.Margin = new Padding(4, 0, 4, 0);
            label_cedula.Name = "label_cedula";
            label_cedula.Size = new Size(102, 28);
            label_cedula.TabIndex = 9;
            label_cedula.Text = "Cédula:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 674);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 10;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 744);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 11;
            label4.Text = "Teléfono:";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.Anchor = AnchorStyles.Top;
            comboBoxCargo.BackColor = Color.LightBlue;
            comboBoxCargo.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(246, 672);
            comboBoxCargo.Margin = new Padding(4, 5, 4, 5);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(216, 34);
            comboBoxCargo.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top;
            btnFiltrar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnFiltrar.Location = new Point(952, 603);
            btnFiltrar.Margin = new Padding(4, 5, 4, 5);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(217, 57);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "FILTRAR DATOS";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Top;
            btnGuardarCambios.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(737, 704);
            btnGuardarCambios.Margin = new Padding(4, 5, 4, 5);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(251, 66);
            btnGuardarCambios.TabIndex = 14;
            btnGuardarCambios.Text = "GUARDAR DATOS";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(393, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(540, 52);
            label2.TabIndex = 15;
            label2.Text = "CONSULTA UN EMPLEADO";
            // 
            // btn_Minimizar
            // 
            btn_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minimizar.BackColor = Color.Transparent;
            btn_Minimizar.Cursor = Cursors.Hand;
            btn_Minimizar.Image = (Image)resources.GetObject("btn_Minimizar.Image");
            btn_Minimizar.Location = new Point(1180, 16);
            btn_Minimizar.Name = "btn_Minimizar";
            btn_Minimizar.Size = new Size(43, 40);
            btn_Minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Minimizar.TabIndex = 38;
            btn_Minimizar.TabStop = false;
            btn_Minimizar.Click += btn_Minimizar_Click;
            // 
            // btn_Maximizar
            // 
            btn_Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Maximizar.BackColor = Color.Transparent;
            btn_Maximizar.Cursor = Cursors.Hand;
            btn_Maximizar.Image = (Image)resources.GetObject("btn_Maximizar.Image");
            btn_Maximizar.Location = new Point(1236, 16);
            btn_Maximizar.Name = "btn_Maximizar";
            btn_Maximizar.Size = new Size(43, 40);
            btn_Maximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Maximizar.TabIndex = 37;
            btn_Maximizar.TabStop = false;
            btn_Maximizar.Click += btn_Maximizar_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(1292, 16);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(43, 40);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 36;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btn_Minimizar);
            panel1.Controls.Add(btn_Maximizar);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1354, 64);
            panel1.TabIndex = 39;
            // 
            // Consulta_empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 824);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Consulta_empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta_empleado";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximizar).EndInit();
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
        private PictureBox btn_Minimizar;
        private PictureBox btn_Maximizar;
        private PictureBox btn_Cerrar;
        private Panel panel1;
    }
}