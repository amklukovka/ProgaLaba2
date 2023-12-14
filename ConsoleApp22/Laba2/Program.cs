// ЛАБОРАТОРНАЯ РАБОТА 2 // Вариант 2
// ЗАПИСНАЯ КНИЖКА

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp22.Laba2;

public class Program
{
    static void Main(string[] args)
    {
        Notebook notebook = new Notebook();

        // бесконечный цикл (до того, пока пользователь не выберет вариант "Exit")
        while (true)
        {
            notebook.ShowMenu(); // показ меню

            int choice = int.Parse(Console.ReadLine()); // считывание выбора пользователя

            switch (choice)
            {
                case 1:
                    notebook.ViewAll(); // показ всех контактов
                    break;
                case 2:
                    notebook.Search(); // поиск контактов
                    break;
                case 3:
                    notebook.NewContact(); // добавление нового контакта
                    break;
                case 4:
                    notebook.Exit(); // выход
                    break;
                default: // некорректное значение
                    Console.WriteLine("Некорректное значение.");
                    break;
            }
        }
    }
}