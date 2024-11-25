//Q1
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
/*class Program
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
}*/
//Q4
/*class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if(num > 0 ){
            Console.WriteLine("Positive");
        }
        else if(num < 0){
            Console.WriteLine("Negative");
        }
        else if(num == 0){
            Console.WriteLine("Zero");
        }
    }
}*/
//Q5
/*class Program{
    static void Main(string[] args){
int[] numbers = new int[20];
for(int num = 1; num <= numbers.Length; num++){
    Console.WriteLine(num);
}
int num1 = 20;
while(num1 < 20){//I forget how to make the while loop:(

}

    }
}*/
//Q6
class Program{
    static void Main(string[] args){
        Car obj1 = new Car();
        obj1.Make = "Audi";
        obj1.Model = "Geman";
        obj1.Color = "Black";
        obj1.Year = 2020;
         Car obj2 = new Car();
        obj2.Make = "BMW";
        obj2.Model = "German";
        obj2.Color = "Red";
        obj2.Year = 2018;
         Car obj3 = new Car();
        obj3.Make = "Lexus";
        obj3.Model = "Jabanese";
        obj3.Color = "White";
        obj3.Year = 2024;
        obj1.DisplayDetails();
        obj2.DisplayDetails();
        obj3.DisplayDetails();
    }
}
class Car{
    public string Make {get; set;}
    public string Model {get; set;}
    public string Color {get; set;}
    public int Year {get; set;}

    public void DisplayDetails(){
        Console.WriteLine("Make: " +Make+ ", Model: "+Model+ ", Color: "+Color+", Year: "+Year);
    }
}