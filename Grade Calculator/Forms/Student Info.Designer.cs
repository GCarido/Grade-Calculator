
namespace Grade_Calculator.Forms
{
    partial class studentinfo
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
            this.courseinpt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idinpt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameinpt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subinpt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentsubtn = new System.Windows.Forms.Button();
            this.studentclearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseinpt
            // 
            this.courseinpt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseinpt.Location = new System.Drawing.Point(393, 237);
            this.courseinpt.Name = "courseinpt";
            this.courseinpt.Size = new System.Drawing.Size(167, 24);
            this.courseinpt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Course:";
            // 
            // idinpt
            // 
            this.idinpt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idinpt.Location = new System.Drawing.Point(393, 194);
            this.idinpt.Name = "idinpt";
            this.idinpt.Size = new System.Drawing.Size(167, 24);
            this.idinpt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID #:";
            // 
            // nameinpt
            // 
            this.nameinpt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameinpt.Location = new System.Drawing.Point(393, 155);
            this.nameinpt.Name = "nameinpt";
            this.nameinpt.Size = new System.Drawing.Size(167, 24);
            this.nameinpt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Mincho", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // subinpt
            // 
            this.subinpt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subinpt.Location = new System.Drawing.Point(393, 282);
            this.subinpt.Name = "subinpt";
            this.subinpt.Size = new System.Drawing.Size(167, 24);
            this.subinpt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Subject to compute:";
            // 
            // studentsubtn
            // 
            this.studentsubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsubtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentsubtn.Location = new System.Drawing.Point(309, 338);
            this.studentsubtn.Name = "studentsubtn";
            this.studentsubtn.Size = new System.Drawing.Size(75, 23);
            this.studentsubtn.TabIndex = 4;
            this.studentsubtn.Text = "Submit";
            this.studentsubtn.UseVisualStyleBackColor = false;
            this.studentsubtn.Click += new System.EventHandler(this.studentsubtn_Click);
            // 
            // studentclearbtn
            // 
            this.studentclearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentclearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studentclearbtn.Location = new System.Drawing.Point(415, 338);
            this.studentclearbtn.Name = "studentclearbtn";
            this.studentclearbtn.Size = new System.Drawing.Size(75, 23);
            this.studentclearbtn.TabIndex = 5;
            this.studentclearbtn.Text = "Clear";
            this.studentclearbtn.UseVisualStyleBackColor = false;
            this.studentclearbtn.Click += new System.EventHandler(this.studentclearbtn_Click);
            // 
            // studentinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentclearbtn);
            this.Controls.Add(this.studentsubtn);
            this.Controls.Add(this.subinpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.courseinpt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idinpt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameinpt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "studentinfo";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.studentinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseinpt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idinpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subinpt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button studentsubtn;
        private System.Windows.Forms.Button studentclearbtn;
        private System.Windows.Forms.TextBox nameinpt;
    }
}