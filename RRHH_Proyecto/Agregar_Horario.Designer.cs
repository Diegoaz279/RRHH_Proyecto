namespace RRHH_Proyecto
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
            label2 = new Label();
            cmb_Empleado = new ComboBox();
            mb_HoraSalida = new MaskedTextBox();
            mb_HoraEntrada = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            btn_Cancelar = new Button();
            btn_Agregar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(107, 222);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 41;
            label2.Text = "Empleado";
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.Anchor = AnchorStyles.Top;
            cmb_Empleado.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(320, 222);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(302, 34);
            cmb_Empleado.TabIndex = 40;
            // 
            // mb_HoraSalida
            // 
            mb_HoraSalida.BorderStyle = BorderStyle.FixedSingle;
            mb_HoraSalida.Location = new Point(322, 426);
            mb_HoraSalida.Mask = "00:00";
            mb_HoraSalida.Name = "mb_HoraSalida";
            mb_HoraSalida.Size = new Size(98, 31);
            mb_HoraSalida.TabIndex = 54;
            mb_HoraSalida.ValidatingType = typeof(DateTime);
            // 
            // mb_HoraEntrada
            // 
            mb_HoraEntrada.BorderStyle = BorderStyle.FixedSingle;
            mb_HoraEntrada.Location = new Point(321, 323);
            mb_HoraEntrada.Mask = "00:00";
            mb_HoraEntrada.Name = "mb_HoraEntrada";
            mb_HoraEntrada.Size = new Size(99, 31);
            mb_HoraEntrada.TabIndex = 53;
            mb_HoraEntrada.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(105, 429);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 52;
            label5.Text = "Hora Salida:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(105, 323);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 51;
            label4.Text = "Hora Entrada:";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(296, 560);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(148, 59);
            btn_Cancelar.TabIndex = 56;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Top;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(567, 560);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(148, 59);
            btn_Agregar.TabIndex = 55;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(267, 68);
            label1.Name = "label1";
            label1.Size = new Size(424, 52);
            label1.TabIndex = 57;
            label1.Text = "AGREGAR HORARIO";
            // 
            // Agregar_Horario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 679);
            Controls.Add(label1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Agregar);
            Controls.Add(mb_HoraSalida);
            Controls.Add(mb_HoraEntrada);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmb_Empleado);
            Name = "Agregar_Horario";
            Text = "Pase_Empleado";
            Load += Agregar_Horario_Load;
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
    }
}