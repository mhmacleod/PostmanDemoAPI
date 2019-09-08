using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebAPI
{
    public class DemoService
    {
        public string UserName { get; set; } = "Sam";

        public List<string> Locations { get; set; } = new List<string>() { "Here", "There", "Anywhere" };

        public List<Food> Foods { get; set; } = new List<Food>();

        public DemoService()
        {
            Foods.Add(new Food()
            {
                Colour = "Blue",
                FoodType = "Cheese"
            });
            Foods.Add(new Food()
            {
                FoodType = "Ham"
            });
        }

        public string GenerateResult()
        {
            return $"I do not like them {Locations[0]} or {Locations[1]};\nI do not like them {Locations[2]}.\n" +
                $"I do not like {Foods[0].Colour} {Foods[0].FoodType} and {Foods[1].FoodType}.\n" +
                $"I do not like them; {UserName}-I-Am.";
        }
    }

    public class Food
    {
        public string Colour { get; set; }
        public string FoodType { get; set; }
    }
}
