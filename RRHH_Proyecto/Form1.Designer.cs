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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Cancelar = new Button();
            btn_Ingresar = new Button();
            txt_Usuario = new TextBox();
            txt_Contraseña = new TextBox();
            label2 = new Label();
            btn_Cerrar = new PictureBox();
            btn_Maximizar = new PictureBox();
            btn_Minimizar = new PictureBox();
            pictureBox4 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.BackColor = Color.SkyBlue;
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_Cancelar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Cancelar.Location = new Point(108, 742);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(157, 58);
            btn_Cancelar.TabIndex = 0;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Anchor = AnchorStyles.Top;
            btn_Ingresar.BackColor = Color.SkyBlue;
            btn_Ingresar.Cursor = Cursors.Hand;
            btn_Ingresar.FlatAppearance.BorderColor = Color.Black;
            btn_Ingresar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ingresar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Ingresar.Location = new Point(304, 742);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(157, 58);
            btn_Ingresar.TabIndex = 1;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Anchor = AnchorStyles.Top;
            txt_Usuario.BackColor = Color.LightBlue;
            txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_Usuario.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Usuario.ForeColor = Color.DimGray;
            txt_Usuario.Location = new Point(108, 560);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(353, 40);
            txt_Usuario.TabIndex = 4;
            txt_Usuario.Text = "USUARIO";
            txt_Usuario.TextChanged += txt_Usuario_TextChanged;
            txt_Usuario.Enter += txt_Usuario_Enter;
            txt_Usuario.Leave += txt_Usuario_Leave;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Anchor = AnchorStyles.Top;
            txt_Contraseña.BackColor = Color.LightBlue;
            txt_Contraseña.BorderStyle = BorderStyle.FixedSingle;
            txt_Contraseña.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contraseña.ForeColor = Color.DimGray;
            txt_Contraseña.Location = new Point(108, 643);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(353, 40);
            txt_Contraseña.TabIndex = 5;
            txt_Contraseña.Text = "CONTRASEÑA";
            txt_Contraseña.TextChanged += txt_Contraseña_TextChanged;
            txt_Contraseña.Enter += txt_Contraseña_Enter;
            txt_Contraseña.Leave += txt_Contraseña_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 86);
            label2.Name = "label2";
            label2.Size = new Size(441, 52);
            label2.TabIndex = 7;
            label2.Text = "INGRESE SUS DATOS";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(491, 12);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(43, 40);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 8;
            btn_Cerrar.TabStop = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Maximizar
            // 
            btn_Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Maximizar.Cursor = Cursors.Hand;
            btn_Maximizar.Image = (Image)resources.GetObject("btn_Maximizar.Image");
            btn_Maximizar.Location = new Point(435, 12);
            btn_Maximizar.Name = "btn_Maximizar";
            btn_Maximizar.Size = new Size(43, 40);
            btn_Maximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Maximizar.TabIndex = 9;
            btn_Maximizar.TabStop = false;
            btn_Maximizar.Click += btn_Maximizar_Click;
            // 
            // btn_Minimizar
            // 
            btn_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minimizar.Cursor = Cursors.Hand;
            btn_Minimizar.Image = (Image)resources.GetObject("btn_Minimizar.Image");
            btn_Minimizar.Location = new Point(379, 12);
            btn_Minimizar.Name = "btn_Minimizar";
            btn_Minimizar.Size = new Size(43, 40);
            btn_Minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Minimizar.TabIndex = 10;
            btn_Minimizar.TabStop = false;
            btn_Minimizar.Click += btn_Minimizar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(98, 158);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(353, 362);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(557, 842);
            Controls.Add(pictureBox4);
            Controls.Add(btn_Minimizar);
            Controls.Add(btn_Maximizar);
            Controls.Add(btn_Cerrar);
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
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancelar;
        private Button btn_Ingresar;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Label label2;
        private PictureBox btn_Cerrar;
        private PictureBox btn_Maximizar;
        private PictureBox btn_Minimizar;
        private PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
