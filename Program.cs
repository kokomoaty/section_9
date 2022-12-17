using System;
    namespace Program;
    abstract class Person{
                public string Name;
                public int Age;
                public Person(string name,int age){
                    Name=name;
                    Age=age;
                }
                public abstract void Print();
            }
    class Student:Person{
        public int Year;
        public float GPA;
        public Student(string name,int age,int year,float gpa):base(name,age){
            Year=year;
            GPA=gpa;
        }
        public override void Print(){
            Console.WriteLine("My name is " + Name + ", my age is " + Age + " and my gpa is " + GPA);
        }
    }
    class Staff:Person{
        public double Salary;
        public int JoinYear ;
        public Staff(string name , int age ,double salary , int joinyear):base(name,age){
            Salary=salary;
            JoinYear=joinyear;
        }
        public override void Print(){
            Console.WriteLine("My name is " + Name + ", my age is " + Age + " and my salary is " + Salary);
        }
    }
    class Database{
        int currentIndex=0;
        Person[] People=new Person[50];
        public void addStudnet(Student student){
            People[currentIndex++]=student;
            student.Print();
        }
        public void addStaff(Staff staff){
            People[currentIndex++]=staff;
            staff.Print();
        }
        public void printPeople(){
            for(int i=0;i<currentIndex;i++){
                People[i].Print();
            }
        }
    }
    class MainClass{
        public static void Main(){
            string name;
            int age,year,joinyear;
            float gpa;
            double salary;
            Database database=new Database();
            while(true){
            Console.WriteLine("choose 1 to 4 \n 1=>student \n 2=>staff \n 3=>printall");
            int key=Convert.ToInt32(Console.ReadLine());
            
            switch (key){
                case 1 :
                    Console.WriteLine("enter the studnet name: ");
                    name=Console.ReadLine();
                    Console.WriteLine("enter the studnet age: ");
                    age=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the studnet year: ");
                    year=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the studnet gpa: ");
                    gpa=float.Parse(Console.ReadLine());
                    Student student=new Student(name,age,year,gpa);
                    database.addStudnet(student);
                    break;
                case 2:
                    Console.WriteLine("enter the staff name: ");
                    name=Console.ReadLine();
                    Console.WriteLine("enter the staff age: ");
                    age=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the staff join year: ");
                    joinyear=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the staff salary: ");
                    salary=float.Parse(Console.ReadLine());
                    Staff staff=new Staff(name,age,salary,joinyear);
                    database.addStaff(staff);
                    break;
                case 3:
                    database.printPeople();
                    break;
                default:
                    Console.WriteLine("entered values is wrong");
                    break;
            }
        }
        }
    }
