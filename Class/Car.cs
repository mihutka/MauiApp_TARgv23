using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Car
    {
        private int speed = 0;

        public void PrintSpeed()
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте...");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем вперед со скоростью {speed} км\\ч");

            }
            if (speed < 0)
            {
                Console.WriteLine($"Едем назад со скоростью {speed} км\\ч");
            }
        }

        public void DriveForward()
        {
            speed = 50;
        }
        
        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward()
        {
            speed = -5;
        }
        
    }
}
