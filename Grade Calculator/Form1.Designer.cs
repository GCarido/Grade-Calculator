
namespace Grade_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.titlebarPan = new System.Windows.Forms.Panel();
            this.lblpicBar = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesk = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniBtn = new System.Windows.Forms.PictureBox();
            this.Exitbtn = new System.Windows.Forms.PictureBox();
            this.iconPicbar = new FontAwesome.Sharp.IconPictureBox();
            this.calendartab = new FontAwesome.Sharp.IconButton();
            this.comptab = new FontAwesome.Sharp.IconButton();
            this.calctab = new FontAwesome.Sharp.IconButton();
            this.studentinfo = new FontAwesome.Sharp.IconButton();
            this.logotab = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.Logo.SuspendLayout();
            this.titlebarPan.SuspendLayout();
            this.panelDesk.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotab)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(176)))), ((int)(((byte)(195)))));
            this.panelMenu.Controls.Add(this.calendartab);
            this.panelMenu.Controls.Add(this.comptab);
            this.panelMenu.Controls.Add(this.calctab);
            this.panelMenu.Controls.Add(this.studentinfo);
            this.panelMenu.Controls.Add(this.Logo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 580);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // Logo
            // 
            this.Logo.Controls.Add(this.logotab);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(220, 100);
            this.Logo.TabIndex = 0;
            // 
            // titlebarPan
            // 
            this.titlebarPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.titlebarPan.Controls.Add(this.miniBtn);
            this.titlebarPan.Controls.Add(this.Exitbtn);
            this.titlebarPan.Controls.Add(this.lblpicBar);
            this.titlebarPan.Controls.Add(this.iconPicbar);
            this.titlebarPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebarPan.Location = new System.Drawing.Point(220, 0);
            this.titlebarPan.Name = "titlebarPan";
            this.titlebarPan.Size = new System.Drawing.Size(822, 60);
            this.titlebarPan.TabIndex = 1;
            this.titlebarPan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPan_MouseDown);
            // 
            // lblpicBar
            // 
            this.lblpicBar.AutoSize = true;
            this.lblpicBar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblpicBar.ForeColor = System.Drawing.Color.Black;
            this.lblpicBar.Location = new System.Drawing.Point(61, 21);
            this.lblpicBar.Name = "lblpicBar";
            this.lblpicBar.Size = new System.Drawing.Size(49, 17);
            this.lblpicBar.TabIndex = 1;
            this.lblpicBar.Text = "Home";
            this.lblpicBar.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(172)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(822, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesk
            // 
            this.panelDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(72)))), ((int)(((byte)(113)))));
            this.panelDesk.Controls.Add(this.panel1);
            this.panelDesk.Controls.Add(this.pictureBox2);
            this.panelDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesk.Location = new System.Drawing.Point(220, 69);
            this.panelDesk.Name = "panelDesk";
            this.panelDesk.Size = new System.Drawing.Size(822, 511);
            this.panelDesk.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(147, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 514);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Grade_Calculator.Properties.Resources.maths_class_zoom_backgrounds_design_template_b0d01da793b4d82996aed2ba221faf60_screen;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(830, 511);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grade_Calculator.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 911);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniBtn.Image")));
            this.miniBtn.Location = new System.Drawing.Point(747, 0);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(40, 38);
            this.miniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniBtn.TabIndex = 4;
            this.miniBtn.TabStop = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.Location = new System.Drawing.Point(782, 0);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(40, 38);
            this.Exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.TabStop = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // iconPicbar
            // 
            this.iconPicbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(162)))), ((int)(((byte)(180)))));
            this.iconPicbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(0)))));
            this.iconPicbar.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPicbar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(0)))));
            this.iconPicbar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicbar.IconSize = 51;
            this.iconPicbar.Location = new System.Drawing.Point(3, 6);
            this.iconPicbar.Name = "iconPicbar";
            this.iconPicbar.Size = new System.Drawing.Size(52, 51);
            this.iconPicbar.TabIndex = 0;
            this.iconPicbar.TabStop = false;
            // 
            // calendartab
            // 
            this.calendartab.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendartab.FlatAppearance.BorderSize = 0;
            this.calendartab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendartab.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendartab.ForeColor = System.Drawing.Color.Black;
            this.calendartab.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.calendartab.IconColor = System.Drawing.Color.DarkBlue;
            this.calendartab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.calendartab.IconSize = 45;
            this.calendartab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendartab.Location = new System.Drawing.Point(0, 265);
            this.calendartab.Name = "calendartab";
            this.calendartab.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.calendartab.Size = new System.Drawing.Size(220, 55);
            this.calendartab.TabIndex = 4;
            this.calendartab.TabStop = false;
            this.calendartab.Text = "Calendar";
            this.calendartab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendartab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calendartab.UseVisualStyleBackColor = true;
            this.calendartab.Click += new System.EventHandler(this.calendartab_Click);
            // 
            // comptab
            // 
            this.comptab.Dock = System.Windows.Forms.DockStyle.Top;
            this.comptab.FlatAppearance.BorderSize = 0;
            this.comptab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comptab.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comptab.ForeColor = System.Drawing.Color.Black;
            this.comptab.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.comptab.IconColor = System.Drawing.Color.DarkBlue;
            this.comptab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.comptab.IconSize = 45;
            this.comptab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comptab.Location = new System.Drawing.Point(0, 210);
            this.comptab.Name = "comptab";
            this.comptab.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.comptab.Size = new System.Drawing.Size(220, 55);
            this.comptab.TabIndex = 3;
            this.comptab.TabStop = false;
            this.comptab.Text = "Computed Grades";
            this.comptab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comptab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.comptab.UseVisualStyleBackColor = true;
            this.comptab.Click += new System.EventHandler(this.comptab_Click);
            // 
            // calctab
            // 
            this.calctab.Dock = System.Windows.Forms.DockStyle.Top;
            this.calctab.FlatAppearance.BorderSize = 0;
            this.calctab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calctab.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calctab.ForeColor = System.Drawing.Color.Black;
            this.calctab.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.calctab.IconColor = System.Drawing.Color.DarkBlue;
            this.calctab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.calctab.IconSize = 45;
            this.calctab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calctab.Location = new System.Drawing.Point(0, 155);
            this.calctab.Name = "calctab";
            this.calctab.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.calctab.Size = new System.Drawing.Size(220, 55);
            this.calctab.TabIndex = 2;
            this.calctab.TabStop = false;
            this.calctab.Text = "Calculator";
            this.calctab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calctab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calctab.UseVisualStyleBackColor = true;
            this.calctab.Click += new System.EventHandler(this.calctab_Click);
            // 
            // studentinfo
            // 
            this.studentinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentinfo.FlatAppearance.BorderSize = 0;
            this.studentinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentinfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentinfo.ForeColor = System.Drawing.Color.Black;
            this.studentinfo.IconChar = FontAwesome.Sharp.IconChar.User;
            this.studentinfo.IconColor = System.Drawing.Color.DarkBlue;
            this.studentinfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.studentinfo.IconSize = 45;
            this.studentinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentinfo.Location = new System.Drawing.Point(0, 100);
            this.studentinfo.Name = "studentinfo";
            this.studentinfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.studentinfo.Size = new System.Drawing.Size(220, 55);
            this.studentinfo.TabIndex = 1;
            this.studentinfo.TabStop = false;
            this.studentinfo.Text = "Student Info";
            this.studentinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentinfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentinfo.UseVisualStyleBackColor = true;
            this.studentinfo.Click += new System.EventHandler(this.studentinf_Click);
            // 
            // logotab
            // 
            this.logotab.Image = ((System.Drawing.Image)(resources.GetObject("logotab.Image")));
            this.logotab.Location = new System.Drawing.Point(-13, -12);
            this.logotab.Name = "logotab";
            this.logotab.Size = new System.Drawing.Size(245, 129);
            this.logotab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotab.TabIndex = 0;
            this.logotab.TabStop = false;
            this.logotab.Click += new System.EventHandler(this.logotab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1042, 580);
            this.Controls.Add(this.panelDesk);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.titlebarPan);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Grade Calculation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.titlebarPan.ResumeLayout(false);
            this.titlebarPan.PerformLayout();
            this.panelDesk.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton studentinfo;
        private System.Windows.Forms.Panel Logo;
        private FontAwesome.Sharp.IconButton calendartab;
        private FontAwesome.Sharp.IconButton comptab;
        private FontAwesome.Sharp.IconButton calctab;
        private System.Windows.Forms.PictureBox logotab;
        private System.Windows.Forms.Panel titlebarPan;
        private FontAwesome.Sharp.IconPictureBox iconPicbar;
        private System.Windows.Forms.Label lblpicBar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesk;
        private System.Windows.Forms.PictureBox Exitbtn;
        private System.Windows.Forms.PictureBox miniBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

