using sistem;
namespace selectores{

//selectores de acceso
//ejemplo
class Person
{
  private string name;
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
}
//propiedad de solo lectura
class Persona1
{
  private string name;
  public string Name
  {
    get { return name; }
  }
}

//propiedades autoimplementada
class Person{
  private string name(get; set;);
}

static void Main(string[] args)
{
  Person p = new Person();
  p.Name = "Bob";
  Console.WriteLine(p.Name);
  
}
}
