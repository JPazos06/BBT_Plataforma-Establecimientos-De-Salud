using System;
using System.Collections.Generic;

namespace BBT_Plataforma_Establecimientos_De_Salud.Models.DB;

public partial class Valoracion
{
    public int Id { get; set; }

    public int EstablecimientoId { get; set; }

    public int UsuarioId { get; set; }

    public string? Comentario { get; set; }

    public int? Valoracion1 { get; set; }

    public virtual EstablecimientoDeSalud Establecimiento { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
