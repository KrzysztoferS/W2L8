using System;
using System.Security.Cryptography.X509Certificates;

namespace W2L8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            Task10();
        }

        public static void Task1()
        {
            byte startNumber = 0;
            byte endNumber = 100;

            byte numberOfPrimeNumbers=0;

            for(int i=startNumber ; i<=endNumber; i++)
            {
                if (i > 1)
                {
                    bool isPrimeNumber = true;
                    for (int z = 2; z <= Math.Round(Math.Sqrt(i),0); z++)
                    {
                        if (i % z == 0)
                        {
                            isPrimeNumber = false;
                            break;
                        }
                    }
                    if (isPrimeNumber)
                    {
                        numberOfPrimeNumbers++;
                        Console.Write(i + " ");
                    }
                }
            }

            Console.WriteLine($"W przedziale {startNumber} : {endNumber} jest {numberOfPrimeNumbers} liczb pierwszych ");
        }

        public static void Task2()
        {
            ushort minNumber = 0;
            ushort maxNumber = 1000;
            ushort currentNumber = minNumber;

            do
            {
                if (currentNumber % 2 == 0)
                {
                    Console.Write(currentNumber + " ");
                }
                currentNumber++;
            }while (currentNumber <= maxNumber) ;

            Console.WriteLine();
        }

        public static void Task3()
        {
            uint firstNumber = 0;
            uint secondNumber = 1;

            byte numberOfFibonacciElements = 19;

            Console.Write(firstNumber + " "+secondNumber+" ");

            for(byte i=1; i<numberOfFibonacciElements; i++)
            {
                uint currentElement = firstNumber + secondNumber;
                Console.Write(currentElement + " ");

                firstNumber = secondNumber;
                secondNumber = currentElement;
            }
            
        }

        public static void Task4()
        {
            uint maxNumber = 0;

            Console.WriteLine("Podaj liczbe elementów piramidy:");
            uint.TryParse(Console.ReadLine(), out maxNumber);

            byte piramidRow = 0;
            uint currentNumber = 0;

            while (currentNumber <= maxNumber)
            {
                for (uint i = 0; i < piramidRow; i++)
                {
                    currentNumber++;
                    Console.Write(currentNumber + "\t");
                    if (currentNumber >= maxNumber)
                        return;
                }
                Console.WriteLine();
                piramidRow++;
            }
        }

        public static void Task5()
        {
            ushort startNumber = 1;
            ushort endNumber = 20;

            for(ushort i=startNumber; i <= endNumber; i++)
            {
                Console.WriteLine($"{i}^3 = " + Math.Pow(i, 3));
            }
        }

        public static void Task6()
        {
            ushort startNumber = 0;
            ushort endNumber = 20;

            for(ushort i=startNumber; i <= endNumber; i++)
            {
                float sumOfNumbers = 0;
                for(ushort z = 1; z <= i; z++)
                {
                    sumOfNumbers += (1f / z);
                }
                Console.WriteLine($"Suma liczby {i} jest równa {sumOfNumbers}");
            }
        }

        public static void Task7()
        {
            byte width;
            Console.WriteLine("Podaj długość krótszej przekatnej od 1 do 255(najlepiej by była nie parzysta):");
            byte.TryParse(Console.ReadLine(), out width);

            if(width%2==0) { width++; }

            for(int i=0; i<=width; i++)
            {
                string singleLine="";
                int numberOfStars = 1;

                if (i < width / 2)
                {
                    numberOfStars = (2 * (i+1)) - 1;

                }
                else
                {
                    numberOfStars = width-(i-width/2)*2;
                }

                int numberOfSpaces = (width - numberOfStars) / 2;
                
                for(int z=0; z<numberOfSpaces; z++)
                {
                    singleLine += " ";
                }
                for(int z = 0; z < numberOfStars; z++)
                {
                    singleLine += "*";
                }
                Console.WriteLine(singleLine);
            }

        }

        public static void Task8()
        {
            Console.WriteLine("Wprowadz tekst a do wyświetlenia w odwrotnej kolejności");
            string input = Console.ReadLine();

            for(int i=input.Length-1; i>=0; i--)
            {
                Console.Write(input[i]);
            }
        }

        public static void Task9()
        {
            Console.WriteLine("Podaj liczbę calkowita:");
            int number;
            int.TryParse(Console.ReadLine(), out number);

            string binarNumber="";

            while (number > 0)
            {
                binarNumber += number % 2;
                number = number / 2;
            }

            for (int i = binarNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binarNumber[i]);
            }
        }

        public static void Task10()
        {
            Console.WriteLine("Podaj pierwsza liczbe:");
            int firstNumber;
            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Podaj drugą liczbę:");
            int secondNumber;
            int.TryParse(Console.ReadLine(), out secondNumber);

            int modulo;
            int nextToDivide;

            if (firstNumber > secondNumber)
            {
                modulo = firstNumber % secondNumber;
                nextToDivide = secondNumber;
            }
            else
            {
                modulo = secondNumber % firstNumber;
                nextToDivide = firstNumber;
            }

            
             while (modulo > 0)
            {
                int interimModulo = modulo;
                modulo= nextToDivide % modulo;
                nextToDivide = interimModulo;
            }

            Console.WriteLine($"Najmniejszym wspólnym dzielnikiem jest {nextToDivide}");
            Console.WriteLine("Najmniejszą wspólną wielokrotnością jest "+ (firstNumber * secondNumber)/ nextToDivide);

        }
    }

}
