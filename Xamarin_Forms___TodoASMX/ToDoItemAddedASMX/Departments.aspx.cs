﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToDoItemAddedASMX
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            departmentsXML.DocumentContent = File.ReadAllText(Server.MapPath("Departments.xml"));
            departmentsXML.TransformSource = Server.MapPath("Departments.xslt");
        }
    }
}