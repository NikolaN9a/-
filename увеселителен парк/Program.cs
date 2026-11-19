using System.Collections;

namespace увеселителен_парк
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Регистрация на посетители
       Console.WriteLine("Add name");
            Console.ReadLine();
            ArrayList visitors = new ArrayList()
        {
            "Anna", "Ivan", "Maria", "Georgi",
            "Peter", "Elena", "Nikolay"
        };

            // Добавяне на още трима посетители
            visitors.Add("Dimitar");
            visitors.Add("Stefan");
            visitors.Add("Viktoria");

            // Добавяне на посетител на индекс 3
            visitors.Insert(3, "Alex");

            Console.WriteLine("1. Всички посетители:");

            foreach (string visitor in visitors)
            {
                Console.WriteLine(visitor);
            }


            // 2. Проблем на входа

            Console.WriteLine("\n2. Проблем на входа:");

            // Премахване по име
            visitors.Remove("Dimitar");

            // Премахване на посетител с индекс 2
            visitors.RemoveAt(2);

            // Проверка за Maria
            if (visitors.Contains("Maria"))
            {
                Console.WriteLine("Maria се намира в списъка.");
            }
            else
            {
                Console.WriteLine("Maria не се намира в списъка.");
            }

            // Брой посетители
            Console.WriteLine("Брой посетители: " + visitors.Count);


            // 3. VIP посетители

            Console.WriteLine("\n3. VIP посетители:");

            // Добавяне на двама VIP посетители в началото
            visitors.Insert(0, "VIP_Anna");
            visitors.Insert(0, "VIP_Ivan");

            // Проверка за Georgi
            if (visitors.Contains("Georgi"))
            {
                int index = visitors.IndexOf("Georgi");
                visitors[index] = "VIP_Georgi";

                Console.WriteLine("Georgi е заменен с VIP_Georgi.");
            }
            else
            {
                Console.WriteLine("Georgi не се намира в списъка.");
            }

            // Намиране на Peter
            int peterIndex = visitors.IndexOf("Peter");

            if (peterIndex != -1)
            {
                Console.WriteLine("Peter е на индекс: " + peterIndex);
            }
            else
            {
                Console.WriteLine("Peter не е намерен.");
            }


            // 4. Техническа повреда

            Console.WriteLine("\n4. Техническа повреда:");

            // Премахване на имената, започващи с A
            for (int i = visitors.Count - 1; i >= 0; i--)
            {
                string name = (string)visitors[i];

                if (name.StartsWith("A"))
                {
                    visitors.RemoveAt(i);
                }
            }

            // Премахване на имената с по-малко от 4 символа
            for (int i = visitors.Count - 1; i >= 0; i--)
            {
                string name = (string)visitors[i];

                if (name.Length < 4)
                {
                    visitors.RemoveAt(i);
                }
            }

            Console.WriteLine("Актуален списък:");

            foreach (string visitor in visitors)
            {
                Console.WriteLine(visitor);
            }


            // 5. Ново подреждане

            Console.WriteLine("\n5. Ново подреждане:");

            // Сортиране по азбучен ред
            visitors.Sort();

            Console.WriteLine("Сортиран списък:");

            foreach (string visitor in visitors)
            {
                Console.WriteLine(visitor);
            }

            // Обръщане на реда
            visitors.Reverse();

            // Размяна на първия и последния посетител
            if (visitors.Count > 1)
            {
                object temp = visitors[0];
                visitors[0] = visitors[visitors.Count - 1];
                visitors[visitors.Count - 1] = temp;
            }

            Console.WriteLine("\nКраен списък:");

            foreach (string visitor in visitors)
            {
                Console.WriteLine(visitor);
            }


            // 6. Проверка преди затваряне

            Console.WriteLine("\n6. Проверка преди затваряне:");

            if (visitors.Count > 5)
            {
                Console.WriteLine("Паркът беше пълен днес!");
            }
            else if (visitors.Count >= 1 && visitors.Count <= 5)
            {
                Console.WriteLine("Днес беше спокоен ден!");
            }
            else
            {
                Console.WriteLine("Паркът беше празен!");
            }
        }
    }
}
