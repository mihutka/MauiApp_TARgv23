namespace Class
{
    //ООП
    //методы объетка класса



    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();

            student.firstName = "Мартин";
            student.middleName = "Игоревич";
            student.lastName = "Дугин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "ЙЦУКЕН_1";

            return student;
        }

       



        static void Main(string[] args)
        {
            Console.WriteLine("\t == Car 1 ==");
            var car = new Car();
            car.PrintSpeed();
            car.DriveForward();
            car.PrintSpeed();
            car.Stop();
            car.PrintSpeed();

            Console.WriteLine("\t == Car 2 ==");
            var car2 = new Car();
            car2.PrintSpeed();
            car2.DriveBackward();
            car2.PrintSpeed();
            
        }
    }
}
