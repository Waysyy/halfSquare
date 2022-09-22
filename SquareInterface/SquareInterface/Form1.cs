using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string square = textBox1.Text;
            int tmp = 0;
            for (int j = 0; j < 2; ++j)
            {
                if(j>0)
                {
                    square = Convert.ToString(tmp);
                    square = square.Remove(square.Length - 2, 2);
                    tmp = (int)(Convert.ToInt64(square) * Convert.ToInt64(square));
                }
                else
                {
                    tmp = (int)(Convert.ToInt64(square) * Convert.ToInt64(square));
                    square = Convert.ToString(tmp);
                    square = square.Remove(0, 2);
                    square = square.Remove(square.Length - 2, 2);
                    tmp = (int)(Convert.ToInt64(square) * Convert.ToInt64(square));
                }
                
            }
            square = Convert.ToString(tmp);
            square = square.Remove(square.Length - 2, 2);
            label1.Text = square;
        }
    }
}
