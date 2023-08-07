using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//importando a classe de dados
namespace EmpresaTI17T
{
    internal class DAO
    {
        public MySqlConnection conexao;
        public long[] CPF;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] uf; //nao precisa ter o nome igual o banco
        public int i;
        public int contador;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=EmpresaTI17T;Uid=root;Password=");//servidor banco de dados e senha
            try
            {

                conexao.Open();//abrir a conexao com o banco de dados
                MessageBox.Show("Conectado!");
            }
            catch (Exception Erro)//tratar e encaminhar o erro
            {
                MessageBox.Show("algo deu errado!\n\n" + Erro.Message);
            }//fim do metodo construtor

        }//metodo de insersao que possa servir pra mts tabelas

        public string inserir(long CPF, string nome, string telefone, string cidade, string UF, string nomeTabela)//long atende o big int
        {
            string inserir = $"insert into {nomeTabela}(CPF, nome, telefone, cidade, UF) values ('{CPF}','{nome}','{telefone}','{cidade}','{UF}')";
            //metodo global que atende a qualquer tabela interpolaçao
            //insert into colocando dentro de uma variavel tipo texto
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";//cntrl enter vai retormar 0 ou 1
            return resultado;
            //variavel para acessar todos os condos o com que vai executar e ond evai executar
        }

        //metodo de consulta
        //pegar os dados que tao no banco e enquanto pegar vaipreench3er um vetor e os dados vem de la e td transaão vai vir direto do vetr

        public void PreencherVetor()
        {
            string query = "select * from pessoa";//comando que faz a seleção

            //instanciar
            this.CPF = new long[100];//por enqunato esse valor
            this.nome = new string[100];
            this.telefone = new string[100];
            this.cidade = new string[100];
            this.uf = new string[100];
            //preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);// chave pra acessar o banco e faz o retorno dentro do sql 
            ///leitor

            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;

            while (leitura.Read()) //ja por padrao é true
            {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                cidade[i] = leitura["cidade"] + "";
                uf[i] = leitura["uf"] + "";
                i++;
                contador++;//contando quantos dados estao sendoa armazenados
            }// fim do whilw

            // encerro a comunicação com o banco
            leitura.Close();
        }//fim do metodo


        public int QuantidadeDados()
        {
            return contador;
        }

        public string Atualizar(long CPF, string nomeTabela, string campo, String dado)//atualizar individual
        {
            string query = $"update {nomeTabela} set campo {campo} = '{dado}' where CPF = '{CPF}'"; //comando upade e dps oq tem que ser alterado por isso o '
            MySqlCommand sql =new MySqlCommand(query, conexao);
            string resultado= sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;

        }//fim do metodo

        public string Excluir(long CPF, string nomeTabela)
        {
            string query = $" delete from {nomeTabela} where CPF = {CPF}";
            MySqlCommand sql =new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "excluido";
            return resultado;

        }//fim do metodo
    }//fim da classe



    //
    atu = new DAO();



    //atu.atualizar(convert.toint64cpf.Text),"pessoa","nome", nome.text);
    //atu.atualizar(convert.toint64cpf.Text),"pessoa","telefone", nome.text);
    //atu.atualizar(convert.toint64cpf.Text),"pessoa","cidade", telefone.text);
    //atu.atualizar(convert.toint64cpf.Text),"pessoa","uf", cidade.text);
    //messageBox.show("dados atualizados com sucesso")
    //fim do cpf


    //fim do nome


    //fim do telefone

    //fim da cidade

    //fim da uf


    ///////exc =new dao;
    ///

    //string result = exc.Excluir (convert.ToInt64(cpf.Text), "pessoa");
    //MessageBox.show(result);

}//fim do projeto
