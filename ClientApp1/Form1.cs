using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ClientApp1
{
    public partial class Form1 : Form
    {
        public ICalculatorLibService httpChannel = null;

        public ICalculatorLibService channel = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            httpChannel = new ChannelFactory<CalculatorLibrary.ICalculatorLibService>("Calculator_Http").CreateChannel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyNumber obj = new MyNumber();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox1.Text);

            int result = httpChannel.Add(obj);
            textBox3.Text = result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            MyNumber obj = new MyNumber();
            obj.Number1 = Convert.ToInt32(textBox1.Text);
            obj.Number2 = Convert.ToInt32(textBox1.Text);

            int result = httpChannel.Sub(obj);
            textBox3.Text = result.ToString();
        }
    }
}
