public class Program
{
    public static string SayHello()
    {
        return "Hello World!";
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(SayHello());
        // Menu chọn bài tập
        Console.WriteLine("1. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that noperation.\n2. Write a C# Sharp program to display certain values of the function x = y2+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).\n3. Write a C# Sharp program that takes distance and time (hours, minutes,seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).\n4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere. V =4/3*π*r3 \n5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.");
        Console.WriteLine("6.Write a C# Sharp program to check whether a given number is even or  odd.  \n7. Write a C# Sharp program to find the largest of three numbers. \n8. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.");
        Console.WriteLine("9. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene. \n10. Write a program to read 10 numbers and find their average and sum. \n11. Write a program to display the multiplication table of a given integer. \n12. Write a program to display a pattern like triangles with a number. The patterns like \n13. Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms \n14. Write a program to find the ‘perfect’ numbers within a given number range. \n15. Write a program to determine whether a given number is prime or not.");
        Console.WriteLine("Chon bai tap (1-15): ");
        int chon = Convert.ToInt32(Console.ReadLine());

        switch (chon)
        {
            case 1: ThucHienPhepToanHaiSo(); break;
            case 2: HienThiGiaTri(); break;
            case 3: KhoangCachVaThoiGian(); break;
            case 4: HinhCau(); break;
            case 5: KiemTraDuLieuDauVao(); break;
            case 6: ChanHayLe(); break;
            case 7: SoLonNhat(); break;
            case 8: HeTrucToaDo(); break;
            case 9: KiemTraTamGiac(); break;
            case 10: TrungBinhCong10So(); break;
            case 11: BangCuuChuong(); break;
            case 12: TamGiacSo(); break;
            case 13: DaySoDieuHoa(); break;
            case 14: PerfectNumbers(); break;
            case 15: SoNguyenTo(); break;
        }
        //Cau 1
        static void ThucHienPhepToanHaiSo()
        {
            Console.WriteLine("Nhap so dau tien: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap so tiep theo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            if (b != 0)
            {
                Console.WriteLine("a / b = " + (a / b));
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0");
            }
        }
        //Cau 2
        static void HienThiGiaTri()
        {
            for (int y = -5; y <= 5; y++)
            {
                Console.WriteLine("Gia tri y: " + y);
                Console.WriteLine("Gia tri x tuong ung: " + (y * y + 2 * y + 1));
            }
        }
        //Cau 3
        static void KhoangCachVaThoiGian()
        {
            Console.WriteLine("Nhap khoang cach (km): ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (gio): ");
            double hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (phut): ");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian (giay): ");
            double sec = double.Parse(Console.ReadLine());
            //Tinh thoi gian theo gio
            double time = hour + min / 60 + sec / 3600;
            //Tinh van toc
            Console.WriteLine("Toc do (km/h) = " + (s / time));
            Console.WriteLine("Toc do (miles/h) = " + ((s / 1.609f) / time));
        }
        //Cau 4
        static void HinhCau()
        {
            Console.WriteLine("Nhap ban kinh: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(" Dien tich hinh cau: " + (4 * Math.PI * r * r));
            Console.WriteLine("The tich hinh cau: " + ((4 / 3) * Math.PI * r * r * r));
        }
        //Cau 5
        static void KiemTraDuLieuDauVao()
        {
            Console.WriteLine("Nhap du lieu dau vao: ");
            char x = Convert.ToChar(Console.ReadLine());
            // vowel
            char lowerx = char.ToLower(x);
            if ((lowerx == 'a') || (lowerx == 'e') || (lowerx == 'u') || (lowerx == 'o') || (lowerx == 'i'))
            {
                Console.WriteLine("It is a vowel");
            }
            else if ((x >= '0') && (x <= '9'))
            {
                Console.WriteLine("It is a digit");
            }
            else
            {
                Console.WriteLine("It is another symbol");
            }
        }
        //Cau 6
        static void ChanHayLe()
        {
            Console.WriteLine("Nhap so: ");
            int a = int.Parse(Console.ReadLine());
            if (a / 2 == 0)
            {
                Console.WriteLine("The given number is even");
            }
            else
            {
                Console.WriteLine("The given number is odd");
            }
        }
        //Cau 7
        static void SoLonNhat()
        {
            Console.WriteLine("Nhap so dau tien: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine(a + " is the largest number");
            }
            else if (b >= c)
            {
                Console.WriteLine(b + " is the largest number");
            }
            else { Console.WriteLine(c + " is the largest number"); }
        }
        //Cau 8
        static void HeTrucToaDo()
        {
            Console.WriteLine("Nhap hoanh do x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tung do y: ");
            double y = double.Parse(Console.ReadLine());
            if ((x == 0) && (y == 0))
            {
                Console.WriteLine("Day la tam O cua he truc");
            }
            else if ((x > 0) && (y > 0))
            {
                Console.WriteLine("Diem thuoc goc phan tu I");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("Diem thuoc goc phan tu II");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("Diem thuoc goc phan tu III");
            }
            else
            {
                Console.WriteLine("Diem thuoc goc phan tu IV");
            }
        }
        //Cau 9
        static void KiemTraTamGiac()
        {
            Console.WriteLine("Nhap so do canh 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so do canh 2: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so do canh 3: ");
            double c = double.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Day la tam giac deu");
            }
            else if ((a == b) || (b == c) || (c == a))
            {
                Console.WriteLine("Day la tam giac can");
            }
            else
            {
                Console.WriteLine("Day la tam giac thuong");
            }
        }
        //Cau 10
        static void TrungBinhCong10So()
        {
            Console.WriteLine("Nhap lan luot 10 so: ");
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double a3 = double.Parse(Console.ReadLine());
            double a4 = double.Parse(Console.ReadLine());
            double a5 = double.Parse(Console.ReadLine());
            double a6 = double.Parse(Console.ReadLine());
            double a7 = double.Parse(Console.ReadLine());
            double a8 = double.Parse(Console.ReadLine());
            double a9 = double.Parse(Console.ReadLine());
            double a10 = double.Parse(Console.ReadLine());
            double answer = (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10) / 10.0;
            Console.WriteLine(answer);
        }
        //Cau 11
        static void BangCuuChuong()
        {
            Console.WriteLine("Nhap so nguyen can tinh bang cuu chuong: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
        //Cau 12
        static void TamGiacSo()
        {
            Console.WriteLine("Nhap so dong cua day so: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Dang 1:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Dang 2:");
            int num = 1;
            for (int m = 1; m <= rows; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Console.Write(num + " ");
                    ++num;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Dang 3:");
            int val = 1;
            for (int i = 1; i <= rows; i++)
            {
                // khoảng trống để căn phải (mỗi số cách nhau 1 space -> nhân đôi cho đẹp)
                Console.Write(new string(' ', (rows - i)));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val++;
                }
                Console.WriteLine();
            }
        }
        //Cau 13
        static void DaySoDieuHoa()
        {
            Console.WriteLine("Nhap so so hang: ");
            int n = int.Parse(Console.ReadLine());
            double answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer = answer + (1.0 / i);
            }
            Console.WriteLine("Tong day so dieu hoa la " + answer);
        }
        //Cau 14
        static void PerfectNumbers()
        {
            Console.Write("Nhap so bat dau: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhap so ket thuc: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cac so hoan hao trong khoang [{start}, {end}]:");

            for (int num = start; num <= end; num++)
            {
                if (IsPerfect(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
        // Hàm kiểm tra số hoàn hảo
        static bool IsPerfect(int number)
        {
            if (number < 2) return false; // 1 không phải số hoàn hảo

            int sum = 1; // 1 luôn là ước
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }
        //Cau 15
        static void SoNguyenTo()
        {
            Console.Write("Nhap so can kiem tra: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(n + " khong la so nguyen to");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            { Console.WriteLine(n + " la so nguyen to"); }
            else
            { Console.WriteLine(n + " khong la so nguyen to"); }
        }

    }

}