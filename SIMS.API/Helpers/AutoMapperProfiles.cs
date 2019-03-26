using System.Linq;
using AutoMapper;
using SIMS.API.Dtos;
using SIMS.API.Models;

namespace SIMS.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>().ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            });
            // .ForMember(dest => dest.Age, opt => {
            //     opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            // });
            CreateMap<User, UserForDetailedDto>().ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            }).ForMember(dest => dest.BachelorsMentor, opt => {
                opt.MapFrom(src => src.BachelorsMentor.MentorName);
            }).ForMember(dest => dest.BachelorsProjectAdvisor, opt => {
                opt.MapFrom(src => src.BachelorsProjectAdvisor.AdvisorName);
            }).ForMember(dest => dest.BachelorsThesisAdvisor, opt => {
                opt.MapFrom(src => src.BachelorsThesisAdvisor.AdvisorName);
            }).ForMember(dest => dest.MastersProjectAdvisor, opt => {
                opt.MapFrom(src => src.MastersProjectAdvisor.AdvisorName);
            }).ForMember(dest => dest.MastersThesisAdvisor, opt => {
                opt.MapFrom(src => src.MastersThesisAdvisor.AdvisorName);
            }).ForMember(dest => dest.DoctorateAdvisor, opt => {
                opt.MapFrom(src => src.DoctorateAdvisor.AdvisorName);
            }).ForMember(dest => dest.ExternalAdvisor, opt => {
                opt.MapFrom(src => src.ExternalAdvisor.AdvisorName);
            });
            // .ForMember(dest => dest.Age, opt => {
            //     opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            // });
            CreateMap<Photo, PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<string, BachelorsMentor>().ForMember(dest => dest.MentorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<string, BachelorsProjectAdvisor>().ForMember(dest => dest.AdvisorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<string, BachelorsThesisAdvisor>().ForMember(dest => dest.AdvisorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<string, MastersProjectAdvisor>().ForMember(dest => dest.AdvisorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<string, MastersThesisAdvisor>().ForMember(dest => dest.AdvisorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<string, DoctorateAdvisor>().ForMember(dest => dest.AdvisorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<string, ExternalAdvisor>().ForMember(dest => dest.AdvisorName, opt => {
                opt.MapFrom(src => src);
            });
            CreateMap<UserForRegisterDto, User>();
            // CreateMap<UserForRegisterDto, User>().ForMember(dest => dest.BachelorsMentor, opt => {
            //     opt.MapFrom(src => src.BachelorsMentor);
            // }).ForMember(dest => dest.BachelorsMentor, opt => {
            //     opt.MapFrom(src => src.BachelorsMentor);;
            
            CreateMap<UserForDeleteDto, User>();
        }
    }
}