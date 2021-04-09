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
    public partial class F_Login : Form
    {
        Form1 form1;
        public F_Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
                    Globais.logado = true;
                    Globais.nivel = usuario.Nivel;
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
            form1.Close();
        }
    }
}
