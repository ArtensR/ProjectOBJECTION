using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client perviy = new Client();
            perviy.name = "Vanya";
            perviy.age = 242;
            perviy.number = "5235235235";
            perviy.Print();
        }
    }
}
class Client
{
    public string name = "Undefined";
    public int age;
    public string gender;;
    public string number;
    
    public void Print()
    {
        Console.WriteLine("Client: {0},{1},{2}", name, age, number);
        Console.ReadKey();
    }
}

class lawyer
{
    public string name;
    public int ID;
}
class law__case 
{
    public int Name;
    public int ID;
    public int lawyerID;
    public int time;
    
}
class booking_consultation
{
    public int time;
    public string client_name;
    

}
class bill
{
    public int money;
    public int time;
}