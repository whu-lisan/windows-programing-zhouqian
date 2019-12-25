using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal_dll_csharp
{

    public class Calculate
    {
        public static Stack<Number> expr = new Stack<Number>();//后缀表达式
        public static Stack<Operator> operators = new Stack<Operator>();//运算符堆栈
        public static Stack<Number> numbers = new Stack<Number>();//操作数堆栈

        public static Number getNumber(string s)
        {
            Number number = null;
            int number_int = 0;
            double number_double = 0.0;
            bool success_int = int.TryParse(s, out number_int);
            bool success_double = double.TryParse(s, out number_double);
            if(s.Equals("e"))
            {
                number = new Number();
                number.isBool = false;
                number.value = Math.E;
            }
            else if (s.Equals("π"))
            {
                number = new Number();
                number.isBool = false;
                number.value = Math.PI;
            }
            //如果为操作数
            else if (success_int || success_double)
            {
                number = new Number();
                number.isBool = false;
                number.isDouble = !success_int;
                number.value = success_int ? number_int : number_double;
            }
            else if (s.Equals("True") || s.Equals("False"))
            {
                number = new Number();
                number.isBool = true;
                number.isDouble = false;
                number.boolValue = s.Equals("True");
                number.value = number.boolValue ? 1 : 0;
            }
            else //为运算符
            {
                number = new Operator();
                Operator @operator = (Operator)number;
                @operator.operatorType = s;
                if (s.Equals("^2") || s.Equals("^3") || s.Equals("2√") || s.Equals("3√")
                || s.Equals("Sin") || s.Equals("Cos") || s.Equals("Tan") || s.Equals("Sinh")
                || s.Equals("Cosh") || s.Equals("Tanh") || s.Equals("NOT"))
                {
                    @operator.isUnary = true;
                    @operator.priority = 1;
                }
                else if (s.Equals("^") || s.Equals("√"))
                {
                    @operator.priority = 2;
                }
                else if (s.Equals("*") || s.Equals("/") || s.Equals("%"))
                {
                    @operator.priority = 3;
                }
                else if (s.Equals("+") || s.Equals("-"))
                {
                    @operator.priority = 4;
                }
                else if (s.Equals(">") || s.Equals("<") || s.Equals(">=") || s.Equals("<="))
                {
                    @operator.priority = 5;
                }
                else if (s.Equals("!=") || s.Equals("=="))
                {
                    @operator.priority = 6;
                }
                else if (s.Equals("XOR"))
                {
                    @operator.priority = 7;
                }
                else if (s.Equals("AND"))
                {
                    @operator.priority = 8;
                }
                else if (s.Equals("OR"))
                {
                    @operator.priority = 9;
                }
            }
            return number;
        }

        public static void getExpr(List<string> vs)
        {
            foreach(string s in vs)
            {
                Number number = getNumber(s);
                if (number.GetType() == typeof(Number))
                    numbers.Push(number);
                else if(number.GetType() == typeof(Operator))
                {
                    Operator @operator = (Operator)number;
                    if (@operator.operatorType.Equals("("))
                        operators.Push(@operator);
                    else if(@operator.operatorType.Equals(")"))
                    {
                        while (operators.Peek().operatorType != "(")
                        {
                            Number op = operators.Pop();
                            numbers.Push(op);
                        }
                        operators.Pop();
                    }else
                    {
                        //该运算符为非括号运算符：
                        //考虑栈顶为空的情况 
                        if (operators.Count <= 0)
                        {
                            operators.Push(@operator);
                            continue;
                        }
                        // (a) 若运算符堆栈栈顶的运算符为括号，则直接存入运算符堆栈。
                        ////符合为左括号 直接存入运算符
                        if (operators.Peek().operatorType == "(")
                        {
                            operators.Push(@operator);
                        }
                        else
                        {
                            //(b) 若比运算符堆栈栈顶的运算符优先级高，则直接存入运算符堆栈。  
                            if (@operator.priority < operators.Peek().priority)
                            {
                                operators.Push(@operator);
                            }
                            else
                            {
                                // (c) 若比运算符堆栈栈顶的运算符优先级低或相等，则输出栈顶运算符到操作数堆栈，并将当前运算符压入运算符堆栈。
                                Operator op = operators.Pop();
                                numbers.Push(op);
                                operators.Push(@operator);
                            }
                        }
                    }
                }
            }
            //当表达式读取完成后运算符堆栈中尚有运算符时，则依序取出运算符到操作数堆栈，直到运算符堆栈为空。
            while (operators.Count > 0)
            {
                Operator op = operators.Pop();
                numbers.Push(op);
            }
            //反转numbers获取正常的后缀表达式
            while (numbers.Count > 0)
            {
                Number number = numbers.Pop();
                expr.Push(number);
            }
        }

        public static object getValue()
        {
            //临时存储计算数据
            Stack<Number> resultSt = new Stack<Number>();
            while (expr.Count > 0)
            {
                Number number = expr.Peek();
                if (number.GetType() == typeof(Number))
                {
                    //如果字符是一个操作数，把它压入堆栈。
                    resultSt.Push(number);
                }
                else
                {
                    Operator @operator = (Operator)number;
                    if (@operator.isUnary)
                    {
                        Number number1 = resultSt.Pop();
                        @operator.value = unaryOperate(@operator, number1);
                        Number reslt = new Number();
                        reslt.copy(@operator);
                        resultSt.Push(reslt);
                    }
                    else
                    {
                        //如果是二元运算符，弹出两个操作数，执行恰当操作，
                        //然后把结果压入堆栈。如果您不能够弹出两个操作数，后缀表达式的语法就不正确。 
                        Number number1 = resultSt.Pop();
                        Number number2 = resultSt.Pop();
                        @operator.value = binaryOperate(@operator, number2, number1);
                        Number reslt = new Number();
                        reslt.copy(@operator);
                        resultSt.Push(reslt);
                    }
                }
                expr.Pop();
            }
            Number result = resultSt.Peek();
            return result.isDouble ? (double)result.value: (int)(double)result.value;
        }

        public static object unaryOperate(Operator @operator, Number number)
        {
            try
            {
                if (number == null)
                    return 1 / 0.0;
                double result = 0.0;
                double value = (double)number.value;
                if (number.GetType() == typeof(Operator))
                    throw new CalException("请检查是否存在两个连续运算符");
                switch (@operator.operatorType)
                {
                    case "Sin":
                        @operator.isDouble = true;
                        return Math.Sin(value);
                    case "Sinh":
                        return Math.Sinh(value);
                    case "Cos":
                        return Math.Cos(value);
                    case "Cosh":
                        return Math.Cosh(value);
                    case "Tan":
                        return Math.Tan(value);
                    case "Tanh":
                        return Math.Tanh(value);
                    case "2√":
                        if (value < 0)
                            throw new CalException("小于0的数不能开二次根号");
                        return Math.Sqrt(value);
                    case "3√":
                        return Math.Pow(value, 1 / 3);
                    case "^2":
                        result = value * value;
                        @operator.isDouble = number.isDouble;
                        return number.isDouble ? result : (int) result;
                    case "^3":
                        result = value * value * value;
                        @operator.isDouble = number.isDouble;
                        return number.isDouble ? result : (int)result;
                    case "NOT":
                        @operator.isDouble = false;
                        if (number.isBool)
                        {
                            @operator.isBool = true;
                            @operator.boolValue = !number.boolValue;
                            return @operator.boolValue ? 1 : 0;
                        }
                        @operator.isBool = false;
                        return ~(int)number.value;
                    default:
                        return number.value;
                }
            }
            catch (CalException e)
            {
                MessageBox.Show("Error", e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error", e.Message);
            }
            return 0.0;
        }

        public static object binaryOperate(Operator @operator, Number left, Number right)
        {
            if (left == null || right == null)
                return 1 / 0.0;
            double result = 0.0;
            if (left.GetType() == typeof(Operator) || right.GetType() == typeof(Operator))
                throw new CalException("请检查是否存在两个连续运算符");
            double leftValue = (double)left.value;
            double rightValue = (double)right.value;
            try
            {
                switch (@operator.operatorType)
                {
                    case "+":
                        result = leftValue + rightValue;
                        @operator.isDouble = left.isDouble || right.isDouble;
                        return @operator.isDouble ? result : (int)result;
                    case "-":
                        result = leftValue - rightValue;
                        @operator.isDouble = left.isDouble || right.isDouble;
                        return @operator.isDouble ? result : (int)result;
                    case "*":
                        result = leftValue * rightValue;
                        @operator.isDouble = left.isDouble || right.isDouble;
                        return @operator.isDouble ? result : (int)result;
                    case "/":
                        if (rightValue - 0 < 0.00001)
                            throw new CalException("不能除以0");
                        @operator.isDouble = (leftValue % rightValue) < 0.00001;
                        result = leftValue / rightValue;
                        return @operator.isDouble ? result : (int)result;
                    case "%":
                        if (rightValue - 0 < 0.00001)
                            throw new CalException("不能对0求余数");
                        result = leftValue * rightValue;
                        @operator.isDouble = left.isDouble || right.isDouble;
                        return @operator.isDouble ? result : (int)result;
                    case "^":
                        result = Math.Pow(leftValue, rightValue);
                        @operator.isDouble = left.isDouble || right.isDouble;
                        return @operator.isDouble ? result : (int)result;
                    case "√":
                        if (rightValue< 0.5)
                            throw new CalException("开n次根号,n只能是大于1的正数");
                        return Math.Pow(rightValue, 1.0 / (int)leftValue);
                    case ">":
                        @operator.isBool = true;
                        @operator.isDouble = false;
                        @operator.boolValue = leftValue > rightValue;
                        return @operator.boolValue ? 1 : 0;
                    case "<":
                        @operator.isBool = true;
                        @operator.isDouble = false;
                        @operator.boolValue = leftValue < rightValue;
                        return @operator.boolValue ? 1 : 0;
                    case ">=":
                        @operator.isBool = true;
                        @operator.isDouble = false;
                        @operator.boolValue = leftValue >= rightValue;
                        return @operator.boolValue ? 1 : 0;
                    case "<=":
                        @operator.isBool = true;
                        @operator.isDouble = false;
                        @operator.boolValue = leftValue <= rightValue;
                        return @operator.boolValue ? 1 : 0;
                    case "==":
                        @operator.isBool = true;
                        @operator.isDouble = false;
                        @operator.boolValue = Math.Abs(leftValue - rightValue) < 0.00001;
                        return @operator.boolValue ? 1 : 0;
                    case "!=":
                        @operator.isBool = true;
                        @operator.isDouble = false;
                        @operator.boolValue = Math.Abs(leftValue - rightValue) >= 0.00001;
                        return @operator.boolValue ? 1 : 0;
                    case "AND":
                        @operator.isDouble = false;
                        if (left.isBool && right.isBool)
                        {
                            @operator.isBool = true;
                            @operator.boolValue = left.boolValue && right.boolValue;
                            return @operator.boolValue ? 1 : 0;
                        }
                        @operator.isBool = false;
                        return (int)left.value & (int)right.value;
                    case "OR":
                        @operator.isDouble = false;
                        if (left.isBool && right.isBool)
                        {
                            @operator.isBool = true;
                            @operator.boolValue = left.boolValue || right.boolValue;
                            return @operator.boolValue ? 1 : 0;
                        }
                        @operator.isBool = false;
                        return (int)left.value | (int)right.value;
                    case "XOR":
                        @operator.isDouble = false;
                        if (left.isBool && right.isBool)
                        {
                            @operator.boolValue = left.boolValue ^ right.boolValue;
                            return @operator.boolValue ? 1 : 0;
                        }
                        @operator.isBool = false;
                        return (int)left.value ^ (int)right.value;
                    default:
                        return left.value;
                }
            }
            catch (CalException e)
            {
                MessageBox.Show("Error", e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error", e.Message);
            }
            return 0.0;
        }
    }

}
