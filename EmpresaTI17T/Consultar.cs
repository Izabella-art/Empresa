using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTI17T
{
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul= new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//nomear os titulos das colunas
            AdicionarDados();//preenchendo o datagrid view
        }
        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";
        }


        public void ConfigurarDataGrid()

        {
            dataGridView1.AllowUserToAddRows= false; //adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false; //deletar linhas
            dataGridView1 .AllowUserToResizeColumns = false;//redimencionar as colunas
            dataGridView1. AllowUserToResizeRows= false;//redimencionar as linhas
            
            dataGridView1.ColumnCount = 5;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void AdicionarDados() //adicionar a quantoidade de linhas que tenho no banco
        {
            consul.PreencherVetor();
            for (int i = 0; i < consul.QuantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.CPF[i], consul.nome[i], consul.telefone[i], consul.cidade[i], consul.uf[i]);

            }//adicionando dados no datagrid view
        }//fim do metodo
    }//datagrid view
}
