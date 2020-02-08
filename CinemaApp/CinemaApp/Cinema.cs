using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    class Cinema
    {
        private int counter = 0;
        public string Name;
        public int MaxHall;

        //public Hall[] Halls=new Hall[0];
        public Hall[] Halls;
        public Cinema(string name, int maxhall)
        {
            Name = name;
            MaxHall = maxhall;
            Halls = new Hall[maxhall];
        }

        public void AddHall(Hall hall)
        {

            if (MaxHall > counter)
            {
                //Array.Resize(ref Halls, Halls.Length + 1);
                //Halls[Halls.Length - 1] = hall;
                Halls[counter++] = hall;
                //counter++;
                Console.WriteLine("Elave olundu");
            }
            else
            {
                Console.WriteLine("Zal sayi {0} reqemini kecdi",MaxHall);
            }

        }
    }
}
