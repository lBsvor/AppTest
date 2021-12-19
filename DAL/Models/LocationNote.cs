// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LocationNote : AuditableEntity
    {
        public decimal XCoordinate { get; set; }
        public decimal YCoordinate { get; set; }
        public string Note { get; set; }
    }
}
