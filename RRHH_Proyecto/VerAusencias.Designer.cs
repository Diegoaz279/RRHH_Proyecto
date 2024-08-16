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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 211);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(777, 335);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // comboBoxAusencia
            // 
            comboBoxAusencia.Anchor = AnchorStyles.Top;
            comboBoxAusencia.BackColor = Color.LightBlue;
            comboBoxAusencia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAusencia.FlatStyle = FlatStyle.Popup;
            comboBoxAusencia.FormattingEnabled = true;
            comboBoxAusencia.Location = new Point(301, 726);
            comboBoxAusencia.Margin = new Padding(4, 5, 4, 5);
            comboBoxAusencia.Name = "comboBoxAusencia";
            comboBoxAusencia.Size = new Size(171, 33);
            comboBoxAusencia.TabIndex = 1;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.Anchor = AnchorStyles.Top;
            comboBoxEmpleado.BackColor = Color.LightBlue;
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FlatStyle = FlatStyle.Popup;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(301, 618);
            comboBoxEmpleado.Margin = new Padding(4, 5, 4, 5);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(171, 33);
            comboBoxEmpleado.TabIndex = 2;
            // 
            // maskedTextBoxinicio
            // 
            maskedTextBoxinicio.Anchor = AnchorStyles.Top;
            maskedTextBoxinicio.BackColor = Color.LightBlue;
            maskedTextBoxinicio.Location = new Point(696, 610);
            maskedTextBoxinicio.Margin = new Padding(4, 5, 4, 5);
            maskedTextBoxinicio.Mask = "00/00/0000";
            maskedTextBoxinicio.Name = "maskedTextBoxinicio";
            maskedTextBoxinicio.Size = new Size(141, 31);
            maskedTextBoxinicio.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.BackColor = Color.LightCyan;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.Location = new Point(257, 841);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 72);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.LightCyan;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(484, 841);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 72);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // maskedTextBoxFin
            // 
            maskedTextBoxFin.Anchor = AnchorStyles.Top;
            maskedTextBoxFin.BackColor = Color.LightBlue;
            maskedTextBoxFin.Location = new Point(696, 726);
            maskedTextBoxFin.Margin = new Padding(4, 5, 4, 5);
            maskedTextBoxFin.Mask = "00/00/0000";
            maskedTextBoxFin.Name = "maskedTextBoxFin";
            maskedTextBoxFin.Size = new Size(141, 31);
            maskedTextBoxFin.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 52);
            label1.TabIndex = 23;
            label1.Text = "VER AUSENCIAS";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 726);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 24;
            label2.Text = "Tipos de ausencia:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 618);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 25;
            label3.Text = "Empleado:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(516, 618);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 26;
            label4.Text = "Fecha inicio:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(516, 726);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 27;
            label5.Text = "Fecha Final:";
            // 
            // VerAusencias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 993);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxFin);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(maskedTextBoxinicio);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(comboBoxAusencia);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "VerAusencias";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox btn_Cerrar;
        private PictureBox pictureBox3;
    }
}