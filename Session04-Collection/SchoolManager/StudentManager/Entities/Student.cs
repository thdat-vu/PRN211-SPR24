﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
            
        public double Gpa { get; set; }

        //Java @override
        //C#: override new 
        public override string ToString() => $"{Id} | {Name} | {Email} | {Yob} | {Gpa} |";
    }
}
