
namespace CantinaTioBill
{
    partial class F_gerenciarItenscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_gerenciarItenscs));
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nomeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_disponivel = new System.Windows.Forms.GroupBox();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.btn_novoProduto = new System.Windows.Forms.Button();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluirProduto = new System.Windows.Forms.Button();
            this.cb_tiposProdutos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.gb_disponivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(12, 102);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(244, 226);
            this.dgv_produtos.TabIndex = 0;
            this.dgv_produtos.SelectionChanged += new System.EventHandler(this.dgv_produtos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif Lao", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciar Produtos";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(528, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif Lao", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(530, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voltar";
            // 
            // tb_nomeProduto
            // 
            this.tb_nomeProduto.Location = new System.Drawing.Point(320, 165);
            this.tb_nomeProduto.Name = "tb_nomeProduto";
            this.tb_nomeProduto.Size = new System.Drawing.Size(124, 20);
            this.tb_nomeProduto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(266, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(459, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esta disponivel?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(266, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome:";
            // 
            // gb_disponivel
            // 
            this.gb_disponivel.Controls.Add(this.rb_nao);
            this.gb_disponivel.Controls.Add(this.rb_sim);
            this.gb_disponivel.Location = new System.Drawing.Point(462, 186);
            this.gb_disponivel.Name = "gb_disponivel";
            this.gb_disponivel.Size = new System.Drawing.Size(120, 34);
            this.gb_disponivel.TabIndex = 12;
            this.gb_disponivel.TabStop = false;
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nao.ForeColor = System.Drawing.SystemColors.Window;
            this.rb_nao.Location = new System.Drawing.Point(61, 10);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(52, 22);
            this.rb_nao.TabIndex = 1;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sim.ForeColor = System.Drawing.SystemColors.Window;
            this.rb_sim.Location = new System.Drawing.Point(6, 10);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(49, 22);
            this.rb_sim.TabIndex = 0;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "Sim";
            this.rb_sim.UseVisualStyleBackColor = true;
            // 
            // btn_novoProduto
            // 
            this.btn_novoProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_novoProduto.BackgroundImage")));
            this.btn_novoProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_novoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoProduto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btn_novoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novoProduto.Location = new System.Drawing.Point(0, 0);
            this.btn_novoProduto.Name = "btn_novoProduto";
            this.btn_novoProduto.Size = new System.Drawing.Size(64, 46);
            this.btn_novoProduto.TabIndex = 13;
            this.btn_novoProduto.UseVisualStyleBackColor = true;
            this.btn_novoProduto.Click += new System.EventHandler(this.btn_novoProduto_Click);
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvarEdicoes.BackgroundImage")));
            this.btn_salvarEdicoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salvarEdicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarEdicoes.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btn_salvarEdicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(111, 0);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(64, 46);
            this.btn_salvarEdicoes.TabIndex = 14;
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_excluirProduto);
            this.panel1.Controls.Add(this.btn_novoProduto);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Location = new System.Drawing.Point(282, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 46);
            this.panel1.TabIndex = 16;
            // 
            // btn_excluirProduto
            // 
            this.btn_excluirProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluirProduto.BackgroundImage")));
            this.btn_excluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_excluirProduto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btn_excluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluirProduto.Location = new System.Drawing.Point(234, 0);
            this.btn_excluirProduto.Name = "btn_excluirProduto";
            this.btn_excluirProduto.Size = new System.Drawing.Size(64, 46);
            this.btn_excluirProduto.TabIndex = 15;
            this.btn_excluirProduto.UseVisualStyleBackColor = true;
            this.btn_excluirProduto.Click += new System.EventHandler(this.btn_excluirProduto_Click);
            // 
            // cb_tiposProdutos
            // 
            this.cb_tiposProdutos.FormattingEnabled = true;
            this.cb_tiposProdutos.Location = new System.Drawing.Point(320, 198);
            this.cb_tiposProdutos.Name = "cb_tiposProdutos";
            this.cb_tiposProdutos.Size = new System.Drawing.Size(124, 21);
            this.cb_tiposProdutos.TabIndex = 17;
            // 
            // F_gerenciarItenscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.cb_tiposProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_disponivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_gerenciarItenscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Itens";
            this.Load += new System.EventHandler(this.F_gerenciarItenscs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_gerenciarItenscs_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_gerenciarItenscs_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.gb_disponivel.ResumeLayout(false);
            this.gb_disponivel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nomeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_disponivel;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.Button btn_novoProduto;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_excluirProduto;
        private System.Windows.Forms.ComboBox cb_tiposProdutos;
    }
}