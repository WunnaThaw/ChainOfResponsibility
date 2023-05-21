using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver myo = new Director();
            Approver khin = new VicePresident();
            Approver chris = new President();

            myo.SetSuccessor(khin);
            khin.SetSuccessor(chris);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            myo.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            myo.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            myo.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}
