namespace HeroisViloes
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbaNasc = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbRepresnt = new System.Windows.Forms.Label();
            this.btHeroi = new System.Windows.Forms.Button();
            this.btVilao = new System.Windows.Forms.Button();
            this.btAmigoHeroi = new System.Windows.Forms.Button();
            this.lbDigit = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.Snow;
            this.lbWelcome.Location = new System.Drawing.Point(190, 9);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(468, 25);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Olá, Seja Bem Vindo ao Sistema de Heróis!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(250, 105);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNascimento.TabIndex = 2;
            this.txtAnoNascimento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(442, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(631, 105);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Snow;
            this.lbNome.Location = new System.Drawing.Point(90, 86);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 16);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome:";
            // 
            // lbaNasc
            // 
            this.lbaNasc.AutoSize = true;
            this.lbaNasc.BackColor = System.Drawing.Color.Transparent;
            this.lbaNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaNasc.ForeColor = System.Drawing.Color.Snow;
            this.lbaNasc.Location = new System.Drawing.Point(225, 86);
            this.lbaNasc.Name = "lbaNasc";
            this.lbaNasc.Size = new System.Drawing.Size(147, 16);
            this.lbaNasc.TabIndex = 6;
            this.lbaNasc.Text = "Ano de Nascimento:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.Color.Snow;
            this.lbemail.Location = new System.Drawing.Point(463, 86);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(56, 16);
            this.lbemail.TabIndex = 7;
            this.lbemail.Text = "E-Mail:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Snow;
            this.lbID.Location = new System.Drawing.Point(667, 86);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 16);
            this.lbID.TabIndex = 8;
            this.lbID.Text = "ID:";
            // 
            // lbRepresnt
            // 
            this.lbRepresnt.AutoSize = true;
            this.lbRepresnt.BackColor = System.Drawing.Color.Transparent;
            this.lbRepresnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepresnt.ForeColor = System.Drawing.Color.Snow;
            this.lbRepresnt.Location = new System.Drawing.Point(245, 165);
            this.lbRepresnt.Name = "lbRepresnt";
            this.lbRepresnt.Size = new System.Drawing.Size(297, 25);
            this.lbRepresnt.TabIndex = 9;
            this.lbRepresnt.Text = "Qual Botão te Representa?";
            // 
            // btHeroi
            // 
            this.btHeroi.Location = new System.Drawing.Point(51, 209);
            this.btHeroi.Name = "btHeroi";
            this.btHeroi.Size = new System.Drawing.Size(130, 116);
            this.btHeroi.TabIndex = 11;
            this.btHeroi.Text = "Herói";
            this.btHeroi.UseVisualStyleBackColor = true;
            this.btHeroi.Click += new System.EventHandler(this.btHeroi_Click);
            // 
            // btVilao
            // 
            this.btVilao.BackColor = System.Drawing.SystemColors.Control;
            this.btVilao.Location = new System.Drawing.Point(604, 209);
            this.btVilao.Name = "btVilao";
            this.btVilao.Size = new System.Drawing.Size(140, 116);
            this.btVilao.TabIndex = 12;
            this.btVilao.Text = "Vilão";
            this.btVilao.UseVisualStyleBackColor = false;
            this.btVilao.Click += new System.EventHandler(this.btVilao_Click);
            // 
            // btAmigoHeroi
            // 
            this.btAmigoHeroi.Location = new System.Drawing.Point(340, 209);
            this.btAmigoHeroi.Name = "btAmigoHeroi";
            this.btAmigoHeroi.Size = new System.Drawing.Size(133, 116);
            this.btAmigoHeroi.TabIndex = 13;
            this.btAmigoHeroi.Text = "Amigo do Herói";
            this.btAmigoHeroi.UseVisualStyleBackColor = true;
            this.btAmigoHeroi.Click += new System.EventHandler(this.btAmigoHeroi_Click);
            // 
            // lbDigit
            // 
            this.lbDigit.AutoSize = true;
            this.lbDigit.BackColor = System.Drawing.Color.Transparent;
            this.lbDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDigit.ForeColor = System.Drawing.Color.Snow;
            this.lbDigit.Location = new System.Drawing.Point(362, 44);
            this.lbDigit.Name = "lbDigit";
            this.lbDigit.Size = new System.Drawing.Size(120, 20);
            this.lbDigit.TabIndex = 14;
            this.lbDigit.Text = "Digite Abaixo:";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(228, 363);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(370, 56);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbDigit);
            this.Controls.Add(this.btAmigoHeroi);
            this.Controls.Add(this.btVilao);
            this.Controls.Add(this.btHeroi);
            this.Controls.Add(this.lbRepresnt);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbaNasc);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbWelcome);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbaNasc;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbRepresnt;
        private System.Windows.Forms.Button btHeroi;
        private System.Windows.Forms.Button btVilao;
        private System.Windows.Forms.Button btAmigoHeroi;
        private System.Windows.Forms.Label lbDigit;
        private System.Windows.Forms.Button btSair;
    }
}

