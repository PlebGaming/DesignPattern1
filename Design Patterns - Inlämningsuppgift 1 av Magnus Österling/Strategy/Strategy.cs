using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy
    {
        internal static void Run()
        {            
            MessageHandler messageHandler = new MessageHandler();
            IMessage sms = new SmsMessage();
            IMessage email = new EmailMessage();
            IMessage face = new FacebookMessage();
            bool strategyRunning = true;
            var message = "This is the message";

            messageHandler.sendMessage = sms; // default message mode

            while (strategyRunning)
            {
                var userinput = Console.ReadKey(true).Key;
                Console.WriteLine("Strategy");
                Console.WriteLine();                
                Console.WriteLine("Pick your action please!");
                Console.WriteLine("1. SMS");
                Console.WriteLine("2. Email");
                Console.WriteLine("3. Facebook");
                Console.WriteLine("4. Send Message");
                Console.WriteLine("5. Exit");

                switch (userinput)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Your messages will be sent via SMS");
                        messageHandler.sendMessage = sms;
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Your messages will be sent via Email");
                        messageHandler.sendMessage = email;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Your messages will be sent via Facebook");
                        messageHandler.sendMessage = face;
                        break;
                    case ConsoleKey.D4:
                        messageHandler.sendMessage.SendMessage(message);
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("Thanks and good bye!");
                        Console.WriteLine();
                        strategyRunning = false;
                        break;
                    default:
                        break;
                }
            }         
        }
    }
}