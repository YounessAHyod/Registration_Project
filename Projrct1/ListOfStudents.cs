using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Projrct1
{
    public partial class ListOfStudents : Form
    {
        private List<Students> Rstudents = new List<Students>();

        private int indexToShow = 0;

        public ListOfStudents()
        {
            InitializeComponent();
        }

        private void ListOfStudents_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            MinimizeBox = false;

            LoadStudentsFromFile();

            ShowStudents();
        }

        private void LoadStudentsFromFile()
        {
            try
            {
                using (FileStream fs = new FileStream("ListOfStudents.txt", FileMode.Open, FileAccess.Read))

                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();

                        string[] splittedLine = line.Split(';');

                        Students s = new Students(

                            splittedLine[0],

                            splittedLine[1],

                            splittedLine[2],

                            DateTime.Parse(splittedLine[3]),

                            DateTime.Parse(splittedLine[4]),

                            splittedLine[5]
                        );

                        Rstudents.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error, Please Close program and Start Again: {ex.Message}");

            }
        }

        private void btnBCK_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();

            f1.ShowDialog();

            this.Close();
        }

        private void ShowStudents()
        {
            if (Rstudents.Count > 0)
            {
                lblCount.Text = $"{indexToShow + 1}/{Rstudents.Count}";

                txtName.Text = Rstudents[indexToShow].Name;

                txtLN.Text = Rstudents[indexToShow].LastName;

                txtFN.Text = Rstudents[indexToShow].FatherName;

                txtDOB.Text = Rstudents[indexToShow].DateofBirth.ToString();

                txtJD.Text = Rstudents[indexToShow].JoinDate.ToString();

                txtNat.Text = Rstudents[indexToShow].Nationality;

                btnNext.Enabled = indexToShow < Rstudents.Count - 1;

                btnBack.Enabled = indexToShow > 0;
            }
            else
            {
                lblCount.Text = "0/0";

                txtName.Text = string.Empty;

                txtLN.Text = string.Empty;

                txtFN.Text = string.Empty;

                txtDOB.Text = string.Empty;

                txtJD.Text = string.Empty;

                txtNat.Text = string.Empty;

                btnNext.Enabled = false;

                btnBack.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            indexToShow++;

            ShowStudents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            indexToShow--;

            ShowStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Rstudents.Count > 0)
            {
                Rstudents.RemoveAt(indexToShow);


                if (indexToShow >= Rstudents.Count)
                {
                    indexToShow = Math.Max(0, Rstudents.Count - 1);
                }


                ShowStudents();

                UpdateTextFile();


            }
            else
            {

                MessageBox.Show("List is Empty.");

            }
        }

        private void UpdateTextFile()
        {
            try
            {
                
                using (FileStream fs = new FileStream("ListOfStudents.txt", FileMode.Create, FileAccess.Write))

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Students student in Rstudents)

                    {

                        sw.WriteLine($"{student.Name};{student.LastName};{student.FatherName};{student.DateofBirth};{student.JoinDate};{student.Nationality}");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Could not Delete Student from Storage: {ex.Message}");

            }








        }
    }
}
