using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv() 
        {
        }

        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Expedition";
        public int SeatCount { get; set; } = 8;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tuff";
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; }

        public bool HasLoungeMode { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving foward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving foward");
            }

        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park and lounge mode can be enabled...");
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool IsChanged)
        {
            HasChangedGears = IsChanged;
        }

    }
}
