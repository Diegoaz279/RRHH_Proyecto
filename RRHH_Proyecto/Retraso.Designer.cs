namespace RRHH_Proyecto
{
    partial class Agregar_Retraso
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
            mb_Fecha = new MaskedTextBox();
            btn_Cancelar = new Button();
            txt_OtroRetraso = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmb_TipoRetraso = new ComboBox();
            btn_Agregar = new Button();
            label2 = new Label();
            cmb_Empleado = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // mb_Fecha
            // 
            mb_Fecha.BorderStyle = BorderStyle.FixedSingle;
            mb_Fecha.Location = new Point(348, 305);
            mb_Fecha.Margin = new Padding(2);
            mb_Fecha.Mask = "00/00/0000";
            mb_Fecha.Name = "mb_Fecha";
            mb_Fecha.Size = new Size(242, 27);
            mb_Fecha.TabIndex = 61;
            mb_Fecha.ValidatingType = typeof(DateTime);
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Anchor = AnchorStyles.Top;
            btn_Cancelar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Cancelar.Location = new Point(246, 498);
            btn_Cancelar.Margin = new Padding(2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(118, 47);
            btn_Cancelar.TabIndex = 60;
            btn_Cancelar.Text = "CANCELAR";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_OtroRetraso
            // 
            txt_OtroRetraso.Anchor = AnchorStyles.Top;
            txt_OtroRetraso.BorderStyle = BorderStyle.FixedSingle;
            txt_OtroRetraso.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            txt_OtroRetraso.Location = new Point(348, 246);
            txt_OtroRetraso.Margin = new Padding(2);
            txt_OtroRetraso.Name = "txt_OtroRetraso";
            txt_OtroRetraso.Size = new Size(242, 29);
            txt_OtroRetraso.TabIndex = 59;
            txt_OtroRetraso.Text = "MOTIVO DE RETRASO";
            txt_OtroRetraso.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(176, 390);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 58;
            label5.Text = "Observacion";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(176, 305);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 57;
            label4.Text = "Fecha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(176, 218);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 56;
            label3.Text = "Tipo Retraso";
            // 
            // cmb_TipoRetraso
            // 
            cmb_TipoRetraso.Anchor = AnchorStyles.Top;
            cmb_TipoRetraso.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_TipoRetraso.FormattingEnabled = true;
            cmb_TipoRetraso.Items.AddRange(new object[] { "Tráfico o problemas de transporte", "Problemas de salud", "Compromisos familiares", "Problemas técnicos", "Desorganización personal" });
            cmb_TipoRetraso.Location = new Point(348, 214);
            cmb_TipoRetraso.Margin = new Padding(2);
            cmb_TipoRetraso.Name = "cmb_TipoRetraso";
            cmb_TipoRetraso.Size = new Size(242, 30);
            cmb_TipoRetraso.TabIndex = 55;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Anchor = AnchorStyles.Top;
            btn_Agregar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(463, 498);
            btn_Agregar.Margin = new Padding(2);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(118, 47);
            btn_Agregar.TabIndex = 54;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(176, 132);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 53;
            label2.Text = "Empleado";
            // 
            // cmb_Empleado
            // 
            cmb_Empleado.Anchor = AnchorStyles.Top;
            cmb_Empleado.Font = new Font("Arial", 11F, FontStyle.Italic, GraphicsUnit.Point);
            cmb_Empleado.FormattingEnabled = true;
            cmb_Empleado.Location = new Point(347, 132);
            cmb_Empleado.Margin = new Padding(2);
            cmb_Empleado.Name = "cmb_Empleado";
            cmb_Empleado.Size = new Size(242, 30);
            cmb_Empleado.TabIndex = 52;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(357, 44);
            label1.TabIndex = 51;
            label1.Text = "AGREGAR RETRASO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 387);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 62;
            // 
            // Agregar_Retraso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(textBox1);
            Controls.Add(mb_Fecha);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_OtroRetraso);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmb_TipoRetraso);
            Controls.Add(btn_Agregar);
            Controls.Add(label2);
            Controls.Add(cmb_Empleado);
            Controls.Add(label1);
            Name = "Agregar_Retraso";
            Text = "Agregar_Retraso";
            Load += Retraso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox mb_Fecha;
        private Button btn_Cancelar;
        private TextBox txt_OtroRetraso;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmb_TipoRetraso;
        private Button btn_Agregar;
        private Label label2;
        private ComboBox cmb_Empleado;
        private Label label1;
        private TextBox textBox1;
    }
}