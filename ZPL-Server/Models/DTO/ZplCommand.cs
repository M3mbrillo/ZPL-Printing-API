using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZPL_Server.Models.DTO
{
    public class ZplCommand
    {
        [Required]
        [MinLength(1)]
        public string Command { get; set; }
    }
}
