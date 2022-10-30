using DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.SkillDto
{
    public  class SkillUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
