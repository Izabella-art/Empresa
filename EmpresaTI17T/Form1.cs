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
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        DAO consul;

        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
            consul = new DAO();

        }//fim do construtor
        //houl de entrada DAO = conectar;conectar =new DAO();//ligando o formulario ao conetor do banco
        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();//abre a tela
        }//fim do cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();//abre a tela
        }//fim do consultar

        private void button3_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//fim do atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//fim do excluir


    }
}//fim do projeto
