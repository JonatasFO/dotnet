using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>().ReverseMap();
        CreateMap<Cinema, ReadCinemaDto>().ReverseMap();
        CreateMap<UpdateCinemaDto, Cinema>().ReverseMap();
    }
}
