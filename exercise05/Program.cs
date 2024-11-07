using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENQUYNHNAMPHUONG_31231027650_24C1INF50900503
{
    internal class session04
    {
        public static void Main()
        {
            //VD01()
            //gametaixiu();
            //Question_01();
            //Question_02();
            //Question_04a();
            //Question_04b();
            //Question_05();
            //Question_06();
            Console.ReadKey();
        }
        public static void VD_01()
        {
            int a = 6; int b = 7;
            Console.WriteLine($"Before call a = {a}, b = {b}");
            swap(ref a, ref b);
            Console.WriteLine($"After call a = {a}, b = {b}");
            Console.ReadKey();
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void gametaixiu()
        {
            Game_engine();
        }
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void playOneRound()
        {
            int comp_dice = rollDice();
            Console.WriteLine("Chao mung den voi Game Tai Xiu ><");
            Console.Write("Ban doan Tai hay Xiu? <T/X> ");
            string uesr_guessing = Console.ReadLine();
            if (uesr_guessing.ToUpper().Equals("T"))
            {
                if (comp_dice >= 10)//Tài
                    Console.WriteLine("You Win!");
                else
                    Console.WriteLine("You Lose!");
            }
            else if (uesr_guessing.ToUpper().Equals("X"))
            {
                if (comp_dice < 10)//Xỉu
                    Console.WriteLine("You Win!");
                else
                    Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("Vui long chon cho dung");
            }
        }
        static void Game_engine()
        {
            int count = 0;
            do
            {
                playOneRound();
                count++;
                Console.Write("Ban co muon choi tiep hong? <C/K> ");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Byeee! Mai choi tiep nha!");
                    Console.WriteLine($"Hom nay ban da choi {count} ban!");
                    break;
                }
            } while (true);
        }
        public static void Question_01()
        //tìm số lớn nhất trong ba số
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            FindMax(ref a, ref b, ref c, ref max);
            Console.WriteLine($"So lon nhat la {max}");
        }
        static void FindMax(ref int a, ref int b, ref int c, ref int max)
        {
            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else if (c > a && c > b)
            {
                max = c;
            }
        }
        public static void Question_02()
        //tính giai thừa của một số
        {
            Console.Write("Nhap so can tinh: ");
            int num = int.Parse(Console.ReadLine());
            long res = Factorial(num);
            Console.WriteLine($"Ket qua: {num}! = {res}");
        }
        static long Factorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (num == 0 || num == 1)
            {
                return 1;
            }
            long res = 1;
            for (int i = 2; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }
        public static void Question_03()
        //kiểm tra xem 1 số có phải số nguyên tố hay không
        {
            Console.Write("Nhap so can kiem tra (x > 1): ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine($"{num} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{num} khong phai la so nguyen to.");
            }
        }
        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++) // Kiểm tra ước của num từ 2 đến căn bậc hai của num
            {
                if (num % i == 0)
                {
                    return false; // Nếu tìm thấy ước của num, thì num không phải là số nguyên tố
                }
            }
            return true; // Nếu không tìm thấy ước nào, thì num là số nguyên tố
        }
        static void printPrimenumberUnderN(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                    Console.Write($" {i} ");
            }
        }
        public static void Question_04a()
        //Xuất ra các số nguyên tố đứng trước 1 số cho trước
        {
            Console.Write("Nhap so n = ");
            int n = int.Parse(Console.ReadLine());
            printPrimenumberUnderN(n);
        }
        static void printFirstNprimenumbers()
        {

        }
        public static void Question_04b()
        //xuất ra số nguyên tố đầu tiên
        {

            Console.Write("Nhap N so nguyen to can xuat: ");
            int N = int.Parse(Console.ReadLine());
            int so = 2;
            int dem = 0;
            while (dem < N)
            {
                if (IsPrime(so))
                {
                    Console.Write($" {so} ");
                    dem++;
                }
                so++;
            }
        }
        static bool IsPerfect(int num) //Hàm IsPerfect để kiểm tra
        {
            int sum = 1;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num; //hàm trả về true nếu sum = num
        }
        static void printPerfectNumbersLessthan1000()
        {
            Console.WriteLine("Cac so hoan hao nho hon 1000: ");
            for (int i = 0; i < 1000; i++)
            {
                if (IsPerfect(i))
                    Console.Write($" {i} ");
            }
        }
        public static void Question_05()
        {
            printPerfectNumbersLessthan1000();
        }
        static bool IsPangram(string input)
        {
            input = input.ToLower();
            return "abcdefghijklmnopqrstuvwxyz".All(input.Contains);
        }
        public static void Question_06()
        {
            Console.Write("Nhap chuoi can kiem tra: ");
            string teststring = Console.ReadLine();
            if (IsPangram(teststring))
                Console.WriteLine("Chuoi nay la Pangram");
            else
                Console.WriteLine("Chuoi nay khong phai la Pangram");
        }
    }
}
