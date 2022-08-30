using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaCar.Model
{
    [Table("carros")]
    public class Carros
    {
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public Int32 fabricacao { get; set; }
        public Int32 ano { get; set; }
        public Int32 quilometragem { get; set; }
        public float preco { get; set; }
        public Boolean disponivel { get; set; }

    }
}
