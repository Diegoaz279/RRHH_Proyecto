namespace RRHH_Proyecto
{
    partial class Agregar_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Empleado));
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nacimiento = new TextBox();
            txt_Correo = new TextBox();
            mtb_Cedula = new MaskedTextBox();
            mtb_Telefono = new MaskedTextBox();
            btn_Registrar = new Button();
            btn_Cerrar = new PictureBox();
            txt_Cargo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_Cancelar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Anchor = AnchorStyles.Top;
            txt_Nombre.BackColor = Color.LightBlue;
            txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_Nombre.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Nombre.ForeColor = SystemColors.WindowFrame;
            txt_Nombre.Location = new Point(233, 141);
            txt_Nombre.Margin = new Padding(2, 2, 2, 2);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(257, 24);
            txt_Nombre.TabIndex = 8;
            txt_Nombre.Enter += txt_Nombre_Enter;
            txt_Nombre.Leave += txt_Nombre_Leave;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Anchor = AnchorStyles.Top;
            txt_Apellido.BackColor = Color.LightBlue;
            txt_Apellido.BorderStyle = BorderStyle.FixedSingle;
            txt_Apellido.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Apellido.ForeColor = SystemColors.WindowFrame;
            txt_Apellido.Location = new Point(233, 179);
            txt_Apellido.Margin = new Padding(2, 2, 2, 2);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(257, 24);
            txt_Apellido.TabIndex = 9;
            txt_Apellido.Enter += txt_Apellido_Enter;
            txt_Apellido.Leave += txt_Apellido_Leave;
            // 
            // txt_Nacimiento
            // 
            txt_Nacimiento.Anchor = AnchorStyles.Top;
            txt_Nacimiento.BackColor = Color.LightBlue;
            txt_Nacimiento.BorderStyle = BorderStyle.FixedSingle;
            txt_Nacimiento.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Nacimiento.ForeColor = SystemColors.WindowFrame;
            txt_Nacimiento.Location = new Point(233, 254);
            txt_Nacimiento.Margin = new Padding(2, 2, 2, 2);
            txt_Nacimiento.Name = "txt_Nacimiento";
            txt_Nacimiento.Size = new Size(257, 24);
            txt_Nacimiento.TabIndex = 11;
            txt_Nacimiento.Enter += txt_Nacimiento_Enter;
            txt_Nacimiento.Leave += txt_Nacimiento_Leave;
            // 
            // txt_Correo
            // 
            txt_Correo.Anchor = AnchorStyles.Top;
            txt_Correo.BackColor = Color.LightBlue;
            txt_Correo.BorderStyle = BorderStyle.FixedSingle;
            txt_Correo.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Correo.ForeColor = SystemColors.WindowFrame;
            txt_Correo.Location = new Point(233, 325);
            txt_Correo.Margin = new Padding(2, 2, 2, 2);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(257, 24);
            txt_Correo.TabIndex = 14;
            txt_Correo.Enter += txt_Correo_Enter;
            txt_Correo.Leave += txt_Correo_Leave;
            // 
            // mtb_Cedula
            // 
            mtb_Cedula.Anchor = AnchorStyles.Top;
            mtb_Cedula.BackColor = Color.LightBlue;
            mtb_Cedula.BorderStyle = BorderStyle.FixedSingle;
            mtb_Cedula.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            mtb_Cedula.ForeColor = SystemColors.WindowFrame;
            mtb_Cedula.Location = new Point(233, 217);
            mtb_Cedula.Margin = new Padding(2, 2, 2, 2);
            mtb_Cedula.Mask = "000-0000000-0";
            mtb_Cedula.Name = "mtb_Cedula";
            mtb_Cedula.Size = new Size(121, 24);
            mtb_Cedula.TabIndex = 16;
            // 
            // mtb_Telefono
            // 
            mtb_Telefono.Anchor = AnchorStyles.Top;
            mtb_Telefono.BackColor = Color.LightBlue;
            mtb_Telefono.BorderStyle = BorderStyle.FixedSingle;
            mtb_Telefono.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            mtb_Telefono.ForeColor = SystemColors.WindowFrame;
            mtb_Telefono.Location = new Point(233, 290);
            mtb_Telefono.Margin = new Padding(2, 2, 2, 2);
            mtb_Telefono.Mask = "000-000-0000";
            mtb_Telefono.Name = "mtb_Telefono";
            mtb_Telefono.Size = new Size(112, 24);
            mtb_Telefono.TabIndex = 17;
            // 
            // btn_Registrar
            // 
            btn_Registrar.Anchor = AnchorStyles.Top;
            btn_Registrar.BackColor = Color.LightCyan;
            btn_Registrar.Cursor = Cursors.Hand;
            btn_Registrar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Registrar.Location = new Point(304, 451);
            btn_Registrar.Margin = new Padding(2, 2, 2, 2);
            btn_Registrar.Name = "btn_Registrar";
            btn_Registrar.Size = new Size(127, 46);
            btn_Registrar.TabIndex = 18;
            btn_Registrar.Text = "REGISTRAR";
            btn_Registrar.UseVisualStyleBackColor = false;
            btn_Registrar.Click += btnRegistrar_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(501, 7);
            btn_Cerrar.Margin = new Padding(2, 2, 2, 2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(30, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 19;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // txt_Cargo
            // 
            txt_Cargo.Anchor = AnchorStyles.Top;
            txt_Cargo.BackColor = Color.LightBlue;
            txt_Cargo.BorderStyle = BorderStyle.FixedSingle;
            txt_Cargo.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Cargo.ForeColor = SystemColors.WindowFrame;
            txt_Cargo.Location = new Point(233, 372);
            txt_Cargo.Margin = new Padding(2, 2, 2, 2);
            txt_Cargo.Name = "txt_Cargo";
            txt_Cargo.Size = new Size(218, 24);
            txt_Cargo.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 35);
            label1.TabIndex = 23;
            label1.Text = "DATOS DEL EMPLEADO ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 145);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 24;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 183);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 25;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 254);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 18);
            label4.TabIndex = 27;
            label4.Text = "Lugar De Nacimiento:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 216);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 18);
            label5.TabIndex = 26;
            label5.Text = "Cedula:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 329);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 18);
            label6.TabIndex = 30;
            label6.Text = "Correo Electrico:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 289);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 18);
            label7.TabIndex = 29;
            label7.Text = "Numero Telefonico:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(42, 371);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 18);
            label8.TabIndex = 28;
            label8.Text = "Cargo:";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.BackColor = Color.LightCyan;
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(95, 451);
            btn_Cancelar.Margin = new Padding(2, 2, 2, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(127, 46);
            btn_Cancelar.TabIndex = 31;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 37);
            panel1.TabIndex = 35;
            // 
            // Agregar_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 550);
            Controls.Add(btn_Cancelar);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Cargo);
            Controls.Add(btn_Cerrar);
            Controls.Add(btn_Registrar);
            Controls.Add(mtb_Telefono);
            Controls.Add(mtb_Cedula);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Nacimiento);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Agregar_Empleado";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_Empleado";
            Load += Agregar_Empleado_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Nacimiento;
        private TextBox txt_Correo;
        private MaskedTextBox mtb_Cedula;
        private MaskedTextBox mtb_Telefono;
        private Button btn_Registrar;
        private PictureBox btn_Cerrar;
        private TextBox txt_Cargo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_Cancelar;
        private Panel panel1;
    }
}