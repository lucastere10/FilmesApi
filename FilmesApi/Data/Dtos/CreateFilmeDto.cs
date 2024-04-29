using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O Filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Gênero é obrigatório")]
    [StringLength(50)]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600")]
    public int Duracao { get; set; }
}
