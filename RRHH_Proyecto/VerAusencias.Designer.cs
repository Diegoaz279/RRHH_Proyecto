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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAusencias));
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_Cerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 201);
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
            comboBoxAusencia.Location = new Point(211, 446);
            comboBoxAusencia.Name = "comboBoxAusencia";
            comboBoxAusencia.Size = new Size(121, 23);
            comboBoxAusencia.TabIndex = 1;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.Anchor = AnchorStyles.Top;
            comboBoxEmpleado.BackColor = Color.LightBlue;
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FlatStyle = FlatStyle.Popup;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(211, 381);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(121, 23);
            comboBoxEmpleado.TabIndex = 2;
            // 
            // maskedTextBoxinicio
            // 
            maskedTextBoxinicio.Anchor = AnchorStyles.Top;
            maskedTextBoxinicio.BackColor = Color.LightBlue;
            maskedTextBoxinicio.Location = new Point(487, 376);
            maskedTextBoxinicio.Mask = "00/00/0000";
            maskedTextBoxinicio.Name = "maskedTextBoxinicio";
            maskedTextBoxinicio.Size = new Size(100, 23);
            maskedTextBoxinicio.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.BackColor = Color.LightCyan;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.Location = new Point(180, 515);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 43);
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
            btnGuardar.Location = new Point(339, 515);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 43);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // maskedTextBoxFin
            // 
            maskedTextBoxFin.Anchor = AnchorStyles.Top;
            maskedTextBoxFin.BackColor = Color.LightBlue;
            maskedTextBoxFin.Location = new Point(487, 446);
            maskedTextBoxFin.Mask = "00/00/0000";
            maskedTextBoxFin.Name = "maskedTextBoxFin";
            maskedTextBoxFin.Size = new Size(100, 23);
            maskedTextBoxFin.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 75);
            label1.Name = "label1";
            label1.Size = new Size(240, 35);
            label1.TabIndex = 23;
            label1.Text = "VER AUSENCIAS";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 446);
            label2.Name = "label2";
            label2.Size = new Size(157, 18);
            label2.TabIndex = 24;
            label2.Text = "Tipos de ausencia:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 381);
            label3.Name = "label3";
            label3.Size = new Size(92, 18);
            label3.TabIndex = 25;
            label3.Text = "Empleado:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(361, 381);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 26;
            label4.Text = "Fecha inicio:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(361, 446);
            label5.Name = "label5";
            label5.Size = new Size(105, 18);
            label5.TabIndex = 27;
            label5.Text = "Fecha Final:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 38);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, 9);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(1348, 8);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(27, 25);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 36;
            btn_Cerrar.TabStop = false;
            // 
            // VerAusencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 596);
            Controls.Add(panel1);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerAusencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " n  ";
            Load += VerAusencias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
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
        private Panel panel1;
        private PictureBox btn_Cerrar;
        private PictureBox pictureBox1;
    }
}