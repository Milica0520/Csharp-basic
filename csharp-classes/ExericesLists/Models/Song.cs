﻿using ExericesLists.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericesLists.Models
{
    public class Song
    {
        public string Title { get; set; }

        public double Length { get; set; }
        public Genre Genre { get; set; }

        //konstruktor
        public Song(string title, double length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }

    }
}
