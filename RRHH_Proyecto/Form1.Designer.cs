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
            txt_Usuario = new TextBox();
            txt_Contraseña = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.SkyBlue;
            btn_Cancelar.FlatAppearance.BorderColor = Color.DimGray;
            btn_Cancelar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Cancelar.Location = new Point(82, 688);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(151, 59);
            btn_Cancelar.TabIndex = 0;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = Color.LightSkyBlue;
            btn_Ingresar.FlatAppearance.BorderColor = Color.DimGray;
            btn_Ingresar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Ingresar.Location = new Point(325, 688);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(162, 59);
            btn_Ingresar.TabIndex = 1;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.LightBlue;
            txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_Usuario.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.Location = new Point(110, 479);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(353, 33);
            txt_Usuario.TabIndex = 4;
            txt_Usuario.Text = "USUARIO";
            txt_Usuario.TextChanged += txt_Usuario_TextChanged;
            txt_Usuario.Enter += txt_Usuario_Enter;
            txt_Usuario.Leave += txt_Usuario_Leave;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.BackColor = Color.LightBlue;
            txt_Contraseña.BorderStyle = BorderStyle.FixedSingle;
            txt_Contraseña.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contraseña.Location = new Point(110, 563);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(353, 33);
            txt_Contraseña.TabIndex = 5;
            txt_Contraseña.Text = "CONTRASEÑA";
            txt_Contraseña.Enter += txt_Contraseña_Enter;
            txt_Contraseña.Leave += txt_Contraseña_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 47);
            label2.Name = "label2";
            label2.Size = new Size(496, 52);
            label2.TabIndex = 7;
            label2.Text = "GESTION DE PERSONAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(579, 837);
            Controls.Add(label2);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Usuario);
            Controls.Add(btn_Ingresar);
            Controls.Add(btn_Cancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.93D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancelar;
        private Button btn_Ingresar;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Label label2;
    }
}
