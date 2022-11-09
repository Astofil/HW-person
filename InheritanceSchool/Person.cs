namespace sixteenthLesson.InheritanceScool;
public class Person
{
    public string name;
    public string address;
    public Person(string name,string address)
    {
        this.name=name;
        this.address=address;
    }
    public string GetName()
    {
        return name;
    }
    public string GetAddress()
    {
        return address;
    }
    public void SetAddress(string address)
    {
        this.address=address;
    }
    public override string ToString()
    {
        return address; // for a time
    }
}