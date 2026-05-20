using System;
using System.Collections.Generic;

namespace ContactsCsvManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManager manager = new ContactManager();

            while (true)
            {
                Console.WriteLine("\n=== CONTACTS CSV MANAGER ===");

                Console.WriteLine("[1] Dodaj kontakt");
                Console.WriteLine("[2] Usuń kontakt");
                Console.WriteLine("[3] Szukaj kontaktu");
                Console.WriteLine("[4] Sortuj kontakty");
                Console.WriteLine("[5] Wyświetl kontakty");
                Console.WriteLine("[0] Wyjdź");

                Console.Write("Wybierz opcję: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        Contact contact = new Contact();

                        Console.Write("Imię: ");
                        contact.FirstName = Console.ReadLine();

                        Console.Write("Nazwisko: ");
                        contact.LastName = Console.ReadLine();

                        Console.Write("Email: ");
                        contact.Email = Console.ReadLine();

                        Console.Write("Telefon: ");
                        contact.Phone = Console.ReadLine();

                        manager.Add(contact);

                        Console.WriteLine("Kontakt dodany.");

                        break;

                    case "2":

                        Console.Write("Podaj ID: ");

                        int id =
                            Convert.ToInt32(Console.ReadLine());

                        manager.Delete(id);

                        Console.WriteLine("Kontakt usunięty.");

                        break;

                    case "3":

                        Console.Write("Szukaj: ");

                        string query = Console.ReadLine();

                        List<Contact> results =
                            manager.Search(query);

                        ShowContacts(results);

                        break;

                    case "4":

                        Console.Write("Pole sortowania: ");

                        string field = Console.ReadLine();

                        List<Contact> sorted =
                            manager.Sort(field);

                        ShowContacts(sorted);

                        break;

                    case "5":

                        ShowContacts(manager.Contacts);

                        break;

                    case "0":

                        return;
                }
            }
        }
        static void ShowContacts(List<Contact> contacts)
        {

            Console.WriteLine("\n-----------------------------------------------------------");

            Console.WriteLine(
                "| ID | FirstName | LastName | Email | Phone |");

            Console.WriteLine("-----------------------------------------------------------");

            foreach (Contact c in contacts)
            {
                Console.WriteLine(
                    $"| {c.Id,-2} " +
                    $"| {c.FirstName,-9} " +
                    $"| {c.LastName,-8} " +
                    $"| {c.Email,-20} " +
                    $"| {c.Phone,-10} |"
                );
            }

            Console.WriteLine("-----------------------------------------------------------");
        }
        }
    }

