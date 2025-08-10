using AutoMapper;
using Models;
using DTOs;
namespace Profiles;

public class CategoryProfile : Profile {
    public CategoryProfile() {
        CreateMap<Category, CategoryReadDto>();
        CreateMap<CategoryCreateDto, Category>();
    }
}