namespace RRHH_Proyecto
{
    partial class Agregar_Horario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Horario));
            panel1 = new Panel();
            btn_Cerrar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmb_Empleado = new ComboBox();
            comboBox2 = new ComboBox();
            masked_Fecha = new MaskedTextBox();
            masked_Hentrada = new MaskedTextBox();
            masked_Hsalida = new MaskedTextBox();
            masked_Clave = new MaskedTextBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 64);
            panel1.TabIndex = 37;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(992, 14);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(43, 40);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 14;
            btn_Cerrar.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(259, 115);
            label1.Name = "label1";
            label1.Size = new Size(495, 52);
            label1.TabIndex = 38;
            label1.Text = "AGREGAR UN HORARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 276);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 39;
            label2.Text = "Nombre Empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 330);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 40;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 440);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 42;
            label4.Text = "Hora Salida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 386);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 41;
            label5.Text = "Hora Entrada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 547);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 44;
            label6.Text = "Motivo de Pase";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 493);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 43;
            label7.Text = "Clave Empleado";
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(553, 267);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(290, 33);
            cmb_Empleado.TabIndex = 45;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(553, 564);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(290, 33);
            comboBox2.TabIndex = 46;
            // 
            // masked_Fecha
            // 
            masked_Fecha.Location = new Point(553, 330);
            masked_Fecha.Name = "masked_Fecha";
            masked_Fecha.Size = new Size(258, 31);
            masked_Fecha.TabIndex = 47;
            // 
            // masked_Hentrada
            // 
            masked_Hentrada.Location = new Point(553, 386);
            masked_Hentrada.Name = "masked_Hentrada";
            masked_Hentrada.Size = new Size(258, 31);
            masked_Hentrada.TabIndex = 48;
            // 
            // masked_Hsalida
            // 
            masked_Hsalida.Location = new Point(553, 453);
            masked_Hsalida.Name = "masked_Hsalida";
            masked_Hsalida.Size = new Size(258, 31);
            masked_Hsalida.TabIndex = 49;
            // 
            // masked_Clave
            // 
            masked_Clave.Location = new Point(553, 508);
            masked_Clave.Name = "masked_Clave";
            masked_Clave.Size = new Size(258, 31);
            masked_Clave.TabIndex = 50;
            // 
            // button2
            // 
            button2.Location = new Point(574, 682);
            button2.Name = "button2";
            button2.Size = new Size(124, 51);
            button2.TabIndex = 52;
            button2.Text = "AGREGAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(314, 682);
            button3.Name = "button3";
            button3.Size = new Size(124, 51);
            button3.TabIndex = 53;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // Agregar_Horario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 915);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(masked_Clave);
            Controls.Add(masked_Hsalida);
            Controls.Add(masked_Hentrada);
            Controls.Add(masked_Fecha);
            Controls.Add(comboBox2);
            Controls.Add(cmb_Empleado);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Horario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Horario";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btn_Cerrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmb_Empleado;
        private ComboBox comboBox2;
        private MaskedTextBox masked_Fecha;
        private MaskedTextBox masked_Hentrada;
        private MaskedTextBox masked_Hsalida;
        private MaskedTextBox masked_Clave;
        private Button button2;
        private Button button3;
    }
}