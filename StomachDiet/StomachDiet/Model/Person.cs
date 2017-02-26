using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomachDiet
{
     public enum Sex
     {
          Male,
          Female
     }
     public enum DietState
     {
          On,
          Off
     }
     public class Person
     {
          public string FullName { get; set; }
          public int Age { get; set; }
          public Sex Sex { get; set; }
          public uint Height { get; set; }
          public uint Weight { get; set; }
          public string History { get; set; }
          public DietState CurrentState { get; set; } = DietState.Off;
     }
}
