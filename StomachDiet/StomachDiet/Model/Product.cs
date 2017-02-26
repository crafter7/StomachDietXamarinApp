using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomachDiet
{
     public enum ProductCategories
     {
          None,
          Vegetables,
          Milk,
          Meat,
          Fish,
          Fruits,
          Cereals,
          FlourProducts
     }

     public class Product
     {
          public string Name { get; set; } = string.Empty;
          public ProductCategories Category { get; set; } = ProductCategories.None;
          public float EnergyValue { get; set; } = 0;
     }
}
