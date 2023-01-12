using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Application
{
    
    public partial class Form1 : Form
    {
        static int qcount = 0;
        static int marks = 0;
        static int option;
        string[] que = { "Q1.What is capital of india?\n\n A.Mumbai      B.Delhi      C.Nagpur       D.Jaipur",
            "Q2.Which is the Financial Capital of India?\n\nA.Mumbai      B.Delhi         C.Chennai       D.Kolkata",
            "Q3.Which city is called the pink city of India?\n\nA.Hyderabad        B.Jaipur        C.Pune      D.Nagpur",
            "Q4.What is value of x in equation x + 4 = 9 ?\n\nA.Seven     B.Nine     C.Six     D.Five",
            "Q5.What is value of x in equation x + 3 = 12 ?\n\nA.Nine     B.Seven     C.Five     D.Six"};

        int[] key = { 2, 1, 2, 4, 1 };
        int[] ans = new int[5];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.button1.Visible= false;
            this.button2.Visible= true;
            this.radioButton1.Visible= true;
            this.radioButton2.Visible = true;
            this.radioButton3.Visible = true;
            this.radioButton4.Visible = true;
            label1.Text = que[0];

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            option = 4;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(qcount<que.Length-1)
            {
                this.radioButton1.Checked = false;
                this.radioButton2.Checked= false;
                this.radioButton3.Checked= false;
                this.radioButton4.Checked= false;
                ans[qcount] = option;
                qcount++;
                
                this.label1.Text = que[qcount];
            
                if(qcount == que.Length - 1)
                {
                    button2.Text = "Submit";
                }
                
            }
            else if(qcount==que.Length-1)
            {
                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
                this.radioButton3.Visible = false;
                this.radioButton4.Visible = false;
                ans[qcount] = option;
                this.button2.Visible= false;
                for(int i=0;i<que.Length;i++)
                {
                    if (ans[i] == key[i])
                    {
                        marks++;
                    }
                }
                qcount++;
                this.label1.Text = "You have completed paper and your marks are : " + marks;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            option= 2;
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            option= 3;
            

        }
    }
}
