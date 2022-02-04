using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer
    {
        internal static void Run()
        {
            Console.WriteLine("Observer");

            IEmail email = new Email();
            IEmailWatcher emailWatcher = new EmailWatcher();
            email.RegisterObserver(emailWatcher);
            bool observerRunning = true;

            Console.WriteLine("Press M to tell listener's to send mail");
            Console.WriteLine("Press S to sub/unsub");
            Console.WriteLine("Press E to exit");

            while (observerRunning)
            {                
                var userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.M:                        
                        email.Check();
                        break;
                    case ConsoleKey.S:
                        if (email.Observers.Contains(emailWatcher))
                        {
                            email.UnRegisterObserver(emailWatcher);
                            Console.WriteLine("Unsubscribed");
                        }
                        else
                        {
                            email.RegisterObserver(emailWatcher);
                            Console.WriteLine("Subscribed");
                        }
                        break;
                    case ConsoleKey.E:
                        observerRunning = false;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
