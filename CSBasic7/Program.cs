﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Wanted<T>
    {
        public T Value;

        public Wanted(T value)
        {
            this.Value = value;
        }
    }
    class Student
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("스프링");
            Wanted<int> wantedInt = new Wanted<int>(3);
            Wanted<Student> wantedStudent = new Wanted<Student>(new Student());
        }
    }
}
