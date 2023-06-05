using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //MySql Connection Library
using ClosedXML.Excel;   //Exporting and Reading Database to Excel format
namespace Grade_Calculator.Forms
{
    public partial class ComputedGrade : Form
    {
        public static string FinalType { get; set; }
        public static string MidType { get; set; }
        string dataInfo = "server=localhost;"
                          + "password=Admin1234-;"
                          + "user=root;"
                          + "database=gradecalc;"
                          + "port=3306;";
        MySqlConnection Sqlcon = new MySqlConnection();
        MySqlCommand Sqlcmd = new MySqlCommand();
        DataTable sqldt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter sqldta = new MySqlDataAdapter();
        MySqlDataReader sqlrd;
        DataSet ds = new DataSet();
        public ComputedGrade()
        {
            InitializeComponent();
        }
        private void UploadData()
        {
            Sqlcon.ConnectionString = dataInfo;
            Sqlcon.Open();
            Sqlcmd.Connection = Sqlcon;
            Sqlcmd.CommandText = "SELECT * FROM gradecalc.studentinfo " +
                "ORDER BY R0WS, Full_Name;";
            sqlrd = Sqlcmd.ExecuteReader();
            sqldt.Load(sqlrd);
            sqlrd.Close();
            Sqlcon.Close();
            dgv1.DataSource = sqldt;
            
        }



        private void ComputedGrade_Load(object sender, EventArgs e)
        {
            nameoutpt.Text = studentinfo.FullName;
            idoutpt.Text = studentinfo.IdNo;
            courseoutpt.Text = studentinfo.Course;
            suboutpt.Text = studentinfo.Subject;
            midwres1.Text = ($"{GradeCalculator.MidWeightAct}%");
            midwres2.Text = ($"{GradeCalculator.MidWeightQuiz}%");
            midwres3.Text = ($"{GradeCalculator.MidWeightExam}%");
            midwres4.Text = ($"{GradeCalculator.MidWeightAssignment}%");
            finalwres1.Text = ($"{GradeCalculator.FinalWeightAct}%");
            finalwres2.Text = ($"{GradeCalculator.FinalWeightQuiz}%");
            finalwres3.Text = ($"{GradeCalculator.FinalWeightExam}%");
            finalwres4.Text = ($"{GradeCalculator.FinalWeightMidPercent}%");
            finalwres5.Text = ($"{GradeCalculator.FinalWeightAssignment}%");
            midgraderes.Text = ($"{GradeCalculator.MidGrade.ToString("00.00")}%");
            finalgraderes.Text = ($"{GradeCalculator.FinalGrade.ToString("00.00")}%");
            UploadData();
        }

        private void nameoutpt_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
 

