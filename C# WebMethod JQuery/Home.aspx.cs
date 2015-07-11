using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static Employee testMethod(string ID, string Name) {
        
        Employee emp = new Employee
        {
            ID = shuffle(ID),
            Name = shuffle(Name)
        };
        return emp;
    }

    private static string shuffle(string arg) {
        Random rand = new Random();
        return new string(arg.ToCharArray().OrderBy(s => (rand.Next(2) % 2) == 0).ToArray());
    }
}

public class Employee {
    public string ID { get; set; }
    public string Name { get; set; }
}