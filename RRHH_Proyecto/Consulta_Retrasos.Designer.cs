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
            dataGridView1 = new DataGridView();
            txtFecha = new TextBox();
            txtMinutos = new TextBox();
            txtObservacion = new TextBox();
            comboBox1 = new ComboBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxEmpleado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(486, 222);
            dataGridView1.TabIndex = 0;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(241, 311);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 2;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(241, 340);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(100, 23);
            txtMinutos.TabIndex = 3;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(241, 369);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(120, 54);
            txtObservacion.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(479, 400);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(367, 311);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(367, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(367, 369);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 277);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 319);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 348);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "minutos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 377);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "Observacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 408);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Tipo Retraso";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(220, 269);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(121, 23);
            comboBoxEmpleado.TabIndex = 13;
            // 
            // Consulta_Retrasos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(comboBox1);
            Controls.Add(txtObservacion);
            Controls.Add(txtMinutos);
            Controls.Add(txtFecha);
            Controls.Add(dataGridView1);
            Name = "Consulta_Retrasos";
            Text = "Consulta_Retrasos";
            Load += Consulta_Retrasos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtFecha;
        private TextBox txtMinutos;
        private TextBox txtObservacion;
        private ComboBox comboBox1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxEmpleado;
    }
}