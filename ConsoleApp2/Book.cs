using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book : PrintEdition, IPrintEdition
{
    private double price;

    public Book(string name, string type, double price) : base(name, type)
    {
        this.price = price;
    }

    public string About_Company()
    {
        return "This is a publishing house that specializes in books.";
    }

    public double Get_Price()
    {
        return price;
    }
}
