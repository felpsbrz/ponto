namespace Ponto
{
    partial class PainelAdm
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
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(452, 171);
            label3.Name = "label3";
            label3.Size = new Size(214, 65);
            label3.TabIndex = 13;
            label3.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 103);
            label2.Name = "label2";
            label2.Size = new Size(354, 29);
            label2.TabIndex = 12;
            label2.Text = "“JUNTOS VAMOS MAIS LONGE”";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 38);
            label1.Name = "label1";
            label1.Size = new Size(445, 65);
            label1.TabIndex = 11;
            label1.Text = "PONTO DE HORAS";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(246, 239);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 70);
            textBox1.TabIndex = 10;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(457, 312);
            label4.Name = "label4";
            label4.Size = new Size(178, 65);
            label4.TabIndex = 15;
            label4.Text = "Senha:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(246, 377);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(600, 70);
            textBox2.TabIndex = 14;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(246, 474);
            button1.Name = "button1";
            button1.Size = new Size(600, 76);
            button1.TabIndex = 16;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PainelAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgazul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1053, 646);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "PainelAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
    }
}