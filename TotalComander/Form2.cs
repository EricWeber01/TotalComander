using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalComander
{
    public partial class Form2 : Form
    {
        IFormData parentForm;
        public Form2(IFormData f)
        {
            InitializeComponent();
            parentForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.AddText(textBox1.Text);
            Close();
        }
    }
}