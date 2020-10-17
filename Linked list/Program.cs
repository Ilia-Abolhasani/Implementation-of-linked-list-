using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Linked_list
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);                       
            if (!File.Exists("project_data_Storage.txt"))
            {
                FileStream myfile;
                myfile=File.Create("project_data_Storage.txt");
                myfile.Close();
            }            
            StreamReader sr = new StreamReader("project_data_Storage.txt");
            if (!(sr.ReadLine() == "1"))
                Application.Run(new start_up());             
            sr.Close();
            Application.Run(new Form1());
            //LinkedList<int> A = new LinkedList<int>();
            //A.Add(3);
            //A.Add(3);
            //A.Add(3);
            //A.Add(3);
            //A.Add(1);
            //A.Add(3);
            //A.Add(10);
            //A.Add(4);
            //A.Add(1);
            //A.Add(3);
            //A.Add(3);
            //A.PrintAll();
            //A.Remove(3);
            //A.PrintAll();
        }
    }
}
