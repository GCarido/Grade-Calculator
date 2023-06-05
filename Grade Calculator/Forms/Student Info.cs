using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Grade_Calculator.Forms
{
    public partial class studentinfo : Form
    {

        public static string FullName { get; set; }
        public static string IdNo { get; set; }
        public static string Course { get; set; }
        public static string Subject { get; set; }
        public studentinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void studentsubtn_Click(object sender, EventArgs e)
        {
            if (nameinpt.Text == "" || idinpt.Text == "" || 
                courseinpt.Text == "" || subinpt.Text == "")
                MessageBox.Show("All fields must be filled", 
                    "ALERT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                FullName = nameinpt.Text;
                IdNo = idinpt.Text;
                Course = courseinpt.Text;
                Subject = subinpt.Text;        
                MessageBox.Show("You have successfully entered all the required fields. " +
                    "User info is saved","Student Info Result",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void studentclearbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("All items will be cleared. Do you want to continue?",
                "ALERT",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                nameinpt.Text = "";
                idinpt.Text = "";
                courseinpt.Text = "";
                subinpt.Text = "";
            }

        }

        private void studentinfo_Load(object sender, EventArgs e)
        {
            nameinpt.Text = studentinfo.FullName;
            idinpt.Text = studentinfo.IdNo;
            courseinpt.Text = studentinfo.Course;
            subinpt.Text = studentinfo.Subject;
        }
    }
}
