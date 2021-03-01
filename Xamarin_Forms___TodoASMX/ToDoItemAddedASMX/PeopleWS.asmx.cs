using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Xml;

namespace ToDoItemAddedASMX
{
    /// <summary>
    /// Summary description for PeopleWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PeopleWS : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetPeople()
        {
            XmlDocument peopleDoc = new XmlDocument();
            var file = Path.Combine(HttpRuntime.AppDomainAppPath, "People.xml");
            peopleDoc.Load(file);
            XmlNode root = peopleDoc.LastChild;
            XmlNodeList people = root.SelectNodes("Person");
            var peopleList = new List<Person>();
            foreach (XmlNode n in people)
            {

                var per = new Person();

                per.Id = n.Attributes["Id"].Value;
                per.Name = n.SelectSingleNode("Name").InnerText;
                per.Phone = n.SelectSingleNode("Phone").InnerText;

                string actDepartment = "Unknown";
                if (int.Parse(n.SelectSingleNode("Department").InnerText) == 0)
                {
                    actDepartment = "General";
                }
                else if
                    (int.Parse(n.SelectSingleNode("Department").InnerText) == 1)
                {
                    actDepartment = "Information Technology";
                }
                else if (int.Parse(n.SelectSingleNode("Department").InnerText) == 2)
                {
                    actDepartment = "Accounting";
                }
                else if (int.Parse(n.SelectSingleNode("Department").InnerText) == 3)
                {
                    actDepartment = "Marketing";
                }
                else if (int.Parse(n.SelectSingleNode("Department").InnerText) == 4)
                {
                    actDepartment = "Human Resources";
                }
                else {
                    per.Department = n.SelectSingleNode("Department").InnerText;
                }
                per.Department = actDepartment;
                per.Street = n.SelectSingleNode("Address/Street").InnerText;
                per.City = n.SelectSingleNode("Address/City").InnerText;
                per.State = n.SelectSingleNode("Address/State").InnerText;
                per.ZIP = n.SelectSingleNode("Address/ZIP").InnerText;
                per.Country = n.SelectSingleNode("Address/Country").InnerText;

                peopleList.Add(per);
            }
            var result = new JavaScriptSerializer().Serialize(peopleList);
            //MAKE SURE YOU DISPLAY THE ATTRIBUTE AS AN ATTRIBUTE! -> XML format NOT json!! 
            Context.Response.Write(result);
        }

        [WebMethod]
        public void GetDepartments()
        {
            XmlDocument departmentsDoc = new XmlDocument();
            var file = Path.Combine(HttpRuntime.AppDomainAppPath, "Departments.xml");
            departmentsDoc.Load(file);
            XmlNode root = departmentsDoc.LastChild;
            XmlNodeList departments = root.SelectNodes("Department");
            var departmentsList = new List<Department>();
            
            foreach (XmlNode n in departments)
            {
                var dep = new Department();

                dep.Id = n.Attributes["ID"].Value;
                dep.Name = n.SelectSingleNode("Name").InnerText;

                departmentsList.Add(dep);

            }

        var result = new JavaScriptSerializer().Serialize(departmentsList);
        //MAKE SURE YOU DISPLAY THE ATTRIBUTE AS AN ATTRIBUTE! -> XML format NOT json!! 
        Context.Response.Write(result);

        }


            [WebMethod]
        public void EditPeople(string Id, string Name, string Phone, string Department, string Street, string City, string State, string ZIP, string Country)
        {
            String fileName = Path.Combine(HttpRuntime.AppDomainAppPath, "People.xml");
            XmlDocument peopleDoc = new XmlDocument();
            peopleDoc.Load(fileName);
            XmlNode root = peopleDoc.LastChild;
            XmlNodeList people = root.SelectNodes("Person");
            foreach (XmlNode n in people)
            {
                if ((n.SelectSingleNode("@Id").InnerText == Id) &&
                    (n.SelectSingleNode("Name").InnerText == Name))
                {

                    n.SelectSingleNode("Phone").InnerText = Phone;
                    n.SelectSingleNode("Department").InnerText = Department;
                    n.SelectSingleNode("Address/Street").InnerText = Street;
                    n.SelectSingleNode("Address/City").InnerText = City;
                    n.SelectSingleNode("Address/State").InnerText = State;
                    n.SelectSingleNode("Address/ZIP").InnerText = ZIP;
                    n.SelectSingleNode("Address/Country").InnerText = Country;
                }
            }
            peopleDoc.Save(fileName);

        }

        [WebMethod]
        public void AddPeople(string Name, string Phone, string Department, string Street, string City, string State, string ZIP, string Country)
        {

            String fileName = Path.Combine(HttpRuntime.AppDomainAppPath, "People.xml");
            XmlDocument peopleDoc = new XmlDocument();
            peopleDoc.Load(fileName);
            XmlNode root = peopleDoc.LastChild, nodeId, nodeName, nodePhone, nodeDepartment, nodeAddress, nodeStreet, nodeCity, nodeState, nodeZIP, nodeCountry;

            XmlNodeList peopleList = root.SelectNodes("Person");
            int id = peopleList.Count + 1; 
            XmlElement person = peopleDoc.CreateElement("Person");
            

            person.SetAttribute("Id", id.ToString()); 
            root.AppendChild(person);

            if (Name.Length > 0 && Phone.Length > 0 && Department.Length > 0 && Street.Length > 0 && City.Length > 0 && State.Length > 0 && ZIP.Length > 0 && Country.Length > 0)
            {

                //Look up how to create attribute!
                nodeName = peopleDoc.CreateElement("Name");
                nodeName.InnerText = Name;
                person.AppendChild(nodeName); 

                nodePhone = peopleDoc.CreateElement("Phone");
                nodePhone.InnerText = Phone;
                person.AppendChild(nodePhone);

                nodeDepartment = peopleDoc.CreateElement("Department");
                nodeDepartment.InnerText = Department;
                person.AppendChild(nodeDepartment);


                nodeAddress = peopleDoc.CreateElement("Address");
                person.AppendChild(nodeAddress);

                nodeStreet = peopleDoc.CreateElement("Street");
                nodeStreet.InnerText = Street;
                nodeAddress.AppendChild(nodeStreet);


                nodeCity = peopleDoc.CreateElement("City");
                nodeCity.InnerText = City;
                nodeAddress.AppendChild(nodeCity);


                nodeState = peopleDoc.CreateElement("State");
                nodeState.InnerText = State;
                nodeAddress.AppendChild(nodeState);


                nodeZIP = peopleDoc.CreateElement("ZIP");
                nodeZIP.InnerText = ZIP;
                nodeAddress.AppendChild(nodeZIP);


                nodeCountry = peopleDoc.CreateElement("Country");
                nodeCountry.InnerText = Country;
                nodeAddress.AppendChild(nodeCountry);

                peopleDoc.Save(fileName);
                Context.Response.StatusCode = 201;
                //Add the Id yourself!
            }

        }

        [WebMethod]
        public void DeletePeople(string Id, string Name)
        {
            String fileName = Path.Combine(HttpRuntime.AppDomainAppPath, "People.xml");
            XmlDocument peopleDoc = new XmlDocument();
            peopleDoc.Load(fileName);
            XmlNode root = peopleDoc.LastChild;
            XmlNodeList people = root.SelectNodes("Person");
            foreach (XmlNode n in people)
            {
                if ((n.SelectSingleNode("Name").InnerText == Name) &&
                    (n.Attributes["Id"].Value == Id))
                {
                    root.RemoveChild(n);
                }
            }
            peopleDoc.Save(fileName);

        }
    }
}
