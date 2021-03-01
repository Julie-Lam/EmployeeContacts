using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToDoItemAddedASMX
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            peopleXML.DocumentContent = File.ReadAllText(Server.MapPath("People.xml"));
            peopleXML.TransformSource = Server.MapPath("People.xslt");
        }
    }
}