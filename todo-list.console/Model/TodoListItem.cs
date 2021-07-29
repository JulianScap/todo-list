using System;
using TodoTool.Interfaces;

namespace TodoTool.Model
{
    public class TodoListItem : IDisplayable
    {
        public TodoListItem()
        {
            CreationDate = DateTimeOffset.Now;
        }
        
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTimeOffset CreationDate { get; set; }

        public void Display()
        {
            Console.WriteLine($"{ID} - {Title} - {Description} - {Status}");
        }
    }
}
