namespace RRHH_Proyecto
{
    partial class Pase_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pase_Empleado));
            panel1 = new Panel();
            btn_Cerrar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            cmb_Empleado = new ComboBox();
            cmb_MotivoPase = new ComboBox();
            masked_Fecha = new MaskedTextBox();
            masked_Hentrada = new MaskedTextBox();
            masked_Hsalida = new MaskedTextBox();
            masked_Clave = new MaskedTextBox();
            btn_Agregar = new Button();
            btn_Canclar = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-4, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 38);
            panel1.TabIndex = 37;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(520, 8);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(30, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 14;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 35);
            label1.TabIndex = 38;
            label1.Text = "PASE EMPLEADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(85, 163);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 18);
            label2.TabIndex = 39;
            label2.Text = "Nombre Empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 205);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 40;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(85, 286);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 42;
            label4.Text = "Hora Salida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(85, 246);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 18);
            label5.TabIndex = 41;
            label5.Text = "Hora Entrada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(85, 328);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 18);
            label7.TabIndex = 43;
            label7.Text = "Clave Empleado";
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.BackColor = Color.LightBlue;
            cmb_Empleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Empleado.FlatStyle = FlatStyle.Popup;
            cmb_Empleado.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_Empleado.ForeColor = SystemColors.WindowFrame;
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(286, 163);
            cmb_Empleado.Margin = new Padding(2);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(204, 25);
            cmb_Empleado.TabIndex = 45;
            // 
            // cmb_MotivoPase
            // 
            cmb_MotivoPase.BackColor = Color.LightBlue;
            cmb_MotivoPase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MotivoPase.FlatStyle = FlatStyle.Popup;
            cmb_MotivoPase.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_MotivoPase.ForeColor = SystemColors.WindowFrame;
            cmb_MotivoPase.FormattingEnabled = true;
            cmb_MotivoPase.Location = new Point(286, 370);
            cmb_MotivoPase.Margin = new Padding(2);
            cmb_MotivoPase.Name = "cmb_MotivoPase";
            cmb_MotivoPase.Size = new Size(204, 25);
            cmb_MotivoPase.TabIndex = 46;
            // 
            // masked_Fecha
            // 
            masked_Fecha.BackColor = Color.LightBlue;
            masked_Fecha.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            masked_Fecha.ForeColor = SystemColors.WindowFrame;
            masked_Fecha.Location = new Point(286, 203);
            masked_Fecha.Margin = new Padding(2);
            masked_Fecha.Mask = "00/00/0000";
            masked_Fecha.Name = "masked_Fecha";
            masked_Fecha.Size = new Size(83, 24);
            masked_Fecha.TabIndex = 47;
            // 
            // masked_Hentrada
            // 
            masked_Hentrada.BackColor = Color.LightBlue;
            masked_Hentrada.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            masked_Hentrada.ForeColor = SystemColors.WindowFrame;
            masked_Hentrada.Location = new Point(286, 243);
            masked_Hentrada.Margin = new Padding(2);
            masked_Hentrada.Mask = "00:00";
            masked_Hentrada.Name = "masked_Hentrada";
            masked_Hentrada.Size = new Size(49, 24);
            masked_Hentrada.TabIndex = 48;
            // 
            // masked_Hsalida
            // 
            masked_Hsalida.BackColor = Color.LightBlue;
            masked_Hsalida.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            masked_Hsalida.ForeColor = SystemColors.WindowFrame;
            masked_Hsalida.Location = new Point(286, 283);
            masked_Hsalida.Margin = new Padding(2);
            masked_Hsalida.Mask = "00:00";
            masked_Hsalida.Name = "masked_Hsalida";
            masked_Hsalida.Size = new Size(49, 24);
            masked_Hsalida.TabIndex = 49;
            // 
            // masked_Clave
            // 
            masked_Clave.BackColor = Color.LightBlue;
            masked_Clave.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            masked_Clave.ForeColor = SystemColors.WindowFrame;
            masked_Clave.Location = new Point(286, 328);
            masked_Clave.Margin = new Padding(2);
            masked_Clave.Mask = "99999";
            masked_Clave.Name = "masked_Clave";
            masked_Clave.Size = new Size(49, 24);
            masked_Clave.TabIndex = 50;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.LightCyan;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(321, 451);
            btn_Agregar.Margin = new Padding(2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(108, 48);
            btn_Agregar.TabIndex = 52;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Canclar
            // 
            btn_Canclar.BackColor = Color.LightCyan;
            btn_Canclar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Canclar.Location = new Point(118, 451);
            btn_Canclar.Margin = new Padding(2);
            btn_Canclar.Name = "btn_Canclar";
            btn_Canclar.Size = new Size(107, 48);
            btn_Canclar.TabIndex = 53;
            btn_Canclar.Text = "CANCELAR";
            btn_Canclar.UseVisualStyleBackColor = false;
            btn_Canclar.Click += btn_Canclar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(85, 373);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 18);
            label8.TabIndex = 54;
            label8.Text = "Motivo de Pase";
            // 
            // Pase_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 532);
            Controls.Add(label8);
            Controls.Add(btn_Canclar);
            Controls.Add(btn_Agregar);
            Controls.Add(masked_Clave);
            Controls.Add(masked_Hsalida);
            Controls.Add(masked_Hentrada);
            Controls.Add(masked_Fecha);
            Controls.Add(cmb_MotivoPase);
            Controls.Add(cmb_Empleado);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Pase_Empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Horario";
            Load += Agregar_Horario_Load;
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
        private Label label7;
        private ComboBox cmb_Empleado;
        private ComboBox cmb_MotivoPase;
        private MaskedTextBox masked_Fecha;
        private MaskedTextBox masked_Hentrada;
        private MaskedTextBox masked_Hsalida;
        private MaskedTextBox masked_Clave;
        private Button btn_Agregar;
        private Button btn_Canclar;
        private Label label8;
    }
}