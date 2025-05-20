using System;
using System.ComponentModel.DataAnnotations;

public class Evento
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Título")]
    public string Titulo { get; set; }

    [Required]
    [Display(Name = "Data e Hora")]
    [DataType(DataType.DateTime)]
    public DateTime DataHora { get; set; }

    [Display(Name = "Conteúdo")]
    public string Conteudo { get; set; }

    [Display(Name = "Local")]
    public string Local { get; set; }

    [Display(Name = "Meta")]
    public string Meta { get; set; }
}
