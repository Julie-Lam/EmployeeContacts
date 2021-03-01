using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using TodoASMXService.Models;

namespace TodoASMXService.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _todoList;

        public TodoRepository()
        {
            InitializeData();
        }

        public IEnumerable<TodoItem> All
        {
            get { return _todoList; }
        }

        public bool DoesItemExist(string id)
        {
            return _todoList.Any(item => item.ID == id);
        }

        public TodoItem Find(string id)
        {
            return _todoList.Where(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(TodoItem item)
        {
            _todoList.Add(item);
        }

        public void Update(TodoItem item)
        {
            var todoItem = Find(item.ID);
            var index = _todoList.IndexOf(todoItem);
            _todoList.RemoveAt(index);
            _todoList.Insert(index, item);
        }

        public void Delete(string id)
        {
            _todoList.Remove(Find(id));
        }

        #region Helpers

        private void InitializeData()
        {
            _todoList = new List<TodoItem>();


            XmlDocument peopleDoc = new XmlDocument();
            var file = Path.Combine(HttpRuntime.AppDomainAppPath, "People.xml");
            peopleDoc.Load(file);
            XmlNode root = peopleDoc.LastChild;
            XmlNodeList people = root.SelectNodes("TodoItem");
            var peopleList = new List<TodoItem>();
            foreach (XmlNode n in people)
            {

                var person = new TodoItem
                {

                    ID = n.SelectSingleNode("@ID").InnerText,
                    Name = n.SelectSingleNode("Name").InnerText,
                    Phone = n.SelectSingleNode("Phone").InnerText,
                    Department = n.SelectSingleNode("Department").InnerText,
                    Street = n.SelectSingleNode("Street").InnerText,
                    City = n.SelectSingleNode("City").InnerText,
                    State = n.SelectSingleNode("State").InnerText,
                    ZIP = n.SelectSingleNode("ZIP").InnerText,
                    Country = n.SelectSingleNode("Country").InnerText,
                    //Address = n.SelectSingleNode("Address").InnerText,
                    
                    //Age = int.Parse(n.SelectSingleNode("Age").InnerText),
                    //AllowedToDrive = n.SelectSingleNode("AllowedToDrive").InnerText,
                    //Notes = n.SelectSingleNode("Notes").InnerText,
                    //Done = bool.Parse(n.SelectSingleNode("Done").InnerText)
                };
                peopleList.Add(person);
            }

            foreach (var person in peopleList) {
                var todoItem = new TodoItem
                {
                    ID = person.ID,
                    Name = person.Name,
                    Phone = person.Phone,
                    Department = person.Department,
                    Street = person.Street,
                    City = person.City,
                    State = person.State,
                    ZIP = person.ZIP,
                    Country = person.Country,
                };

                _todoList.Add(todoItem);

            }
            //var todoItem1 = new TodoItem
            //{
            //    ID = troopersList[0].ID,
            //    Name = troopersList[0].Name,
            //    Phone = troopersList[0].Phone,
            //    Department = troopersList[0].Department,
            //    Street = troopersList[0].Street,
            //    City = troopersList[0].City,
            //    State = troopersList[0].State,
            //    ZIP = troopersList[0].ZIP,
            //    Country = troopersList[0].Country,
            //    //Address = troopersList[0].Address,
 
            //    //Age = troopersList[0].Age,
            //    //AllowedToDrive = troopersList[0].AllowedToDrive,
            //    //Notes = troopersList[0].Notes,
            //    //Done = troopersList[0].Done
            //};

            //var todoItem2 = new TodoItem
            //{
            //    ID = troopersList[1].ID,
            //    Name = troopersList[1].Name,
            //    Phone = troopersList[1].Phone,
            //    Department = troopersList[1].Department,
            //    Street = troopersList[1].Street,
            //    City = troopersList[1].City,
            //    State = troopersList[1].State,
            //    ZIP = troopersList[1].ZIP,
            //    Country = troopersList[1].Country,
            //    //Address = troopersList[1].Address,
            //    //Age = troopersList[1].Age,
            //    //AllowedToDrive = troopersList[1].AllowedToDrive,
            //    //Notes = troopersList[1].Notes,
            //    //Done = troopersList[1].Done
            //};

            //var todoItem3 = new TodoItem
            //{
            //    ID = troopersList[2].ID,
            //    Name = troopersList[2].Name,
            //    Phone = troopersList[2].Phone,
            //    Department = troopersList[2].Department,
            //    Street = troopersList[2].Street,
            //    City = troopersList[2].City,
            //    State = troopersList[2].State,
            //    ZIP = troopersList[2].ZIP,
            //    Country = troopersList[2].Country,
            //    //Address = troopersList[2].Address,
            //    //Age = troopersList[2].Age,
            //    //AllowedToDrive = troopersList[2].AllowedToDrive,
            //    //Notes = troopersList[2].Notes,
            //    //Done = troopersList[2].Done
            //};
           

  /*          var todoItem3 = new TodoItem
            {
                ID = "ecfa6f80-3671-4911-aabe-63cc442c1ecf",
                Name = "Publish apps",
                Address = "25 Birthday Street",
                Age = 35,
                AllowedToDrive = "Yes",
                Notes = "All app stores",
                Done = false,
            }; */

            //_todoList.Add(todoItem1);
            //_todoList.Add(todoItem2);
            //_todoList.Add(todoItem3);
        }

        #endregion
    }
}
