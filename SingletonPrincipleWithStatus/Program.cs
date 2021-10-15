using System;

namespace SingletonPrincipleWithStatus
{
    class Program
    {
        static FaultStatus faultStatus = FaultStatus.GetFaultStatus();
        static void Main(string[] args)
        {
            faultStatus.SetStatusses(true, false);

            Console.WriteLine($"--> Status1: {faultStatus.GetStatus1()}");
            Console.WriteLine($"--> Status2: {faultStatus.GetStatus2()}");

            if (faultStatus.IsAllTrue())
            {
                //Action
            }

            var test = new TestSingleton();
        }
    }

    class TestSingleton
    {
        static FaultStatus faultStatusTest = FaultStatus.GetFaultStatus();
        public TestSingleton()
        {
            Console.WriteLine("--> Testing class:");
            Console.WriteLine($"--> Status1: {faultStatusTest.GetStatus1()}");
            Console.WriteLine($"--> Status2: {faultStatusTest.GetStatus2()}");
        }
    }
}
