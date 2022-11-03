using AutoMapper;
using DTO.DTOs.CertificationDtos;
using EntityLayer.Concrete;

namespace Dapper.WebAppCV.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();
        }
    }
}