        private void compsub_Click(object sender, EventArgs e)
        {
            if (midwres1.Text == "%" )   //Bases for database confirmation
            {
                MessageBox.Show("CANNOT PERFORM ACTION. NO DATA RECORDED","ALERT",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("All items will be sent into the database. Do " +
                    "You Want to Continue?",
                    "ALERT", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == 
                    DialogResult.Yes)
                {
                    // Database
                    Sqlcon.ConnectionString = dataInfo;
                    Sqlcon.Open();
                    try
                    {
                        MidType = "Midterm";
                        sqlQuery = ($"INSERT INTO studentinfo(Full_Name, " +
                            $"Student_ID, Course, Subject_, Grade_Type, " +
                            $"Grade) VALUES('{nameoutpt.Text}', '{idoutpt.Text}', " +
                            $"'{courseoutpt.Text}', '{suboutpt.Text}', '{MidType}', " +
                            $"'{GradeCalculator.MidGrade.ToString("00.00")}');");
                        Sqlcmd = new MySqlCommand(sqlQuery,Sqlcon);
                        sqlrd = Sqlcmd.ExecuteReader();
                        Sqlcon.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Sqlcon.Close();
                    }
                    UploadData();
                }
                else { }
            }
        }

        private void compsubfinal_Click(object sender, EventArgs e)
        {
            if (finalwres1.Text == "%")   //Bases for database confirmation
            {
                MessageBox.Show("CANNOT PERFORM ACTION. NO DATA RECORDED", "ALERT", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("All items will be sent into the database. Do You Want " +
                    "to Continue?",
                    "ALERT", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == 
                    DialogResult.Yes)
                {
                    // Database
                    Sqlcon.ConnectionString = dataInfo;
                    Sqlcon.Open();
                    try
                    {
                        FinalType = "Final";
                        sqlQuery = ($"INSERT INTO studentinfo(Full_Name, " +
                            $"Student_ID, Course, Subject_, Grade_Type, " +
                            $"Grade) VALUES('{nameoutpt.Text}', '{idoutpt.Text}', " +
                            $"'{courseoutpt.Text}', '{suboutpt.Text}', '{FinalType}', " +
                            $"'{GradeCalculator.FinalGrade.ToString("00.00")}');");
                        Sqlcmd = new MySqlCommand(sqlQuery, Sqlcon);
                        sqlrd = Sqlcmd.ExecuteReader();
                        Sqlcon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Sqlcon.Close();
                    }
                    UploadData();
                }
                else { }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (updaterec.Text == "" || midgraderes.Text == "00.00%")
                { MessageBox.Show("Please enter the desired row number to modify " +
                    "and make sure that the midterm grade data is not empty.",
                    "ALERT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); }
                else
                {
                    if (MessageBox.Show("This row will be modified. Do You Want to Continue?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == 
                    DialogResult.Yes)
                    {
                        Sqlcon.ConnectionString = dataInfo;
                        Sqlcon.Open();
                        MySqlCommand sqlcmd = new MySqlCommand();
                        sqlcmd.Connection = Sqlcon;
                        sqlcmd.CommandText = "UPDATE gradecalc.studentinfo SET " +
                            "Full_Name = @Full_Name, Student_ID = @Student_ID, Course = " +
                            "@Course, Subject_ = @Subject_, Grade = @Grade WHERE R0WS = " +
                            "@R0WS;";
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.Parameters.AddWithValue("@R0WS", updaterec.Text);
                        sqlcmd.Parameters.AddWithValue("@Full_Name", nameoutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Student_ID", idoutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Course", courseoutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Subject_", suboutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Grade", 
                            GradeCalculator.MidGrade.ToString("00.00"));
                        sqlcmd.ExecuteNonQuery();
                        Sqlcon.Close();
                        UploadData();
                        updaterec.Text = "";
                    }
                    else { }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an existing row number " +
                    "to modify","Input Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                studentinfo.FullName = dgv1.SelectedRows[0].Cells[1].Value.ToString();
                studentinfo.IdNo = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                studentinfo.Course = dgv1.SelectedRows[0].Cells[3].Value.ToString();
                studentinfo.Subject = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                nameoutpt.Text = dgv1.SelectedRows[0].Cells[1].Value.ToString();
                idoutpt.Text = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                courseoutpt.Text = dgv1.SelectedRows[0].Cells[3].Value.ToString();
                suboutpt.Text = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                delrec.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                MessageBox.Show("The record has been selected. Click OK to continue.", 
                    "Record Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the left most column of " +
                    "the specific row you wish to select " +
                    "record.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (delrec.Text == "NONE")
                {
                    MessageBox.Show("Please Select the left most column of the " +
                        "specific row you wish to delete",
                      "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } 
                else
               {   
                    if (MessageBox.Show("This row will be modified. Do You Want to Continue?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == 
                    DialogResult.Yes)
                    {
                        Sqlcon.ConnectionString = dataInfo;
                        Sqlcon.Open();
                        MySqlCommand sqlcmd = new MySqlCommand();
                        sqlcmd.Connection = Sqlcon;
                        sqlcmd.CommandText = "DELETE FROM gradecalc.studentinfo " +
                            "WHERE R0WS = @R0WS;";
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.Parameters.AddWithValue("@R0WS", delrec.Text);
                        sqlcmd.ExecuteNonQuery();
                        Sqlcon.Close();
                        foreach (DataGridViewRow item in this.dgv1.SelectedRows)
                        {
                            dgv1.Rows.RemoveAt(item.Index);
                        }
                        UploadData();
                        delrec.Text = "";
                    }
                    else { }
                } 

            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an existing row number " +
                    "to modify", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updelrow_Click(object sender, EventArgs e)
        { 

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (updaterec2.Text == "" || finalgraderes.Text == "00.00%")
                {
                    MessageBox.Show("Please enter the desired row number to modify " +
                        "and make sure that the final grade data is not empty.",
                      "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("This row will be modified. Do You Want to Continue?",
                    "ALERT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == 
                    DialogResult.Yes)
                    {
                        Sqlcon.ConnectionString = dataInfo;
                        Sqlcon.Open();
                        MySqlCommand sqlcmd = new MySqlCommand();
                        sqlcmd.Connection = Sqlcon;
                        sqlcmd.CommandText = "UPDATE gradecalc.studentinfo SET " +
                            "Full_Name = @Full_Name, Student_ID = @Student_ID, Course = " +
                            "@Course, Subject_ = @Subject_, Grade = @Grade WHERE R0WS = " +
                            "@R0WS;";
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.Parameters.AddWithValue("@R0WS", updaterec2.Text);
                        sqlcmd.Parameters.AddWithValue("@Full_Name", nameoutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Student_ID", idoutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Course", courseoutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Subject_", suboutpt.Text);
                        sqlcmd.Parameters.AddWithValue("@Grade", 
                            GradeCalculator.FinalGrade.ToString("00.00"));
                        sqlcmd.ExecuteNonQuery();
                        Sqlcon.Close();
                        UploadData();
                        updaterec2.Text = "";
                    }
                    else { }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an existing row number " +
                    "to modify", "Input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed)
                {
                    Sqlcon.ConnectionString = dataInfo;
                    Sqlcon.Open();
                }
                using (DataTable dtable = new DataTable("Student_ID"))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM " +
                        "gradecalc.studentinfo WHERE Student_ID = @Student_ID OR Full_Name " +
                        "LIKE @Full_Name OR Grade_Type LIKE @Grade_Type OR Subject_ LIKE " +
                        "@Subject_ OR Course LIKE @Course ORDER BY R0WS, Full_Name;", Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("Student_ID", searchtext.Text);
                        cmd.Parameters.AddWithValue("Full_Name", string.Format("%{0}%", 
                            searchtext.Text));
                        cmd.Parameters.AddWithValue("Grade_Type", searchtext.Text);
                        cmd.Parameters.AddWithValue("Subject_", string.Format("%{0}%", 
                            searchtext.Text));
                        cmd.Parameters.AddWithValue("Course", string.Format("%{0}%", 
                            searchtext.Text));
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dtable);
                        dgv1.DataSource = dtable;

                    }

                }

            }
            catch (Exception ex)
            { }
        }

        private void exportbtn1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "Excel " +
                "Workbook|*.xlsx" })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (DataTable dtable = new DataTable("Student Grades"))
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(this.sqldt);
                                wb.SaveAs(save.FileName);
                            }
                        }
                        MessageBox.Show("You have successfully exported the " +
                            "database table", "NOTICE",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    { 
                        
                    }
                }
            }
        }
    }
}

