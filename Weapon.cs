using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    internal class Weapon
    {
        private int _capacity;
        private int _count;
        private string _mod;

        public Weapon(int capacity, int count, string mode)
        {
            Capacity = capacity;
            Count = count;
            Mod = mode;

            

        }

        public int Capacity 
        {
            get 
            { 
                return _capacity;

            }
            set 
            {
                if (value > 0)
                {
                    _capacity = value;

                }
                else 
                {
                    Console.WriteLine("incorrect choose");
                    Environment.Exit(0);
                    
                }

            } 
        }
        public int Count 
        { 
            get 
            { 
                return _count;

            } 
            set 
            {
                if (value<=Capacity) 
                { 
                    _count = value;
                }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("Error.");
                    Environment.Exit(0);

                }
            } 
        }
        public string Mod {
            get 
            { 
                return _mod;

            }

            set 
            {
                if (value=="single" || value =="auto") 
                {
                    _mod = value;
                }
            } 
        }

        public void Shoot()
        {

            if (Mod=="single")
            {
                Count--;
                if (Count >= 0)
                {
                    Console.WriteLine(Count);
                }
                else
                {
                    Console.WriteLine("Count cannot be equal neagative number.");
                    Environment.Exit(0);
                }
            }
            else if(Mod=="auto")
            {
                Count=0;
                Console.WriteLine(Count);
            }
        }

        public int GetRemainBulletCount()
        {
            int num = 0;
            num=Capacity-Count;
            return num;

        }

        public void Reload()
        {
            
            Count = Capacity;
            Console.WriteLine(Count);
        }

        public void ChangeFireMode()
        {
            if (Mod == "single")
            {
                Mod = "auto";

            }
            else if (Mod == "auto")
            {
                Mod = "single";
            }
        }


    }
}
