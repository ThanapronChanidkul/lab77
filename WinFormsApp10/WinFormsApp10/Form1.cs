using System.Linq.Expressions;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        List<Class1> Class1sList = new List<Class1>();
        List<double> GradeList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.textBox1.Text;
                string student_id = this.textBox4.Text;
                string birthyear = this.textBox3.Text;
                string height = this.textBox2.Text;
                double grade = double.Parse(this.textBox5.Text);
                string branch = this.textBox6.Text;

                Class1 class1 = new Class1(name, student_id, birthyear, height, grade, branch);

                Class1sList.Add(class1);

                BindingSource source = new BindingSource();
                source.DataSource = Class1sList;
                this.dataGridView1.DataSource = source;

                foreach (var val in Class1sList)
                {
                    this.GradeList.Add(val.Grade);
                }

                double maxgrade = GradeList.Max();
                double mingrade = GradeList.Min();
                    
                int allperson = Class1sList.Count();

                this.labelAllStu.Text = allperson.ToString();
                this.labelMax.Text = maxgrade.ToString();
                this.labelMin.Text = mingrade.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}