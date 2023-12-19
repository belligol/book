using AutoMapper;
using BookStore.Models.Data;
using BookStore.Models.Request;

namespace BookStoreB.AutoMappings
{
    public class AutoMapperConfigs : Profile
    {
        public AutoMapperConfigs()
        {
            CreateMap<AddAuthorRequest, Author>();
        }
    }
}
