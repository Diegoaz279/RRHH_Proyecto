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
            btn_Minimizar = new PictureBox();
            btn_Maximizar = new PictureBox();
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
            dt_InicioAusencia = new DateTimePicker();
            txt_OtraAusencia = new TextBox();
            btn_Cancelar = new Button();
            dt_FinAusencia = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // btn_Minimizar
            // 
            btn_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minimizar.Cursor = Cursors.Hand;
            btn_Minimizar.Image = (Image)resources.GetObject("btn_Minimizar.Image");
            btn_Minimizar.Location = new Point(601, 8);
            btn_Minimizar.Name = "btn_Minimizar";
            btn_Minimizar.Size = new Size(43, 40);
            btn_Minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Minimizar.TabIndex = 13;
            btn_Minimizar.TabStop = false;
            btn_Minimizar.Click += btn_Minimizar_Click;
            // 
            // btn_Maximizar
            // 
            btn_Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Maximizar.Cursor = Cursors.Hand;
            btn_Maximizar.Image = (Image)resources.GetObject("btn_Maximizar.Image");
            btn_Maximizar.Location = new Point(657, 8);
            btn_Maximizar.Name = "btn_Maximizar";
            btn_Maximizar.Size = new Size(43, 40);
            btn_Maximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Maximizar.TabIndex = 12;
            btn_Maximizar.TabStop = false;
            btn_Maximizar.Click += btn_Maximizar_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(713, 8);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(43, 40);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 57);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(160, 102);
            label1.Name = "label1";
            label1.Size = new Size(448, 52);
            label1.TabIndex = 37;
            label1.Text = "AGREGAR AUSENCIA ";
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.Anchor = AnchorStyles.Top;
            cmb_Empleado.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(286, 235);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(302, 34);
            cmb_Empleado.TabIndex = 38;
            cmb_Empleado.SelectedIndexChanged += cmb_Empleado_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 235);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 39;
            label2.Text = "Empleado";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Top;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(431, 693);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(148, 59);
            btn_Agregar.TabIndex = 40;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // cmb_TipoAusencia
            // 
            cmb_TipoAusencia.Anchor = AnchorStyles.Top;
            cmb_TipoAusencia.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_TipoAusencia.FormattingEnabled = true;
            cmb_TipoAusencia.Items.AddRange(new object[] { "Enfermedad", "Vacaciones", "Permiso Personal", "Licencia por Maternidad/Paternidad", "Licencia por Enfermedad Familiar", "Asuntos Legales", "Problemas de Salud", "Otras" });
            cmb_TipoAusencia.Location = new Point(288, 338);
            cmb_TipoAusencia.Name = "cmb_TipoAusencia";
            cmb_TipoAusencia.Size = new Size(302, 34);
            cmb_TipoAusencia.TabIndex = 41;
            cmb_TipoAusencia.SelectedIndexChanged += cmb_TipoAusencia_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 343);
            label3.Name = "label3";
            label3.Size = new Size(176, 28);
            label3.TabIndex = 42;
            label3.Text = "Tipo Ausencia";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 451);
            label4.Name = "label4";
            label4.Size = new Size(189, 28);
            label4.TabIndex = 43;
            label4.Text = "Inicio Ausencia";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(73, 557);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 44;
            label5.Text = "Fin Ausencia";
            // 
            // dt_InicioAusencia
            // 
            dt_InicioAusencia.Anchor = AnchorStyles.Top;
            dt_InicioAusencia.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            dt_InicioAusencia.Location = new Point(286, 449);
            dt_InicioAusencia.Name = "dt_InicioAusencia";
            dt_InicioAusencia.Size = new Size(414, 33);
            dt_InicioAusencia.TabIndex = 45;
            // 
            // txt_OtraAusencia
            // 
            txt_OtraAusencia.Anchor = AnchorStyles.Top;
            txt_OtraAusencia.BorderStyle = BorderStyle.FixedSingle;
            txt_OtraAusencia.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_OtraAusencia.Location = new Point(288, 377);
            txt_OtraAusencia.Name = "txt_OtraAusencia";
            txt_OtraAusencia.Size = new Size(302, 33);
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
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(160, 693);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(148, 59);
            btn_Cancelar.TabIndex = 48;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // dt_FinAusencia
            // 
            dt_FinAusencia.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            dt_FinAusencia.Location = new Point(286, 557);
            dt_FinAusencia.Name = "dt_FinAusencia";
            dt_FinAusencia.Size = new Size(412, 33);
            dt_FinAusencia.TabIndex = 49;
            dt_FinAusencia.ValueChanged += dt_FinAusencia_ValueChanged;
            // 
            // Agregar_Ausencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 812);
            Controls.Add(dt_FinAusencia);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_OtraAusencia);
            Controls.Add(dt_InicioAusencia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_TipoAusencia);
            Controls.Add(btn_Agregar);
            Controls.Add(label2);
            Controls.Add(cmb_Empleado);
            Controls.Add(label1);
            Controls.Add(btn_Minimizar);
            Controls.Add(btn_Maximizar);
            Controls.Add(btn_Cerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agregar_Ausencia";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Ausencia";
            Load += Agregar_Ausencia_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_Minimizar;
        private PictureBox btn_Maximizar;
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
        private DateTimePicker dt_InicioAusencia;
        private TextBox txt_OtraAusencia;
        private Button btn_Cancelar;
        private DateTimePicker dt_FinAusencia;
    }
}