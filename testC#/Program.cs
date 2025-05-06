/* ----------- 資料型態 & 變數 -----------
System.Console.WriteLine("Hello World!");

// 字串 string  "hello"
// 字元 char  'a'
// 整數 int  123
// 浮點數 float,double  123.45
// 布林值 bool  true / false

//

// 換行 \n
System.Console.WriteLine("\n換 \n行");

// 特殊字形 \",
System.Console.WriteLine("\"特殊字形\"");

// 字串相加 +
System.Console.WriteLine("字串相加" + "123");
// 較常用的方法
System.Console.WriteLine("字串{0}{1}", "相加", 123);
*/

/* ----------- 字串 string ----------- 

// 字串長度 .Length
string phrase = "字串長度567";
System.Console.WriteLine(phrase.Length);
System.Console.WriteLine("字串長度".Length);

// 字串轉換大寫 .ToUpper()
phrase = "hello world";
System.Console.WriteLine(phrase.ToUpper());

// 字串轉換小寫 .ToLower()
phrase = "HELLO WORLD";
System.Console.WriteLine(phrase.ToLower());

// 判斷字串內容 .Contains()
phrase = "hello world";
System.Console.WriteLine(phrase.Contains("world"));

// 回傳字串特定位置的植 []
System.Console.WriteLine(phrase[0]);

// 用值去尋找位置 IndexOf()
// 重複則回傳第一個位置
System.Console.WriteLine(phrase.IndexOf('h'));
// 尋找字串則回傳第一個位置
System.Console.WriteLine(phrase.IndexOf("world"));
// 尋找不存在的字串則回傳 -1
System.Console.WriteLine(phrase.IndexOf("www"));

// 取出字串的子字串,切割 .Substring(起始位置,長度)
System.Console.WriteLine(phrase.Substring(2));
System.Console.WriteLine(phrase.Substring(6, 5));
*/

/* ----------- 數字運算 -----------

// 整除 / 整數 = 整數
// 整除 / 浮點數 = 浮點數
System.Console.WriteLine(5 / 2); // 2
System.Console.WriteLine(5.0 / 2); // 2.5

// 絕對值 .Math.Abs(數字) or System.Math.Abs(數字)
System.Console.WriteLine(System.Math.Abs(-100));

// 次方 .Math.Pow(底數, 指數) or System.Math.Pow(底數, 指數)
System.Console.WriteLine(System.Math.Pow(2,3)); // 8

// 開根號 .Math.Sqrt(數字) or System.Math.Sqrt(數字)
System.Console.WriteLine(System.Math.Sqrt(16)); // 4

// 取最大值 .Math.Max(數字1, 數字2) or System.Math.Max(數字1, 數字2)
System.Console.WriteLine(System.Math.Max(2, 100));
// 取最小值 .Math.Min(數字1, 數字2) or System.Math.Min(數字1, 數字2)
System.Console.WriteLine(System.Math.Min(2, 100));

// 四捨五入 .Math.Round(數字) or System.Math.Round(數字)
// 銀行家捨入法 列：保留小數後兩位，則 5.214->5.21 , 5.216->5.22 , 5.215->5.22 , 5.225->5.22 5.2154->5.22
// 其中遇到5時，若前一位數字為偶數則捨去，若前一位數字為奇數則進位
// 而5後面還有數字則無條件進位
System.Console.WriteLine(System.Math.Round(4.4)); // 4
System.Console.WriteLine(System.Math.Round(4.5)); // 4
*/

/* ----------- 取得用戶輸入 -----------

// 取得用戶輸入 .Console.ReadLine()
// WriteLine() 會自動換行, Write() 不會換行
System.Console.Write("輸入出生西年年分：");
string birthday = System.Console.ReadLine();
System.Console.WriteLine("你出生於" + birthday + "年");
// 防止視窗立即關閉,使用 ReadKey() 等待用戶按下任意鍵 or ReadLine() 等待用戶輸入
System.Console.ReadKey(); // System.Console.ReadLine() 也可以
*/

