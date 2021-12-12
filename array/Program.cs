using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string task1 = "Задание 1. Случайная матрица.";
            string task2 = "Задание 2. Наименьший элемент в последовательности.";
            string task3 = "Задание 3. Игра «Угадай число».";

            string tasks_pattern = "Выберите задание: \n{0} \n{1} \n{2}";

            Console.WriteLine(tasks_pattern
                                , task1
                                , task2
                                , task3);

            int coise = Convert.ToInt32(Console.ReadLine());

            switch (coise)
            {
                #region Задание 1. Случайная матрица.
                case 1:
                    //Сначала пользователю предлагается ввести количество строк в будущей матрице.
                    Console.WriteLine("Ввведите количество строк в матрице");
                    int line = int.Parse(Console.ReadLine());
                    //Затем — ввести количество столбцов в будущей матрице.
                    Console.WriteLine("Ввведите количество строк в матрице");
                    int colum = int.Parse(Console.ReadLine());
                    //После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
                    int[,] rand_matrix = new int[line, colum];
                    //Используя Random, заполнить матрицу случайными целыми числами.
                    Random r = new Random();
                    int total_sum = 0;

                    for (int i = 0; i < rand_matrix.GetLongLength(0); i++)
                    {
                        for (int j = 0; j < rand_matrix.GetLongLength(1); j++)
                        {
                            rand_matrix[i, j] = r.Next(0, 10);
                            //Вывести полученную матрицу на экран.
                            Console.Write($"{rand_matrix[i, j]} ");
                            total_sum += rand_matrix[i, j];
                        }
                        Console.WriteLine();
                    }
                    //Вывести полученную матрицу на экран.
                    Console.WriteLine($"Сумма все эелементов матрицы = {total_sum}");
                    Console.ReadKey();
                    break;
                #endregion
                #region Задание 2. Наименьший элемент в последовательности.
                case 2:
                    //Задание 2.Наименьший элемент в последовательности.
                    Console.WriteLine("Ведите дилинну последовательности");
                    int lenght = int.Parse(Console.ReadLine());
                    int[] row = new int[lenght];
                    int max = int.MaxValue;
                    //Затем пользователь последовательно вводит целые числа(как положительные, так и отрицательные). Числа разделяются клавишей Enter.
                    for (int i = 0; i < row.Length; i++)
                    {
                        //Каждое введённое число помещается в соответствующий элемент массива.
                        row[i] = int.Parse(Console.ReadLine());
                        if (row[i] < max) max = row[i];
                    }
                    //После окончания ввода данных отдельный цикл проходит по последовательности и находит минимальное число.Для этого он сравнивает каждое число в итерации с предыдущим найденным минимальным числом.
                    Console.WriteLine($"Наименьший элемент в последовательности = {max}");
                    Console.ReadKey();
                    break;
                #endregion
                #region Задание 3. Игра «Угадай число».
                default:
                    //Пользователь вводит максимальное целое число диапазона. .
                    Console.WriteLine("Введите максимальнон целое число диапозона:");
                    int max_d = Convert.ToInt32(Console.ReadLine());
                    //На основе диапазона целых чисел(от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона.
                    Random r_d = new Random();
                    int number = r_d.Next(0, max_d);
                    //Пользователю предлагается ввести загаданное программой случайное число.Пользователь вводит свои предположения в консоли приложения.
                    do
                    {
                        Console.WriteLine("Введите целое число или пустую строку для завершения работы программы.") ;
                        string ent = Console.ReadLine();
                         //Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. Тогда программа завершается, предварительно показывая, какое число было загадано.
                        if (String.IsNullOrEmpty(ent))
                        {
                            Console.WriteLine($"Вы вышли - правильный ответ был {number}.");
                            break;
                        }
                        else if (number > int.Parse(ent))
                        {
                            //Если число меньше загаданного, программа сообщает об этом пользователю.
                            Console.WriteLine($"Введенное число {ent} меньше загаданного числа.");
                        }
                        else if (number < int.Parse(ent))
                        {
                            //Если больше, то тоже сообщает, что число больше загаданного.
                            Console.WriteLine($"Введенное число {ent} Больше загаданного числа.");
                        }
                        else if (number == int.Parse(ent))
                        {
                            //Программа завершается, когда пользователь угадал число.
                            Console.WriteLine($"Вы выграли! {ent} - правильный ответ.");
                            break;
                        }
                    } while (1 == 1);

                    break;
                    #endregion

            }
        }
    }
}
