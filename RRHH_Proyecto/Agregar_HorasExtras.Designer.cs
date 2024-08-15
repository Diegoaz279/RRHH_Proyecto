namespace RRHH_Proyecto
{
    partial class Agregar_HorasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_HorasExtras));
            cmb_Empleado = new ComboBox();
            label2 = new Label();
            masked_Hsalida = new MaskedTextBox();
            masked_Hentrada = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_DescripcionTrabajo = new TextBox();
            btn_Canclar = new Button();
            btn_Agregar = new Button();
            label3 = new Label();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.BackColor = Color.LightBlue;
            cmb_Empleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Empleado.FlatStyle = FlatStyle.Popup;
            cmb_Empleado.ForeColor = SystemColors.WindowFrame;
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(250, 151);
            cmb_Empleado.Margin = new Padding(2);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(204, 23);
            cmb_Empleado.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 151);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 18);
            label2.TabIndex = 46;
            label2.Text = "Nombre Empleado:";
            // 
            // masked_Hsalida
            // 
            masked_Hsalida.BackColor = Color.LightBlue;
            masked_Hsalida.BorderStyle = BorderStyle.FixedSingle;
            masked_Hsalida.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            masked_Hsalida.ForeColor = SystemColors.WindowFrame;
            masked_Hsalida.Location = new Point(250, 244);
            masked_Hsalida.Margin = new Padding(2);
            masked_Hsalida.Mask = "00:00";
            masked_Hsalida.Name = "masked_Hsalida";
            masked_Hsalida.Size = new Size(49, 24);
            masked_Hsalida.TabIndex = 53;
            // 
            // masked_Hentrada
            // 
            masked_Hentrada.BackColor = Color.LightBlue;
            masked_Hentrada.BorderStyle = BorderStyle.FixedSingle;
            masked_Hentrada.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            masked_Hentrada.ForeColor = SystemColors.WindowFrame;
            masked_Hentrada.Location = new Point(250, 195);
            masked_Hentrada.Margin = new Padding(2);
            masked_Hentrada.Mask = "00:00";
            masked_Hentrada.Name = "masked_Hentrada";
            masked_Hentrada.Size = new Size(49, 24);
            masked_Hentrada.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 244);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 18);
            label4.TabIndex = 51;
            label4.Text = "Hora Salida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 195);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 18);
            label5.TabIndex = 50;
            label5.Text = "Hora Entrada:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 291);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 18);
            label1.TabIndex = 54;
            label1.Text = "Descripcion Trabajo:";
            // 
            // txt_DescripcionTrabajo
            // 
            txt_DescripcionTrabajo.BackColor = Color.LightBlue;
            txt_DescripcionTrabajo.BorderStyle = BorderStyle.FixedSingle;
            txt_DescripcionTrabajo.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_DescripcionTrabajo.ForeColor = SystemColors.WindowFrame;
            txt_DescripcionTrabajo.Location = new Point(250, 291);
            txt_DescripcionTrabajo.Multiline = true;
            txt_DescripcionTrabajo.Name = "txt_DescripcionTrabajo";
            txt_DescripcionTrabajo.Size = new Size(204, 64);
            txt_DescripcionTrabajo.TabIndex = 55;
            // 
            // btn_Canclar
            // 
            btn_Canclar.BackColor = Color.LightCyan;
            btn_Canclar.Cursor = Cursors.Hand;
            btn_Canclar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Canclar.Location = new Point(101, 393);
            btn_Canclar.Margin = new Padding(2);
            btn_Canclar.Name = "btn_Canclar";
            btn_Canclar.Size = new Size(107, 45);
            btn_Canclar.TabIndex = 57;
            btn_Canclar.Text = "CANCELAR";
            btn_Canclar.UseVisualStyleBackColor = false;
            btn_Canclar.Click += btn_Canclar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.LightCyan;
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(274, 393);
            btn_Agregar.Margin = new Padding(2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(108, 45);
            btn_Agregar.TabIndex = 56;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 35);
            label3.TabIndex = 58;
            label3.Text = "HORAS EXTRAS";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(464, 6);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(30, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 59;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(-37, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 37);
            panel1.TabIndex = 60;
            // 
            // Agregar_HorasExtras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 491);
            Controls.Add(btn_Cerrar);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btn_Canclar);
            Controls.Add(btn_Agregar);
            Controls.Add(txt_DescripcionTrabajo);
            Controls.Add(label1);
            Controls.Add(masked_Hsalida);
            Controls.Add(masked_Hentrada);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cmb_Empleado);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_HorasExtras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_HorasExtras";
            Load += Agregar_HorasExtras_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Empleado;
        private Label label2;
        private MaskedTextBox masked_Hsalida;
        private MaskedTextBox masked_Hentrada;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txt_DescripcionTrabajo;
        private Button btn_Canclar;
        private Button btn_Agregar;
        private Label label3;
        private PictureBox btn_Cerrar;
        private Panel panel1;
    }
}