using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlugaCar.Model
{
    [Table("aluguel")]
    public class Aluguel
    {
        public Int32 cod_aluguel { get; set; }
        public string carro { get; set; }
        public string usuario { get; set; }
        public DateTime dia_inicio { get; set; }
        public DateTime dia_fim { get; set; }
        public float preco { get; set; }
        public Boolean ativo { get; set; }


    }
}
