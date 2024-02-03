using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Transkript
{
    public partial class Form1 : Form
    {
      static string DatabaseName = "ObsSistemi";
      static string DatabaseTableName = "Table_1";
        //  SqlConnection baglanti=new SqlConnection("Data Source=.;Initial Catalog=ObsSistemi;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog='"+ DatabaseName+ "';Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        DataTable tablo = new DataTable();
        private void listele()
        {
            tablo.Clear();
            baglanti.Open();
            //  SqlDataAdapter ad = new("select *from Table_1 where Term='" + textTerm.Text + "'", baglanti);
            SqlDataAdapter ad = new(String.Format("select *From {0} ",DatabaseTableName), baglanti);
            ad.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }
        
       
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                baglanti.Open();
            string indx = string.Format("INSERT INTO {0} (Term,CourseCode,CourseName,ECTSCredits,LetterGrade) VALUES (@Term,@CourseCode,@CourseName,@ECTSCredits,@LetterGrade)",DatabaseTableName); 
            cmd=new SqlCommand(indx,baglanti);
            cmd.Parameters.AddWithValue("@Term", textTerm.Text);
            cmd.Parameters.AddWithValue("@CourseCode", textCoursecode.Text);
            cmd.Parameters.AddWithValue("@CourseName", textCourseName.Text);
            cmd.Parameters.AddWithValue("@ECTSCredits", textECTS.Text);
            cmd.Parameters.AddWithValue("@LetterGrade", textLatterGrade.Text);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = null;
            baglanti.Close();
            listele();
            TextBoxClearFunction();
            } catch {
            MessageBox.Show("Error Course Codes can not be same ..");
            baglanti.Close();
            }
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textTerm.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textCoursecode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textCourseName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textECTS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textLatterGrade.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string indx = string.Format("DELETE FROM {0} WHERE CourseCode=@CourseCode",DatabaseTableName);///
            cmd = new SqlCommand(indx, baglanti);
            cmd.Parameters.AddWithValue("@CourseCode",Convert.ToInt32(textCoursecode.Text));
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            dataGridView1.DataSource = null;
            listele();
        }

        private void textTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            e.Handled = !char.IsDigit(e.KeyChar);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Text_Clear_Click(object sender, EventArgs e)
        {
            TextBoxClearFunction();
        }
        private void TextBoxClearFunction()
        {
            textTerm.Text = ""; 
            textCoursecode.Text = "";
            textCourseName.Text = "";
            textECTS.Text = "";
            textLatterGrade.Text = "";

        }
        // For Details
        private void button2_Click_2(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
          
            frm2.Show();
        }
        private double calculateCGPA()
        {

            string letter;
            int ECTSValue, sumofECTS = 0;
            double letterGrade, TotalGrade = 0;
            int i = 0;
            for (i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                ArrayList grades = new ArrayList();
                ArrayList ECTS = new ArrayList();
                ECTSValue = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                letter = dataGridView1.Rows[i].Cells[4].Value.ToString();
                ECTS.Add(ECTSValue);
                if (letter == "AA" || letter == "aa")
                    letterGrade = 4;
                else if (letter == "BA" || letter == "ba")
                    letterGrade = 3.5;
                else if (letter == "BB" || letter == "bb")
                    letterGrade = 3;
                else if (letter == "CB" || letter == "cb")
                    letterGrade = 2.5;
                else if (letter == "CC" || letter == "cc")
                    letterGrade = 2;
                else if (letter == "DC" || letter == "dc")
                    letterGrade = 1.5;
                else if (letter == "DD" || letter == "dd")
                    letterGrade = 1;
                else if (letter == "FD" || letter == "fd")
                    letterGrade = 0.5;
                else
                    letterGrade = 0;

                sumofECTS += ECTSValue;
                TotalGrade += letterGrade * ECTSValue;
            }
            double CGPA = TotalGrade / sumofECTS;
            return CGPA;

        }

        private void textLatterGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }

        }

        private void CGPA_Click(object sender, EventArgs e)
        {
            double x = calculateCGPA();
            textCGPA.Text = x.ToString();
        }
    }
}
