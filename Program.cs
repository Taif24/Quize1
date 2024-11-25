using System;
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
}