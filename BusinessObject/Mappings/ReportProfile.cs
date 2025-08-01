﻿using BusinessObject.DTOs.ReportDto;
using BusinessObject.Models;

namespace BusinessObject.Mappings
{
    public class ReportProfile : AutoMapper.Profile
    {
        public ReportProfile()
        {
            CreateMap<Report, ReportViewModel>()
                .ForMember(dest => dest.ReporterName, opt => opt.MapFrom(src => src.Reporter.Profile.FullName))
                .ForMember(dest => dest.ReporterEmail, opt => opt.MapFrom(src => src.Reporter.Email))
                .ForMember(dest => dest.ReporteeName, opt => opt.MapFrom(src => src.Reportee.Profile.FullName))
                .ForMember(dest => dest.ReporteeEmail, opt => opt.MapFrom(src => src.Reportee.Email))
                .ForMember(dest => dest.AssignedAdminName, opt => opt.MapFrom(src => src.AssignedAdmin != null ? src.AssignedAdmin.Profile.FullName : null))
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.CreatedAt));

            CreateMap<ReportDTO, Report>().ReverseMap();
        }
    }
}
