using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Crvenkapica", "Bila jednom jedna crvenkapica"));
            notebook.AddNote(new Note("Pale sam na svijetu", "Bio jednom jedan Pale sam na svijetu"));
            notebook.AddNote(new Note("Alisa u zemlji čudesa", "Bila jednom jedna Alisa u zemlji čudesa"));

            Iterator iterator = new Iterator(notebook);

            while(iterator.IsDone == false){
                iterator.Current.Show();
                iterator.Next();
            }
        }
    }
}
