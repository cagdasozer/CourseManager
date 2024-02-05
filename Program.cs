﻿using Intro.Busines;
using Intro.Entities;

Console.WriteLine("Hello, World!");

//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8 vs...";
//course1.Price = 10;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Java 17 vs...";
//course2.Price = 5;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12 vs...";
//course3.Price = 15;

//Course[] courses = {course1, course2, course3};

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / "+ courses[i].Price + "TL");
//}

Console.WriteLine(" ");

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price + "TL");
}