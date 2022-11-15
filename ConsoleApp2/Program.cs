
//static void number()
//{
//    string numStr = Console.ReadLine();
//    int num = Convert.ToInt32(numStr);
//    int add = numStr.Length;
//    int adder = 3;
//    for (int i = 1; i <= add; i++)
//    {
//        adder = adder * 10;
//    }
//    int sum = num + adder;
//    Console.WriteLine(sum);
//}
//number();
//static void Show(int num)

//{
//    string numStr = Console.ReadLine();
//    int num1 = Convert.ToInt32(numStr);
//    Console.WriteLine("eded teyin edin");

//    for (int i = 1; i <= num1; i *= 10)
//    {
//        num = i;

//    }
//    if (num1 == 0)
//    {
//        int rent = 3 * 10;
//        Console.WriteLine(rent);
//        return;
//    }
//    num *= 10;
//    int rent1 = 3 * num + num1;
//    Console.WriteLine(rent1);



//}
//Show(default);
 static int Show(int num,int num2,int num3)
{
    num = num + (num2 * num3);
    return num;
}
int num = Show(529,1000,3);
Console.WriteLine(num);