/* ----------- 取得用戶輸入並轉換型態 -----------
// 使用 .ReadLine() 預設會取得字串型態
System.Console.Write("請輸入第一個數字：");
string firstNumber = System.Console.ReadLine();
System.Console.Write("請輸入第二個數字：");
string secondNumber = System.Console.ReadLine();
System.Console.WriteLine("兩數相加為 " + firstNumber + secondNumber);
System.Console.ReadKey();

// 轉換成整數型態 .Convert.ToInt32(字串) or System.Convert.ToInt32(字串)
// 如果 int firstNumber = Systen.Console.ReadLine(); 會報錯
// 因為 .ReadLine() 取得的型態是字串,而 int 不能直接轉換字串
System.Console.Write("請輸入第一個數字：");
int firstNumber1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("請輸入第二個數字：");
int secondNumber2 = System.Convert.ToInt32(System.Console.ReadLine());
// 兩數相加記得加上括號,否則會是字串相加
System.Console.WriteLine("兩數相加為 " + (firstNumber1 + secondNumber2));
System.Console.ReadKey();

// 轉換成浮點數型態 .Convert.ToDouble(字串) or System.Convert.ToDouble(字串)
System.Console.Write("請輸入第一個數字：");
double firstNumber3 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("請輸入第二個數字：");
double secondNumber4 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("兩數相加為 " + (firstNumber3 + secondNumber4));
System.Console.ReadKey();
 */

/* ----------- 陣列 array -----------

// 創建陣列 type[] name
// 直接賦予值
// type[] name = { value1, value2, value3, ... };
int[] scores = { 100, 90, 80, 70, 60 };

scores[0] = 99;
System.Console.WriteLine(scores[0]);
System.Console.WriteLine(scores[1]);
System.Console.WriteLine(scores[2]);
System.Console.WriteLine(scores[3]);
System.Console.WriteLine(scores[4]);
System.Console.ReadKey();

// 不直接賦予值
// type[] name = new type[數量];
string[] phones = new string[10];

phones[0] = "0912345678";
phones[1] = "0923456789";
System.Console.WriteLine(phones[0]);
System.Console.WriteLine(phones[1]);
System.Console.ReadKey();
*/

/* ----------- 判斷句 if ----------- 

// 且 &&
// 或 ||
// 非 !
// 不等於 !=
// 等於 ==
// 大於 >
// 小於 <
// 大於等於 >=
// 小於等於 <=

// if(判斷句)
// {
//     執行的程式碼
// }
// else if(判斷句)
// {
//     執行的程式碼
// }

bool girlfriend = false;
bool cool = true;
if (girlfriend)
{
    System.Console.WriteLine("有女朋友");
}
else if (girlfriend || cool)
{
    System.Console.WriteLine("不需要");
}
else
{
    System.Console.WriteLine("沒有女朋友");
}
System.Console.ReadKey();
*/

/* 計算問題

System.Console.Write("請輸入第一個數字：");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("請輸入要做的運算：");
string operation = System.Console.ReadLine();
System.Console.Write("請輸入第二個數字：");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());

if (operation == "+")
{
    System.Console.WriteLine("兩數相加為 " + (num1 + num2));
}
else if (operation == "-")
{
    System.Console.WriteLine("兩數相減為 " + (num1 - num2)); 
}
else if (operation == "*")
{
    System.Console.WriteLine("兩數相乘為 " + (num1 * num2));
}
else if (operation == "/")
{
    System.Console.WriteLine("兩數相除為 " + (num1 / num2));
}
else
{
    System.Console.WriteLine("運算符號錯誤");
}
System.Console.ReadKey();
*/

/* 迴圈while

// while(條件)
// {
//     執行的程式碼
// }
// 迴圈的條件為 true 時,就會一直執行
// 迴圈的條件為 false 時,就會跳出迴圈
// 迴圈的條件可以是任何的布林值,例如變數、運算式、方法等

int num = 0;
while( num < 10)
{
    num++;
    System.Console.WriteLine(num);
}
System.Console.ReadKey();

// do
// {
//     執行的程式碼
// } while(條件);
// do while 迴圈會先執行一次,然後再判斷條件
num = 5;
do
{
    System.Console.WriteLine(num);
    num++;
}
while (num < 10);
System.Console.ReadKey();
*/

