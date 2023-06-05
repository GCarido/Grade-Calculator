using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator
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
            Application.Run(new Form1());
        }
    }
    class Student
    {
        private string fullname;
        private string idno;
        private string course;
        private string sub;

        public Student(string name)
        {
            this.FullName = name;
        }
        public string FullName
        {
            get { return this.fullname; }
            set { this.fullname = value; }
        }
        public string IdNo
        {
            get { return this.idno; }
            set { this.idno = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public string Subject
        {
            get { return this.sub; }
            set { this.sub = value; }
        }
        public string GetInfo()
        {
            return ("TEST");
        }
    }
}
