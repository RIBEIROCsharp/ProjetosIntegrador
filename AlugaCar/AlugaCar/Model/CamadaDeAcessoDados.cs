using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlugaCar.Model
{
    public class CamadaDeAcessoDados
    {
        public void CadastraCarros(Carros carro)
        {
            MySqlConnection conexaoBd = new MySqlConnection("server=localhost; user id=root;password=admin; database=alugacar; port=3306");
            conexaoBd.Open(); // Abrir a conexão
            var comando = conexaoBd.CreateCommand();
            comando.CommandText = "INSERT INTO carros (`placa`, `marca`, `modelo`, `fabricacao`, `ano`, `quilometragem`, `preco`) values ('" + carro.placa + "','" + carro.marca + "','" + carro.modelo + "','" + carro.fabricacao + "','" + carro.ano + "','" + carro.quilometragem + "','" + carro.preco + "')";
            comando.ExecuteNonQuery();
            conexaoBd.Close();
            GetListaDeCarros();
        }
        public void CadastraUsuario(Usuario usuario)
        {
            MySqlConnection conexaoBd = new MySqlConnection("server=localhost; user id=root;password=admin; database=alugacar; port=3306");
            conexaoBd.Open(); // Abrir a conexão
            var comando = conexaoBd.CreateCommand();
            comando.CommandText = "INSERT INTO usuario (`cpf`, `nome`, `sobrenome`, `idade`, `genero`, `telefone`, `email`, `senha`) values ('" + usuario.cpf + "','" + usuario.nome + "','" + usuario.sobrenome + "','" + usuario.idade + "','" + usuario.genero + "','" + usuario.telefone + "','" + usuario.email + "','" + usuario.senha + "')";
            comando.ExecuteNonQuery();
            conexaoBd.Close();
            GetListaDeUsuarios();
        }

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
                
                lista.Add(car);//Adiciona a lista
            }
            leitorDados.Close();// Sempre fechar
            conexaoBd.Close();//É opcional fechar, pois pode manter ele aberto dependendo do que deseja ai tem q declarar como private ou static 
            return lista;

        }
        public List<Carros> GetPlaca(string placa)
        {
            //buscar carros por Placa
            List<Carros> lista = new List<Carros>();
            lista = GetListaDeCarros().Where(x => x.placa == placa).ToList();
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
                usuario.genero = leitorDados.GetString("genero");
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
        public List<Aluguel> GetListaDeAlugueis()
        {
            List<Aluguel> lista = new List<Aluguel>();

            MySqlConnection conexaoBd = new MySqlConnection("server=localhost; user id=root;password=admin; database=alugacar; port=3306");
            conexaoBd.Open(); // Abrir a conexão
            var comando = conexaoBd.CreateCommand(); // Criando comando para consultas BD
            comando.CommandText = "SELECT * FROM usuario";// Especificando a consulta ao BD
            var leitorDados = comando.ExecuteReader();// abre o datareader(Lê os dados) 
            while (leitorDados.Read())//Read(Ele lê e se posiciona a linha seguinte)
            {
                var aluguel = new Aluguel();
                aluguel.carro = leitorDados.GetString("carro");
                aluguel.cod_aluguel = leitorDados.GetInt32("cod_aluguel");
                aluguel.dia_inicio = leitorDados.GetDateTime("dia_inicio");
                aluguel.dia_fim = leitorDados.GetDateTime("dia_fim");
                aluguel.preco = leitorDados.GetFloat("preco");
                aluguel.ativo = leitorDados.GetBoolean("ativo");
                aluguel.usuario = leitorDados.GetString("usuario");

                lista.Add(aluguel);//Adiciona a lista
            }
            leitorDados.Close();// Sempre fechar
            conexaoBd.Close();//É opcional fechar, pois pode manter ele aberto dependendo do que deseja ai tem q declarar como private ou static 
            return lista;

        }

        public List<Aluguel> GetCodAluguel(Int32 cod_aluguel)
        {
            //buscar aluguel por COD_ALUGUEL
            List<Aluguel> lista = new List<Aluguel>();
            lista = GetListaDeAlugueis().Where(x => x.cod_aluguel == cod_aluguel).ToList();
            return lista;
        }

        public Usuario AdicionaUsuario()
        {
            return null;
        }

    }
}
