namespace New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity;
            int count;

            while (true)
            {
                Console.WriteLine("Please enter capacity of weapon:");
                string capacity1=Console.ReadLine();

                if(int.TryParse(capacity1, out capacity) && capacity > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The capacity isnot true value.");
                }
            }


            while (true)
            {
                Console.WriteLine("Please enter count of weapon:");
                string count1 = Console.ReadLine();

                if (int.TryParse(count1, out count) && count > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The count isnot true value.");
                }
            }

            Console.WriteLine("Please enter mod of weapon:");
            string mod =Console.ReadLine();

            Weapon weapon=new Weapon(capacity, count, mod);

            //weapon.ChangeFireMode();
            //weapon.Shoot();
            //Console.WriteLine(weapon.GetRemainBulletCount());
            //weapon.Reload();


            while (true) 
            {
                Console.WriteLine("0 - Get info");
                Console.WriteLine("1 - For Shoot method");
                Console.WriteLine("2 - For GetRemainBulletCount method");
                Console.WriteLine("3 - For Reload method");
                Console.WriteLine("4 - For ChangeFireMode method");
                Console.WriteLine("5 - Stop");


                Console.WriteLine();
                string input=Console.ReadLine();

                Console.WriteLine();

                switch (input) 
                {
                    case "0":
                        Console.WriteLine($"{weapon.Capacity} {weapon.Count} {weapon.Mod}");
                        break;

                    case "1":
                        weapon.Shoot();
                        break;
                    
                    case "2":
                        Console.WriteLine(weapon.GetRemainBulletCount());
                        break;

                    case "3":
                        weapon.Reload();
                        break;

                    case "4":
                        weapon.ChangeFireMode();
                        break;

                    case "5":
                        Console.WriteLine("Stop");
                        return;

                    default:
                        Console.WriteLine("incorrect choose.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
