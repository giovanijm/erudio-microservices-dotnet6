using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model;

[Table("product")]
public class Product : BaseEntity
{
    /// <summary>
    /// Nome do produto
    /// </summary>
    [Column("name")]
    [Required]
    [StringLength(150)]
    public string Name { get; set; } = null !;

    /// <summary>
    /// Preço do produto
    /// </summary>
    [Column("price")]
    [Required]
    [Range(1, 10000)]
    public decimal Price { get; set; }

    /// <summary>
    /// Descrição do produto
    /// </summary>
    [Column("description")]
    [StringLength(500)]
    public string? Description { get; set; }

    /// <summary>
    /// Categoria do produto
    /// </summary>
    [Column("category_name")]
    [StringLength(50)]
    public string? CategoryName { get; set; }

    /// <summary>
    /// Url da imagem do produto
    /// </summary>
    [Column("image_url")]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
}
