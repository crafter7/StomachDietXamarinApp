using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomachDiet
{
     public enum Eatings
     {
          Main,
          Additional
     }
     public class Recipe
     {
          public string Title { get; set; } = string.Empty;
          public string Description { get; set; } = string.Empty;
          public int TimeOfCooking { get; set; } = 10;
          public Eatings TimeOfEatin { get; set; } = Eatings.Main;
     }
}
