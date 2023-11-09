using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; set; }

        //int StudID, string StudName, string StudGender, int StudAge, string StudClass, float StudAvgMark
        public void Print(Hashtable students)
        {
            foreach (var key in students)
            {
                Console.WriteLine(key + ":" + students[key]);
            }
        }

        public int[] MarkList = new int[3];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < MarkList.Length)
                    return MarkList[index];
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < MarkList.Length)
                    MarkList[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public float CallAvg(int[] Marklist, float StudAvgMark)
        {
            Console.WriteLine("Input student Mark:");
            for (int i = 0; i < MarkList.Length; i++)
            {
                Console.WriteLine($"    Input mark {i}:");
                MarkList[i] = Convert.ToInt32(Console.ReadLine());
            }
            StudAvgMark = (MarkList[0] + MarkList[1] + MarkList[2]) / 3;

            return StudAvgMark;
        }

        public void AddStudent(Hashtable students, int[] MarkList)
        {
            Student student = new Student();

            Console.WriteLine("Input student ID: ");
            student.StudID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input student Name: ");
            student.StudName = Console.ReadLine();
            Console.WriteLine("Input student Gender: ");
            student.StudGender = Console.ReadLine();
            Console.WriteLine("Input student Age: ");
            student.StudAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input student Class: ");
            student.StudClass = Console.ReadLine();

            student.StudAvgMark = student.CallAvg(MarkList, StudAvgMark);

            students.Add(student.StudID, student.StudName + student.StudGender + student.StudAge + student.StudClass + student.StudAvgMark);
        }

        public void ShowStudent(Hashtable students)
        {
            Print(students);
        }

        public void SearchStudent(Hashtable students)
        {
            Console.WriteLine("1. Search By ID: ");
            Console.WriteLine("2. Search By Name: ");
            Console.WriteLine("3. Search By Class: ");
            Console.Write("Otion: ");

            int choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Nhap ID can tim: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    foreach (Hashtable student in students)
                        if (student.ContainsKey(id))
                            Console.WriteLine(student.Keys);
                    break;
                case 2:
                
                    break;
                case 3:

                    break;
            }
        }
    }
}
