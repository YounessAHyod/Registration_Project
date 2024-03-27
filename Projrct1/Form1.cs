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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox=false;

            MinimizeBox=false;
        }

        private void btnAddS_Click(object sender, EventArgs e)
        {
            Registrations Form = new Registrations();

            this.Hide();

            Form.ShowDialog();

            this.Close();

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowS_Click(object sender, EventArgs e)
        {
            ListOfStudents Form2 = new ListOfStudents();

            this.Hide();

            Form2.ShowDialog();

            this.Close();
        }
    }
}
