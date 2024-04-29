using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Titulo é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Gênero é obrigatório")]
    [MaxLength(100)]
    public string Genero { get; set; }
    [Required]
    [Range(70,600, ErrorMessage = "A duração deve ter entre 70 e 600")]
    public int Duracao { get; set; }
}
