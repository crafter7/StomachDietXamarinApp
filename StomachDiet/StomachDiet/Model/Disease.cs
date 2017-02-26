using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomachDiet
{
     public class Disease
     {
          public string Name { get; } = string.Empty;
          public string Description { get; set; } = string.Empty;
          public List<Product> Constrains { get; set; }
     }
}
