﻿using DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.EducationDtos
{
    public class EducationAddDto:IDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime DateTime { get; set; }
    }
}
