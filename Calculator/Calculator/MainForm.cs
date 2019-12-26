using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cal_dll_csharp;

namespace Calculator
{
    enum Type
    {
        beforeUnOp, afterUnOp, binOp, leftBracket, rightBracket, digit,
    }
    public partial class MainForm : Form
    {
        private List<string> expr = new List<string>();//表达式字符串
        private List<Type> types = new List<Type>();//表达式单元类型
        private int curIndex = -1;
        private int curSelect = 0;
        private StringBuilder digit = new StringBuilder();//数字缓冲区

        public MainForm()
        {
            InitializeComponent();
        }


        private void showText()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in expr)
            {
                stringBuilder.Append(s);
            }
            inputTxBox.Focus();
            inputTxBox.Text = stringBuilder.ToString();
            if (curIndex >= 0)
                inputTxBox.Select(curSelect, expr[curIndex].Length);
            else
                inputTxBox.Select(0, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            expr.Clear();
            types.Clear();
            digit.Clear();
            curIndex = -1;
            curSelect = 0;
            inputTxBox.Text = "";
            resultTxtBox.Text = "";
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "^2");
            types.Insert(curIndex, Type.afterUnOp);
            showText();
        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "^3");
            types.Insert(curIndex, Type.afterUnOp);
            showText();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "^");
            types.Insert(curIndex, Type.binOp);
            showText();
        }

        private void radicalButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "2√");
            types.Insert(curIndex, Type.beforeUnOp);
            showText();
        }

        private void radical3Button_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "3√");
            types.Insert(curIndex, Type.beforeUnOp);
            showText();
        }

        private void radicalYButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "√");
            types.Insert(curIndex, Type.binOp);
            showText();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
            {
                expr.RemoveAt(curIndex);
                types.RemoveAt(curIndex);
                curIndex--;
                if (curIndex >= 0)
                    curSelect -= expr[curIndex].Length;
            }
            showText();
        }

        private void leftShiftButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex > 0)
            {
                curIndex--;
                curSelect -= expr[curIndex].Length;
            }
            else if (curIndex == 0)
            {
                curIndex--;
                curSelect = 0;
            }
            showText();
        }

        private void rightShiftButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex < expr.Count - 1 && curIndex >= 0)
            {

                curSelect += expr[curIndex].Length;
                curIndex++;
            }
            else if (curIndex == -1 && expr.Count > 0)
            {
                curIndex++;
            }
            showText();
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "π");
            types.Insert(curIndex, Type.digit);
            showText();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (curIndex >= 0)
                    curSelect += expr[curIndex].Length;
                curIndex++;
                string text = btn.Text;
                expr.Insert(curIndex, text);
                if (text == "Sin" || text == "Cos" || text == "Tan"
                  || text == "Sinh" || text == "Cosh" || text == "Tanh"
                  || text == "NOT")
                    types.Insert(curIndex, Type.beforeUnOp);
                else
                    types.Insert(curIndex, Type.binOp);
                showText();
            }
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "e");
            types.Insert(curIndex, Type.digit);
            showText();
        }

        private void trueButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "True");
            types.Insert(curIndex, Type.digit);
            showText();
        }

        private void falseButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "False");
            types.Insert(curIndex, Type.digit);
            showText();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "(");
            types.Insert(curIndex, Type.leftBracket);
            showText();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, ")");
            types.Insert(curIndex, Type.rightBracket);
            showText();
        }

        private bool checkDigit()
        {
            int pointCount = 0;
            resultTxtBox.Text = "";
            if (digit.Length != 0)
            {
                if (digit[0] == '.')
                {
                    MessageBox.Show("小数点不能在第一位");
                    showText();
                    digit.Clear();
                    return false;
                }
                for (int i = 0; i < digit.Length; i++)
                {
                    if (digit[i] == '.')
                        pointCount++;
                }
                if (pointCount > 1)
                {
                    MessageBox.Show("一个数不能有多个小数点");
                    showText();
                    digit.Clear();
                    return false;
                }
                if (curIndex >= 0)
                    curSelect += expr[curIndex].Length;
                curIndex++;
                expr.Insert(curIndex, digit.ToString());
                types.Insert(curIndex, Type.digit);
                showText();
                digit.Clear();
            }
            return true;
        }
        private void dight_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                string text = btn.Text;
                digit.Append(text);
                resultTxtBox.Text = digit.ToString();
            }
        }

        private bool checkType()
        {
            List<Type> copytypes = new List<Type>(types);
            int leftBracketCount = 0;
            for (int i = 0; i < types.Count; i++)
            {
                if (types[i] == Type.leftBracket)
                {
                    leftBracketCount++;
                }
                else if (types[i] == Type.rightBracket)
                {
                    leftBracketCount--;
                    if (leftBracketCount < 0)
                    {
                        MessageBox.Show("表达式括号不匹配");
                        return false;
                    }
                }
            }
            if (leftBracketCount != 0)
            {
                MessageBox.Show("表达式括号不匹配");
                return false;
            }
            copytypes.RemoveAll(t => (t == Type.leftBracket || t == Type.rightBracket));
            for (int i = 0; i < copytypes.Count; i++)
            {
                if (copytypes[i] == Type.beforeUnOp)
                {
                    if (i == copytypes.Count - 1)
                    {
                        MessageBox.Show("表达式不能以前置一元运算符结尾");
                        return false;
                    }
                    if (copytypes[i + 1] == Type.binOp || copytypes[i+1] == Type.afterUnOp)
                    {
                        MessageBox.Show("前置一元运算符后面没有数值");
                        return false;
                    }
                }
                if (copytypes[i] == Type.afterUnOp)
                {
                    if (i == 0)
                    {
                        MessageBox.Show("表达式不能以后置一元运算符开头");
                        return false;
                    }
                    if (copytypes[i - 1] == Type.binOp || copytypes[i - 1] == Type.beforeUnOp)
                    {
                        MessageBox.Show("后置一元运算符前面没有数值");
                        return false;
                    }
                }
                if (copytypes[i] == Type.binOp)
                {
                    if (i == copytypes.Count - 1)
                    {
                        MessageBox.Show("表达式不能以二元运算符结尾");
                        return false;
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("表达式不能以二元运算符开头");
                        return false;
                    }
                    if (copytypes[i + 1] == Type.binOp || copytypes[i + 1] == Type.afterUnOp
                        || copytypes[i - 1] == Type.binOp || copytypes[i - 1] == Type.beforeUnOp
                        )
                    {
                        MessageBox.Show("二元运算符前后没有数值");
                        return false;
                    }
                }
                if(copytypes[i] == Type.digit)
                {
                    if( i < copytypes.Count - 1 && copytypes[i+1] == Type.digit)
                    {
                        MessageBox.Show("不能有两个连续的数字");
                        return false;
                    }
                }
            }
            return true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if(!checkDigit() || !checkType())
            {
                return;
            }
            else
            {
                Calculate.getExpr(expr);
                Object result = Calculate.getValue();
                resultTxtBox.Text = result.ToString();
            }
        }
    }
}
