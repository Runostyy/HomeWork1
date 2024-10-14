using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Journal : PrintEdition, IPrintEdition
{
    private double price;

    public Journal(string name, string type, double price) : base(name, type)
    {
        this.price = price;
    }

    public string About_Company()
    {
        return "This is a journal company specializing in periodicals.";
    }

    public double Get_Price()
    {
        return price;
    }
}
