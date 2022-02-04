using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator
    {
        internal static void Run()
        {
            bool decoratorRunning = true;
            ITag allTags = new BaseTag("");

            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            string textInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press B for Bold");
            Console.WriteLine("Press D for Deleted");
            Console.WriteLine("Press E Emphasized");
            Console.WriteLine("Press I for Important");
            Console.WriteLine("Press J for Inserted");
            Console.WriteLine("Press K for Italic");
            Console.WriteLine("Press M for Marked");
            Console.WriteLine("Press S for Smaller");
            Console.WriteLine("Press T for SubScript");
            Console.WriteLine("Press U SuperScript");
            Console.WriteLine("Press F for preview");
            Console.WriteLine("Press Z When you are happy to finnish");
            Console.WriteLine();
            Console.WriteLine("Type the tags you want separated by space");            

            while (decoratorRunning)
            {                
                var userinput = Console.ReadKey(true).Key;

                switch (userinput)
                {
                    case ConsoleKey.B:
                        allTags = new BoldDecorator(allTags);
                        Console.WriteLine("Bold tag added");
                        break;
                    case ConsoleKey.D:
                        allTags = new DeletedDecorator(allTags);
                        Console.WriteLine("Deleted tag added");
                        break;
                    case ConsoleKey.E:
                        allTags = new EmphasizedDecorator(allTags);
                        Console.WriteLine("Emphasized tag added");
                        break;
                    case ConsoleKey.I:
                        allTags = new ImportantDecorator(allTags);
                        Console.WriteLine("Important tag added");
                        break;
                    case ConsoleKey.J:
                        allTags = new InsertedDecorator(allTags);
                        Console.WriteLine("Inserted tag added");
                        break;
                    case ConsoleKey.K:
                        allTags = new ItalicDecorator(allTags);
                        Console.WriteLine("Italic tag added");
                        break;
                    case ConsoleKey.M:
                        allTags = new MarkedDecorator(allTags);
                        Console.WriteLine("Marked tag added");
                        break;
                    case ConsoleKey.S:
                        allTags = new SmallerDecorator(allTags);
                        Console.WriteLine("Smaller tag added");
                        break;
                    case ConsoleKey.T:
                        allTags = new SubScriptDecorator(allTags);
                        Console.WriteLine("SubScript tag added");
                        break;
                    case ConsoleKey.U:
                        allTags = new SuperScriptDecorator(allTags);
                        Console.WriteLine("SuperScript tag added");
                        break;
                    case ConsoleKey.Z:
                        decoratorRunning = false;
                        break;
                    case ConsoleKey.F:
                        string test = allTags.GetTag();
                        string test2 = HTMLGenerator.TagProcessor(test, textInput);
                        Console.WriteLine(test2);
                        break;
                    default:
                        break;
                }
            }
            string tagSelection = allTags.GetTag();
            string result = HTMLGenerator.TagProcessor(tagSelection, textInput);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}