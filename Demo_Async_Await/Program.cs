// See https://aka.ms/new-console-template for more information
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Async_Await
{
    internal class Program
    {
        static int a = 5, b = 6, c = 10;
        static async Task Main(string[] args)
        {
            Task tk1 = Task1();
            Task tk2 = Task2();
            //Task tk3 = Task3();

            Task<int> tk = GetURLAsyncLength();

            Task.WaitAll(tk1, tk2);
            Console.WriteLine("Execution 3 tasks completed\n\n");

            await tk;
            Console.WriteLine("The Length of URL is {0}", tk.Result);
            Console.Read();
        }

        static async Task Task1()
        {
            Task tsk1 = new Task(
                () =>
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("Implement task 1");
                        Thread.Sleep(1000);
                    }
                });
            
            tsk1.Start();
            await tsk1;
            Console.WriteLine("Task 1 Completed");

        }

        static async Task Task2()
        {
            Task tsk2 = new Task(
                () =>
                {
                    for (int i = 0; i < b; i++)
                    { 
                        Console.WriteLine("Implement task 2");
                        Thread.Sleep(1000);
                    }
                });
            tsk2.Start();
            await tsk2;
            Console.WriteLine("Task 2 Completed");
        }

        //static async Task Task3()
        //{
        //    Task tsk3 = new Task(
        //        () =>
        //        {
        //            for (int i = 0; i < c; i++)
        //            {
        //                Console.WriteLine("Implement task 3");
        //                Thread.Sleep(1000);
        //            }
        //        });
        //    tsk3.Start();
        //    await tsk3;
        //    Console.WriteLine("Task 3 Completed");
        //}

        static async Task<int> GetURLAsyncLength()
        {
            var client = new HttpClient();
            Task<string> tsk = client.GetStringAsync("https://www.youtube.com/");
            Console.WriteLine("Working ...");
            string ctn = await tsk;
            return ctn.Length;
        }

    }
}