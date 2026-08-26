Persona persona1 = new Persona();
persona1.Name = "joazinho";

Persona persona2 = persona1;

persona2.Name = "pedrinho";

Console.WriteLine(persona1.Name);
Console.WriteLine(persona2.Name);

class Persona
{
    public string Name;
}

