namespace GeekShopping.Web.Models;

/// <summary>
/// Classe ProductModel
/// </summary>
public class ProductModel
{
    /// <summary>
    /// Identificador único do produto
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Nome do produto
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Preço do produto
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Descrição do produto
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Categoria do produto
    /// </summary>
    public string? CategoryName { get; set; }

    /// <summary>
    /// Url da imagem do produto
    /// </summary>
    public string? ImageUrl { get; set; }
}

