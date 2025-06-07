namespace Ponto
{
    partial class painel_adm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(270, 173);
            label3.Name = "label3";
            label3.Size = new Size(516, 65);
            label3.TabIndex = 16;
            label3.Text = "Painel Administrativo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 112);
            label2.Name = "label2";
            label2.Size = new Size(354, 29);
            label2.TabIndex = 15;
            label2.Text = "“JUNTOS VAMOS MAIS LONGE”";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 47);
            label1.Name = "label1";
            label1.Size = new Size(445, 65);
            label1.TabIndex = 14;
            label1.Text = "PONTO DE HORAS";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(124, 309);
            button1.Name = "button1";
            button1.Size = new Size(239, 59);
            button1.TabIndex = 17;
            button1.Text = "Usuarios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click; // Corrigido - removido o NewMethod()
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(379, 309);
            button2.Name = "button2";
            button2.Size = new Size(239, 59);
            button2.TabIndex = 18;
            button2.Text = "Registros de Ponto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(642, 309);
            button3.Name = "button3";
            button3.Size = new Size(239, 59);
            button3.TabIndex = 19;
            button3.Text = "Relatorios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // painel_adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgazul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 642);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "painel_adm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "painel adm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           usuarios us = new usuarios();
            us.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Adicione aqui o código para o que deve acontecer quando button1 for clicado
            // Por exemplo:
            // MessageBox.Show("Botão Usuários foi clicado!");
            // Ou abrir outro formulário:
            // var form = new UsuariosForm();
            // form.Show();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}