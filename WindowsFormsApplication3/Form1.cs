using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        
        private delegate void myDelegate(string name,int age);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDelegate md = new myDelegate(method1);
            md.Invoke("see u",32);

        }
        void method1(string name,int age) {
            label1.Text = name;
            label2.Text = "" + age;
        }

    }
}
