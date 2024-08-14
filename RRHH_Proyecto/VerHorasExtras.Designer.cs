namespace RRHH_Proyecto
{
    partial class VerHorasExtras
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
            maskedTextBoxiniciohora = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBoxfinhora = new MaskedTextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(107, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(671, 180);
            dataGridView1.TabIndex = 15;
            // 
            // maskedTextBoxiniciohora
            // 
            maskedTextBoxiniciohora.Location = new Point(198, 208);
            maskedTextBoxiniciohora.Mask = "90:00";
            maskedTextBoxiniciohora.Name = "maskedTextBoxiniciohora";
            maskedTextBoxiniciohora.Size = new Size(100, 23);
            maskedTextBoxiniciohora.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 216);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 20;
            label1.Text = "Inicio hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 261);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 21;
            label2.Text = "Fin  hora";
            // 
            // maskedTextBoxfinhora
            // 
            maskedTextBoxfinhora.Location = new Point(198, 253);
            maskedTextBoxfinhora.Mask = "90:00";
            maskedTextBoxfinhora.Name = "maskedTextBoxfinhora";
            maskedTextBoxfinhora.Size = new Size(100, 23);
            maskedTextBoxfinhora.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 320);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 84);
            textBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 345);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 24;
            label3.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(421, 388);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(461, 216);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // VerHorasExtras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBoxfinhora);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxiniciohora);
            Controls.Add(dataGridView1);
            Name = "VerHorasExtras";
            Text = "VerHorasExtras";
            Load += VerHorasExtras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBoxiniciohora;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBoxfinhora;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}