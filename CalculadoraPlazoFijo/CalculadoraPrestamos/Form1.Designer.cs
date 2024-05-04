namespace CalculadoraPrestamos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonto = new TextBox();
            txtAños = new TextBox();
            txtTasa = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            label5 = new Label();
            txtAcumulado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(119, 35);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 0;
            label1.Text = "Monto Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(119, 93);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 1;
            label2.Text = "Tasa de Interes Anual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(119, 149);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 2;
            label3.Text = "Periodo de Tiempo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(119, 290);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 3;
            label4.Text = "Capital Final";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(493, 41);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 4;
            // 
            // txtAños
            // 
            txtAños.Location = new Point(493, 155);
            txtAños.Name = "txtAños";
            txtAños.Size = new Size(125, 27);
            txtAños.TabIndex = 5;
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(493, 99);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(125, 27);
            txtTasa.TabIndex = 6;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(493, 290);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.GradientInactiveCaption;
            btnCalcular.Font = new Font("Segoe UI", 14F);
            btnCalcular.Location = new Point(119, 217);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 45);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(119, 351);
            label5.Name = "label5";
            label5.Size = new Size(247, 32);
            label5.TabIndex = 9;
            label5.Text = "Intereses Acumulados";
            // 
            // txtAcumulado
            // 
            txtAcumulado.Location = new Point(493, 351);
            txtAcumulado.Name = "txtAcumulado";
            txtAcumulado.Size = new Size(125, 27);
            txtAcumulado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAcumulado);
            Controls.Add(label5);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtTasa);
            Controls.Add(txtAños);
            Controls.Add(txtMonto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonto;
        private TextBox txtAños;
        private TextBox txtTasa;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label label5;
        private TextBox txtAcumulado;
    }
}
