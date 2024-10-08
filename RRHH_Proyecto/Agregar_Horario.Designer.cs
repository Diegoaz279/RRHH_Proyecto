﻿namespace RRHH_Proyecto
{
    partial class Agregar_Horario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Horario));
            label2 = new Label();
            cmb_Empleado = new ComboBox();
            mb_HoraSalida = new MaskedTextBox();
            mb_HoraEntrada = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            btn_Cancelar = new Button();
            btn_Agregar = new Button();
            label1 = new Label();
            btn_Cerrar = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 185);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 41;
            label2.Text = "Empleado";
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
            cmb_Empleado.Location = new Point(213, 185);
            cmb_Empleado.Margin = new Padding(2);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(213, 25);
            cmb_Empleado.TabIndex = 40;
            // 
            // mb_HoraSalida
            // 
            mb_HoraSalida.Anchor = AnchorStyles.Top;
            mb_HoraSalida.BackColor = Color.LightBlue;
            mb_HoraSalida.BorderStyle = BorderStyle.FixedSingle;
            mb_HoraSalida.ForeColor = SystemColors.WindowFrame;
            mb_HoraSalida.Location = new Point(213, 319);
            mb_HoraSalida.Margin = new Padding(2);
            mb_HoraSalida.Mask = "00:00";
            mb_HoraSalida.Name = "mb_HoraSalida";
            mb_HoraSalida.Size = new Size(69, 23);
            mb_HoraSalida.TabIndex = 54;
            mb_HoraSalida.ValidatingType = typeof(DateTime);
            // 
            // mb_HoraEntrada
            // 
            mb_HoraEntrada.Anchor = AnchorStyles.Top;
            mb_HoraEntrada.BackColor = Color.LightBlue;
            mb_HoraEntrada.BorderStyle = BorderStyle.FixedSingle;
            mb_HoraEntrada.ForeColor = SystemColors.WindowFrame;
            mb_HoraEntrada.Location = new Point(213, 251);
            mb_HoraEntrada.Margin = new Padding(2);
            mb_HoraEntrada.Mask = "00:00";
            mb_HoraEntrada.Name = "mb_HoraEntrada";
            mb_HoraEntrada.Size = new Size(70, 23);
            mb_HoraEntrada.TabIndex = 53;
            mb_HoraEntrada.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(65, 318);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 18);
            label5.TabIndex = 52;
            label5.Text = "Hora Salida:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 251);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 18);
            label4.TabIndex = 51;
            label4.Text = "Hora Entrada:";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.BackColor = Color.LightCyan;
            btn_Cancelar.Cursor = Cursors.Hand;
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(81, 389);
            btn_Cancelar.Margin = new Padding(2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(104, 45);
            btn_Cancelar.TabIndex = 56;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Top;
            btn_Agregar.BackColor = Color.LightCyan;
            btn_Agregar.Cursor = Cursors.Hand;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(267, 389);
            btn_Agregar.Margin = new Padding(2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(104, 45);
            btn_Agregar.TabIndex = 55;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 35);
            label1.TabIndex = 57;
            label1.Text = "AGREGAR HORARIO";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.Transparent;
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(442, 6);
            btn_Cerrar.Margin = new Padding(2);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(30, 24);
            btn_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Cerrar.TabIndex = 58;
            btn_Cerrar.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(-3, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 37);
            panel1.TabIndex = 59;
            // 
            // Agregar_Horario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 458);
            Controls.Add(btn_Cerrar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Agregar);
            Controls.Add(mb_HoraSalida);
            Controls.Add(mb_HoraEntrada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmb_Empleado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Agregar_Horario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pase_Empleado";
            Load += Agregar_Horario_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmb_Empleado;
        private MaskedTextBox mb_HoraSalida;
        private MaskedTextBox mb_HoraEntrada;
        private Label label5;
        private Label label4;
        private Button btn_Cancelar;
        private Button btn_Agregar;
        private Label label1;
        private PictureBox btn_Cerrar;
        private Panel panel1;
    }
}