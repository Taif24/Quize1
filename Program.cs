﻿//Q1
/*using System;
class Student{
   public string Name;
   public int Age;
   public string Grade;
public Student(string name , int age , string grade){
    Name = name;
    Age = age;
    Grade = grade;
}
   public void DisplayInfo(){
    Console.WriteLine("Name: " +Name+ " , Age: " +Age+ " , Grade: "+Grade);
   } 
}
class Program{
    static void Main(string[] args){
        Student std1 = new Student("Taif", 21, "A+");
        Student std2 = new Student("Nouf", 25, "B");
        Student std3 = new Student("Lama", 18, "A");
        std1.DisplayInfo();
        std2.DisplayInfo();
        std3.DisplayInfo();

    }
}*/

//Q2
/*using System;
namespace Q2;
class Program2{
    static void Main(string[] args){
        int[] numbers = {2,3,4,6,7};
        foreach(int num in numbers){
            Console.WriteLine(num);
        }// I Couldn't Make the sum:(

    }
}*/
//Q3
class Program
{
    static void Main(string[] args){
        Console.WriteLine("Enter your Name: ");
        string name = Console.ReadLine();
        GetGreeting(name);
    }

    private static void GetGreeting(string name)
    {
        Console.WriteLine("Hello " +name);

    }
}