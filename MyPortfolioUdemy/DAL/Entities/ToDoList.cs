using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioUdemy.DAL.Entities
{
    public class ToDoList
    {
        public int ToDoListID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
