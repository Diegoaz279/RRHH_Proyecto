namespace RRHH_Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Cancelar = new Button();
            btn_Ingresar = new Button();
            lbl_Usuario = new Label();
            lbl_Contraseña = new Label();
            txt_Usuario = new TextBox();
            txt_Contraseña = new TextBox();
            SuspendLayout();
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(138, 558);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(129, 49);
            btn_Cancelar.TabIndex = 0;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(359, 558);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(135, 49);
            btn_Ingresar.TabIndex = 1;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(138, 407);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(88, 25);
            lbl_Usuario.TabIndex = 2;
            lbl_Usuario.Text = "USUARIO";
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.Location = new Point(138, 470);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(126, 25);
            lbl_Contraseña.TabIndex = 3;
            lbl_Contraseña.Text = "CONTRASEÑA";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(351, 400);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(150, 31);
            txt_Usuario.TabIndex = 4;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Location = new Point(351, 470);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(150, 31);
            txt_Contraseña.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 698);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Usuario);
            Controls.Add(lbl_Contraseña);
            Controls.Add(lbl_Usuario);
            Controls.Add(btn_Ingresar);
            Controls.Add(btn_Cancelar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancelar;
        private Button btn_Ingresar;
        private Label lbl_Usuario;
        private Label lbl_Contraseña;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
    }
}
