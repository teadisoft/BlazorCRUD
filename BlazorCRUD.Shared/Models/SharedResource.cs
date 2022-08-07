using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared.Models
{
    public class SharedResource
    {
        public SharedResource()
        {
        }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int LimitCpu { get; set; } = 100;

        public int LimitMemory { get; set; } = 100;

        public int AllocationCpu { get; set; } = 0;

        public int AllocationMemory { get; set; } = 0;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime ExpriedDate { get; set; }
    }
}
