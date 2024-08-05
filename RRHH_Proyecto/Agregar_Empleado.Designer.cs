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
            label8 = new Label();
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nacimiento = new TextBox();
            txt_Correo = new TextBox();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(141, 73);
            label8.Name = "label8";
            label8.Size = new Size(448, 52);
            label8.TabIndex = 7;
            label8.Text = "INGRESE LOS DATOS ";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = SystemColors.InactiveCaption;
            txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_Nombre.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Nombre.ForeColor = SystemColors.WindowFrame;
            txt_Nombre.Location = new Point(141, 200);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(448, 33);
            txt_Nombre.TabIndex = 8;
            txt_Nombre.Text = "NOMBRE";
            txt_Nombre.Enter += txt_Nombre_Enter;
            txt_Nombre.Leave += txt_Nombre_Leave;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = SystemColors.InactiveCaption;
            txt_Apellido.BorderStyle = BorderStyle.FixedSingle;
            txt_Apellido.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Apellido.ForeColor = SystemColors.WindowFrame;
            txt_Apellido.Location = new Point(141, 263);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(448, 33);
            txt_Apellido.TabIndex = 9;
            txt_Apellido.Text = "APELLIDO";
            txt_Apellido.Enter += txt_Apellido_Enter;
            txt_Apellido.Leave += txt_Apellido_Leave;
            // 
            // txt_Nacimiento
            // 
            txt_Nacimiento.BackColor = SystemColors.InactiveCaption;
            txt_Nacimiento.BorderStyle = BorderStyle.FixedSingle;
            txt_Nacimiento.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Nacimiento.ForeColor = SystemColors.WindowFrame;
            txt_Nacimiento.Location = new Point(141, 388);
            txt_Nacimiento.Name = "txt_Nacimiento";
            txt_Nacimiento.Size = new Size(448, 33);
            txt_Nacimiento.TabIndex = 11;
            txt_Nacimiento.Text = "LUGAR DE NACIMIENTO";
            txt_Nacimiento.Enter += txt_Nacimiento_Enter;
            txt_Nacimiento.Leave += txt_Nacimiento_Leave;
            // 
            // txt_Correo
            // 
            txt_Correo.BackColor = SystemColors.InactiveCaption;
            txt_Correo.BorderStyle = BorderStyle.FixedSingle;
            txt_Correo.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_Correo.ForeColor = SystemColors.WindowFrame;
            txt_Correo.Location = new Point(141, 581);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(448, 33);
            txt_Correo.TabIndex = 14;
            txt_Correo.Text = "CORREO ELECTRONICO";
            txt_Correo.Enter += txt_Correo_Enter;
            txt_Correo.Leave += txt_Correo_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(241, 688);
            button1.Name = "button1";
            button1.Size = new Size(199, 54);
            button1.TabIndex = 15;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.InactiveCaption;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            maskedTextBox1.ForeColor = SystemColors.WindowFrame;
            maskedTextBox1.Location = new Point(141, 330);
            maskedTextBox1.Mask = "000-0000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(448, 33);
            maskedTextBox1.TabIndex = 16;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(141, 522);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(448, 31);
            maskedTextBox2.TabIndex = 17;
            // 
            // Agregar_Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(721, 795);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Nacimiento);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(label8);
            Name = "Agregar_Empleado";
            Text = "Agregar_Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Nacimiento;
        private TextBox txt_Correo;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}