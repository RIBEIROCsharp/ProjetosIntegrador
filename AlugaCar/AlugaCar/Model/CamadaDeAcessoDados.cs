using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AlugaCar.Model
{
    public class CamadaDeAcessoDados
    {
        public List<Carros> GetListaDeCarros()
        {
                List<Carros> lista = new List<Carros>();           
                        
                MySqlConnection conexaoBd = new MySqlConnection("server=localhost; user id=root;password=admin; database=alugacar; port=3306");
                conexaoBd.Open(); // Abrir a conexão
                var comando = conexaoBd.CreateCommand(); // Criando comando para consultas BD
                comando.CommandText = "SELECT * FROM carros";// Especificando a consulta ao BD
                var leitorDados = comando.ExecuteReader();// abre o datareader(Lê os dados) 
                while (leitorDados.Read())//Read(Ele lê e se posiciona a linha seguinte)
                {
                    var car = new Carros();
                    car.placa = leitorDados.GetString("placa");
                    car.marca = leitorDados.GetString("marca");
                    car.modelo = leitorDados.GetString("modelo");
                    car.fabricacao = leitorDados.GetInt32("fabricacao");
                    car.ano = leitorDados.GetInt32("ano");
                    car.quilometragem = leitorDados.GetInt32("quilometragem");
                    car.preco = leitorDados.GetFloat("preco");
                    car.disponivel = leitorDados.GetBoolean("disponivel");
                    lista.Add(car);//Adiciona a lista
                }
                leitorDados.Close();// Sempre fechar
                conexaoBd.Close();//É opcional fechar, pois pode manter ele aberto dependendo do que deseja ai tem q declarar como private ou static 
                return lista;

        }

        public List<Usuario> GetListaDeUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            MySqlConnection conexaoBd = new MySqlConnection("server=localhost; user id=root;password=admin; database=alugacar; port=3306");
            conexaoBd.Open(); // Abrir a conexão
            var comando = conexaoBd.CreateCommand(); // Criando comando para consultas BD
            comando.CommandText = "SELECT * FROM usuario";// Especificando a consulta ao BD
            var leitorDados = comando.ExecuteReader();// abre o datareader(Lê os dados) 
            while (leitorDados.Read())//Read(Ele lê e se posiciona a linha seguinte)
            {
                var usuario = new Usuario();
                usuario.cpf = leitorDados.GetString("cpf");
                usuario.telefone = leitorDados.GetString("telefone");
                usuario.nome = leitorDados.GetString("nome");
                usuario.sobrenome = leitorDados.GetString("sobrenome");
                usuario.sexo = leitorDados.GetString("sexo");
                usuario.idade = leitorDados.GetInt32("idade");
                usuario.email = leitorDados.GetString("email");
                usuario.senha = leitorDados.GetString("senha");
                lista.Add(usuario);//Adiciona a lista
            }
            leitorDados.Close();// Sempre fechar
            conexaoBd.Close();//É opcional fechar, pois pode manter ele aberto dependendo do que deseja ai tem q declarar como private ou static 
            return lista;

        }

        public List<Usuario> GetUsuario(string cpf)
        {
            //buscar usuario por CPF
            List<Usuario> lista = new List<Usuario>();
            lista = GetListaDeUsuarios().Where(x => x.cpf == cpf).ToList();
            return lista;
        }

        public Usuario AdicionaUsuario() {
            return null;
        }

    }
}
