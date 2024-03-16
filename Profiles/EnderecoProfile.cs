using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, Endereco>().ReverseMap();
        CreateMap<Endereco, ReadEnderecoDto>().ReverseMap();
        CreateMap<UpdateEnderecoDto, Endereco>().ReverseMap();
    }
}
