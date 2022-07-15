internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 25: Напишите цикл, который принимает на вход два числа
        //(A и B) и возводит число A в натуральную степень B.
        void zadacha25()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" {number} в степени {number2} Равно {Grade(number, number2)}");

            int Grade(int number, int number2)
            {
                int grade1=1;
                for (int i =0; i < number2; i++)
                {

                    grade1 *= number;
                }
                return grade1;
            }
           
        }
        //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        void zadacha27()
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"сумма цифр в числе {number} равна {Findsum(number)}");

            int Findsum(int number)
            {
                int sum = 0;
                while (number>0)
                {
                    sum = number%10 + sum;
                    number=number/10;
                }
                return sum;
            }
        }
        //Задача 29: Напишите программу, которая задаёт массив 
        //из 8 случайных целых чисел и выводит отсортированный по модулю массив.
        void zadacha29()
        {
            int size = 8;
            int [] array = new int [size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-99, 100);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Вывод Массива:");
             for (int i = 0; i<array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            for ( int i = array.Length-1; i>0; i--)
            {
                for (int j =0; j<i; j++)
                {
                    if (Math.Abs(array[j]) > Math.Abs(array[j+1]))
                    {
                        int x = array[j];
                        array[j]=array[j+1];
                        array[j+1] = x;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Вывод отсортированного по модулю Массива:");
            for (int i = 0; i<array.Length; i++)
            {
            Console.Write(array[i] + "\t");
            }
        }
            
            
      //  }
        //zadacha25();
        //zadacha27();
        //zadacha29();
    }
}
