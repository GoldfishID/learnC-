# C# 基礎練習

這份程式展示了 C# 基礎知識與語法範例，適合初學者在 GitHub 上做為自我複習與教學用。內容涵蓋資料型態、字串、數字運算、輸入輸出、陣列、流程控制、方法、類別與物件、Namespace、靜態成員、繼承等常見主題。

---

## 目錄

1. [環境與執行方式](#環境與執行方式)
2. [資料型態 & 變數](#資料型態--變數)
3. [字串 String](#字串-string)
4. [數字運算 Math](#數字運算-math)
5. [輸入與輸出 I/O](#輸入與輸出-io)
6. [陣列 Array](#陣列-array)
7. [流程控制 Control Flow](#流程控制-control-flow)

   * If / Else
   * While / Do-While
   * For
8. [方法 Method](#方法-method)
9. [類別 Class & 物件 Object](#類別-class--物件-object)
10. [Namespace 與 Using](#namespace-與-using)
11. [建構子 Constructor](#建構子-constructor)
12. [Getter & Setter](#getter--setter)
13. [靜態成員 Static](#靜態成員-static)
14. [繼承 Inheritance](#繼承-inheritance)

---

## 環境與執行方式

* .NET SDK 版本：`.NET 6+`
* 編譯與執行：

  ```bash
  dotnet new console -n CSharpBasics
  cd CSharpBasics
  # 將 Program.cs 覆蓋
  dotnet run
  ```

---

## 資料型態 & 變數

* 常見基本型態：

  * `string`, `char`, `int`, `float`, `double`, `bool`
* 範例：

  ```csharp
  string msg = "Hello World!";
  int n = 123;
  double pi = 3.14;
  bool isTrue = true;
  ```

---

## 字串 String

* 長度：`.Length`
* 大小寫轉換：`.ToUpper()`, `.ToLower()`
* 包含檢查：`.Contains()`
* 索引與搜尋：`phrase[0]`, `.IndexOf()`
* 擷取子字串：`.Substring(start, length)`

```csharp
string phrase = "hello world";
Console.WriteLine(phrase.Length);
Console.WriteLine(phrase.ToUpper());
Console.WriteLine(phrase.Contains("world"));
Console.WriteLine(phrase.Substring(6, 5));
```

---

## 數字運算 Math

* 四則運算、餘數、整除
* 常用方法：`Math.Abs()`, `Math.Pow()`, `Math.Sqrt()`, `Math.Max()`, `Math.Min()`, `Math.Round()`

```csharp
Console.WriteLine(Math.Pow(2, 3));  // 8
Console.WriteLine(Math.Sqrt(16));    // 4
Console.WriteLine(Math.Round(5.215));
```

---

## 輸入與輸出 I/O

* 讀取使用者輸入： `Console.ReadLine()`
* 顯示：`Console.Write()`, `Console.WriteLine()`
* 轉型：`Convert.ToInt32()`, `Convert.ToDouble()`

```csharp
Console.Write("輸入數字：");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("你輸入的是 " + x);
```

---

## 陣列 Array

* 一維與二維陣列宣告與存取

```csharp
int[] scores = { 100, 90, 80 };
Console.WriteLine(scores[0]);

int[,] grid = { {1,2}, {3,4} };
Console.WriteLine(grid[1,0]);
```

---

## 流程控制 Control Flow

### If / Else

```csharp
if (score >= 60) Console.WriteLine("及格");
else Console.WriteLine("不及格");
```

### While / Do-While

```csharp
int i = 0;
while (i < 5) { Console.WriteLine(i); i++; }
```

### For

```csharp
for (int i = 0; i < 5; i++)
    Console.WriteLine(i);
```

---

## 方法 Method

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

---

## 類別 Class & 物件 Object

```csharp
class Person { public string Name; public int Age; }

var p = new Person();
p.Name = "Alice";
Console.WriteLine(p.Name);
```

---

## Namespace 與 Using

* 用於組織程式碼、避免命名衝突
* `using System;`

```csharp
namespace MyApp {
  class Program { }
}
```

---

## 建構子 Constructor

```csharp
class Dog {
  public string Name;
  public Dog(string name) { Name = name; }
}
```

---

## Getter & Setter

```csharp
class Video {
  public string Title { get; set; }
}
```

---

## 靜態成員 Static

```csharp
class Counter {
  public static int Count;
}
Counter.Count++;
```

---

## 繼承 Inheritance

```csharp
class Animal { public void Eat() { } }
class Dog : Animal { public void Bark() { } }
```

---

## 進階練習

* 嘗試擴充上述範例，實作簡易計算機、猜數字遊戲、物件導向小專案。

---

歡迎在此基礎上，持續練習與擴展專案！
