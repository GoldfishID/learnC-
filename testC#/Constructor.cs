using System;

// �ϥΩ�Program.cs������kconstructor
class Constructor
{
    public string name;
    public int age;
    public double height;

    // Constructor
    public Constructor(string say,string name, int a, double h)
    {
        // ��l���ݩ�
        // �p�G�ѼƦW�٩M�ݩʦW�٬ۦP�A�h�ݭn�ϥ�this����r�ӰϤ�
        this.name = name;
        age = a;
        height = h;
        Console.WriteLine("�Ыئ��\�Bsay = " + say);
    }
}

// �ϥΩ�Program.cs������kgetter�Bsetter �H�� static attribute �R�A�ݩ�
class Video
{
    public string title;
    public string author;
    //�u��b�o��class���ϥγo��type
    //����getter�Msetter���e�m�@�~
    private string type;

    // static �ݩ�
    // �ΨӰO���ЫشX���o��Video ����
    public static int count = 0; // �R�A�ݩ�

    public Video(string title,string author,string type)
    {
        this.title = title;
        this.author = author;
        // �o�̧令Type
        Type = type;

        // �C�Ыؤ@��Video����Acount�N�[1
        count++;
    }

    public int GetCount()
    {
        return count;
    }


    // �`�N�o�̭n�ϥ�getter�Msetter�A�ҥHType�᭱���঳()
    public string Type
    {
        //���H�ϥ�Video.type�ɡA�|�^��type����
        get { return type; }
        set{
            if(value == "�Ш|" || value == "����" || value == "��L")
            {
                type = value;
            }
            else
            {
                type = "��L";
            }
        }
    }
}

// �ϥΩ�inheritance �~��
// ����class �� attribute�M method �@�ˮ�,�i�H�ϥ��~�Ө�²�Ƶ{���X
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
//����Dog �~��Animal
//Animal ����attribute�Mmethod���i�H�ϥ�
class Dog : Animal
{
    //public string name;
    //public int age;
    public void bark()
    {
        System.Console.WriteLine("�L�L");
    }
    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}