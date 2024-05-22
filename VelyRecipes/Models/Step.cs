using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelyRecipes.Library.Models
{
    public class Step
    {
        [Key]
        public int IdStep { get; set; }
        public int StepNumber { get; set; }
        public string? Description { get; set; }
        public virtual int IdRecipe { get; set; }
    }
}
