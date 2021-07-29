using System;
using System.Collections.Generic;
using System.Linq;
using TodoTool.Interfaces;

namespace TodoTool.Model
{
    public class TodoList : IDisplayable
    {
        private readonly List<TodoListItem> _todoList;

        public TodoList()
        {
            _todoList = new List<TodoListItem>();
        }

        public void Add(string title, string description)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return;
            }

            _todoList.Add(new TodoListItem
            {
                ID = _todoList.Count + 1,
                Title = title,
                Description = description
            });
        }

        public void Remove(int id)
        {
            TodoListItem todoListItem = _todoList.FirstOrDefault(item => item.ID == id);

            if (todoListItem == null)
            {
                return;
            }

            _todoList.Remove(todoListItem);
        }

        public void UpdateStatus(int id, Status status)
        {
            TodoListItem todoListItem = _todoList.FirstOrDefault(item => item.ID == id);

            if (todoListItem == null)
            {
                return;
            }

            todoListItem.Status = status;
        }

        public void Display()
        {
            Console.WriteLine("This is my current todolist");
            foreach (TodoListItem todoListItem in _todoList)
            {
                todoListItem.Display();
            }
        }
    }
}
