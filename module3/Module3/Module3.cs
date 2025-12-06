using System;
using System.Linq;
using System.Text;

namespace M3
{
    public class Module3
    {
        static void Main(string[] args)
        {
            // Демонстрация работы методов
            var module = new Module3();
            
            Console.WriteLine("=== Module 3: Простые задачи ===\n");
            
            // Задание 1
            Console.WriteLine("1. Реверс строки:");
            Console.WriteLine($"   'Hello' -> '{module.ReverseString("Hello")}'");
            
            // Задание 2
            Console.WriteLine("\n2. Проверка на палиндром:");
            Console.WriteLine($"   121 -> {module.IsPalindrome(121)}");
            Console.WriteLine($"   123 -> {module.IsPalindrome(123)}");
            
            // Задание 3
            Console.WriteLine("\n3. Факториал числа:");
            Console.WriteLine($"   5! = {module.Factorial(5)}");
            
            // Задание 4
            Console.WriteLine("\n4. Проверка на простое число:");
            Console.WriteLine($"   7 -> {module.IsPrime(7)}");
            Console.WriteLine($"   10 -> {module.IsPrime(10)}");
            
            // Задание 5
            Console.WriteLine("\n5. Число Фибоначчи:");
            Console.WriteLine($"   F(10) = {module.Fibonacci(10)}");
            
            // Задание 6
            Console.WriteLine("\n6. Подсчет гласных:");
            Console.WriteLine($"   'Hello World' -> {module.CountVowels("Hello World")}");
            
            // Задание 7
            Console.WriteLine("\n7. НОД (GCD):");
            Console.WriteLine($"   GCD(48, 18) = {module.GCD(48, 18)}");
            
            // Задание 8
            Console.WriteLine("\n8. Проверка анаграммы:");
            Console.WriteLine($"   'listen', 'silent' -> {module.AreAnagrams("listen", "silent")}");
            Console.WriteLine($"   'hello', 'world' -> {module.AreAnagrams("hello", "world")}");
        }

        /// <summary>
        /// Задание 1: Реверс строки
        /// Переворачивает строку задом наперед
        /// </summary>
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Задание 2: Проверка числа на палиндром
        /// Число является палиндромом, если оно читается одинаково слева направо и справа налево
        /// </summary>
        public bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;

            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return original == reversed;
        }

        /// <summary>
        /// Задание 3: Вычисление факториала
        /// n! = 1 * 2 * 3 * ... * n
        /// </summary>
        public long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определен только для неотрицательных чисел");

            if (n <= 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Задание 4: Проверка числа на простоту
        /// Простое число делится только на 1 и само себя
        /// </summary>
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Задание 5: Вычисление N-го числа Фибоначчи
        /// F(0) = 0, F(1) = 1, F(n) = F(n-1) + F(n-2)
        /// </summary>
        public long Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Индекс должен быть неотрицательным");

            if (n <= 1)
                return n;

            long prev = 0;
            long current = 1;

            for (int i = 2; i <= n; i++)
            {
                long next = prev + current;
                prev = current;
                current = next;
            }

            return current;
        }

        /// <summary>
        /// Задание 6: Подсчет количества гласных в строке
        /// Гласные: a, e, i, o, u (и их заглавные версии)
        /// </summary>
        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Задание 7: Нахождение наибольшего общего делителя (НОД)
        /// Используется алгоритм Евклида
        /// </summary>
        public int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        /// <summary>
        /// Задание 8: Проверка, являются ли две строки анаграммами
        /// Анаграммы - слова, состоящие из одних и тех же букв
        /// </summary>
        public bool AreAnagrams(string first, string second)
        {
            if (first == null || second == null)
                return false;

            // Приводим к нижнему регистру и убираем пробелы
            string cleanFirst = new string(first.ToLower().Where(char.IsLetter).ToArray());
            string cleanSecond = new string(second.ToLower().Where(char.IsLetter).ToArray());

            if (cleanFirst.Length != cleanSecond.Length)
                return false;

            // Сортируем символы и сравниваем
            char[] sortedFirst = cleanFirst.ToCharArray();
            char[] sortedSecond = cleanSecond.ToCharArray();

            Array.Sort(sortedFirst);
            Array.Sort(sortedSecond);

            return new string(sortedFirst) == new string(sortedSecond);
        }

        /// <summary>
        /// Задание 9: Сумма цифр числа
        /// </summary>
        public int SumOfDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        /// <summary>
        /// Задание 10: Поиск максимального элемента в массиве
        /// </summary>
        public int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Массив не может быть пустым");

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Задание 11: Проверка, отсортирован ли массив по возрастанию
        /// </summary>
        public bool IsSorted(int[] array)
        {
            if (array == null || array.Length <= 1)
                return true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Задание 12: Удаление дубликатов из массива
        /// </summary>
        public int[] RemoveDuplicates(int[] array)
        {
            if (array == null || array.Length == 0)
                return array;

            return array.Distinct().ToArray();
        }
    }
}

