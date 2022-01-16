using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void visor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "9";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "9";
                visor.Text = this.result;
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "8";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "8";
                visor.Text = this.result;
            }
        }

        private void button_7_Click(object sender, EventArgs e )
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "7";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "7";
                visor.Text = this.result;
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "6";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "6";
                visor.Text = this.result;
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "5";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "5";
                visor.Text = this.result;
            }
        }



        private void button_4_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "4";
                visor.Text = this.result;

            }
            else
            {
                
                this.result = this.result + "4";
                visor.Text = this.result;
            }
        }



        private void button_3_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "3";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "3";
                visor.Text = this.result;
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "2";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "2";
                visor.Text = this.result;
            }
        }
        
        private void button_1_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "1";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "1";
                visor.Text = this.result;
            }
        }


        private void button_0_Click(object sender, EventArgs e)
        {
            if (this.finalvalor != 0)
            {
                this.result = "";
                this.result = this.result + "0";
                visor.Text = this.result;

            }
            else
            {
                this.result = this.result + "0";
                visor.Text = this.result;
            }
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (this.result == "" || this.finalvalor != 0 )
            { 
                visor.Text = this.result;

            }
            else
            {
                this.result = "";
                this.result = this.result + "9";
                visor.Text = this.result;
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (this.result == "" || this.result == "" || this.firtnumber == 0)
            {
                visor.Text = this.result;
            }
            else
            {
                this.secondnumber = float.Parse(this.result);
                if (this.operation == "sum")
                {
                    this.finalvalor = this.firtnumber + this.secondnumber;
                }
                else if (this.operation == "subtraction")
                {
                    this.finalvalor = this.firtnumber - this.secondnumber;
                }
                else if (this.operation == "multiplication")
                {
                    this.finalvalor = this.firtnumber * this.secondnumber;
                }
                else if (this.operation == "division")
                {
                    if (this.secondnumber == 0)
                    {
                        this.result = "";
                    }

                    else
                    {
                    this.finalvalor = this.firtnumber / this.secondnumber;
                    }
                }
            this.firtnumber = 0;
            this.secondnumber = 0;
            this.result = Convert.ToString(this.finalvalor);
            visor.Text = this.result;
            }
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = this.result;
            }
            else
            {
            this.firtnumber = float.Parse(this.result);
            this.result = "";
            this.operation = "sum";
            visor.Text = this.result;
            }
        }
        private void button_subtraction_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = this.result;
            }
            else
            {
                this.firtnumber = float.Parse(this.result);
                this.result = "";
                this.operation = "subtraction";
                visor.Text = this.result;
            }
        }
        private void button_multiplication_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = this.result;
            }
            else
            {
                this.firtnumber = float.Parse(this.result);
                this.result = "";
                this.operation = "multiplication";
                visor.Text = this.result;
            }
        }
        private void button_division_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = this.result;
            }
            else
            {
                this.firtnumber = float.Parse(this.result);
                this.result = "";
                this.operation = "division";
                visor.Text = this.result;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.finalvalor = 0;
            this.firtnumber = 0;
            this.secondnumber = 0;
            this.result = "";
            visor.Text=this.result;
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = this.result;
            }
            else
            {
                this.firtnumber = float.Parse(this.result);
                this.finalvalor = this.firtnumber * this.firtnumber;
                this.firtnumber = 0;
                this.secondnumber = 0;
                this.result = Convert.ToString(this.finalvalor);
                visor.Text = this.result;
            }
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = this.result;
            }
            else
            {
                this.firtnumber = float.Parse(this.result);
                this.finalvalor = (float)Math.Sqrt(this.firtnumber);
                this.firtnumber = 0;
                this.secondnumber = 0;
                this.result = Convert.ToString(this.finalvalor);
                visor.Text = this.result;
            }
        }

        private void button_negative_Click(object sender, EventArgs e)
        {
            if (this.result == "")
            {
                visor.Text = "";
            }
            else
            {

                float i = float.Parse(this.result);
                if (i <= 0)
                {
                    float j = i + (-2 * i);
                    this.result = Convert.ToString(j);
                    visor.Text = this.result;
                }
                else
                {
                    this.result = "-" + this.result;
                    visor.Text = this.result;
                }

            }
        }
    }
}
