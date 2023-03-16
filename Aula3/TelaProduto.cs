using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();
        private void CarregaCategoria()
        {
            cbxCategoria.DataSource = null;
            cbxCategoria.DataSource = con.Retorna("select * from tb_categoria");
            cbxCategoria.DisplayMember = "cat_descricao";
            cbxCategoria.ValueMember = "cat_id";
        }
        private void CarregaTabela()
        {
            dgvDados.DataSource = null;
            DataTable dados = con.Retorna("select * from tb_categoria");
        }
        private void TelaProduto_Load(object sender, EventArgs e)
        {
            CarregaCategoria();
            CarregaTabela();
        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "updtate tb_produto set prod_nome'" + txtNome.Text + "',prod_descricao='" + txtDescricao.Text + "',prod_categoria=" + cbxCategoria.SelectedValue +
                ",prod_valor=" + txtValor.Text;

            if (con.Executar(sql))
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar");
            }
    
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_produto set prod_nome'" + txtNome.Text + "',prod_descricao='" + txtDescricao.Text + "',prod_categoria=" + cbxCategoria.SelectedValue +
                ",prod_valor=" + txtValor.Text;

            if (con.Executar(sql))
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_produto where prod_codigo=" + txtCodigo.Text;
            if (con.Executar(sql))
            {
                MessageBox.Show("Excluído com suucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }
    }
}
