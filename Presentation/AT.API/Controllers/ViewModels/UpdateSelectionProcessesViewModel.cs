using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.API.Controllers.ViewModels
{
    public class UpdateSelectionProcessesViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}