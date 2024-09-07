using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository;

public interface IProductRepository
{
    /// <summary>
    /// Retorna a lista de todos os proutos do banco de dados
    /// </summary>
    /// <returns>Lista de ProductVO</returns>
    Task<IEnumerable<ProductVO>> FindAll();

    /// <summary>
    /// Retorna o produto localizado pelo Id
    /// </summary>
    /// <param name="id">Identificador único</param>
    /// <returns>Objeto ProductVO</returns>
    Task<ProductVO> FindById(long id);

    /// <summary>
    /// Cria um novo registro no banco de dados
    /// </summary>
    /// <param name="vo">Objeto do tipo ProductVO</param>
    /// <returns>Objeto do tipo ProductVO</returns>
    Task<ProductVO> Create(ProductVO vo);

    /// <summary>
    /// Atualiza os dados do produto do banco de dados
    /// </summary>
    /// <param name="vo">Objeto do tipo ProductVO</param>
    /// <returns>Objeto do tipo ProductVO</returns>
    Task<ProductVO> Update(ProductVO vo);

    /// <summary>
    /// Apaga os dados do produto no banco de dados
    /// </summary>
    /// <param name="id">Identificador único</param>
    /// <returns>Retorna verdadeiro ou falso</returns>
    Task<bool> Delete(long id);
}
