using System;
using System.Collections.Generic;


class Book
{
    public Dictionary<string , string> contacts = new Dictionary <string,string> ();
    public void Entry() // Welcome screen
    {
        ChangeColor();
        Console.WriteLine("Welcome to 'Console_Phonebook' phone book");
        ResetColor();
        System.Threading.Thread.Sleep(10000);
        Console.Clear();
    }

    public void AddContact(string name, string phone)
    {
        contacts.Add(name, phone);
    } 

    public void DelContact(string name)
    {
        contacts.Remove(name);
    }

    public void Show()
    {
        ChangeColor();
        Console.WriteLine("Your contacts:\n");
        ResetColor();
        foreach (object contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }

    public void ChangeColor() // for faster changeable color
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }

    public void ResetColor() // in pair with 'ChangeColor'
    {
        Console.ResetColor();
    } 
}

class Phone
{
    static void Main()
    {
        Book b = new Book ();
        int choise;

        b.Entry();
        do
        {
            Console.Clear();
            Console.WriteLine("What option you want to use?\n");
            Console.WriteLine("1 - Add contact \n" + "2 - Delete contact \n" + "3 - Show your contacts\n" + "4 - Exit\n");
            b.ChangeColor();
            Console.Write("Option №: ");
            choise = int.Parse(Console.ReadLine());
            b.ResetColor();
            Console.Clear();

            switch (choise)
            {
                case 1:
                    {
                        b.ChangeColor();
                        Console.WriteLine("Enter contact name:");
                        b.ResetColor();
                        string name = Console.ReadLine();
                        b.ChangeColor();
                        Console.WriteLine("\nEnter phone number:");
                        b.ResetColor();
                        string phone = Console.ReadLine();
                        b.AddContact(name, phone);
                        
                    }
                    break;
                case 2:
                    {
                        b.ChangeColor();
                        Console.WriteLine("Enter contact name:");
                        string name = Console.ReadLine();
                        b.DelContact(name);
                    }
                    break;
                case 3:
                    {
                        b.Show();
                        System.Threading.Thread.Sleep(10000);
                    }
                    break;
                case 4:
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("You chose the wrong option. Please, try again.");
                    break;
            }
        }
        while (choise != 4);
    }
}
