using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config;

/// <summary>
/// Classe de configuração do Mapping
/// </summary>
public class MappingConfig
{
    /// <summary>
    /// Método de registro dos mapeamentos de objetos
    /// </summary>
    /// <returns></returns>
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config => {
            config.CreateMap<ProductVO, Product>();
            config.CreateMap<Product, ProductVO>();
        });

        return mappingConfig;
    }
}
