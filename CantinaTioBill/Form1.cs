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
    public partial class Form1 : Form
    {
        MoveForm mv = new MoveForm();
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_horas.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
            timer1.Start();
        }

        private void btn_fchar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deslogar_Click(object sender, EventArgs e)
        {
            lb_nomeUser.Text = "...";
            lb_nomeTitulo.Text = "...";
            pb_led.Image = Properties.Resources.led_circle_red;
            Globais.logado = false;
            Globais.nivel = 0;
            btn_deslogar.Text = "Logar";
            btn_deslogar.BackgroundImage = Properties.Resources.Conectar_oficial_removebg_preview;
            //Desabilita os botões na tela principal
            btn_addPedidos.Visible = btn_gerenciarClientes.Visible = btn_meusPedidos.Visible = btn_gerenciarUsuarios.Visible =  btn_gerenciarItens.Visible =  false;
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left = mv.X + MousePosition.X;
            this.Top = mv.Y + MousePosition.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            mv.X = this.Left - MousePosition.X;
            mv.Y = this.Top - MousePosition.Y;
        }

        private void btn_gerenciarItens_Click(object sender, EventArgs e)
        {
            F_gerenciarItenscs f_GerenciarItenscs = new F_gerenciarItenscs();
            f_GerenciarItenscs.ShowDialog();
        }
    }
}
