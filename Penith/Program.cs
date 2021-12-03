using Penith.ConcreteObserver;
using Penith.ConcreteSubject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Penith // Note: actual namespace depends on the project name.
{
    public class Program
    {

        static void Main(string[] args)
        {
            Academy p = new Academy("UCL", "Seebladsgade");

            Student s1 = new Student(p, "Jens");
            Student s2 = new Student(p, "Niels");
            Student s3 = new Student(p, "Susan");

            p.MessageChanged += s1.Update;
            p.MessageChanged += s2.Update;
            p.MessageChanged += null;
            p.MessageChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.MessageChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            Console.ReadLine();
        }

        /*static void Main(string[] args)
        {

            var p = new Academy("UCL", "Seebladsgade");

            var s1 = new Student(p, "Jens");
            var s2 = new Student(p, "Niels");
            var s3 = new Student(p, "Susan");

            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            p.Message = "Så er der julefrokost!";

            p.Detach(s2);

            p.Message = "Så er der fredagsbar!";
        */
        /*Academy p = new Academy("UCL", "Seebladsgade");

        Student s1 = new Student(p, "Jens");
        Student s2 = new Student(p, "Niels");
        Student s3 = new Student(p, "Susan");

        p.Attach(s1);
        p.Attach(s2);
        p.Attach(s3);

        p.Message = "Så er der julefrokost!";

        p.Detach(s2);

        p.Message = "Så er der fredagsbar!";*/
    }

    /*static void Main(string[] args)

    {

        var p = new Academy("UCL");

        var s1 = new Student(p, "Jens");

        var s2 = new Student(p, "Niels");

        var s3 = new Student(p, "Susan");

        p.Attach(s1);

        p.Attach(s2);

        p.Attach(s3);

        p.Message = "Så er der julefrokost!";

        p.Detach(s2);

        p.Message = "Så er der fredagsbar!";

        Console.ReadLine();


    }*/
}
