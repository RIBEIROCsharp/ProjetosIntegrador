using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlugaCar.Model
{
    [Table("carros")]
    public class Carros
    {
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int fabricacao { get; set; }
        public int ano { get; set; }
        public int quilometragem { get; set; }
        public float preco { get; set; }
        public Boolean disponivel { get; set; }

    }
}
