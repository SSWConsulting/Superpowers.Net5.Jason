using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5Superpowers.WebUI.Models
{
    public class TodosVm
    {
        public IList<LookupDto> PriorityLevels { get; set; }

        public IList<TodoListDto> Lists { get; set; }
    }
}
