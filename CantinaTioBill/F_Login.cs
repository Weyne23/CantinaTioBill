using CantinaTioBill.Moldels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CantinaTioBill
{
    public struct MoveForm
    {
        public int X;
        public int Y;
    }
    public partial class F_Login : Form
    {
        Form1 form1;
        MoveForm mv = new MoveForm();
        public F_Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.MouseDown += new MouseEventHandler(F_Login_MouseDown);
            this.MouseMove += new MouseEventHandler(F_Login_MouseMove);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_userName.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Campos de usuário ou senha não preenchidos.", "Erro");
                tb_userName.Focus();
                return;
            }

            try
            {
                using (var ctx = new CantinaContexto())
                {
                    var usuario = ctx.Usuarios.First(u => u.UserName == username && u.Senha == senha && u.Status == "A");
                    form1.pb_led.Image = Properties.Resources.led_circle_green;
                    form1.lb_nomeUser.Text = usuario.Nome;
                    form1.lb_nomeTitulo.Text = usuario.Nome;
                    Globais.logado = true;
                    Globais.nivel = usuario.Nivel;
                    form1.btn_deslogar.Text = "Deslogar";
                    form1.btn_deslogar.BackgroundImage = Properties.Resources.sair__1__removebg_preview__2_;
                    //Habilita os botões na tela inicial
                    form1.btn_addPedidos.Visible = form1.btn_gerenciarClientes.Visible = form1.btn_meusPedidos.Visible =  form1.btn_gerenciarItens.Visible = true;
                    if (usuario.Nivel >= 2)
                    {
                        form1.btn_gerenciarUsuarios.Visible = true;
                    }
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Usuário ou senha errado(s).", "Erro");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_fecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
        }

        private void F_Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) 
                return;
            mv.X = this.Left - MousePosition.X;
            mv.Y = this.Top - MousePosition.Y;
        }

        private void F_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left = mv.X + MousePosition.X;
            this.Top = mv.Y + MousePosition.Y;
        }
    }
}
