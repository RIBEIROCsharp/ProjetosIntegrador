using System.ComponentModel.DataAnnotations.Schema;

namespace AlugaCar.Model
{
    [Table("usuario")]
    public class Usuario
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idade { get; set; }
        public string genero { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}
