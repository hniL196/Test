﻿using System.Collections;
using Test;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main(string[] agrs)
    {
        //List<Student> ListStudent = new List<Student>();
        Hashtable students = new Hashtable();
        Student student = new Student();


        int choice = 0;
        Start:
        do
        {
            Console.WriteLine();
            ShowSelection();
            Console.Write("Option: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    student.AddStudent(students, student.MarkList);
                    break;
                case 2:
                    Console.WriteLine();
                    student.ShowStudent(students);
                    break;
                case 3:
                    Console.WriteLine();
                    student.Print(students);
                    break;
                case 4:
                    Console.WriteLine();
                    student.SearchStudent(students);
                    goto Start;
            }
        }
        while (choice >0 && choice < 5);
    }

    public static void ShowSelection()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("=====================================");
        Console.WriteLine("   1. Insert new student...");
        Console.WriteLine("   2. Display all the student list...");
        Console.WriteLine("   3. Calculator average mark...");
        Console.WriteLine("   4. Search for students.");
        Console.WriteLine("   5. Exit.");
        Console.WriteLine("=====================================");
    }
}