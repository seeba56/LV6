using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();
            ToDoItem toDo = new ToDoItem("Zadaci", "Treci", DateTime.Now.AddDays(1));

            careTaker.AddPreviousState(toDo.StoreState());
            Console.WriteLine(toDo.ToString());

            toDo.Rename("Novi zadaci");
            toDo.ChangeTask("Novi treci zadatak");
            Console.WriteLine(toDo.ToString());

            toDo.Rename("LV7");
            toDo.ChangeTask("Minimalno 2 zadatka");
            toDo.ChangeTimeDue(DateTime.Now.AddDays(7));
            Console.WriteLine(toDo.ToString());
        }
    }
}
