using System.Xml.Linq;

namespace MotoApp1.Entities;

public class Manager : Employee
{
    public override string ToString() => base.ToString() + " (Manager)";
}