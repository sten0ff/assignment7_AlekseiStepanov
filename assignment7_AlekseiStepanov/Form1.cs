using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        
        string[] numberArray = {"1.B", "2.D", "3.A", "4.A", "5.C", "6.A", "7.B", "8.A", "9.C",
        "10.D", "11.B", "12.C", "13.D", "14.A", "15.D", "16.C", "17.C", "18.B", "19.D", "20.A"};
        string[] numbers = new string[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            StreamReader inputFile;
            inputFile = File.OpenText("Exam.txt");
            while (index < numbers.Length && !inputFile.EndOfStream)
            {
                numbers[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
            int count = 0;
            int correct = 0;
            index = 0;
            while (index < numbers.Length)
            {
                if (numberArray[index] == numbers[index])
                {
                    correct++;
                }
                else
                {
                    count++;
                }
                index++;
            }
            int[] number = new int[count];
            index = 0;
            int nums = 0;
            while (nums < number.Length)
            {
                while (index < numbers.Length)
                {
                    if (numberArray[index] != numbers[index])
                    {
                        number[nums] =  index;
                        nums++;
                    }
                    index++;
                }
            }
            label1.Text = "There was "+ count.ToString() + " mistakes\n" + "There was " + correct.ToString() + " correct answers\n" + "Those are question numbers of the incorrectly answered questions. " + string.Join("/", number);
            
            
            
        }
    }
}
