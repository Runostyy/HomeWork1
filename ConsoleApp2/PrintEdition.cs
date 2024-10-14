using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class PrintEdition
{
    public string Name { get; set; }
    public string Type { get; set; }

    public PrintEdition(string name, string type)
    {
        Name = name;
        Type = type;
    }
}
