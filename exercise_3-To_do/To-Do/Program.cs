using System.IO;

namespace To_Do
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> tasks = [];
            string choise;
            bool running = true;

            string line;

            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Lars Henrik\\Desktop\\test.txt");
                line = sr.ReadLine();

                while (line != null )
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }


            while (running == true)
            {
                Console.WriteLine("Wecome to you todo app!");

                Console.WriteLine("press 1 to add task, 2 for printing current tasks, or 3 to exit");

                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":

                        Console.WriteLine("What task to you want to add?");
                        tasks.Add(Console.ReadLine());
                        break; 

                    case "2":

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks");
                        }

                        else
                        {
                            Console.WriteLine("\n--------- Tasks List ----------");

                            foreach (string task in tasks)
                            {
                                Console.WriteLine(task);
                            }

                        }

                        break;

                    case "3":


                        running = false;

                            //pass the filepath
                        StreamWriter sw = new StreamWriter("C:\\Users\\Lars Henrik\\Desktop\\test.txt");
                            // Write a like of text
                        sw.WriteLine("======== ToDo ========");
                            // Write second line
                        foreach (string task in tasks)
                        {
                            sw.WriteLine(task);
                        }
                        
                        sw.Close();

                        Console.WriteLine("Goodbye");
                        break;

                }
            }

        }
    }
}
