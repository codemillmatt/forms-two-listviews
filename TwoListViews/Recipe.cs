using System;
using System.Collections.Generic;

namespace TwoListViews
{
    public class Recipe
    {
        public Recipe()
        {
        }

        public List<string> Ingredients { get; set; }
        public List<string> Directions { get; set; }
    }
}
