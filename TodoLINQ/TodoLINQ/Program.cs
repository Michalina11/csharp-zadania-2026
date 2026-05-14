using System;
using System.Collections.Generic;

namespace TodoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoManager manager = new TodoManager();

            int nextId = 1;

            while (true)
            {
                Console.WriteLine("\n=== TODO List ===");
                Console.WriteLine("[1] Dodaj zadanie");
                Console.WriteLine("[2] Zakończ zadanie");
                Console.WriteLine("[3] Wyświetl wszystkie");
                Console.WriteLine("[4] Pokaż nieukończone");
                Console.WriteLine("[5] Filtruj po priorytecie");
                Console.WriteLine("[6] Grupuj zadania");
                Console.WriteLine("[7] Policz ukończone");
                Console.WriteLine("[0] Wyjdź");

                Console.Write("Wybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Podaj tytuł zadania: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("Priorytet");
                        Console.WriteLine("0 - Low");
                        Console.WriteLine("1 - Medium");
                        Console.WriteLine("2 - High");

                        int priorityNumber = Convert.ToInt32(Console.ReadLine());

                        Priority priority = (Priority)priorityNumber;

                        TodoTask task = new TodoTask(nextId, title, priority);

                        manager.AddTask(task);

                        nextId++;

                        Console.WriteLine("Zadanie dodane.");
                        break;

                    case "2":
                        Console.Write("Podaj ID zadania: ");
                        int FinishId = Convert.ToInt32(Console.ReadLine());

                        manager.FinishTask(FinishId);

                        Console.WriteLine("Zadanie zakończone");
                        break;

                    case "3":
                        ShowTasks(manager.GetAll());
                        break;

                    case "4":
                        ShowTasks(manager.GetPending());
                        break;

                    case "5":
                        Console.WriteLine("0 - Low");
                        Console.WriteLine("1 - Medium");
                        Console.WriteLine("2 - High");

                        int filterNumber = Convert.ToInt32(Console.ReadLine());

                        Priority filterPriority = (Priority)filterNumber;

                        ShowTasks(manager.GetByPriority(filterPriority));
                        break;

                    case "6":
                        var grouped = manager.GetGrouped();

                        foreach (var group in grouped)
                        {
                            Console.WriteLine($"\n=== {group.Key} ===");

                            foreach (var taskItem in group)
                            {
                                Console.WriteLine($"{taskItem.Id} - {taskItem.Title}");
                            }
                        }
                        break;

                    case "7":
                        Console.WriteLine($"Ukończone zadania: {manager.CountDone()}");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Niepoprawna opcja.");
                        break;
                }
            }
        }

        static void ShowTasks(List<TodoTask> tasks)
        {
            foreach (TodoTask task in tasks)
            {
                switch (task.Priority)
                {
                    case Priority.Low:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case Priority.Medium:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case Priority.High:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.WriteLine(
                    $"ID: {task.Id} | " +
                    $"{task.Title} | " +
                    $"Priority: {task.Priority} | " +
                    $"Done: {task.IsDone} | " +
                    $"{task.CreatedAt}"
                    );

                Console.ResetColor();
            }
        }
    }
}