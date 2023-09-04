using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector       
    {
        public static object identifier;

        public List<Shelve> Shelvelist { get ; set; }
        public int Identifier { get ; set; }
        public void ActualSector(List<Shelve> Shelvelist, int identifier)
        {
            this.Shelvelist = Shelvelist;
            this.Identifier=identifier;
        }

    }

}