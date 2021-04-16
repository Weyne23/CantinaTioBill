
namespace CantinaTioBill
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_horas = new System.Windows.Forms.Label();
            this.pb_led = new System.Windows.Forms.PictureBox();
            this.lb_nomeUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_meusPedidos = new System.Windows.Forms.Button();
            this.btn_gerenciarClientes = new System.Windows.Forms.Button();
            this.btn_addPedidos = new System.Windows.Forms.Button();
            this.btn_deslogar = new System.Windows.Forms.Button();
            this.btn_fchar = new System.Windows.Forms.Button();
            this.btn_gerenciarUsuarios = new System.Windows.Forms.Button();
            this.lb_nomeTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_gerenciarItens = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_led)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lb_horas);
            this.panel1.Controls.Add(this.pb_led);
            this.panel1.Controls.Add(this.lb_nomeUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 0;
            // 
            // lb_horas
            // 
            this.lb_horas.AutoSize = true;
            this.lb_horas.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horas.Location = new System.Drawing.Point(661, 9);
            this.lb_horas.Name = "lb_horas";
            this.lb_horas.Size = new System.Drawing.Size(58, 14);
            this.lb_horas.TabIndex = 3;
            this.lb_horas.Text = "lb_horas";
            // 
            // pb_led
            // 
            this.pb_led.Image = global::CantinaTioBill.Properties.Resources.led_circle_red;
            this.pb_led.InitialImage = null;
            this.pb_led.Location = new System.Drawing.Point(13, 5);
            this.pb_led.Name = "pb_led";
            this.pb_led.Size = new System.Drawing.Size(30, 23);
            this.pb_led.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_led.TabIndex = 2;
            this.pb_led.TabStop = false;
            // 
            // lb_nomeUser
            // 
            this.lb_nomeUser.AutoSize = true;
            this.lb_nomeUser.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeUser.Location = new System.Drawing.Point(135, 9);
            this.lb_nomeUser.Name = "lb_nomeUser";
            this.lb_nomeUser.Size = new System.Drawing.Size(16, 14);
            this.lb_nomeUser.TabIndex = 1;
            this.lb_nomeUser.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo(a): ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_meusPedidos
            // 
            this.btn_meusPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_meusPedidos.BackgroundImage")));
            this.btn_meusPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_meusPedidos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_meusPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meusPedidos.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_meusPedidos.ForeColor = System.Drawing.Color.White;
            this.btn_meusPedidos.Location = new System.Drawing.Point(24, 101);
            this.btn_meusPedidos.Name = "btn_meusPedidos";
            this.btn_meusPedidos.Size = new System.Drawing.Size(177, 111);
            this.btn_meusPedidos.TabIndex = 2;
            this.btn_meusPedidos.Text = "Meus Pedidos";
            this.btn_meusPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_meusPedidos.UseVisualStyleBackColor = true;
            this.btn_meusPedidos.Visible = false;
            // 
            // btn_gerenciarClientes
            // 
            this.btn_gerenciarClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gerenciarClientes.BackgroundImage")));
            this.btn_gerenciarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gerenciarClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_gerenciarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciarClientes.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerenciarClientes.ForeColor = System.Drawing.Color.White;
            this.btn_gerenciarClientes.Location = new System.Drawing.Point(586, 101);
            this.btn_gerenciarClientes.Name = "btn_gerenciarClientes";
            this.btn_gerenciarClientes.Size = new System.Drawing.Size(177, 111);
            this.btn_gerenciarClientes.TabIndex = 3;
            this.btn_gerenciarClientes.Text = "Gerenciar Clientes";
            this.btn_gerenciarClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gerenciarClientes.UseVisualStyleBackColor = true;
            this.btn_gerenciarClientes.Visible = false;
            // 
            // btn_addPedidos
            // 
            this.btn_addPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addPedidos.BackgroundImage")));
            this.btn_addPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addPedidos.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_addPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPedidos.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPedidos.ForeColor = System.Drawing.Color.White;
            this.btn_addPedidos.Location = new System.Drawing.Point(308, 101);
            this.btn_addPedidos.Name = "btn_addPedidos";
            this.btn_addPedidos.Size = new System.Drawing.Size(177, 111);
            this.btn_addPedidos.TabIndex = 5;
            this.btn_addPedidos.Text = "Adicionar Pedido";
            this.btn_addPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addPedidos.UseVisualStyleBackColor = true;
            this.btn_addPedidos.Visible = false;
            // 
            // btn_deslogar
            // 
            this.btn_deslogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deslogar.BackgroundImage")));
            this.btn_deslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deslogar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deslogar.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deslogar.ForeColor = System.Drawing.Color.White;
            this.btn_deslogar.Location = new System.Drawing.Point(584, 237);
            this.btn_deslogar.Name = "btn_deslogar";
            this.btn_deslogar.Size = new System.Drawing.Size(179, 111);
            this.btn_deslogar.TabIndex = 7;
            this.btn_deslogar.Text = "Logar";
            this.btn_deslogar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_deslogar.UseVisualStyleBackColor = true;
            this.btn_deslogar.Click += new System.EventHandler(this.btn_deslogar_Click);
            // 
            // btn_fchar
            // 
            this.btn_fchar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fchar.BackgroundImage")));
            this.btn_fchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fchar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.btn_fchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fchar.Location = new System.Drawing.Point(717, 12);
            this.btn_fchar.Name = "btn_fchar";
            this.btn_fchar.Size = new System.Drawing.Size(67, 58);
            this.btn_fchar.TabIndex = 8;
            this.btn_fchar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fchar.UseVisualStyleBackColor = true;
            this.btn_fchar.Click += new System.EventHandler(this.btn_fchar_Click);
            // 
            // btn_gerenciarUsuarios
            // 
            this.btn_gerenciarUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gerenciarUsuarios.BackgroundImage")));
            this.btn_gerenciarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gerenciarUsuarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_gerenciarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciarUsuarios.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerenciarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btn_gerenciarUsuarios.Location = new System.Drawing.Point(308, 237);
            this.btn_gerenciarUsuarios.Name = "btn_gerenciarUsuarios";
            this.btn_gerenciarUsuarios.Size = new System.Drawing.Size(177, 111);
            this.btn_gerenciarUsuarios.TabIndex = 9;
            this.btn_gerenciarUsuarios.Text = "Gerenciar Usuarios";
            this.btn_gerenciarUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gerenciarUsuarios.UseVisualStyleBackColor = true;
            this.btn_gerenciarUsuarios.Visible = false;
            // 
            // lb_nomeTitulo
            // 
            this.lb_nomeTitulo.AutoSize = true;
            this.lb_nomeTitulo.Font = new System.Drawing.Font("Rubik", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_nomeTitulo.Location = new System.Drawing.Point(178, 31);
            this.lb_nomeTitulo.Name = "lb_nomeTitulo";
            this.lb_nomeTitulo.Size = new System.Drawing.Size(30, 28);
            this.lb_nomeTitulo.TabIndex = 5;
            this.lb_nomeTitulo.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bem Vindo(a): ";
            // 
            // btn_gerenciarItens
            // 
            this.btn_gerenciarItens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_gerenciarItens.BackgroundImage")));
            this.btn_gerenciarItens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gerenciarItens.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_gerenciarItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerenciarItens.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerenciarItens.ForeColor = System.Drawing.Color.White;
            this.btn_gerenciarItens.Location = new System.Drawing.Point(26, 237);
            this.btn_gerenciarItens.Name = "btn_gerenciarItens";
            this.btn_gerenciarItens.Size = new System.Drawing.Size(177, 111);
            this.btn_gerenciarItens.TabIndex = 12;
            this.btn_gerenciarItens.Text = "Gerenciar Produtos";
            this.btn_gerenciarItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_gerenciarItens.UseVisualStyleBackColor = true;
            this.btn_gerenciarItens.Visible = false;
            this.btn_gerenciarItens.Click += new System.EventHandler(this.btn_gerenciarItens_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.btn_gerenciarItens);
            this.Controls.Add(this.lb_nomeTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_gerenciarUsuarios);
            this.Controls.Add(this.btn_fchar);
            this.Controls.Add(this.btn_deslogar);
            this.Controls.Add(this.btn_addPedidos);
            this.Controls.Add(this.btn_gerenciarClientes);
            this.Controls.Add(this.btn_meusPedidos);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_led)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lb_nomeUser;
        public System.Windows.Forms.PictureBox pb_led;
        private System.Windows.Forms.Label lb_horas;
        private System.Windows.Forms.Button btn_fchar;
        public System.Windows.Forms.Button btn_deslogar;
        public System.Windows.Forms.Button btn_meusPedidos;
        public System.Windows.Forms.Button btn_gerenciarClientes;
        public System.Windows.Forms.Button btn_addPedidos;
        public System.Windows.Forms.Button btn_gerenciarUsuarios;
        public System.Windows.Forms.Label lb_nomeTitulo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_gerenciarItens;
    }
}

