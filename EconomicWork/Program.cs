using System;
using System.IO;

namespace EconomicWork
{
    class Program
    {
        public static void OutMassiv(int doska)
        {
            float[,] matrix = new float[doska, doska];
            float answer = 0;
            float answercount1 = 0;
            float answercount2 = 0;
            float answercount3 = 0;
            float answercount0 = 0;

            for (int i = 1; i <= doska; i++)
            {
                for (int k = 1; k <= doska; k++)
                {
                    Console.WriteLine("Вам необходимо ввести цвет каждой клетки доски вручную. Пустая клетка (белая) может быть только одна. Остальных - пять.");
                    Console.WriteLine("");
                    for (int d = 0; d < doska; d++)
                    {
                        for (int g = 0; g < doska; g++)
                        {
                            if (matrix[d, g] == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (matrix[d, g] == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (matrix[d, g] == 3)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.Write("{0} ", matrix[d, g]);
                            Console.ResetColor();
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Введите цвет клетки (с -синий, к - красный, з - зеленый и б/п - белая/пустая клетка), ");
                    Console.WriteLine("которая расположена на {0} строке и {1} столбце", i, k);
                    string outanswer = Console.ReadLine();
                    bool count = true;

                    if (outanswer == "синий" || outanswer == "с" || outanswer == "С")
                    {
                        if (answercount1 > 4)
                        {
                            count = false;
                        }
                        else
                        {
                            answer = 1;
                            answercount1 = answercount1 + 1;
                        }
                    }
                    else if (outanswer == "красный" || outanswer == "к" || outanswer == "К")
                    {
                        if (answercount2 > 4)
                        {
                            count = false;
                        }
                        else
                        {
                            answer = 2;
                            answercount2 = answercount2 + 1;
                        }
                    }
                    else if (outanswer == "зеленый" || outanswer == "з" || outanswer == "З")
                    {
                        if (answercount3 > 4)
                        {
                            count = false;
                        }
                        else
                        {
                            answer = 3;
                            answercount3 = answercount3 + 1;
                        }
                    }
                    else if (outanswer == "белый" || outanswer == "пустая" || outanswer == "пустая клетка" || outanswer == "б" || outanswer == "п" || outanswer == "Б" || outanswer == "П" || outanswer == "0")
                    {
                        if (answercount0 > 0)
                        {
                            count = false;
                        }
                        else
                        {
                            answer = 0;
                            answercount0 = answercount0 + 1;
                        }
                    }
                    else
                    {
                        count = false;
                    }
                    if (count == true)
                    {
                        matrix[i - 1, k - 1] = answer;
                    }
                    else
                    {
                        k = k - 1;
                    }
                    Console.Clear();
                }
            }
            Console.Clear();
            Console.WriteLine("Исходная доска:");
            Console.WriteLine("");
            for (int d = 0; d < doska; d++)
            {
                for (int g = 0; g < doska; g++)
                {
                    if (matrix[d, g] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (matrix[d, g] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (matrix[d, g] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0} ", matrix[d, g]);
                    Console.ResetColor();
                }
                Console.WriteLine("");
            }
            Metod(matrix, doska);
        }
        public static void Massiv(int doska)
        {
            Random rand = new Random();
            Console.WriteLine("Исходная доска:");
            Console.WriteLine("");
            int a = 1;
            int b = 4;
            float[,] matrix = new float[doska, doska];
            float[] massiv = new float[doska * doska];
            int superCount = 0;
            int controlShag = 0;
            float controlRandom = 0;
            for (int i = 0; i < doska; i++)
            {
                for (int k = 0; k < doska; k++)
                {
                    controlRandom = rand.Next(a, b);
                    while (controlShag == 1)
                    {
                        controlRandom = rand.Next(a, b);
                        if (controlRandom != 2)
                        {
                            controlShag = 0;
                        }
                        else
                        {
                            if (superCount == 15)
                            {
                                matrix[3, 3] = 0;
                                controlShag = 0;
                            }
                        }
                    }
                    matrix[i, k] = controlRandom;
                    matrix[3, 3] = 0;
                    massiv[superCount] = matrix[i, k];

                    float superg1 = 0;
                    float superg2 = 0;
                    float superg3 = 0;

                    for (int g = 0; g < doska * doska; g++)
                    {
                        if (massiv[g] == 1)
                        {
                            superg1 = superg1 + 1;
                        }
                        else if (massiv[g] == 2)
                        {
                            superg2 = superg2 + 1;
                        }
                        else if (massiv[g] == 3)
                        {
                            superg3 = superg3 + 1;
                        }

                        if (superg1 > 4)
                        {
                            a = 2;
                        }
                        if (superg2 > 4)
                        {
                            controlShag = 1;
                        }
                        if (superg3 > 4)
                        {
                            b = 3;
                        }
                    }


                    if (matrix[i, k] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (matrix[i, k] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (matrix[i, k] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write("{0} ", matrix[i, k]);
                    Console.ResetColor();
                    superCount = superCount + 1;
                }
                Console.WriteLine("");

            }
            Console.WriteLine("");
            Metod(matrix, doska);
        }
        public static void Metod(float[,] matrix, int doska)
        {

            Console.WriteLine("Хотите ли Вы, чтобы программа выводила каждый сдвиг на экран?");
            Console.WriteLine("да/д - программа будет выводить каждый шаг");
            Console.WriteLine("нет/н - программа выведет только конечный результат");
            bool output = false;
            bool outputfirst = false;
            bool metod = false;
            while (metod != true)
            {
                string answerex = Console.ReadLine();
                if (answerex == "да" || answerex == "Да" || answerex == "д" || answerex == "Д")
                {
                    Console.Clear();
                    metod = true;
                    outputfirst = true;
                    output = true;
                }
                else if (answerex == "нет" || answerex == "Нет" || answerex == "н" || answerex == "Н")
                {
                    Console.Clear();

                    Console.WriteLine("Исходная доска:");
                    Console.WriteLine("");
                    for (int d = 0; d < doska; d++)
                    {
                        for (int g = 0; g < doska; g++)
                        {
                            if (matrix[d, g] == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (matrix[d, g] == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (matrix[d, g] == 3)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.Write("{0} ", matrix[d, g]);
                            Console.ResetColor();
                        }
                        Console.WriteLine("");
                    }
                    metod = true;
                    Console.WriteLine("");
                    Console.WriteLine("Программа выведет окончательный результат на экран в формате:");
                    Console.WriteLine("Получившаяся доска");
                    Console.WriteLine("Количество сдвигов");
                    Console.WriteLine("Суммарное время работы алгоритма");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Это не y или n");
                }
            }

            long count = 1;
            int index1 = 0;
            int index2 = 0;
            float colichestvoItteraciy = 0;
            Random rnd = new Random();
            float previosMove = 0;

            float errorOfItteratiy = 0;
            bool otvet1 = false;
            bool otvet2 = false;
            bool otvet3 = false;
            bool answer1 = false;
            bool answer2 = false;
            bool answer3 = false;

            float answer = 0;
            var golden = System.Diagnostics.Stopwatch.StartNew();
            while (count > 0)
            {
                errorOfItteratiy = errorOfItteratiy + 1;
                otvet1 = false;
                otvet2 = false;
                otvet3 = false;
                float side = rnd.Next(1, 5);
                for (int i = 0; i < doska; i++)
                {
                    for (int k = 0; k < doska; k++)
                    {
                        if (0 == matrix[i, k])
                        {
                            index1 = i;
                            index2 = k;
                        }
                    }
                }

                if (output == true && outputfirst == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Сдвиг номер {0}: ", colichestvoItteraciy);
                    for (int d = 0; d < doska; d++)
                    {
                        for (int g = 0; g < doska; g++)
                        {
                            if (matrix[d, g] == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (matrix[d, g] == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            else if (matrix[d, g] == 3)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.Write("{0} ", matrix[d, g]);
                            Console.ResetColor();
                        }
                        Console.WriteLine("");
                    }
                } //вывод на экран каждый шаг программы


                for (int i = 1; i < doska; i++)
                {
                    answer = i;
                    if (Algoritm(matrix, doska, answer)[0] == 1) //проверка на соединение всех ячеек одного цвета
                    {
                        if (answer == 1)
                        {
                            otvet1 = true;
                        }
                        if (answer == 2)
                        {
                            otvet2 = true;
                        }
                        if (answer == 3)
                        {
                            otvet3 = true;
                        }
                    }
                    if (Algoritm(matrix, doska, answer)[1] == 1) // проверка на заморозку
                    {
                        if (errorOfItteratiy < 3)
                        {
                            if (answer == 1)
                            {
                                answer1 = true;
                            }
                            if (answer == 2)
                            {
                                answer2 = true;
                            }
                            if (answer == 3)
                            {
                                answer3 = true;
                            }
                        }
                        else 
                        {
                            //Console.WriteLine(errorOfItteratiy);
                            answer1 = false;
                            answer2 = false;
                            answer3 = false;
                        } //Ошибка заморозки ячеек и их разморозка
                    }
                    
                } //проверка алгоритмом "memory"
                

                if (otvet1 == true && otvet2 == true && otvet3 == true) 
                {
                    count = 0;
                    Console.WriteLine("");
                    if (colichestvoItteraciy != 0)
                    {
                        Console.WriteLine("Готово. Все три цвета сгруппированы.");
                        Console.WriteLine("Получившаяся доска: ");
                        for (int d = 0; d < doska; d++)
                        {
                            for (int g = 0; g < doska; g++)
                            {
                                if (matrix[d, g] == 1)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                }
                                else if (matrix[d, g] == 2)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                else if (matrix[d, g] == 3)
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                Console.Write("{0} ", matrix[d, g]);
                                Console.ResetColor();
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("Количество переставлений: {0}", colichestvoItteraciy);
                        Console.WriteLine("Время выполнения программы (часы:минуты:секунды.миллисекунды) = {0}", golden.Elapsed);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Все три цвета и так уже сгруппированы. Введите другие расположения цветов");

                    }
                } //завершение программы

                //Console.WriteLine(errorOfItteratiy);
                if (count > 0) //index1, index2 = 0
                {
                    //Console.WriteLine("1 = {0}, 2 = {1}, 3 = {2}", Convert.ToString(answer1), Convert.ToString(answer2), Convert.ToString(answer3));
                    if (side == 1) //вниз
                    {
                        if (previosMove == 3)
                        {
                            output = false;
                            continue;
                        }
                        try
                        {
                            if (answer1 == true)
                            {
                                if (matrix[index1 - 1, index2] == 1)
                                {
                                    continue;
                                }
                            }
                            if (answer2 == true)
                            {
                                if (matrix[index1 - 1, index2] == 2)
                                {
                                    continue;
                                }
                            }
                            if (answer3 == true)
                            {
                                if (matrix[index1 - 1, index2] == 3)
                                {
                                    continue;
                                }
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            errorOfItteratiy = 0;
                            colichestvoItteraciy = colichestvoItteraciy + 1;
                            output = true;
                            previosMove = side;
                            float TMP = matrix[index1, index2];
                            matrix[index1, index2] = matrix[index1 - 1, index2];
                            matrix[index1 - 1, index2] = TMP;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            output = false;
                            continue;
                        }
                    }
                    else if (side == 2) //влево
                    {
                        if (previosMove == 4)
                        {
                            output = false;
                            continue;
                        }
                        try
                        {
                            if (answer1 == true)
                            {
                                if (matrix[index1, index2 - 1] == 1)
                                {
                                    continue;
                                }
                            }
                            if (answer2 == true)
                            {
                                if (matrix[index1, index2 - 1] == 2)
                                {
                                    continue;
                                }
                            }
                            if (answer3 == true)
                            {
                                if (matrix[index1, index2 - 1] == 3)
                                {
                                    continue;
                                }
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            errorOfItteratiy = 0;
                            colichestvoItteraciy = colichestvoItteraciy + 1;
                            output = true;
                            previosMove = side;
                            float TMP = matrix[index1, index2];
                            matrix[index1, index2] = matrix[index1, index2 - 1];
                            matrix[index1, index2 - 1] = TMP;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            output = false;
                            continue;
                        }
                    }
                    else if (side == 3) //вверх
                    {
                        if (previosMove == 1)
                        {
                            output = false;
                            continue;
                        }
                        try
                        {
                            if (answer1 == true)
                            {
                                if (matrix[index1 + 1, index2] == 1)
                                {
                                    continue;
                                }
                            }
                            if (answer2 == true)
                            {
                                if (matrix[index1 + 1, index2] == 2)
                                {
                                    continue;
                                }
                            }
                            if (answer3 == true)
                            {
                                if (matrix[index1 + 1, index2] == 3)
                                {
                                    continue;
                                }
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            errorOfItteratiy = 0;
                            colichestvoItteraciy = colichestvoItteraciy + 1;
                            output = true;
                            previosMove = side;
                            float TMP = matrix[index1, index2];
                            matrix[index1, index2] = matrix[index1 + 1, index2];
                            matrix[index1 + 1, index2] = TMP;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            output = false;
                            continue;
                        }
                    }
                    else if (side == 4) //вправо
                    {
                        if (previosMove == 2)
                        {
                            output = false;
                            continue;
                        }
                        try
                        {
                            if (answer1 == true)
                            {
                                if (matrix[index1, index2 + 1] == 1)
                                {
                                    continue;
                                }
                            }
                            if (answer2 == true)
                            {
                                if (matrix[index1, index2 + 1] == 2)
                                {
                                    continue;
                                }
                            }
                            if (answer3 == true)
                            {
                                if (matrix[index1, index2 + 1] == 3)
                                {
                                    continue;
                                }
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            errorOfItteratiy = 0;
                            colichestvoItteraciy = colichestvoItteraciy + 1;
                            output = true;
                            previosMove = side;
                            float TMP = matrix[index1, index2];
                            matrix[index1, index2] = matrix[index1, index2 + 1];
                            matrix[index1, index2 + 1] = TMP;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            output = false;
                            continue;
                        }
                    }
                } //движение (перестановка ячеек)
                
            }
            golden.Stop();
        }
        public static float[] Algoritm(float[,] matrix, int doska, float answer)
        {
            float[] algo = new float[2];
            algo[0] = 0;
            algo[1] = 0;
            string matrixbeta = "";
            string str = "";
            char[] spliter = { ';' };
            float hex = 0;
            try
            {
                string[] memory = File.ReadAllLines("memory.txt");
                foreach (string item in memory)
                {
                    str = str + item;
                }
            }
            catch (FileNotFoundException)
            {
                Error(0);
            }
            //Console.WriteLine(str.Length);
            if (str.Length != 1955) //Длина memory файла
            {
                //Console.WriteLine(str.Length);
                Error(str.Length);
            }
            string[] lines = str.Split(spliter);
            for (int i = 0; i < doska; i++)
            {
                for (int k = 0; k < doska; k++)
                {
                    if (matrix[i, k] != answer)
                    {
                        hex = 0;
                    }
                    else
                    {
                        hex = 1;
                    }
                    matrixbeta = matrixbeta + hex;
                }
            } //приведение matrix в бинарный вид
            for (int i = 0; i < 116; i++)
            {
                try
                {
                    if (matrixbeta == lines[i])
                    {                       
                        if (i == 0 || i == 3 || i == 7 || i == 10 || i == 13 || i == 14 || i == 17 || i == 18 || i == 21 || i == 31 || i == 34 || i == 37 || i == 38 || i == 39 || i == 40 || i == 51 || i == 53 || i == 54 || i == 55)
                        {
                            algo[1] = 1;
                        }
                        algo[0] = 1;
                        return algo;
                    }
                }
                catch (IndexOutOfRangeException)
                {

                    Error(i);
                }
            } //проверка matrix и memory
            return algo;
            
        }
        public static void Error(float error)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(4000, 600);
            Console.Beep(4000, 200);
            Console.Beep(4000, 200);
            Console.WriteLine("Ошибка. Файл 'memory.txt' поврежден!");
            Console.WriteLine("Номер ошибки: {0}", error);
            Console.ResetColor();
            Console.WriteLine("Завершение работы алгоритма...");
            Console.WriteLine("Для решения проблемы прочтите текстовый файл 'Инструкция по эксплуатации.txt'");
            Console.WriteLine("");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите ли Вы сами ввести расположение цветов на доске?");
            Console.WriteLine("да/д - да, надо указать конкретное расположение ячеек");
            Console.WriteLine("нет/н - нет, сгенерировать расположение цветов случайно");


            int doska = 4;
            bool metod = false;
            while (metod != true)
            {
                string answer = Console.ReadLine();
                if (answer == "Да" || answer == "да" || answer == "д" || answer == "Д")
                {
                    Console.Clear();
                    metod = true;
                    OutMassiv(doska);
                }
                else if (answer == "Нет" || answer == "нет" || answer == "н" || answer == "Н")
                {
                    Console.Clear();
                    metod = true;
                    Massiv(doska);
                }
                else
                {
                    Console.WriteLine("Это не 'да' или 'нет'");
                }
            }
            Console.ReadKey();
        }
    }
}
    