/* 猜數字遊戲
int ans = 30;
int guess = 0;
int times = 3;
while((guess != ans) && (times > 0))
{
    System.Console.WriteLine("剩餘次數：" + times);
    System.Console.Write("請輸入一個數字：");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    if (guess == ans)
    {
        System.Console.WriteLine("猜對了");
    }
    else if (guess < ans)
    {
        System.Console.WriteLine("大一點");
        times--;
    }
    else
    {
        System.Console.WriteLine("小一點");
        times--;
    }
    if (times == 0)
    {
        System.Console.WriteLine("你輸了");
        break;
    }
}
System.Console.ReadKey();
*/

/* for 迴圈
// for(初始值; 條件; 遞增)
// {
//     執行的程式碼
// }
// 迴圈的條件為 true 時,就會一直執行
// 迴圈的條件為 false 時,就會跳出迴圈
// 迴圈的條件可以是任何的布林值,例如變數、運算式、方法等

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine("i = " + i);
}
System.Console.ReadKey();
int[] num = {10, 20, 30, 40, 50 };
for(int i = 0; i < num.Length; i++)
{
    System.Console.WriteLine("num[" + i + "] = " + num[i]);
}
System.Console.ReadKey();
*/


/* 二維陣列
// int[,] num = new int[row,cloumn];
// or
// int[,] num = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
// row 橫排 , column 直排
int[,] nums = {
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12}
};
System.Console.WriteLine(nums[0,3]);
System.Console.ReadKey();
// 傳回陣列的長度 .GetLength(dimension), 維度 <- dimension
System.Console.WriteLine("nums的總共數量：" + nums.Length);
System.Console.WriteLine("nums的row長度：" + nums.GetLength(0));
System.Console.WriteLine("nums的column長度：" + nums.GetLength(1));
System.Console.ReadKey();

// 多維陣列
// []內的,數量+1就是幾維陣列
// int[,,] num = new int[row,cloumn,depth];
// or
// int[,,] num = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
*/


/* 類別 class 、 物件 object

// 類別的定義 class
// 專案地方點擊右鍵,然後選擇新增->類別
// 需要在創建一個新的類別檔案,然後命名為 Person.cs
//class Person
//{
//    public double height;
//    public double weight;
//    public int age;
//    public string name;
//}

// 物件的定義 object
Person person1 = new Person();
person1.height = 165;
person1.weight = 70;
person1.age = 23;
person1.name = "Wang";
System.Console.WriteLine(person1.name);
Person person2 = new Person();
person2.age = 25;
person2.name = "Lee";

System.Console.ReadKey();
*/

/* namespace 、 using
// namespace 是用來區分不同的程式碼檔案,可以避免命名衝突
//namespace Animal
//{
//    class dog
//    {
//        public string name;
//        public int age;
//    }
//    class cat
//    {
//        publice string name;
//        public int age;
//    }
//}

//Animal.dog dog1 = new Animal.dog();
//dog1.name = "柯基";
//Animal.cat cat1 = new Animal.cat();
//cat1.name = "英短";
//System.Console.WriteLine(dog1.name);
//System.Console.WriteLine(cat1.name);
//System.Console.ReadKey();

// using 是用來引入命名空間,可以讓程式碼更簡潔
// using namespace
using Animal;
dog dog1 = new dog();
dog1.name = "柯基";
cat cat1 = new cat();
cat1.name = "英短";
System.Console.WriteLine(dog1.name);
System.Console.WriteLine(cat1.name);
System.Console.ReadKey();
//所以說我們可以使用
// using System;
// console.WriteLine("Hello World");
// 這樣就可以省略 System.這個命名空間

//其中namespace裡面可以在創建一個namespace
//namespace Animal
//{
//    namespace People
//    {
//        class Person
//        {
//            public double height;
//            public double weight;
//            public int age;
//            public string name;
//        }
//    }
//}
//using Animal.People;
//所以namespace 就跟資料夾一樣
*/

