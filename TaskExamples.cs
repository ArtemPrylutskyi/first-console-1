using System;
using System.Threading.Tasks;

namespace ThirdTaskApp
{
    public class TaskExamples
    {
      
        public static async Task RunTasksWithDelay()
        {
            Random rnd = new Random();

            Task[] tasks = new Task[3];
            for (int i = 0; i < 3; i++)
            {
                int taskNum = i + 1;
                tasks[i] = Task.Run(async () =>
                {
                    int delay = rnd.Next(1000, 3000); 
                    await Task.Delay(delay);
                    Console.WriteLine($"Task {taskNum} завершився після {delay} мс");
                });
            }

            await Task.WhenAll(tasks);
            Console.WriteLine("✅ Всі таски завершились");
        }

       
        public static async Task RunTasksReturnFirst()
        {
            Random rnd = new Random();

            Task<string>[] tasks = new Task<string>[3];
            for (int i = 0; i < 3; i++)
            {
                int taskNum = i + 1;
                tasks[i] = Task.Run(async () =>
                {
                    int delay = rnd.Next(1000, 3000);
                    await Task.Delay(delay);
                    return $"Task {taskNum} завершився після {delay} мс";
                });
            }

            Task<string> firstFinished = await Task.WhenAny(tasks);
            Console.WriteLine("Першим завершився: " + firstFinished.Result);
        }
    }
}
