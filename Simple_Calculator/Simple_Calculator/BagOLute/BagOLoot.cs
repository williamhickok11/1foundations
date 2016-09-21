using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator.BagOLute
{
    class BagOLoot
    {
        private List<Loot> LootList = new List<Loot>();

        public void choosePath()
        {
            Console.WriteLine("1. Add Toy");
            Console.WriteLine("2. Remove Toy");
            Console.WriteLine("3. List Childern");
            Console.WriteLine("4. List Toys");
            var input = Console.ReadLine();
            if (input == "1")
            {
                addLoot();
            } else if (input == "2")
            {
                removeLoot();
            } else if (input == "3")
            {
                listChildren();
            } else if (input == "4")
            {
                listToys();
            } else
            {
                Console.WriteLine("Please choose a number between 1 and 4");
                choosePath();
            }
        }

        public void addLoot()
        {
            Console.WriteLine("Name of loot:");
            var loot = Console.ReadLine();
            Console.WriteLine("Name of kid:");
            var kidName = Console.ReadLine();
            Loot newLoot = new Loot
            {
                ItemName = loot,
                KidName = kidName
            };
            LootList.Add(newLoot);
            choosePath();
        }

        public void removeLoot()
        {
            Console.WriteLine("Choose Loot");
            var i = 1;
            foreach (var item in LootList)
            {
                Console.WriteLine(i + ": " + item.ItemName);
                i++;
            }
            var lootToDelete = Console.ReadLine();

            choosePath();
        }

        public List<string> listChildren()
        {
            List<string> childrenList = new List<string>();

            foreach (var item in LootList)
            {
                childrenList.Add(item.KidName);
                Console.WriteLine(item.KidName);
            }
            choosePath();
            return childrenList;
        }

        public List<string> listToys()
        {
            List<string> toyList = new List<string>();

            foreach (var item in LootList)
            {
                toyList.Add(item.ItemName);
                Console.WriteLine(item.ItemName);
            }
            choosePath();
            return toyList;
        }
    }
}
