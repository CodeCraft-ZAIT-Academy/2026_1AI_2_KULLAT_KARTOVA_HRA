using Kartova_hra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kartova_hra
{
   public class Card
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public int Points { get; set; }



        public Card(string name, string icon, int points)
        {
            Name = name;
            Icon = icon;
            Points = points;
        }
    }
    
}
public class Common : Card
{
    public Common() : base("Obycajna karta","⚪",1)
    {
    }
}
public class Rare : Card
{
    public Rare() : base("Vzacna karta", "🔵", 5)
    {
    }
}
public class SuperRare : Card
{
    public SuperRare() : base("Velmi vzacna karta", "🟡", 25)
    {
    }
}
