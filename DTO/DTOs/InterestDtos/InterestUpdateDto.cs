﻿using DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.InterestDtos
{
    public class InterestUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
