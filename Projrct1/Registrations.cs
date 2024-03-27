using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projrct1
{
    public partial class Registrations : Form
    {
        public Registrations()
        {
            InitializeComponent();
        }

        private void Registrations_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            MinimizeBox = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();

            f1.ShowDialog();

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!DateTime.TryParse(txtDOB.Text, out _))
                {
                    MessageBox.Show("Plese use Format MM.DD.YY");
                    return;
                }

                
                if (!DateTime.TryParse(txtJD.Text, out _))
                {
                    MessageBox.Show("Plese use Format MM.DD.YYYY");

                    return;
                }

                using (FileStream fs = new FileStream("ListOfStudents.txt", FileMode.Append, FileAccess.Write))

                using (StreamWriter sw = new StreamWriter(fs))

                {

                    sw.WriteLine($"{textName.Text};{txtLN.Text};{txtFN.Text};{txtDOB.Text};{txtJD.Text};{txtNat.Text}");

                }

                
                foreach (var textBox in Controls.OfType<TextBox>())

                {

                    textBox.Clear();

                }

                MessageBox.Show("Student Registered Successfully!!");
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Error Please Try Again: {ex.Message}");

            }
        }
    }
}
