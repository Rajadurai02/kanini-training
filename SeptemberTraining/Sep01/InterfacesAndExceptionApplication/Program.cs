using System;

namespace InterfacesAndExceptionApplication
{
    class Program
    {
        void SkyShow(IFlying flying)
        {
            flying.TakeOff();
            flying.Fly();
            flying.Land();
        }
        void VisitForest(IAnimal animal)
        {
            animal.Eat();
            animal.Sleep();
        }
        void EmpManager(IEmployeeManager employeeManager)
        {
            employeeManager.CheckWork();
            employeeManager.CounductMeeting();
        }
        void CustManager(ICustomerManager customerManager)
        {
            customerManager.ApproveLoan();
            customerManager.SolveIssues();
        }
        static void Main(string[] args)
        {
            //Bird bird = new Bird("peacock");
            //program program = new program();
            ////program.visitforest(bird);
            ////program.skyshow(bird);
            //manager manager = new manager();
            //program.empmanager(manager);
            //program.custmanager(manager);
            //Dog dog = new GreatDane();
            //dog.Look();
            //dog.Eat();
            //dog.Sleep();
            //new ExceptionHandling().ArrayIndexException();
            new ExceptionHandling().DivisionByZeroException();
            //new ExceptionHandling().FormatException();
            //new ExceptionHandling().NullException();
            //new ExceptionHandling().ArithmeticException();
            //new ExceptionHandling().IOException();
            Console.ReadKey();
        }
    }
}
