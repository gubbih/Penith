﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Penith.ConcreteSubject;

namespace Penith.ConcreteObserver
{
    public class Student:IObserver // Concrete observer
    {
        private ISubject academy;


        private string message = "";

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string acaName;

        public string AcaName
        {
            get { return acaName; }
            set { acaName = value; }
        }

        public Student(ISubject academy, string name, string acaName)
        {
            this.academy = academy;
            this.name = name;
            this.acaName = acaName;
        }
        public Student(ISubject academy, string name)
        {
            this.academy = academy;
            this.name = name;
        }
        public void Update()
        {
            Academy thisAcadamy = academy as Academy;
            message = thisAcadamy.Message;
            acaName = thisAcadamy.Name;
            
            Console.WriteLine($"Studerende {name} modtog nyheden '{message}' fra akadamiet '{acaName}'");
        }
        




    }
}
