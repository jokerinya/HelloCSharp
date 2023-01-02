using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // works like a traffic controller or gateway
            Mediator mediator = new Mediator();
            Teacher teacher = new Teacher(mediator);
            Student john = new Student(mediator) { Name = "John" };
            Student carol = new Student(mediator) { Name = "Carol" };
            Student max = new Student(mediator) { Name = "Max" };
            // add teacher and students
            mediator.Teacher = teacher;
            mediator.Students = new List<Student> { john, carol, max };

            // teacher changed the slide
            teacher.SendNewImageUrl("slide1.img");

            // student asks a question
            john.AskQuestion("What is 3+5?");

            // Teacher answers question
            teacher.AnswerQuestion("8", john);

            Console.ReadLine();
        }
    }

    abstract class CourseMember
    {
        // reachable from inherited classes
        protected Mediator Mediator;

        public CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }

    }

    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine($"Teacher received question from {student.Name}, {question}");
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine($"Teacher changed slide: {url}");
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine($"Teacher answered to {student.Name}: {answer}");
            Mediator.SendAnswer(answer, student);
        }
    }

    class Student : CourseMember
    {
        public string Name { get; set; }

        public Student(Mediator mediator) : base(mediator)
        {
        }

        public void ReceiveImage(string url)
        {
            Console.WriteLine($"Student {Name} got new image url {url}");
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine($"Student {Name} got new answer {answer}");
        }

        public void AskQuestion(string question)
        {
            Console.WriteLine($"Student {Name} ask this question: {question}");
            Mediator.SendQuestion(question, this);
        }
    }
    // Works like a hub/router
    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.ReceiveImage(url);
            }
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher.ReceiveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer);
        }
    }
}
