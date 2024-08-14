namespace RRHH_Proyecto
{
    partial class Agregar_Departamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Departamento));
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_NomDepartamento = new TextBox();
            cb_Jefe = new ComboBox();
            txt_CorreoDep = new TextBox();
            btn_Registrar = new Button();
            btn_Cancelar = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(650, 7);
            btn_Cerrar.Margin = new Padding(2, 2, 2, 2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(30, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 14;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(btn_Cerrar);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 38);
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 165);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 18);
            label1.TabIndex = 38;
            label1.Text = "Nombre del Departamento";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 289);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(311, 18);
            label3.TabIndex = 40;
            label3.Text = "Correo Electronico del Departamento ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 226);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 41;
            label2.Text = "Nombre del Jefe";
            // 
            // txt_NomDepartamento
            // 
            txt_NomDepartamento.Anchor = AnchorStyles.Top;
            txt_NomDepartamento.BorderStyle = BorderStyle.FixedSingle;
            txt_NomDepartamento.Location = new Point(380, 163);
            txt_NomDepartamento.Margin = new Padding(2, 2, 2, 2);
            txt_NomDepartamento.Name = "txt_NomDepartamento";
            txt_NomDepartamento.Size = new Size(279, 23);
            txt_NomDepartamento.TabIndex = 42;
            // 
            // cb_Jefe
            // 
            cb_Jefe.Anchor = AnchorStyles.Top;
            cb_Jefe.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Jefe.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cb_Jefe.FormattingEnabled = true;
            cb_Jefe.Location = new Point(380, 226);
            cb_Jefe.Margin = new Padding(2, 2, 2, 2);
            cb_Jefe.Name = "cb_Jefe";
            cb_Jefe.Size = new Size(280, 28);
            cb_Jefe.TabIndex = 43;
            // 
            // txt_CorreoDep
            // 
            txt_CorreoDep.Anchor = AnchorStyles.Top;
            txt_CorreoDep.BorderStyle = BorderStyle.FixedSingle;
            txt_CorreoDep.Location = new Point(380, 289);
            txt_CorreoDep.Margin = new Padding(2, 2, 2, 2);
            txt_CorreoDep.Name = "txt_CorreoDep";
            txt_CorreoDep.Size = new Size(279, 23);
            txt_CorreoDep.TabIndex = 44;
            // 
            // btn_Registrar
            // 
            btn_Registrar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Registrar.Location = new Point(362, 364);
            btn_Registrar.Margin = new Padding(2, 2, 2, 2);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(119, 39);
            btn_Registrar.TabIndex = 45;
            btn_Registrar.Text = "REGISTRAR";
            btn_Registrar.UseVisualStyleBackColor = true;
            btn_Registrar.Click += btn_Registrar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(174, 364);
            btn_Cancelar.Margin = new Padding(2, 2, 2, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(122, 39);
            btn_Cancelar.TabIndex = 46;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 74);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(608, 35);
            label4.TabIndex = 47;
            label4.Text = "INGRESE LOS DATOS DEL DEPARTAMENTO ";
            // 
            // Agregar_Departamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 442);
            Controls.Add(label4);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Registrar);
            Controls.Add(txt_CorreoDep);
            Controls.Add(cb_Jefe);
            Controls.Add(txt_NomDepartamento);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Agregar_Departamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Departamento";
            Load += Agregar_Departamento_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btn_Cerrar;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txt_NomDepartamento;
        private ComboBox cb_Jefe;
        private TextBox txt_CorreoDep;
        private Button btn_Registrar;
        private Button btn_Cancelar;
        private Label label4;
    }
}