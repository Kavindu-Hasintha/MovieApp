using AutoMapper;
using MovieApp.Models;

namespace MovieApp.Dto
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<MovieDto, Movie>();
        }
    }
}
