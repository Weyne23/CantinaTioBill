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

    public partial class F_gerenciarItenscs : Form
    {
        MoveForm mv = new MoveForm();
        public F_gerenciarItenscs()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(F_gerenciarItenscs_MouseDown);
            this.MouseMove += new MouseEventHandler(F_gerenciarItenscs_MouseMove);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_gerenciarItenscs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome Produto", typeof(string));
            dt.Columns.Add("Status", typeof(bool));
            dt.Columns.Add("Tipo", typeof(string));

            List<string> status = new List<string>();
            cb_tiposProdutos.Items.Add("Carboidrato");
            cb_tiposProdutos.Items.Add("Proteína");
            cb_tiposProdutos.Items.Add("Acompanhamento");


            using (var ctx = new CantinaContexto())
            {
                var produtos = ctx.Produtos.OrderBy(p => p.TipoProduto).ToList();
                foreach (var p in produtos)
                {
                    dt.Rows.Add(p.ProdutoId, p.Nome, p.Status, p.TipoProduto);
                }
            }

            dgv_produtos.DataSource = dt;
            dgv_produtos.Columns[1].Width = 120;
            dgv_produtos.Columns[3].Width = 110;
            dgv_produtos.AllowUserToResizeRows = false;
            dgv_produtos.Columns["Id"].Visible = false;
            dgv_produtos.Columns["Status"].Visible = false;

            for (int i = 0; i < dgv_produtos.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_produtos.Rows[i].Cells[2].Value) == false)
                {
                    dgv_produtos.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }

            cb_tiposProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void F_gerenciarItenscs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            mv.X = this.Left - MousePosition.X;
            mv.Y = this.Top - MousePosition.Y;
        }

        private void F_gerenciarItenscs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left = mv.X + MousePosition.X;
            this.Top = mv.Y + MousePosition.Y;
        }

        private void dgv_produtos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv_produtos.SelectedRows.Count > 0)
            {
                tb_nomeProduto.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                cb_tiposProdutos.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                if (Convert.ToBoolean(dgv.SelectedRows[0].Cells[2].Value))
                {
                    rb_sim.Checked = true;
                }
                else
                {
                    rb_nao.Checked = true;
                }
            }
        }

        private void btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            if (tb_nomeProduto.Text.Replace(@"\s", "") == "")
            {
                MessageBox.Show("Campo Nome em Branco", "Erro");
                return;
            }

            try
            {
                if (MessageBox.Show("Deseja salvar as alterações do produto " + dgv_produtos.SelectedRows[0].Cells[1].Value.ToString() + " ?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                int idProduto = Convert.ToInt32(dgv_produtos.SelectedRows[0].Cells[0].Value);

                using (var ctx = new CantinaContexto())
                {
                    var produto = ctx.Produtos.Find(idProduto);
                    produto.Nome = tb_nomeProduto.Text;
                    produto.TipoProduto = cb_tiposProdutos.SelectedItem.ToString();
                    if (rb_sim.Checked)
                    {
                        produto.Status = true;
                        dgv_produtos.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        produto.Status = false;
                        dgv_produtos.SelectedRows[0].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    ctx.SaveChanges();
                }
                dgv_produtos.SelectedRows[0].Cells[1].Value = tb_nomeProduto.Text;
                dgv_produtos.SelectedRows[0].Cells[2].Value = rb_sim.Checked;
                dgv_produtos.SelectedRows[0].Cells[3].Value = cb_tiposProdutos.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Nenhum Produto Selecionado", "Erro");
            }

        }

        private void btn_excluirProduto_Click(object sender, EventArgs e)
        {
            if (tb_nomeProduto.Text.Replace(@"\s", "") == "")
            {
                MessageBox.Show("Campo Nome em Branco ou Nenhum Produto Selecionado", "Erro");
                return;
            }

            try
            {
                if (MessageBox.Show("Deseja excluir o produto " + dgv_produtos.SelectedRows[0].Cells[1].Value.ToString() + " ?", "Mensagem", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                int idProduto = Convert.ToInt32(dgv_produtos.SelectedRows[0].Cells[0].Value);

                using (var ctx = new CantinaContexto())
                {
                    var produto = ctx.Produtos.Find(idProduto);
                    ctx.Remove(produto);
                    ctx.SaveChanges();
                }

                tb_nomeProduto.Clear();
                cb_tiposProdutos.SelectedIndex = -1;
                RadioButton rd;
                rd = gb_disponivel.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked);
                rd.Checked = false;
                MessageBox.Show("Produto Excluido!", "Mensagem");
                dgv_produtos.Rows.Remove(dgv_produtos.SelectedRows[0]);
            }
            catch
            {
                MessageBox.Show("Nenhum produdo selecionado.", "Erro");
            }

            
        }

        private void btn_novoProduto_Click(object sender, EventArgs e)
        {
            F_AdicionarProduto f_AdicionarProduto = new F_AdicionarProduto();
            f_AdicionarProduto.ShowDialog();
        }
    }
}
