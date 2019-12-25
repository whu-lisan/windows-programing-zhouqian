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
    enum type
    {
        unOp, binOp, leftBracket, rightBracket, digit,
    }
    public partial class MainForm : Form
    {
        private List<string> expr = new List<string>();
        private List<type> types = new List<type>();
        private int curIndex = -1;
        private int curSelect = 0;
        private StringBuilder digit = new StringBuilder();

        public MainForm()
        {
            InitializeComponent();
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void juniorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void programGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void seniorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void matrixButton_Click(object sender, EventArgs e)
        {
            Form matrixForm = new MatrixForm();
            matrixForm.Show();
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
            types.Insert(curIndex, type.unOp);
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
            types.Insert(curIndex, type.unOp);
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
            types.Insert(curIndex, type.binOp);
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
            types.Insert(curIndex, type.unOp);
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
            types.Insert(curIndex, type.unOp);
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
            types.Insert(curIndex, type.binOp);
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
            types.Insert(curIndex, type.digit);
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
                    types.Insert(curIndex, type.unOp);
                else
                    types.Insert(curIndex, type.binOp);
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
            types.Insert(curIndex, type.digit);
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
            types.Insert(curIndex, type.digit);
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
            types.Insert(curIndex, type.digit);
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
            types.Insert(curIndex, type.leftBracket);
            showText();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (!checkDigit())
                return;
            if (curIndex >= 0)
                curSelect += expr[curIndex].Length;
            curIndex++;
            expr.Insert(curIndex, "(");
            types.Insert(curIndex, type.rightBracket);
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
                types.Insert(curIndex, type.digit);
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
            List<type> copytypes = new List<type>(types);

            int leftBracketCount = 0;
            for (int i = 0; i < types.Count; i++)
            {
                if (copytypes[i] == type.leftBracket)
                {
                    leftBracketCount++;
                    copytypes.RemoveAt(i);
                }
                else if (copytypes[i] == type.rightBracket)
                {
                    leftBracketCount--;
                    copytypes.RemoveAt(i);
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
            for (int i = 0; i < copytypes.Count; i++)
            {
                if (copytypes[i] == type.unOp)
                {
                    if (i == copytypes.Count - 1)
                    {
                        MessageBox.Show("表达式不能以一元运算符结尾");
                        return false;
                    }
                    if (copytypes[i + 1] == type.binOp)
                    {
                        MessageBox.Show("一元运算符后面没有数值");
                        return false;
                    }
                }
                if (copytypes[i] == type.binOp)
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
                    if (copytypes[i + 1] == type.binOp || copytypes[i - 1] == type.binOp
                        || copytypes[i - 1] == type.unOp)
                    {
                        MessageBox.Show("二元运算符前后没有数值");
                        return false;
                    }
                }
                if(copytypes[i] == type.digit)
                {
                    if( i < copytypes.Count - 1 && copytypes[i+1] == type.digit)
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
