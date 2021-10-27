using System;

namespace _2610HomeWork
{
    class Program
    {

        static void Main(string[] args)
        {


            //1. Verilmis string deyerinde verilmis charin hansi indexde yerlesdiyini tapib qaytaran metod.
            //Misalcun metodu call edib "salam" ve 'l' deyerleri gondersek geriye 2 qaytarmalidir
            //amma char hemin stringde olmasa -1 qaytarmalidir.
            //string yazi ="salam";

            string yazi = "salam";
            char simvol = 'a';
            Console.WriteLine("//1-ci TAPSIRIQ ;");
            Symbol(yazi, simvol);

            //2. Verilmis ededin en yaxin asagi kokaltisini tapib qaytaran
            int eded = 77;
            Console.WriteLine("//2-ci TAPSIRIQ ;");
            Sqr(eded);
            //3. Verilmis ededin reqemleri cemini tapib qaytaran metod.
            int num = 278;
            int counter = 0;
            Console.WriteLine("//3-cu TAPSIRIQ ;");
            Sum(num, counter);
            //4. Verilmis indeger arrayinin icindeki en boyuk deyeri tapan metod
            int [] arr = { 32, 24, 64, 256, 21, 99, 97 };
            int max = arr [0];
            Console.WriteLine("//4-cu TAPSIRIQ ;");
            Largest(arr, max);
            //5.Verilmis integer arrayindeki butun elementleri musbet sekilder qaytaran metod.
            //Misalcun parametr olaraq {1,-4,9,-8} deyerleri olan array daxil edilse arqument kimi
            //metod bize {1,4,9,8} deyerleri olan array qaytarmalidir
            int[] numbers = { 5, -7, -13, 4, 16, -27 };
            Console.WriteLine("//5-ci TAPSIRIQ ;");
            Console.WriteLine("Ededlerin musbete cevrilmis formasi :");
            Positive(numbers);
        }


        static void Symbol(string yazi, char simvol)
        {
            bool sert = false;
            for (int i = 0; i < yazi.Length; i++)
            {
                if (yazi[i] == simvol)
                {
                    Console.WriteLine(i);
                    sert = true;
                    //ozum return etmedim ki eyni char bir nece indexde islenibse hamisini gostersin;
                }
            }
            if (sert == false)
            { Console.WriteLine($"{simvol} herfi {yazi} sozunde yoxdur."); }
          
        }
        static void Sqr(int eded)
        {
            for (int i = 1; i < eded; i++)
            {
                if (i * i > eded)
                {
                    Console.WriteLine($"{eded} ededinin en asagi kok altisi {i - 1}-dir.");
                    return;
                }
            }

        }
        static void Sum(int num, int counter)
        {
            while (num>0)
            {
                counter += num % 10;
                num = (num - counter) / 10;
            }
            Console.WriteLine($"Ededin reqemleri cemi {counter}-dir.");
        }
        static void Largest (int [] arr, int max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine($"Siyahidaki en boyuk eded {max}-dir.");

        }
        static void Positive (int [] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                { numbers[i] *= -1; }
                Console.WriteLine(numbers[i]);
            }
            
        }
    } 
}  
    

