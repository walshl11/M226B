using ObjectOrientedDesign.Classes;
using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using ObjectOrientedDesign.Enums;

namespace ObjectOrientedDesign
{
    public class Program
    {
        private static IEnumerable<IVehicle> _allVehicles;

        private static IEnumerable<IPerson> _allPersons;

        private static IEnumerable<IVehicleType> _allVehicleTypes;

        public static void Main(string[] args)
        {
            _allVehicleTypes = new List<IVehicleType>(1)
            {
                new VehicleType("Car")
            };
            _allPersons = new List<IPerson>();
            _allVehicles = new List<IVehicle>();

            MainSwitch();
        }

        private static void MainSwitch()
        {
            MainSwitchEnum? selectedChoice;
            do
            {
                Console.Clear();
                selectedChoice = null;

                Console.WriteLine("What would you like to do?\n");

                foreach (MainSwitchEnum mainSwitchChoice in (MainSwitchEnum[])Enum.GetValues(typeof(MainSwitchEnum)))
                    Console.WriteLine($"{(int)mainSwitchChoice}\t{mainSwitchChoice}");

                bool wasValidInput = int.TryParse(Console.ReadLine(), out int selectedChoiceIndex);

                if (!wasValidInput)
                    continue;

                selectedChoice = (MainSwitchEnum)selectedChoiceIndex;

                switch (selectedChoice)
                {
                    case MainSwitchEnum.Quit:
                        return;

                    case MainSwitchEnum.RegisterPerson:
                        RegisterPersonSwitch();
                        break;

                    case MainSwitchEnum.RegisterVehicle:
                        RegisterVehicleSwitch();
                        break;
                }
            } while (selectedChoice == null);
        }

        private static void RegisterPersonSwitch()
        {
            RegisterPersonSwitchEnum? selectedChoice;
            do
            {
                Console.Clear();
                selectedChoice = null;

                Console.WriteLine("What type of Person would you like to register?\n");

                foreach (RegisterPersonSwitchEnum mainSwitchChoice in (RegisterPersonSwitchEnum[])Enum.GetValues(typeof(RegisterPersonSwitchEnum)))
                    Console.WriteLine($"{(int)mainSwitchChoice}\t{mainSwitchChoice}");

                bool wasValidInput = int.TryParse(Console.ReadLine(), out int selectedChoiceIndex);

                if (!wasValidInput)
                    continue;

                selectedChoice = (RegisterPersonSwitchEnum)selectedChoiceIndex;

                IPerson newPerson = null;
                switch (selectedChoice)
                {
                    case RegisterPersonSwitchEnum.Quit:
                        return;

                    case RegisterPersonSwitchEnum.RegisterCustomer:
                        Console.WriteLine("Please enter the name of the new customer:");
                        newPerson = new Customer(Console.ReadLine());
                        break;
                }

                if(newPerson is not null)
                    _allPersons = _allPersons.Append(newPerson);
            } while (selectedChoice == null);
        }
        
        private static void RegisterVehicleSwitch()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("What type of Vehicle would you like to register?\n");
                Console.WriteLine("-1\tQuit");
                for(int i = 0; i < _allVehicleTypes.Count(); i++)
                    Console.WriteLine($"{i}\t{_allVehicleTypes.ToList()[i].GetName()}");

                bool wasValidInput = int.TryParse(Console.ReadLine(), out int selectedTypeIndex);

                if (!wasValidInput || selectedTypeIndex < -1 || selectedTypeIndex >= _allVehicleTypes.Count())
                    continue;

                if(selectedTypeIndex == -1)
                    return;

                Console.WriteLine("Please enter the name of your Vehicle:");
                string name = Console.ReadLine();
                IVehicle newVehicle = new VehicleBase(name);
                newVehicle.SetType(_allVehicleTypes.ToList()[selectedTypeIndex]);

                _allVehicles = _allVehicles.Append(newVehicle);
            } while (true);
        }
    }
}