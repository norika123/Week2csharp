using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3Forms1
{
    public partial class DemoForm: Form
    {
        string name = "";
        int years = 0;
        int day = 0;
        string month = "";

        public DemoForm()
        {


            InitializeComponent();
        }

     

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            // get today's date
            DateTime today = DateTime.Now.Date;
            //get the difference in days between todays date
            //and the date in the date time picker
            TimeSpan ageDays = today - dateTimePicker1.Value;
            //work out age in years
            years = ((int)ageDays.TotalDays) / 365;

            //get the day and month from the datetime picker
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.ToString("MMMMM");


            labelMessage.Text = "Hello," + name + "! You will be " + years + "years old on" + day + "" + month + " ";
        }
    }
}
