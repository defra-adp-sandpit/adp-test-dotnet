using Adp.Test.Dotnet.Api.Models;
using Adp.Test.Dotnet.Core.Entities;

using AutoMapper;

namespace Adp.Test.Dotnet.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
