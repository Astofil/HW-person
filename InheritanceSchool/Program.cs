// namespace sixteenthLesson.InheritanceScool;
using sixteenthLesson.InheritanceScool;

var person=new Person("Astofil","Firdavsi");

System.Console.WriteLine(person.GetName());
System.Console.WriteLine(person.GetAddress());

person.SetAddress(person.address);

System.Console.WriteLine(person.ToString());


System.Console.WriteLine("---------------------------------");
System.Console.WriteLine("---------------------------------");

var student=new Student("Muhammad", "amuja");

int Ngroup=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<Ngroup;i++)
{
    student.AddCourseGrade(Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
}

foreach (var item in student.courses)
{
    System.Console.WriteLine(item);
}
