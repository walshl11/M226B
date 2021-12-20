using ObjectOrientedDesign.Interfaces;
using ObjectOrientedDesign.Classes;
using System;
using System.Collections.Generic;
using ObjectOrientedDesign.Enums;

namespace ObjectOrientedDesign
{
    public class Program
    {
        protected static List<IMovie> Movies { get; set; } = new List<IMovie>();
        protected static List<IReservation> Reservations { get; set; } = new List<IReservation>();
        protected static IPerson Customer { get; set; }

        public static void Main(string[] args)
        {
            IPerson person = new Person("hanz", "peter", 35);
            Customer = new Customer("fritz", "meier", 55);
            IPerson actor = new Actor("mairo", "regel", 69);
            IMovie movie = new Movie();
            IMovie movie2 = new Movie();
            IReservation reservation = new Reservation("new reservation");
            //person.Greet();
            //((Actor)actor).Greet();
            //Console.ReadLine();

            movie.SetName("Shrek 420");
            movie.AddToCast(actor);
            movie2.SetName("Avengers 500");
            movie2.AddToCast(actor);
            reservation.ReserveSeats(person, movie, 2);

            Movies.Add(movie);
            Movies.Add(movie2);
            Reservations.Add(reservation);

            MainSwitch();
        }

        private static void MainSwitch()
        {
            LayoutEnum? selectedChoice;
            do
            {
                //Console.Clear();
                selectedChoice = null;

                Console.WriteLine("Which function would you like to do?");

                foreach (LayoutEnum mainSwitchchoice in (LayoutEnum[])Enum.GetValues(typeof(LayoutEnum)))
                    Console.WriteLine($"{(int)mainSwitchchoice}\t {mainSwitchchoice}");

                bool validInput = int.TryParse(Console.ReadLine(), out int selectedChoiceIndex);

                if (!validInput)
                    continue;

                selectedChoice = (LayoutEnum)selectedChoiceIndex;

                switch (selectedChoice)
                {
                    case LayoutEnum.Quit:
                        selectedChoice = LayoutEnum.Quit;
                        return;
                    case LayoutEnum.ShowAllMovies:
                        ShowAllMovies();
                        selectedChoice = null;
                        break;
                    case LayoutEnum.ShowAllReservation:
                        ShowAllReservations();
                        selectedChoice = null;
                        break;
                    case LayoutEnum.MakeReservation:
                        MakeReservation();
                        selectedChoice = null;
                        break;
                }

            } while (selectedChoice == null);
        }

        private static void ShowAllMovies()
        {
            bool isreturn = false;
            do
            {
                Console.Clear();
                
                foreach (IMovie movie in Movies)
                {
                    Console.WriteLine("Movie details");
                    Console.WriteLine($"Name:\t{movie.GetName()}");
                    Console.WriteLine($"Cast:\t");
                    foreach (IPerson actor in movie.GetCast())
                    {
                        Console.WriteLine($"\tName:\t{actor.GetName()}");
                        Console.WriteLine($"\tAge:\t{actor.GetAge()}");
                    }
                    Console.WriteLine("\n");
                }
                isreturn = int.TryParse(Console.ReadLine(), out int resutl);
                Console.WriteLine("\n");
            } while (isreturn != true);
            Console.Clear();
        }

        private static void ShowAllReservations()
        {
            bool isreturn = false;

            do
            {
                Console.Clear();
                if (Reservations.Count == 0)
                {
                    Console.WriteLine("There are no Reservations registered yet.");
                    isreturn = int.TryParse(Console.ReadLine(), out int resutl);
                }
                else
                {
                    foreach (IReservation reservation in Reservations)
                    {
                        reservation.PrintInformation();
                    }
                    isreturn = int.TryParse(Console.ReadLine(), out int resutl);
                }
                Console.WriteLine("\n");
            } while (isreturn != true);
            Console.Clear();
        }

        private static void MakeReservation()
        {
            bool isreturn = false;
            do
            {
                Console.Clear();
                Console.WriteLine("How many Seats would you like to reserve?");
                bool validInput = int.TryParse(Console.ReadLine(), out int amountOfSeats);

                if (!validInput)
                    return;
                Console.Clear();
                Console.WriteLine("Which Movie do you choose?");
                for (int i = 0; i < Movies.Count; i++)
                {
                    Console.WriteLine($"{i}\t{Movies[i].GetName()}");
                }
                validInput = int.TryParse(Console.ReadLine(), out int movieIndex);
                if (!validInput)
                    return;
                IMovie chosenMovie = Movies[movieIndex];

                Console.Clear();
                if (amountOfSeats != 0 && chosenMovie != null) 
                {
                    IReservation newReserveation = Customer.ReserveMovieSeats(chosenMovie, amountOfSeats);
                    Reservations.Add(newReserveation);
                }

                isreturn = int.TryParse(Console.ReadLine(), out int resutl);

            } while (isreturn != true);
            Console.Clear();
        }
    }
}
