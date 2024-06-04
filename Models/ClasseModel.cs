using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreBill.Models
{
    public class ClasseModel
    {
        public required string Title { get; set; }
        public string? Eleves { get; set; }
        public string? Note { get; set; }
        public required string Paiment { get; set; }
    }
}
