using System;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Calculator : Form
    {
        double last_var = 0;
        String _operator = "";
        bool clicked = false; //是否第一次计算
        bool canCalculate = false;
        bool isCalculated = false;
        bool isFromMemory = false;
        bool isEXP = false;
        double m_var = 0;
        memory m = new memory("",0);

        public Calculator()
        {
            InitializeComponent();
        }


        private double calculate(double last_var,double current_var,String action)
        {
        
            
            double result = 0;
            switch (action)
            {
                case "+":
                    result = last_var + current_var;
                    return result;
                case "-":
                    result = last_var - current_var;
                    return result;
                case "*":
                    result = last_var * current_var;
                    return result;
                case "/":
                    if(current_var != 0)
                    {
                    result = last_var / current_var ;
                    return result;
                    }
                    else
                    {
                        MessageBox.Show("You can not deveded a number by 0");
                        return last_var;
                    }
                case "^":
                    result = Math.Pow(last_var, current_var);
                    return result;
                case "%":
                    result = last_var % current_var;
                    return result;
                case "e":
                    result = last_var * Math.Pow(10, current_var);
                    return result;
                default:
                    result = last_var;
                    return result;
            }
        }


        private void textBox1_结果显示_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Symbol_Btn_Click(object sender, EventArgs e)
        {
            String now_action = (sender as Button).Tag.ToString();
            double result;
            if (textBox1_结果显示.Text != ""){
                string str = textBox1_结果显示.Text;

                if (isEXP)
                {
                    textBox1_结果显示.Text = calculate(last_var, double.Parse(str), "e").ToString("F");
                    isEXP = false;
                    last_var = double.Parse(textBox1_结果显示.Text);
                    _operator = now_action;
                    textBox2_步骤显示.Text += textBox1_结果显示.Text + now_action;
                    textBox1_结果显示.Text = "";
                    clicked = true;
                    canCalculate = false;
                }
                 if (!clicked)
                {
                    last_var = double.Parse(textBox1_结果显示.Text);
                    _operator = now_action;
                    textBox1_结果显示.Text = "";
                    clicked = true;
                    canCalculate = false;
                    if (!isFromMemory)
                    {
                        textBox2_步骤显示.Text += last_var + _operator;
                    }
                    else
                    {
                        textBox2_步骤显示.Text += _operator;
                        isFromMemory = false;
                    }
                }
                else if (canCalculate)
                {
                    result = calculate(last_var, double.Parse(textBox1_结果显示.Text), _operator);
                    textBox2_步骤显示.Text += textBox1_结果显示.Text + now_action;
                    textBox1_结果显示.Text = result.ToString();
                    last_var = double.Parse(textBox1_结果显示.Text);
                    _operator = now_action;
                    canCalculate = false;
                    isCalculated = true;

                }
                else if (textBox2_步骤显示.Text != "")
                {
                    _operator = now_action;
                    textBox2_步骤显示.Text = textBox2_步骤显示.Text.Remove(textBox2_步骤显示.Text.Length - 1);
                    textBox2_步骤显示.Text += _operator;

                }

            }
            
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


        private void btn_num_Click(object sender, EventArgs e)
        {
            String num = (sender as Button).Text;
            if (isCalculated)
            {
                textBox1_结果显示.Text = "";
                isCalculated = false;
            }
            if (clicked)
            {
                canCalculate = true;
            }
            textBox1_结果显示.Text += num;
        }
        

        private void btn_小数点_Click(object sender, EventArgs e)
        {
            if((textBox1_结果显示.Text.IndexOf(".") == -1 && textBox2_步骤显示.Text.IndexOf("exp") == -1) && !isEXP)
            {
                textBox1_结果显示.Text += ".";
            }
        }

        private void btn_等于_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                string str = textBox1_结果显示.Text;
                if (clicked)
                {
                    textBox1_结果显示.Text = calculate(last_var, double.Parse(str), _operator).ToString();
                    textBox2_步骤显示.Text += str;
                }else if (isEXP)
                {
                    textBox1_结果显示.Text = calculate(last_var, double.Parse(str), "e").ToString("F");
                }
                clicked = false;
                isCalculated = true;
                if (textBox2_步骤显示.Text != "")
                {
                    m.expression = textBox2_步骤显示.Text;
                }else if(isEXP)
                {
                    m.expression = last_var.ToString() +".exp+" + str;
                }
                else
                {
                    m.expression = textBox1_结果显示.Text;
                }
                m.result = double.Parse(textBox1_结果显示.Text);
                listBox1_记忆.Items.Insert(0, new memory(m.expression, m.result));
                textBox2_步骤显示.Text = "";
            }
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1_结果显示.Text = "";
        }


        private void btn_c_Click(object sender, EventArgs e)
        {
            textBox2_步骤显示.Text = textBox1_结果显示.Text = "";
            last_var = 0;
            _operator = "";
            canCalculate = false;
            isCalculated = false;
            clicked = false;
            isEXP = false;
        }

        private void btn_平方_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                double var = double.Parse(textBox1_结果显示.Text);
            textBox1_结果显示.Text = (var * var).ToString();
            isCalculated = true;
                }
        }

        private void btn_立方_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                double var = double.Parse(textBox1_结果显示.Text);
                textBox1_结果显示.Text = (var * var * var).ToString();
                isCalculated = true;
            }
        }

        private void btn_十指数_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                double var = double.Parse(textBox1_结果显示.Text);
                double _result = 10;
                _result = Math.Pow(_result, var);
                textBox1_结果显示.Text = _result.ToString();
                isCalculated = true;
            }
        }

        private void btn_倒数_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                double var = double.Parse(textBox1_结果显示.Text);
                if (var == 0)
                {
                    MessageBox.Show("0 can not be denominator");
                    btn_c_Click(sender, e);
                }
                else
                {
                    textBox1_结果显示.Text = (1 / var).ToString();
                    isCalculated = true;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text.Length > 0)
            {
                textBox1_结果显示.Text = textBox1_结果显示.Text.Remove(textBox1_结果显示.Text.Length - 1);
            }
        }

        private void btn_正负_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                double var = double.Parse(textBox1_结果显示.Text);
                textBox1_结果显示.Text = (-var).ToString();
            }
        }

        private void btn_阶乘_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                double var = double.Parse(textBox1_结果显示.Text);
                double _result = 1;
                if (var >= 0)
                {
                    for (int i = 1; i <= var; i++)
                    {
                        _result *= i;
                    }
                    textBox1_结果显示.Text = _result.ToString();
                    isCalculated = true;
                }
                else
                {
                    MessageBox.Show("Invalid input");
                    btn_c_Click(sender, e);
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void btn_mp_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                m_var += double.Parse(textBox1_结果显示.Text);
                textBox3_记忆显示.Text = m_var.ToString();
            }
        }

        private void btn_mm_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                m_var -= double.Parse(textBox1_结果显示.Text);
                textBox3_记忆显示.Text = m_var.ToString();
            }
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            m_var = 0;
            textBox3_记忆显示.Text = "";
        }

        private void listBox1_记忆_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBox1_记忆.SelectedIndex != -1)
            {
                memory m2 = new memory("", 0);
                m2 = (memory)listBox1_记忆.SelectedItem;
                textBox1_结果显示.Text = m2.result.ToString();
                textBox2_步骤显示.Text = m2.expression;
                clicked = false;
                canCalculate = true;
                isFromMemory = true;

            }


        }

        private void btn_科学计数_Click(object sender, EventArgs e)
        {
            if (textBox1_结果显示.Text != "")
            {
                last_var = double.Parse(textBox1_结果显示.Text);
                textBox1_结果显示.Text = "";
                isEXP = true;
            }
        }
    }

    public class memory : Object
    {
        public String expression = "";
        public double result = 0;
        public memory(String expression, double result)
        {
            this.expression = expression;
            this.result = result;
        }

        public override String ToString()
        {
            return expression + " = " + result;
        }
    }
}
