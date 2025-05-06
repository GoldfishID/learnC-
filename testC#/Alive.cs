// 在Program.cs中的 方法Mmethod中用到
using System;
namespace Alive 
{
    namespace People
    {
        class yellow
        {
            public double height;
            public double weight;
            public string name;
            public int age;
            
            public void sayName()
            {
                Console.WriteLine("My name is " + name);
            }
            // 要回傳bool值，所以public bool
            public bool isAdult()
            {
                if (age >= 18)
                {
                    Console.WriteLine("I am an adult.");
                    return true;
                }
                else
                {
                    Console.WriteLine("I am not an adult.");
                    return false;
                }
            }

            public int add(int a,int b)
            {
                return (a + b);
            }
            
        }
    }
}