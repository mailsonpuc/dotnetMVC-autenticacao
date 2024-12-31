using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; }  = string.Empty;


        [Required(ErrorMessage = "Obrigatorio informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; } = string.Empty;

       
        [Required(ErrorMessage = "Obrigatorio")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}