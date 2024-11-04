using System.Collections;

namespace domashna___4_4._11._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList library = new ArrayList() {"Левски - ИВАН ВАЗОВ"};
            library.Add("Под Игото - ИВАН ВАЗОВ");
            library.Add("До моето първо либе - ХРИСТО БОТЕБВ");

            Console.WriteLine("В библиотеката са съответните книги: ");
            Console.WriteLine(library[0]);
            Console.WriteLine(library[1]);
            Console.WriteLine(library[2]);

            Console.WriteLine();

            Console.WriteLine("Искате ли да премахнете книга? Отговорете с Yes or No");
            string answer = Console.ReadLine();

            if (answer == "Yes")
            {
                Console.WriteLine("Моля въведете името на книгата, която искате да изтриете");
                string BookName = Console.ReadLine();

                if (BookName == "Левски")
                {
                    library.RemoveAt(0);
                    Console.WriteLine("КНИГАТА БЕШЕ УСПЕШНО ИЗТРИТА!");
                }
                else if (BookName == "Под Игото")
                {
                    library.RemoveAt(1);
                    Console.WriteLine("КНИГАТА БЕШЕ УСПЕШНО ИЗТРИТА!");
                }
                else if (BookName == "До моето първо либе")
                {
                    library.RemoveAt(2);
                    Console.WriteLine("КНИГАТА БЕШЕ УСПЕШНО ИЗТРИТА!");
                }
                else
                {
                    Console.WriteLine("НЯМА ТАКАВА КНИГА");
                }
            }
            else if (answer == "No")
            {
                Console.WriteLine("Няма промяна в библиотеката ви!");
            }
            else 
            {
                Console.WriteLine("Въведохте невалиден отговор. Не бяха направени промени във вашата библиотека!!!");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Останалите Книги в Библиотеката са:");
            foreach (var book in library) 
            {
                Console.WriteLine(book);
            }
        }
    }
}
