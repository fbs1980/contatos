using System.ComponentModel.DataAnnotations;

namespace sistemacontatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório.")]
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage ="Email inválido.")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Número inválido.")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Celular { get; set; }
    }
}
