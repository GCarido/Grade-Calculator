using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Calculator.Forms
{
    public partial class GradeCalculator : Form
    {
        public static string MidWeightAct { get; set; }
        public static string MidWeightAssignment { get; set; }
        public static string MidWeightQuiz { get; set; }
        public static string MidWeightExam { get; set; }
        public static double MidGrade { get; set; }
        public static string FinalWeightAct { get; set; }
        public static string FinalWeightAssignment { get; set; }
        public static string FinalWeightQuiz { get; set; }
        public static string FinalWeightExam { get; set; }
        public static string FinalWeightMidPercent { get; set; }
        public static double FinalGrade { get; set; }
        //MIDTERM STAYS ON DISPLAY
        public static string MidActScore { get; set; }
        public static string MidActTotal { get; set; }
        public static string MidAssignScore { get; set; }
        public static string MidAssignTotal { get; set; }
        public static string MidQuizScore { get; set; }
        public static string MidQuizTotal { get; set; }
        public static string MidExamScore { get; set; }
        public static string MidExamTotal { get; set; }
        //FINAL STAYS ON DISPLAY
        public static string FinalActScore { get; set; }
        public static string FinalActTotal { get; set; }
        public static string FinalAssScore{ get; set; }
        public static string FinalAssTotal { get; set; }
        public static string FinalQuizScore{ get; set; }
        public static string FinalQuizTotal { get; set; }
        public static string FinalExamScore { get; set; }
        public static string FinalExamTotal { get; set; }

        public GradeCalculator()
        {
            InitializeComponent();
        }

        private void GradeCalculator_Load(object sender, EventArgs e)
        {
            calcsubinpt.Text = studentinfo.Subject;
            //MIDTERM STAYS ON DISPLAY
            midactscore.Text = GradeCalculator.MidActScore;
            midactotal.Text = GradeCalculator.MidActTotal;
            midasscore.Text = GradeCalculator.MidAssignScore;
            midasstotal.Text = GradeCalculator.MidAssignTotal;
            midquizscore.Text = GradeCalculator.MidQuizScore;
            midquiztotal.Text = GradeCalculator.MidQuizTotal;
            midscore.Text = GradeCalculator.MidExamScore;
            midtotal.Text = GradeCalculator.MidExamTotal;
            midw1.Text = GradeCalculator.MidWeightAct;
            midw2.Text = GradeCalculator.MidWeightQuiz;
            midw3.Text = GradeCalculator.MidWeightExam;
            midw4.Text = GradeCalculator.MidWeightAssignment;
            //FINAL STAYS ON DISPLAY
            finactscore.Text = GradeCalculator.FinalActScore;
            finactotal.Text = GradeCalculator.FinalActTotal;
            finalasscore.Text = GradeCalculator.FinalAssScore;
            finalasstotal.Text = GradeCalculator.FinalAssTotal;
            finquizscore.Text = GradeCalculator.FinalQuizScore;
            finquiztotal.Text = GradeCalculator.FinalQuizTotal;
            finscore.Text = GradeCalculator.FinalExamScore;
            fintotal.Text = GradeCalculator.FinalExamTotal;
            finalw1.Text = GradeCalculator.FinalWeightAct;
            finalw2.Text = GradeCalculator.FinalWeightQuiz;
            finalw3.Text = GradeCalculator.FinalWeightExam;
            finalw4.Text = GradeCalculator.FinalWeightMidPercent;
            finalw5.Text = GradeCalculator.FinalWeightAssignment;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void midcalc_Click(object sender, EventArgs e)
        {
            
        }

        private void finalcalc_Click(object sender, EventArgs e)
        {
            //MIDTERM
            double middw1, middw2, middw3, middw4, middtotal;
            double midascore, midatotal;
            double midsscore, midsstotal;
            double midqscore, midqtotal;
            double mscore, mtotal;
            double midactst, midquizst, midasscorest, midst;
            double midactstw, midquizstw, midstw, midasscorestw, midoverall;

            //FINAL
            int w1, w2, w3, w4, w5, total;
            double ascore, atotal;
            double qscore, qtotal;
            double asscore, asstotal;
            double fscore, ftotal;
            double actst, quizst, asst, finst;
            double actstw, quizstw, asstw, finstw, finaloverall;
            try
            {

                middw1 = double.Parse(midw1.Text);
                middw2 = double.Parse(midw2.Text);
                middw3 = double.Parse(midw3.Text);
                middw4 = double.Parse(midw4.Text);
                midascore = double.Parse(midactscore.Text);
                midatotal = double.Parse(midactotal.Text);
                midsscore = double.Parse(midasscore.Text);
                midsstotal = double.Parse(midasstotal.Text);
                midqscore = double.Parse(midquizscore.Text);
                midqtotal = double.Parse(midquiztotal.Text);
                mscore = double.Parse(midscore.Text);
                mtotal = double.Parse(midtotal.Text);
                middtotal = middw1 + middw2 + middw3 + middw4;
                w1 = int.Parse(finalw1.Text);
                w2 = int.Parse(finalw2.Text);
                w3 = int.Parse(finalw3.Text);
                w4 = int.Parse(finalw4.Text);
                w5 = int.Parse(finalw5.Text);
                ascore = double.Parse(finactscore.Text);
                atotal = double.Parse(finactotal.Text);
                asscore = double.Parse(finalasscore.Text);
                asstotal = double.Parse(finalasstotal.Text);
                qscore = double.Parse(finquizscore.Text);
                qtotal = double.Parse(finquiztotal.Text);
                fscore = double.Parse(finscore.Text);
                ftotal = double.Parse(fintotal.Text);
                total = w1 + w2 + w3 + w4 + w5;

                if (midascore <= midatotal && midsscore <= midsstotal && midqscore 
                    <= midqtotal && mscore <= mtotal && middtotal == 100 && ascore <= atotal 
                    && asscore <= asstotal && qscore <= qtotal && 
                    fscore <= ftotal &&  total == 100)
                {
                    //MID
                    midactst = (midascore / midatotal) * 100;
                    midquizst = (midqscore / midqtotal) * 100;
                    midasscorest = (midsscore / midsstotal) * 100;
                    midst = (mscore / mtotal) * 100;
                    midactstw = midactst * (middw1 * 0.01);
                    midasscorestw = midasscorest * (middw4 * 0.01);
                    midquizstw = midquizst * (middw2 * 0.01);
                    midstw = midst * (middw3 * 0.01);
                    midoverall = midactstw + midasscorestw + midquizstw + midstw;
                    MidActScore = ($"{midactscore.Text}");
                    MidActTotal = ($"{midactotal.Text}");
                    MidAssignScore = ($"{midasscore.Text}");
                    MidAssignTotal = ($"{midasstotal.Text}");
                    MidQuizScore = ($"{midquizscore.Text}");
                    MidQuizTotal = ($"{midquiztotal.Text}");
                    MidExamScore = ($"{midscore.Text}");
                    MidExamTotal = ($"{midtotal.Text}");
                    MidWeightAct = ($"{midw1.Text}");
                    MidWeightQuiz = ($"{midw2.Text}");
                    MidWeightExam = ($"{midw3.Text}");
                    MidWeightAssignment = ($"{midw4.Text}");
                    MidGrade = midoverall;
                    //FINAL
                    actst = (ascore / atotal) * 100;
                    asst = (asscore / asstotal) * 100;
                    quizst = (qscore / qtotal) * 100;
                    finst = (fscore / ftotal) * 100;
                    actstw = actst * (w1 * 0.01);
                    asstw = asst * (w5 * 0.01);
                    quizstw = quizst * (w2 * 0.01);
                    finstw = finst * (w3 * 0.01);
                    finaloverall = (actstw + asstw + quizstw + finstw + (midoverall * 
                        (w4 * 0.01)));
                    FinalActScore = ($"{finactscore.Text}");
                    FinalActTotal = ($"{finactotal.Text}");
                    FinalAssScore = ($"{finalasscore.Text}");
                    FinalAssTotal = ($"{finalasstotal.Text}");
                    FinalQuizScore = ($"{finquizscore.Text}");
                    FinalQuizTotal = ($"{finquiztotal.Text}");
                    FinalExamScore = ($"{finscore.Text}");
                    FinalExamTotal = ($"{fintotal.Text}");
                    FinalWeightAct = ($"{finalw1.Text}");
                    FinalWeightAssignment = ($"{finalw5.Text}");
                    FinalWeightQuiz = ($"{finalw2.Text}");
                    FinalWeightExam = ($"{finalw3.Text}");
                    FinalWeightMidPercent = ($"{finalw4.Text}");
                    FinalGrade = finaloverall;
                    MessageBox.Show("Calculation Successful. You may view your scores in the " +
                        "Computed Grades tab", "Final Calculation Result", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("You cannot proceed. Make sure " +
                        "that the weight value in total is 100 % and Score/Total is " +
                        "properly entered"
                        ,"ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Weight values were not properly entered. Please " +
                    "fill in all the required fields", "ALERT", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void midclear_Click(object sender, EventArgs e)
        {
            
        }

        private void finalclear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All items will be cleared. Do you want to continue?", "ALERT", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //MIDTERM
                midactscore.Text = "";
                midactotal.Text = "";
                midasscore.Text = "";
                midasstotal.Text = "";
                midquizscore.Text = "";
                midquiztotal.Text = "";
                midscore.Text = "";
                midtotal.Text = "";
                midw1.Text = "";
                midw2.Text = "";
                midw3.Text = "";
                midw4.Text = "";
                //FINAL
                finactscore.Text = "";
                finactotal.Text = "";
                finalasscore.Text = "";
                finalasstotal.Text = "";
                finquizscore.Text = "";
                finquiztotal.Text = "";
                finscore.Text = "";
                fintotal.Text = "";
                finalw1.Text = "";
                finalw2.Text = "";
                finalw3.Text = "";
                finalw4.Text = "";
                finalw5.Text = "";
            }

        }

        private void calcsubinpt_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void midsubtn_Click(object sender, EventArgs e)
        {
            //MIDTERM
            double middw1, middw2, middw3, middw4, middtotal;
            double midascore, midatotal;
            double midsscore, midsstotal;
            double midqscore, midqtotal;
            double mscore, mtotal;
            double midactst, midquizst, midasscorest, midst;
            double midactstw, midquizstw, midstw, midasscorestw, midoverall;
            try
            {

                middw1 = double.Parse(midw1.Text);
                middw2 = double.Parse(midw2.Text);
                middw3 = double.Parse(midw3.Text);
                middw4 = double.Parse(midw4.Text);
                midascore = double.Parse(midactscore.Text);
                midatotal = double.Parse(midactotal.Text);
                midsscore = double.Parse(midasscore.Text);
                midsstotal = double.Parse(midasstotal.Text);
                midqscore = double.Parse(midquizscore.Text);
                midqtotal = double.Parse(midquiztotal.Text);
                mscore = double.Parse(midscore.Text);
                mtotal = double.Parse(midtotal.Text);
                middtotal = middw1 + middw2 + middw3 + middw4;
               
                if (midascore <= midatotal && midsscore <= midsstotal && 
                    midqscore <= midqtotal && mscore <= mtotal && middtotal == 100)
                {
                    //MID
                    midactst = (midascore / midatotal) * 100;
                    midquizst = (midqscore / midqtotal) * 100;
                    midasscorest = (midsscore / midsstotal) * 100;
                    midst = (mscore / mtotal) * 100;
                    midactstw = midactst * (middw1 * 0.01);
                    midasscorestw = midasscorest * (middw4 * 0.01);
                    midquizstw = midquizst * (middw2 * 0.01);
                    midstw = midst * (middw3 * 0.01);
                    midoverall = midactstw + midasscorestw + midquizstw + midstw;
                    MidActScore = ($"{midactscore.Text}"); 
                    MidActTotal = ($"{midactotal.Text}");
                    MidAssignScore = ($"{midasscore.Text}");
                    MidAssignTotal = ($"{midasstotal.Text}");
                    MidQuizScore = ($"{midquizscore.Text}");
                    MidQuizTotal = ($"{midquiztotal.Text}");
                    MidExamScore = ($"{midscore.Text}");
                    MidExamTotal = ($"{midtotal.Text}");
                    MidWeightAct = ($"{midw1.Text}");
                    MidWeightAssignment = ($"{midw4.Text}");
                    MidWeightQuiz = ($"{midw2.Text}");
                    MidWeightExam = ($"{midw3.Text}");
                    MidGrade = midoverall;
                    
                    MessageBox.Show("Calculation Successful. You may view " +
                        "your scores in the Computed Grades tab", "Midterm Calculation " +
                        "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);      
                }
                else
                    MessageBox.Show("You cannot proceed. Make sure that the weight " +
                        "value in total is 100 % and Score/Total is properly entered", 
                        "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show(" Weight values were not properly entered. Please " +
                    "fill in all the required fields", "ALERT", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
