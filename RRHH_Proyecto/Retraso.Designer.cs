namespace RRHH_Proyecto
{
    partial class Agregar_Retraso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Retraso));
            mb_Fecha = new MaskedTextBox();
            btn_Cancelar = new Button();
            txt_OtroRetraso = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmb_TipoRetraso = new ComboBox();
            btn_Agregar = new Button();
            label2 = new Label();
            cmb_Empleado = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mb_Fecha
            // 
            mb_Fecha.Anchor = AnchorStyles.Top;
            mb_Fecha.BackColor = Color.LightBlue;
            mb_Fecha.BorderStyle = BorderStyle.FixedSingle;
            mb_Fecha.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            mb_Fecha.ForeColor = SystemColors.WindowFrame;
            mb_Fecha.Location = new Point(189, 274);
            mb_Fecha.Margin = new Padding(2);
            mb_Fecha.Mask = "00/00/0000";
            mb_Fecha.Name = "mb_Fecha";
            mb_Fecha.Size = new Size(78, 24);
            mb_Fecha.TabIndex = 61;
            mb_Fecha.ValidatingType = typeof(DateTime);
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.BackColor = Color.LightCyan;
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Cancelar.Location = new Point(100, 428);
            btn_Cancelar.Margin = new Padding(2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(103, 45);
            btn_Cancelar.TabIndex = 60;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click_1;
            // 
            // txt_OtroRetraso
            // 
            txt_OtroRetraso.Anchor = AnchorStyles.Top;
            txt_OtroRetraso.BackColor = Color.LightBlue;
            txt_OtroRetraso.BorderStyle = BorderStyle.FixedSingle;
            txt_OtroRetraso.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_OtroRetraso.ForeColor = SystemColors.WindowFrame;
            txt_OtroRetraso.Location = new Point(189, 229);
            txt_OtroRetraso.Margin = new Padding(2);
            txt_OtroRetraso.Name = "txt_OtroRetraso";
            txt_OtroRetraso.Size = new Size(249, 24);
            txt_OtroRetraso.TabIndex = 59;
            txt_OtroRetraso.Text = "MOTIVO DE RETRASO";
            txt_OtroRetraso.Visible = false;
            txt_OtroRetraso.Enter += txt_OtroRetraso_Enter;
            txt_OtroRetraso.Leave += txt_OtroRetraso_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(39, 336);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 18);
            label5.TabIndex = 58;
            label5.Text = "Observacion:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 274);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 57;
            label4.Text = "Fecha:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 207);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 18);
            label3.TabIndex = 56;
            label3.Text = "Tipo Retraso:";
            // 
            // cmb_TipoRetraso
            // 
            cmb_TipoRetraso.Anchor = AnchorStyles.Top;
            cmb_TipoRetraso.BackColor = Color.LightBlue;
            cmb_TipoRetraso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TipoRetraso.FlatStyle = FlatStyle.Popup;
            cmb_TipoRetraso.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_TipoRetraso.ForeColor = SystemColors.WindowFrame;
            cmb_TipoRetraso.FormattingEnabled = true;
            cmb_TipoRetraso.Items.AddRange(new object[] { "Tráfico o problemas de transporte", "Problemas de salud", "Compromisos familiares", "Problemas técnicos", "Desorganización personal", "Otros" });
            cmb_TipoRetraso.Location = new Point(189, 205);
            cmb_TipoRetraso.Margin = new Padding(2);
            cmb_TipoRetraso.Name = "cmb_TipoRetraso";
            cmb_TipoRetraso.Size = new Size(249, 25);
            cmb_TipoRetraso.TabIndex = 55;
            cmb_TipoRetraso.SelectedIndexChanged += cmb_TipoRetraso_SelectedIndexChanged_1;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Top;
            btn_Agregar.BackColor = Color.LightCyan;
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Agregar.Location = new Point(251, 428);
            btn_Agregar.Margin = new Padding(2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(103, 45);
            btn_Agregar.TabIndex = 54;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 53;
            label2.Text = "Empleado:";
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.Anchor = AnchorStyles.Top;
            cmb_Empleado.BackColor = Color.LightBlue;
            cmb_Empleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Empleado.FlatStyle = FlatStyle.Popup;
            cmb_Empleado.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_Empleado.ForeColor = SystemColors.WindowFrame;
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(189, 144);
            cmb_Empleado.Margin = new Padding(2);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(249, 25);
            cmb_Empleado.TabIndex = 52;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 35);
            label1.TabIndex = 51;
            label1.Text = "AGREGAR RETRASO";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = Color.LightBlue;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(189, 335);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 47);
            textBox1.TabIndex = 62;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(438, 8);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(28, 28);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 63;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(-2, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 42);
            panel1.TabIndex = 64;
            // 
            // Agregar_Retraso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 503);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(mb_Fecha);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_OtroRetraso);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_TipoRetraso);
            Controls.Add(btn_Agregar);
            Controls.Add(label2);
            Controls.Add(cmb_Empleado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agregar_Retraso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Retraso";
            Load += Retraso_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox mb_Fecha;
        private Button btn_Cancelar;
        private TextBox txt_OtroRetraso;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmb_TipoRetraso;
        private Button btn_Agregar;
        private Label label2;
        private ComboBox cmb_Empleado;
        private Label label1;
        private TextBox textBox1;
        private PictureBox btn_Cerrar;
        private Panel panel1;
    }
}