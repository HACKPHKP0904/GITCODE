// Chương trình C# để giải bài tập tìm tổng hai số , tích 2 số ,hiệu 2 số 
using System.Text;

Console.OutputEncoding = Encoding.UTF8; // tiếng việt
Console.WriteLine("Bài Tập");

//khai báo biến 
double a;
double b;

//Thực hiện nhập số
Console.WriteLine("Mời bạn nhập số a :");
a = float.Parse(Console.ReadLine());  // đổi kiểu chuỗi sang số

Console.WriteLine("Mời bạn nhấp số b: ");
b = float.Parse(Console.ReadLine());  

//thực hiện phép tính 
Console.WriteLine("Tổng của {0} + {1} = {2}",a,b,a+b);


Console.WriteLine("Hiệu của {0} + {1} = {2}",a,b,a-b);


Console.WriteLine("Tích của {0} * {1} = {2}",a,b,a*b);

Console.WriteLine("-----------------------------------------");

Console.WriteLine("Bài tập giải phương trình");

var x = -b / a;
Console.WriteLine("Phương trình bậc nhất {0}*x +{1} = 0 --> x = {2}", a, b, x);

//

    Console.WriteLine("Nhập số c vào :");
double  c = double.Parse(Console.ReadLine());
double pheptinh2 = a * c;
double pheptinh1 = b * b;
double delta = pheptinh1 - 4 * pheptinh2;

if (delta >0)
{
    Console.WriteLine("Phương trình bậc 2 có 2 ẩn ");
    // tính căn delta
    delta = Math.Sqrt(delta);
    double x1 = -b + delta / 2 * a;
    double x2 = -b - delta / 2 * a;
    Console.WriteLine("x1 = (-b + căn delta)/2a");
    Console.WriteLine("Giá trị của x1 = {0}",x1);
    Console.WriteLine("x2 = (-b - căn delta)/2a");
    Console.WriteLine("Giá trị của x2 ={0}",x2);
}
else if(delta == 0)
{
    double x3 = -b / 2 * a;
    Console.WriteLine("Phương trình bậc nhất có 1 nghiệm kép");
    Console.WriteLine("Nghiệm kép x= -b/2a");
    Console.WriteLine("x ={0}",x3);
}
else
{
    Console.WriteLine("Phương trình vô nghiệm ");
}


Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Bài tập đổi C thành K và độ ");

// khai báo biến
int C;

// thực hiện input
Console.WriteLine("Nhập số C =");
C = int.Parse(Console.ReadLine());

//phép đổi 
double K = 1 * C + 273;
Console.WriteLine("Từ độ C sang độ K ={0}", K);

double F = 1 * 18 / 10 + 32;
Console.WriteLine("Từ độ C sang độ F ={0}",F);

//Bài tập tính giai thừa
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("Bài tập tính giai thừa của 1 số");

int d;
Console.WriteLine("Nhập vào số d");
d = int.Parse(Console.ReadLine()); 
float h = 1;
for (int i = 0;i<d;i++)
{
     h = h + h*i ;
}
Console.WriteLine("Giai thừa của {0} = {1}",d,h);

// bài tập liệt kê tất cả các số nguyên tố trong n 
// số nguyên tố là số lớn hơn 1 và nó chia hết cho 1 và chính nó
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Bài tập liệt kê số nguyên tốt trong n");

int n;
Console.WriteLine("Mời bạn nhập vào số n :");
n = int.Parse(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine("Các số nguyên tốt từ 1 đến {0}", n);
    for (int i = 2; i < n; i++) // cho i chạy từ 2 để so sánh dạy số
    {
        bool value = true; // 
        for (int j = 2; j < i; j++)
        {
            if(i%j ==0)
            {

            value = false;
            break;
            }
        }
        if (value)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    Console.WriteLine("Không được nhập số bé hơn 0 ");
}


//bài tập kiểm tra số chẵn hay số lẻ

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Bài tập kiểm tra số chẵn hay số lẻ");

int e;
Console.WriteLine("Mời bạn nhập số e :");
e = int.Parse(Console.ReadLine());  
if (e > 0)
{
    if(e % 2 == 0)
    {
        Console.WriteLine("Số {0} là số chẵn",e);
    }
    else
    {
        Console.WriteLine("Số {0} là số lẻ", e);
    }
}
else
{
    Console.WriteLine("Bạn nhập số nhỏ hơn 0 ");
}

// bài tập kiểm tra 1 số có là số nguyên tố không ? 

Console.WriteLine("------------------------------------");
Console.WriteLine("Bài tập kiểm tra 1 số có là số nguyên tố không ?");

int f;
Console.WriteLine("Mời bạn nhập số f :");
f = int.Parse(Console.ReadLine());
if (f > 0)
{
   if ( f % 1 ==0 && f % f ==0)
    {
        Console.WriteLine("{0} số nguyên tố",f);
    }else
        {
        Console.WriteLine("{0} không là số nguyên tố", f);
    }
}
else
{
    Console.WriteLine("Bạn nhập số bé hơn 0 ");
}