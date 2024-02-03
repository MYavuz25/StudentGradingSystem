using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        static string DatabaseName = "ObsSistemi";
        static string DatabaseTableName = "Table_1";
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog='" + DatabaseName + "';Integrated Security=True");
        //Alttaki şekilde de database bağlantılarını yapabilirsiniz yorum satırına alınan database işlemleri database ve tablonun
        //alttaki gibi tanımlanmasından sonra yapılan işlemler içindir.
        //SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ObsSistemi;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable tablo=new DataTable();
        
        private double calculateLessonsGrades()
        {
            int i = 0;
            string letter;
            int ECTSValue, sumofECTS = 0;
            double letterGrade, TotalGrade = 0;    
            while( i < dataGridView2.Rows.Count-1)
            {
                ArrayList grades = new ArrayList();
                ArrayList ECTS = new ArrayList();      
                ECTSValue = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                letter = dataGridView2.Rows[i].Cells[4].Value.ToString();
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
                i++;
            }
            double CGPA = TotalGrade / sumofECTS;
            return CGPA;

        }
        private void listeleTerm()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter ad = new(string.Format("Select *From {0} Where Term='" + comboBox1.Text + "'",DatabaseTableName), baglanti);
            ad.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }
        private void listeleCourse()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter ad = new(string.Format("select *from {0} where CourseCode='" + Convert.ToInt32(textBox1.Text) + "'",DatabaseTableName), baglanti);
            ad.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GpaCgpa_Click(object sender, EventArgs e)
        {
            calculateLessonsGrades();
        }

        private void ShowInfos_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowTerm_Click(object sender, EventArgs e)
        {
            listeleTerm();
        }
        private double CalculateGdpa()
        {
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = calculateLessonsGrades();
            textBox2.Text= x.ToString();

        }

        private void SearchCourse_Click(object sender, EventArgs e)
        {
            try {
                listeleCourse();
            }
            catch {
                MessageBox.Show("Course Code Can Not Be Empty");
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
