using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IPrintEdition
{
    string Name { get; set; }
    string Type { get; set; }

    string About_Company();
    double Get_Price();
}
