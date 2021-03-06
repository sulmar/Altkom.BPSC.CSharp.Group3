﻿using System.ComponentModel.DataAnnotations;

namespace Altkom.BPSC.CSharp.Models
{
    public class Product : Item
    {
        public Product(string name, decimal unitPrice)
            : base(name, unitPrice)
        {
            this.Color = "Black";
        }


        public string Color { get; set; }


        public override string ToString()
        {
            return $"{Name} {Color}";
        }
    }
}
