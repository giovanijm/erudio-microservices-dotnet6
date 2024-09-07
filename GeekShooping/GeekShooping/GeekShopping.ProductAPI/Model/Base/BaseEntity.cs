using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model.Base;

/// <summary>
/// Classe base das entidades
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Identificador único
    /// </summary>
    [Key]
    [Column("id")]
    public long Id { get; set; }
}
