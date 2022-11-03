using AutoMapper;
using BusinessLayer.Interfaces;
using DTO.DTOs.CertificationDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dapper.WebAppCV.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> _certificationService;
        private readonly IMapper _mapper;
        public CertificationController(IGenericService<Certification> certificationService, IMapper mapper)
        {
            _certificationService = certificationService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var certificationLists = _mapper.Map<List<CertificationListDto>>(_certificationService.GetAll());
            return View(certificationLists);
        }
    }
}
