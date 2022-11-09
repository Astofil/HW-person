namespace sixteenthLesson.InheritanceScool;
using sixteenthLesson.InheritanceScool;
public class Student : Person
{
    public int newCourses=0;
    public List<string> courses;
    public List<int> grades;
    public Student(string name,string address) : base(name,address)
    {
        var courses=new List<string>();
        var grades=new List<int>();
    }
    /*
    public override string ToString()
    {
        // return base.ToString();
        return name;
    }
    */
    public void AddCourseGrade(String course,int grade)
    {
        courses.Add(course);
        grades.Add(grade);
    }
    public void PrintGrades()
    {
        System.Console.WriteLine(grades);
    }
    public double GetAverageGrade()
    {
        int sum=0;
        foreach (var item in grades)
        {
            sum+=item;
        }
        return sum/grades.Count;
    }

    public override string ToString()
    {
        return address;
        // return base.ToString();
    }
}


