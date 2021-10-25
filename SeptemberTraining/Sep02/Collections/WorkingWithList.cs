using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class WorkingWithList
    {
        public void UnderstandingList()
        {
            List<int> MyList = new List<int>();
            MyList.Add(100);
            MyList.Add(200);
            MyList.Add(300);
            for (int i = 0; i < MyList.Count; i++)
            {
                MyList[i] = MyList[i] * 10;
            }
            MyList.Add(5000);
            Console.WriteLine("Starting List");
            foreach (int num  in MyList)
            {
                Console.Write(num + " ");
            }
            MyList.Remove(1000);
            Console.WriteLine("\nArray after deletion");
            foreach (int num in MyList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n5000 present in array?: "+MyList.Contains(5000));
            Console.WriteLine("4000 present in array?: " + MyList.Contains(4000));

        }
        public void UnderstandingSet()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Raja");
            names.Add("Raj");
            names.Add("durai");
            names.Add("max");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("\nAfter deleting");
            names.Remove("Raj");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("\n'Raja' present in array?: " + names.Contains("Raja"));
            Console.WriteLine("'Raj' present in array?: " + names.Contains("Raj"));
        }
        public void UnderstandingLinkedList()
        {
            LinkedList<float> Numbers = new LinkedList<float>();
            LinkedListNode<float> node = new LinkedListNode<float>(2.5f);
            Numbers.AddFirst(node);
            Numbers.AddAfter(node, 7.5f);
            Numbers.AddLast(10.0f);
            Numbers.AddAfter(node, 5.0f);
            foreach (float num in Numbers)
            {
                Console.Write(num + " ");
            }
        }
        public void WorkingWithDictnories()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(101, new Student(101, "Raja", 98.8f));
            students.Add(102, new Student(102, "Raj", 98.8f));
            students.Add(103, new Student(103, "Durai", 98.4f));
            foreach (int key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }
            Console.WriteLine("The name is present or not?" + students.ContainsValue(new Student(101, "Raja", 98.8f)));
        }
        public void EqualsObject()
        {
            Student s1 = new Student(101, "Raja", 98.8f);
            Student s2 = new Student(101, "Raja", 98.8f);
            if (s1 == s2)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Marks { get; set; }
        public Student()
        {

        }

        public Student(int id, string name, float marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
        public static bool operator ==(Student s1,Student s2)
        {
            if (s1.Id == s2.Id && s1.Name == s2.Name)
                return true;
            else
                return false;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            if (s1.Id == s2.Id && s1.Name == s2.Name)
                return false;
            else
                return true;
        }
        public override bool Equals(object obj)
        {
            Student s1, s2;
            s1 = this;
            s2 = (Student)obj;
            if (s1.Id == s2.Id && s1.Name == s2.Name)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return Id+" "+Name+" " + Marks + " ";
        }
    }
}
