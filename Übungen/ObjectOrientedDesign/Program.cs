using ObjectOrientedDesign.Interfaces;
using ObjectOrientedDesign.Classes;
using System;

namespace ObjectOrientedDesign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person costumer = new Customer();
            Actor actor = new Actor();
            Movie movie = new Movie();
            movie.AddActor(actor);

            MainSwitch();
        }

        public static void MainSwitch()
        {
            LayoutEnum? selectedChoice;
            do
            {
                //Console.Clear();
                selectedChoice = null;

                Console.WriteLine("Which function would you like to do?");

                foreach (LayoutEnum mainSwitchchoice in (LayoutEnum[])Enum.GetValues(typeof(LayoutEnum)))
                    Console.WriteLine($"{(int)mainSwitchchoice}\t {mainSwitchchoice}");

                bool validInput = int.TryParse(Console.ReadLine(), out (int)selectedChoice);


            } while (selectedChoice == null);
        }
    }
}
