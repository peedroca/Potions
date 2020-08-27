using AutoMapper;
using PotionsAPI.Domain.Entities;

namespace PotionsAPI.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PotionView, PotionEntity>().ReverseMap();
            CreateMap<PotionImageView, PotionImageEntity>().ReverseMap();
        }
    }
}
