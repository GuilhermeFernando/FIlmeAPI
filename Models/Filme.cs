using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Diretor titulo é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1,1000, ErrorMessage = "A duração deve ter o minimo de 1 e no maximo 600 minutos")]
        public double Duracao { get; set; }
        public int Id { get; internal set; }
    }
}
