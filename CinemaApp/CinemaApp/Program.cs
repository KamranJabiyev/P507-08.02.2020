using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Hall code = new Hall(4, 3);
            //Hall code1 = new Hall(5, 4);


            //code.GetAllSeat();

            //code.Reserve(1, 2);
            //code.Reserve(1, 2);

            //Cinema cnm1 = new Cinema("CinemaPlus", 1);
            //cnm1.AddHall(code);
            //cnm1.AddHall(code1);
            #endregion

            #region Indexer
            //Group p507 = new Group("P507");
            //Student stu = new Student("Mubush", "Memmedzade");

            //p507[0] = stu;

            //p507[1] = new Student("Javid","Asadullayev");

            //Console.WriteLine(p507[0]);
            //Console.WriteLine(p507[101]);
            #endregion

            #region Nullable value type
            //int? a = 5;
            //char? letter = 'b';
            //bool? isMaried = null;

            //a = null;
            //letter = null;
            #endregion

            #region Extention
            string name = "Mubariz";
            //Console.WriteLine(name.Contains("a"));
            //Console.WriteLine(myContains(name, 't')); 
            Console.WriteLine(name.myContains('t'));
            int x = 77;
            Console.WriteLine(x.IsOdd());
            #endregion
        }

        //static bool myContains(string word, char a)
        //{
        //    for (int i=0; i<word.Length; i++)
        //    {
        //        if (word[i] == a)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}


    }

    #region Indexer
    //class Group
    //{
    //    public string Name { get; set; }

    //    private Student[] students;

    //    public Student this[int i]
    //    {
    //        get
    //        {
    //            return students[i];
    //        }
    //        set
    //        {
    //            students[i] = value;
    //        }
    //    }

    //    public Group(string name)
    //    {
    //        students = new Student[100];
    //        Name = name;
    //    }
    //}

    //class Student
    //{
    //    public string Name { get; set; }

    //    public string Surname { get; set; }
    //    public Student(string name,string surname)
    //    {
    //        Name = name;
    //        Surname = surname;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} {Surname}";
    //    }
    //}
    #endregion
}
