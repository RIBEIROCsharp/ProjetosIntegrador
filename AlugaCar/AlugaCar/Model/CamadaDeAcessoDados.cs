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
                        
                MySqlConnection conexaoBd = new MySqlConnection("server=localhost; user id=root;password=root; database=alugacar; port=3306");
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
    }
}