/* 方法 method
// public void 方法名稱(參數)
// {
//     執行的程式碼
// }
using System;
using Alive.People;
yellow person1 = new yellow();
person1.name = "XING";
person1.sayName();
person1.age = 20;
bool adult = person1.isAdult();
Console.WriteLine("是否成年：" + adult);
Console.WriteLine("計算a + b = " + person1.add(10, 100));
Console.ReadKey();
*/

/* Main方法
// Main方法是程式的進入點,當程式執行時,會從Main方法開始執行
// Main方法的定義
// static void Main(string[] args)
// {
//     // 執行的程式碼
// }

//class Program
//{
//    static void Main()
//    {
//    }
//}
*/

/* constructor 建構方法
// constructor 是一種特殊的方法,用來初始化物件的屬性
// constructor 的名稱必須與類別名稱相同,並且沒有回傳值
// constructor 可以有參數,也可以沒有參數
// constructor 可以重載,也就是可以有多個 constructor,但是參數必須不同
// constructor 會在物件創建時自動執行
// constructor 的使用
//class Person
//{
//    // constructor
//    public Person()
//    {
//         Console.WriteLine("創建成功");
//    }
//}
using System;
Constructor constructor1 = new Constructor("hi","Wang",23,71.1); // 創建成功
Console.WriteLine(constructor1.name); // Wang
Console.ReadKey();
*/

/* getter、setter
// getter 是用來取得物件的屬性值
// setter 是用來設定物件的屬性值
using System;

Video video1 = new Video("MS","Wang","哈");
Console.WriteLine(video1.Type);
Console.ReadKey();
*/

/* static attribute 靜態屬性
// 在class Video 裡面創建一個靜態屬性 count
// 靜態屬性是屬於class的,而不是屬於object的
using System;
Video video1 = new Video("MS", "Wang", "哈");
Video video2 = new Video("MM", "Lee", "娛樂");
Console.WriteLine(video1.Type);
// 這邊要用Video.count來呼叫靜態屬性
// 不能用video1.count
Console.WriteLine("創建幾個Video的object = " + Video.count);

// 也能使用此方式來獲取 static attribute的值
Console.WriteLine("使用GetCount()方法來獲取 static attribute的值 = " + video1.GetCount());

Console.ReadKey();
*/

/* static method 靜態方法 & static class 靜態類別
// static method是屬於class的,所以直接使用 className.method()來呼叫
// static class 是不能被實例化的,所以無法使用 className obj = new className()來創建物件

//// static class 
//static class Tool
//{
//    // static method
//    public static void Print(string str)
//    {
//        System.Console.WriteLine(str);
//    }
//}
//// Tool tool = new Tool(); // will error
//// 這裡不能用tool.Print("Hello"); 會報錯
//// 因為tool是物件,而Print是靜態方法,所以要用類別名稱來呼叫
//Tool.Print("Hello");
*/

// inheritance 繼承
// 當兩個class 的 attribute和 method 一樣時,可以使用繼承來簡化程式碼
//class Animal
//{
//    public string name;
//    public int age;
//    public void getName()
//    {
//        System.Console.WriteLine("Name = " + name);
//    }
//    public void getAge()
//    {
//        System.Console.WriteLine("Age = " + age);
//    }
//}
////此時Dog 繼承Animal
////Animal 內的attribute和method都可以使用
//class Dog : Animal
//{
//    //public string name;
//    //public int age;
//    public void bark()
//    {
//        System.Console.WriteLine("汪汪");
//    }
//}

Dog dog1 = new Dog("小白",10);
System.Console.WriteLine("dog1 name " + dog1.name);
System.Console.WriteLine("dog1 age " + dog1.age);
dog1.getName();
System.Console.ReadKey();

