﻿using System.ComponentModel.DataAnnotations;

namespace Lekcija13_2024.Data
{
    public class Rectangle
    {
        [Key]
        public int ID { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public override string? ToString()
        {
            return $"Rectangle H:{Height}, W:{Width}";
        }
    }
}
