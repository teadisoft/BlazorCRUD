using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Shared.Models
{
    public class SharedResourceModel
    {
        public SharedResourceModel()
        {
        }

        [Required]
        [StringLength(63, ErrorMessage = "Name is too long.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(10, ErrorMessage = "Description is too long.")]
        public string Description { get; set; } = string.Empty;

        public int LimitCpu { get; set; } = 100;

        public int LimitMemory { get; set; } = 100;

        public int AllocationCpu { get; set; } = 0;

        public int AllocationMemory { get; set; } = 0;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime ExpriedDate { get; set; }
    }
}
