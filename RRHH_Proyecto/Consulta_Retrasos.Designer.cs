namespace RRHH_Proyecto
{
    partial class Consulta_Retrasos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Retrasos));
            dataGridView1 = new DataGridView();
            txtObservacion = new TextBox();
            comboBox1 = new ComboBox();
            btnEditar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxEmpleado = new ComboBox();
            btnGuardar = new Button();
            maskedTextBoxfecha = new MaskedTextBox();
            maskedTextBoxminutos = new MaskedTextBox();
            label6 = new Label();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 235);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(924, 352);
            dataGridView1.TabIndex = 0;
            // 
            // txtObservacion
            // 
            txtObservacion.Anchor = AnchorStyles.Top;
            txtObservacion.BackColor = Color.LightBlue;
            txtObservacion.Location = new Point(729, 750);
            txtObservacion.Margin = new Padding(4, 5, 4, 5);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(230, 87);
            txtObservacion.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top;
            comboBox1.BackColor = Color.LightBlue;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(729, 658);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top;
            btnEditar.BackColor = Color.LightCyan;
            btnEditar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEditar.Location = new Point(364, 920);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 63);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 667);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 745);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 10;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 830);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 11;
            label3.Text = "Minutos:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(556, 745);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 11;
            label4.Text = "Observacion:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(556, 658);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 28);
            label5.TabIndex = 12;
            label5.Text = "Tipo Retraso:";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.Anchor = AnchorStyles.Top;
            comboBoxEmpleado.BackColor = Color.LightBlue;
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FlatStyle = FlatStyle.Popup;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(239, 658);
            comboBoxEmpleado.Margin = new Padding(4, 5, 4, 5);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(171, 33);
            comboBoxEmpleado.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.LightCyan;
            btnGuardar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGuardar.Location = new Point(584, 920);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 63);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // maskedTextBoxfecha
            // 
            maskedTextBoxfecha.Anchor = AnchorStyles.Top;
            maskedTextBoxfecha.BackColor = Color.LightBlue;
            maskedTextBoxfecha.Location = new Point(240, 737);
            maskedTextBoxfecha.Margin = new Padding(4, 5, 4, 5);
            maskedTextBoxfecha.Mask = "00/00/0000";
            maskedTextBoxfecha.Name = "maskedTextBoxfecha";
            maskedTextBoxfecha.Size = new Size(85, 31);
            maskedTextBoxfecha.TabIndex = 15;
            maskedTextBoxfecha.MaskInputRejected += maskedTextBoxfecha_MaskInputRejected;
            // 
            // maskedTextBoxminutos
            // 
            maskedTextBoxminutos.Anchor = AnchorStyles.Top;
            maskedTextBoxminutos.BackColor = Color.LightBlue;
            maskedTextBoxminutos.Location = new Point(240, 830);
            maskedTextBoxminutos.Margin = new Padding(4, 5, 4, 5);
            maskedTextBoxminutos.Mask = "000";
            maskedTextBoxminutos.Name = "maskedTextBoxminutos";
            maskedTextBoxminutos.Size = new Size(41, 31);
            maskedTextBoxminutos.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(306, 142);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(467, 52);
            label6.TabIndex = 17;
            label6.Text = "CONSULTA RETRASOS";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(2086, 13);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(39, 42);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 36;
            btn_Cerrar.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 63);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1011, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Consulta_Retrasos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 1123);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(maskedTextBoxminutos);
            Controls.Add(maskedTextBoxfecha);
            Controls.Add(btnGuardar);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(comboBox1);
            Controls.Add(txtObservacion);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Consulta_Retrasos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta_Retrasos";
            Load += Consulta_Retrasos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtObservacion;
        private ComboBox comboBox1;
        private Button btnEditar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxEmpleado;
        private Button btnGuardar;
        private MaskedTextBox maskedTextBoxfecha;
        private MaskedTextBox maskedTextBoxminutos;
        private Label label6;
        private PictureBox btn_Cerrar;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}