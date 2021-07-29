using TodoTool.Model;

namespace TodoTool
{
    class Program
    {
        static void Main()
        {
            var list = new TodoList();
            list.Add("Go to my c# class", "Take my book as well !");
            list.Add("Do shopping", "Buy eggs");
            list.Remove(1);
            list.Display();
        }
    }
}
