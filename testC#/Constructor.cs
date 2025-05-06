using System;

// 使用於Program.cs中的方法constructor
class Constructor
{
    public string name;
    public int age;
    public double height;

    // Constructor
    public Constructor(string say,string name, int a, double h)
    {
        // 初始化屬性
        // 如果參數名稱和屬性名稱相同，則需要使用this關鍵字來區分
        this.name = name;
        age = a;
        height = h;
        Console.WriteLine("創建成功且say = " + say);
    }
}

// 使用於Program.cs中的方法getter、setter 以及 static attribute 靜態屬性
class Video
{
    public string title;
    public string author;
    //只能在這個class中使用這個type
    //做為getter和setter的前置作業
    private string type;

    // static 屬性
    // 用來記錄創建幾次這個Video 物件
    public static int count = 0; // 靜態屬性

    public Video(string title,string author,string type)
    {
        this.title = title;
        this.author = author;
        // 這裡改成Type
        Type = type;

        // 每創建一次Video物件，count就加1
        count++;
    }

    public int GetCount()
    {
        return count;
    }


    // 注意這裡要使用getter和setter，所以Type後面不能有()
    public string Type
    {
        //當有人使用Video.type時，會回傳type的值
        get { return type; }
        set{
            if(value == "教育" || value == "音樂" || value == "其他")
            {
                type = value;
            }
            else
            {
                type = "其他";
            }
        }
    }
}

// 使用於inheritance 繼承
// 當兩個class 的 attribute和 method 一樣時,可以使用繼承來簡化程式碼
class Animal
{
    public string name;
    public int age;
    public void getName()
    {
        System.Console.WriteLine("Name = " + name);
    }
    public void getAge()
    {
        System.Console.WriteLine("Age = " + age);
    }
}
//此時Dog 繼承Animal
//Animal 內的attribute和method都可以使用
class Dog : Animal
{
    //public string name;
    //public int age;
    public void bark()
    {
        System.Console.WriteLine("汪汪");
    }
    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}