﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }

        public string SetName(string name) 
        {
            Name = name;
            //name = "Fluffy";
            return Name;
        }
        public string GetName()
        {
            return Name;
        }

        public string SetSpecies(string species)
        {
            Species = species;
            return Species;
        }

    }

    

}
