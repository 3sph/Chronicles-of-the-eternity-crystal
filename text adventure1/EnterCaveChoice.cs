using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure1
{
    internal class EnterCaveChoice
    {
        public void Excecute()
        {
            Console.WriteLine("\nInside the cave you find two treassure chests, one is golden with elaborate silver designs. the other is a simple wooden chest. what do you want to do?");
            Console.WriteLine("1.Open the golden chest and seek riches.");
            Console.WriteLine("2.Open the Wooden chest, a more humble choice.");
            Console.WriteLine("3. Leave the cave");

            int Choice = Program.GetUserChoice(2);

            if (Choice == 1) 
            {
                Console.WriteLine("\nyou open the golden chest, to find a glimmering treassure, \nbut as you reach to grab it, sharp teeth sprout from the lid of the chest and arms appear dragging you inn. The golden chest was a mimmic pretending to be a chest. \nEpisode 1 ends with you brutally dying."); 
            }
            else
            {
                Console.WriteLine("\nYou open the simple wooden chest, only to find a magic magic gem with untold powers. \nEpisode one ends as you stare deep into the glimmering stone, dreaming about future adventures.");

            }
            
        }
    }
}
