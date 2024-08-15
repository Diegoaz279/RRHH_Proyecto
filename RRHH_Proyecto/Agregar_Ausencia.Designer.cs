namespace RRHH_Proyecto
{
    partial class Agregar_Ausencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Ausencia));
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            cmb_Empleado = new ComboBox();
            label2 = new Label();
            btn_Agregar = new Button();
            cmb_TipoAusencia = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_OtraAusencia = new TextBox();
            btn_Cancelar = new Button();
            mb_FechaInicio = new MaskedTextBox();
            mb_FechaFinal = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(450, 5);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(30, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 11;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 34);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 63);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 35);
            label1.TabIndex = 37;
            label1.Text = "AGREGAR AUSENCIA ";
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
            cmb_Empleado.Location = new Point(202, 143);
            cmb_Empleado.Margin = new Padding(2);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(213, 25);
            cmb_Empleado.TabIndex = 38;
            cmb_Empleado.SelectedIndexChanged += cmb_Empleado_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 39;
            label2.Text = "Empleado";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Top;
            btn_Agregar.BackColor = Color.LightCyan;
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(278, 408);
            btn_Agregar.Margin = new Padding(2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(104, 45);
            btn_Agregar.TabIndex = 40;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // cmb_TipoAusencia
            // 
            cmb_TipoAusencia.Anchor = AnchorStyles.Top;
            cmb_TipoAusencia.BackColor = Color.LightBlue;
            cmb_TipoAusencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TipoAusencia.FlatStyle = FlatStyle.Popup;
            cmb_TipoAusencia.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_TipoAusencia.ForeColor = SystemColors.WindowFrame;
            cmb_TipoAusencia.FormattingEnabled = true;
            cmb_TipoAusencia.Items.AddRange(new object[] { "Enfermedad", "Vacaciones", "Permiso Personal", "Licencia por Maternidad/Paternidad", "Licencia por Enfermedad Familiar", "Asuntos Legales", "Problemas de Salud", "Otras" });
            cmb_TipoAusencia.Location = new Point(204, 205);
            cmb_TipoAusencia.Margin = new Padding(2);
            cmb_TipoAusencia.Name = "cmb_TipoAusencia";
            cmb_TipoAusencia.Size = new Size(213, 25);
            cmb_TipoAusencia.TabIndex = 41;
            cmb_TipoAusencia.SelectedIndexChanged += cmb_TipoAusencia_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 208);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 18);
            label3.TabIndex = 42;
            label3.Text = "Tipo Ausencia";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 273);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 18);
            label4.TabIndex = 43;
            label4.Text = "Inicio Ausencia";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 336);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 18);
            label5.TabIndex = 44;
            label5.Text = "Fin Ausencia";
            // 
            // txt_OtraAusencia
            // 
            txt_OtraAusencia.Anchor = AnchorStyles.Top;
            txt_OtraAusencia.BackColor = Color.LightBlue;
            txt_OtraAusencia.BorderStyle = BorderStyle.FixedSingle;
            txt_OtraAusencia.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_OtraAusencia.ForeColor = SystemColors.WindowFrame;
            txt_OtraAusencia.Location = new Point(204, 228);
            txt_OtraAusencia.Margin = new Padding(2);
            txt_OtraAusencia.Name = "txt_OtraAusencia";
            txt_OtraAusencia.Size = new Size(212, 24);
            txt_OtraAusencia.TabIndex = 47;
            txt_OtraAusencia.Text = "MOTIVO DE AUSENCIA";
            txt_OtraAusencia.Visible = false;
            txt_OtraAusencia.TextChanged += txt_OtraAusencia_TextChanged;
            txt_OtraAusencia.Enter += txt_OtraAusencia_Enter;
            txt_OtraAusencia.Leave += txt_OtraAusencia_Leave;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.BackColor = Color.LightCyan;
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(79, 408);
            btn_Cancelar.Margin = new Padding(2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(104, 45);
            btn_Cancelar.TabIndex = 48;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // mb_FechaInicio
            // 
            mb_FechaInicio.Anchor = AnchorStyles.Top;
            mb_FechaInicio.BackColor = Color.LightBlue;
            mb_FechaInicio.BorderStyle = BorderStyle.FixedSingle;
            mb_FechaInicio.ForeColor = SystemColors.WindowFrame;
            mb_FechaInicio.Location = new Point(204, 273);
            mb_FechaInicio.Margin = new Padding(2);
            mb_FechaInicio.Mask = "00/00/0000";
            mb_FechaInicio.Name = "mb_FechaInicio";
            mb_FechaInicio.Size = new Size(212, 23);
            mb_FechaInicio.TabIndex = 49;
            mb_FechaInicio.ValidatingType = typeof(DateTime);
            // 
            // mb_FechaFinal
            // 
            mb_FechaFinal.Anchor = AnchorStyles.Top;
            mb_FechaFinal.BackColor = Color.LightBlue;
            mb_FechaFinal.BorderStyle = BorderStyle.FixedSingle;
            mb_FechaFinal.ForeColor = SystemColors.WindowFrame;
            mb_FechaFinal.Location = new Point(204, 334);
            mb_FechaFinal.Margin = new Padding(2);
            mb_FechaFinal.Mask = "00/00/0000";
            mb_FechaFinal.Name = "mb_FechaFinal";
            mb_FechaFinal.Size = new Size(212, 23);
            mb_FechaFinal.TabIndex = 50;
            mb_FechaFinal.ValidatingType = typeof(DateTime);
            // 
            // Agregar_Ausencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 499);
            Controls.Add(mb_FechaFinal);
            Controls.Add(mb_FechaInicio);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_OtraAusencia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_TipoAusencia);
            Controls.Add(btn_Agregar);
            Controls.Add(label2);
            Controls.Add(cmb_Empleado);
            Controls.Add(label1);
            Controls.Add(btn_Cerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Agregar_Ausencia";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Ausencia";
            Load += Agregar_Ausencia_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btn_Cerrar;
        private Panel panel1;
        private Label label1;
        private ComboBox cmb_Empleado;
        private Label label2;
        private Button btn_Agregar;
        private ComboBox cmb_TipoAusencia;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_OtraAusencia;
        private Button btn_Cancelar;
        private MaskedTextBox mb_FechaInicio;
        private MaskedTextBox mb_FechaFinal;
    }
}