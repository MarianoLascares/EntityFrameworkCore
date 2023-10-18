using System.ComponentModel.DataAnnotations;
using AutoMapper;
using CodeFirstEF.DTOs;
using CodeFirstEF.Models;

namespace CodeFirstEF.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<MarcasCreacionDTO, Marcas>();
            CreateMap<UnidadesDeMedidaCreacionDTO, UnidadesDeMedida>();
            CreateMap<CategoriaProductoCreacionDTO, CategoriaProducto>();
            CreateMap<AlmacenesCreacionDTO, Almacenes>();
            CreateMap<ProductosCreacionDTO, Productos>();
            CreateMap<StockProductoCreacionDTO, StockProducto>();
            CreateMap<ProvinciasCreacionDTO, Provincias>();
            CreateMap<DepartamentosCreacionDTO, Departamentos>();
            CreateMap<CiudadesCreacionDTO, Ciudades>();
            CreateMap<EncEntradaProductosDTO, EncEntradaProductos>();
            CreateMap<DetalleEntradaProductosDTO, DetalleEntradaProductos>();
        }
    }
}
