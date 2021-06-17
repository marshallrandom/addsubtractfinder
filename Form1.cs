using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace problem3
{

    public partial class Form1 : Form
    {
        int[] numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] operations;
            progressBar1.Value = 0;
            numbers = new int[9];  // numbers is a 10-element array
            operations = new int[8]  { 0, 0, 0, 0, 0, 0, 0, 0 };
            numbers[0] = Convert.ToInt32(textBox1.Text);
            numbers[1] = Convert.ToInt32(textBox2.Text);
            numbers[2] = Convert.ToInt32(textBox3.Text);
            numbers[3] = Convert.ToInt32(textBox4.Text);
            numbers[4] = Convert.ToInt32(textBox5.Text);
            numbers[5] = Convert.ToInt32(textBox6.Text);
            numbers[6] = Convert.ToInt32(textBox7.Text);
            numbers[7] = Convert.ToInt32(textBox8.Text);
            numbers[8] = Convert.ToInt32(textBox9.Text);
           // numbers[9] = Convert.ToInt32(textBox10.Text);
            //numbers[10] = Convert.ToInt32(textBox11.Text);
            textBox11.Text = "";
            findeveryone(operations, 0);




        }
        private void findeveryone(int[] operations, int placenumber)
        {
            Expression loexp = new Expression("2 + 3 * 5");
            string expressionstring;
            
            if (placenumber == 7)
            {
                operations[7] = 0;
                expressionstring = exptostring(operations);
                loexp = new Expression(expressionstring);
                progressBar1.Value++;
                if (Convert.ToInt32(loexp.Evaluate()) == Convert.ToInt32(textBox10.Text))
                {
                    textBox11.Text += expressionstring + "=" + loexp.Evaluate() + Environment.NewLine;
                }

                operations[7] = 1;
                expressionstring = exptostring(operations);
                loexp = new Expression(expressionstring);
                progressBar1.Value++;
                if (Convert.ToInt32(loexp.Evaluate()) == Convert.ToInt32(textBox10.Text))
                {
                    textBox11.Text += expressionstring + "=" + loexp.Evaluate() + Environment.NewLine;
                }

                operations[7] = 2;
                expressionstring = exptostring(operations);
                loexp = new Expression(expressionstring);
                progressBar1.Value++;
                if (Convert.ToInt32(loexp.Evaluate()) == Convert.ToInt32(textBox10.Text))
                {
                    textBox11.Text += expressionstring + "=" + loexp.Evaluate() + Environment.NewLine;
                }

            }
            else
            {
                operations[placenumber] = 0;
                findeveryone(operations, placenumber + 1);
                operations[placenumber] = 1;
                findeveryone(operations, placenumber + 1);
                operations[placenumber] = 2;
                findeveryone(operations, placenumber + 1);

            }
            


        }
        private string exptostring( int[] operations)
        {
            string temp_string = "";
            for (int i = 0; i <= numbers.GetUpperBound(0); i++)
            {
                temp_string += Convert.ToString(numbers[i]);
                if (i < numbers.GetUpperBound(0))
                {
                    if (operations[i] == 0)
                        temp_string += "+";
                    else if (operations[i] == 1)
                        temp_string += "-";
                   


                }

            }
            return temp_string;


        }

        
    }
}
