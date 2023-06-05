using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; //Library for the Panel Drag
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //Library for button icons from the website FontAwesome

namespace Grade_Calculator
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form lblbarform;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form Configuration

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
         
        private struct MORECOLORS
        {
            // Choosing what Color for Buttons when Clicked
           public static Color c1 = Color.FromArgb(0, 247, 1);
           public static Color c2 = Color.FromArgb(202, 81, 0);
           public static Color c3 = Color.FromArgb(225, 202, 164);
           public static Color c4 = Color.FromArgb(247, 231, 0);
           public static Color c5 = Color.FromArgb(247, 192, 186);
           public static Color c6 = Color.FromArgb(106, 141, 150);
        }
        
        //METHODS FOR THE INTERFACE

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Title Bar Panel Codes

                iconPicbar.IconChar = currentBtn.IconChar;
                iconPicbar.IconColor = color;
 
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(135, 206, 250);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.DarkBlue;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ChildForm(Form cform)
        {
            if(lblbarform != null)
            {
                lblbarform.Close();
            }
            lblbarform = cform;
            cform.TopLevel = false;
            cform.FormBorderStyle = FormBorderStyle.None;
            cform.Dock = DockStyle.Fill;
            panelDesk.Controls.Add(cform);
            panelDesk.Tag = cform;
            cform.BringToFront();
            cform.Show();
            lblpicBar.Text = cform.Text; //Shows the label text in the title bar
        }
      
        private void studentinf_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, MORECOLORS.c3);
            ChildForm(new Forms.studentinfo());
        }

        private void calctab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, MORECOLORS.c2);
            ChildForm(new Forms.GradeCalculator());
        }

        private void comptab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, MORECOLORS.c1);
            ChildForm(new Forms.ComputedGrade());
        }

        private void calendartab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, MORECOLORS.c4);
            ChildForm(new Forms.Calendar());
        }

        private void logotab_Click(object sender, EventArgs e)
        {
            try
            {
                lblbarform.Close();
                Reset();
            }
            catch (NullReferenceException ex)
            {}
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPicbar.IconChar = IconChar.Home;
            iconPicbar.IconColor = Color.FromArgb(247, 247, 0);
            lblpicBar.Text = "Home";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        //FOR PANEL DRAG CODE (FORMBORDERSTYLE = SINGLE)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void titlebarPan_MouseDown(object sender, MouseEventArgs e)
        {
            // Being able to drag the form (needed for title bar removal)
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
