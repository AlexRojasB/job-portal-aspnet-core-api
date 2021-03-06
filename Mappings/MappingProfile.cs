using System;
using AutoMapper;
using JobPortal.Core.Domain;
using JobPortal.DTOs;

namespace JobPortal.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Company, CompanyDTO>();
            CreateMap<CompanyDTO, Company>();

            CreateMap<Job, JobDTO>();
            CreateMap<JobDTO, Job>();

            CreateMap<Application, ApplicationDTO>();
            CreateMap<ApplicationDTO, Application>();

            CreateMap<ApplicationDTO, Candidate>();
        }
    }
}