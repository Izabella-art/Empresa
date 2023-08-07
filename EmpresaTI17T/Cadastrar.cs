using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace EmpresaTI17T
{
    public partial class Cadastrar : Form
    {
        DAO conectar;
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();
        }//fim do construtor

        private void label3_Click(object sender, EventArgs e)
        {
            
        }//nome

        private void label1_Click(object sender, EventArgs e)
        {

        }//cpf

        private void Telefone_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//CPF

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Telefone

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//UF

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            string result = conectar.inserir(Convert.ToInt64(maskedTextBox1.Text), textBox1.Text, maskedTextBox2.Text, textBox2.Text, maskedTextBox3.Text, "pessoa");

                MessageBox.Show(result);
            }

            catch (Exception Erro)
            { 

             MessageBox.Show("algo deu errado!\n\n" + Erro.Message);

            }//fim do try catch
        }
    }
}
