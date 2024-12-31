using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; } = string.Empty;


        [Required(ErrorMessage = "Obrigatorio informar a placa")]
        public string  Placa { get; set; } = string.Empty;


        [Required(ErrorMessage = "Obrigatorio informar o ano de fabricação")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }


        [Required(ErrorMessage = "Obrigatorio informar o ano do modelo")]
        [Display(Name = "Ano de Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo>? Consumos { get; set; }
    }
}