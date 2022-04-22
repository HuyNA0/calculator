using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_2
{
    

    public partial class windowDisplay : Form
    {
        Double result = 0.0;
        Double calculate = 0.0;
        String operation = "";
        bool enter_value = false;
        String first, second;
        String operation_temp = "";
        String userInput= "";
        
        

        public windowDisplay()
        {
            InitializeComponent();
        }
        private void windowDisplay_Load(object sender, EventArgs e)
        {
            treeViewMenu.Visible = false;
            lblNotification.Text = "There's no history yet";
            btnClearHistory.Visible = false;
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((calDisplay.Text == "0") || (enter_value))
            {
                calDisplay.Text = "";
                enter_value = false;
            }
            if (b.Text == ".")
            {
                if (!calDisplay.Text.Contains("."))
                {
                    userInput = b.Text;
                    calDisplay.Text += userInput;
                }
            }
            else
            {
                result = 0;
                userInput = b.Text;
                calDisplay.Text += userInput;
            }
        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            if (result != 0)
            {
                btnEqual.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblTempResult.Text = System.Convert.ToString(result) + "  " + operation;
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(calDisplay.Text);
                calDisplay.Text = "";
                if (operation == "√")
                {
                    lblTempResult.Text = operation + "(" + System.Convert.ToString(result) + ")";
                }
                else if (operation == "x²")
                {
                    lblTempResult.Text = System.Convert.ToString(result) + "²";
                }
                else if (operation == "¹/×")
                {
                    lblTempResult.Text = "1" + "/" + System.Convert.ToString(result);
                }
                else
                {
                    lblTempResult.Text = System.Convert.ToString(result) + "  " + operation;
                }
            }
            operation_temp = operation;
            first = System.Convert.ToString(result);
            //firstNum = Double.Parse(result);
            
        }

        private void button_clear_e_Click(object sender, EventArgs e)
        {
            calDisplay.Text = "0";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            calDisplay.Text = "0";
            lblTempResult.Text = "";
            result = 0;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            second = userInput;
            Double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            lblTempResult.Text = "";
            switch (operation)
            {
                case "+":
                    calculate = (firstNum + secondNum);
                    calDisplay.Text = calculate.ToString();
                    break;
                case "–":
                    calculate = (firstNum - secondNum);
                    calDisplay.Text = calculate.ToString();
                    break;
                case "×":
                    calculate = (firstNum * secondNum);
                    calDisplay.Text = calculate.ToString();
                    break;
                case "÷":
                    calculate = (firstNum / secondNum);
                    calDisplay.Text = calculate.ToString();
                    break;
                case "%":
                    calculate = (firstNum / 100);
                    calDisplay.Text = calculate.ToString();
                    break;
                case "√":
                    calculate = (System.Math.Sqrt(firstNum));
                    calDisplay.Text = calculate.ToString();
                    break;
                case "x²":
                    calculate = (firstNum * firstNum);
                    calDisplay.Text = calculate.ToString();
                    break;
                case "¹/×":
                    calculate = (1 / firstNum);
                    calDisplay.Text = calculate.ToString();
                    break;
                default:
                    break;
            }
            result = calculate;
            operation = "";
            //***************************//

            btnClearHistory.Visible = true;
            lblNotification.Text = "";
            hisDisplay.AppendText(firstNum + "  " + operation_temp + "  " + secondNum + " = " + "\n");
            hisDisplay.AppendText("\n" + result + "\n\n");
            
            
            //secondNum = "";
            calDisplay.Text = "";
            


        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (calDisplay.Text.Length > 0)
            {
                calDisplay.Text = calDisplay.Text.Remove(calDisplay.Text.Length - 1, 1);
            }
            if (calDisplay.Text == "")
            {
                calDisplay.Text = "0";
            }
        }

        private void button_clr_his_Click(object sender, EventArgs e)
        {
            hisDisplay.Clear();
            if (lblNotification.Text == "")
            {
                lblNotification.Text = "There's no history yet";
            }
            btnClearHistory.Visible = false;
            hisDisplay.ScrollBars = 0;
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node0")
            {
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node1")
            {
                tittleMenu.Text = "Standard";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node2")
            {
                tittleMenu.Text = "Scientific";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node3")
            {
                tittleMenu.Text = "Programmer";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node4")
            {
                tittleMenu.Text = "Data Calculation";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node5")
            {
                tittleMenu.Text = " ";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node6")
            {
                tittleMenu.Text = "Currency";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node7")
            {
                tittleMenu.Text = "Volume";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node8")
            {
                tittleMenu.Text = "Length";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node9")
            {
                tittleMenu.Text = "Weight and Mass";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node10")
            {
                tittleMenu.Text = "Temperature";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node11")
            {
                tittleMenu.Text = "Energy";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node12")
            {
                tittleMenu.Text = "Area";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node13")
            {
                tittleMenu.Text = "Speed";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node14")
            {
                tittleMenu.Text = "Time";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node15")
            {
                tittleMenu.Text = "Power";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node16")
            {
                tittleMenu.Text = "Data";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node17")
            {
                tittleMenu.Text = "Pressure";
                treeViewMenu.Visible = false;
            }
            if (e.Node.Name == "Node18")
            {
                tittleMenu.Text = "Angle";
                treeViewMenu.Visible = false;
            }
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            treeViewMenu.Visible = true;
        }

        private void btnReverveSign_Click(object sender, EventArgs e)
        {
            result = result * -1;
        }

        private void hisDisplay_TextChanged(object sender, EventArgs e)
        {
            hisDisplay.SelectAll();
            hisDisplay.SelectionAlignment = HorizontalAlignment.Right;
            
        }

        private void tableLayoutWindow_SizeChanged(object sender, EventArgs e)
        {
            int FH = this.Height;
            int FW = this.Width;
            if (FW < 625)
            {
                //tableLayoutWindow.ColumnStyles[0](SizeType.Percent, 100);
                //tableLayoutWindow.ColumnStyles[1](SizeType.Percent, 0);
                this.tableLayoutWindow.ColumnStyles[1].Width = 0;
            }
            else
            {
                this.tableLayoutWindow.ColumnStyles[1].Width = 275;
            }
        }
    }
}