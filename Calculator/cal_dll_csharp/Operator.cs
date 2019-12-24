using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal_dll_csharp
{
    public class Number
    {
        public double Value { set; get; }
        public bool IsDouble { set; get; }
        public bool IsBool { set; get; }
        public bool BoolValue { set; get; }
        public virtual double cal()
        {
            if (!IsBool)
                return Value;
            return BoolValue ? 1.0 : 0.0;
        }
    }


    public class UnaryOperator : Number
    {
        public Number Next { get; set; }
        public string Operator { get; set; }
        public override double cal()
        {
            try
            {
                if (Next == null)
                    return 1 / 0.0;
                switch (Operator)
                {
                    case "Sin":
                        return Math.Sin(Next.cal());
                    case "Sinh":
                        return Math.Sinh(Next.cal());
                    case "Cos":
                        return Math.Cos(Next.cal());
                    case "Cosh":
                        return Math.Cosh(Next.cal());
                    case "Tan":
                        return Math.Tan(Next.cal());
                    case "Tanh":
                        return Math.Tanh(Next.cal());
                    case "2√":
                        if (Next.cal() < 0)
                            throw new CalException("小于0的数不能开二次根号");
                        return Math.Sqrt(Next.cal());
                    case "3√":
                        return Math.Pow(Next.cal(), 1 / 3);
                    case "^2":
                        return Math.Sqrt(Next.cal() * Next.cal());
                    case "^3":
                        return Math.Pow(Next.cal(), 3);
                    case "NOT":
                        if (Next.IsBool)
                        {
                            IsBool = true;
                            BoolValue = !Next.BoolValue;
                            return BoolValue ? 1.0 : 0.0;
                        }
                        IsBool = false;
                        return ~(int)Next.cal();
                    default:
                        return Next.cal();
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

    public class BinaryOperator : Number
    {
        public Number Left { get; set; }
        public Number Right { get; set; }
        public string Operator { get; set; }
        public override double cal()
        {
            if (Left == null || Right == null)
                return 1 / 0.0;
            try
            {
                switch(Operator)
                {
                    case "+":
                        return Left.cal() + Right.cal();
                    case "-":
                        return Left.cal() - Right.cal();
                    case "*":
                        return Left.cal() * Right.cal();
                    case "/":
                        if (Right.cal() - 0 < 0.00001)
                            throw new CalException("不能除以0");
                        return Left.cal() / Right.cal();
                    case "%":
                        if (Right.cal() - 0 < 0.00001)
                            throw new CalException("不能对0求余数");
                        return Left.cal() % Right.cal();
                    case "^":
                        return Math.Pow(Left.cal(), Right.cal());
                    case "√":
                        if (Right.cal() - 0 < 0.5)
                            throw new CalException("开n次根号,n只能是大于1的正数");
                        return Math.Pow(Right.cal(), 1 /(int) Left.cal());
                    case ">":
                         IsBool = true;
                         BoolValue = Left.cal() > Right.cal();
                         return BoolValue ? 1.0 : 0.0;
                    case "<":
                        IsBool = true;
                        BoolValue = Left.cal() < Right.cal();
                        return BoolValue ? 1.0 : 0.0;
                    case ">=":
                        IsBool = true;
                        BoolValue = Left.cal() >= Right.cal();
                        return BoolValue ? 1.0 : 0.0;
                    case "<=":
                        IsBool = true;
                        BoolValue = Left.cal() <= Right.cal();
                        return BoolValue ? 1.0 : 0.0;
                    case "==":
                        IsBool = true;
                        BoolValue = Math.Abs(Left.cal() - Right.cal()) < 0.00001;
                        return BoolValue ? 1.0 : 0.0;
                    case "!=":
                        IsBool = true;
                        BoolValue = Math.Abs(Left.cal() - Right.cal()) >= 0.00001;
                        return BoolValue ? 1.0 : 0.0;
                    case "AND":
                        if (Left.IsBool && Right.IsBool)
                        {
                            IsBool = true;
                            BoolValue = Left.BoolValue && Right.BoolValue;
                            return BoolValue ? 1.0 : 0.0;
                        }
                        IsBool = false;
                        return (int)Left.cal() & (int)Right.cal();
                    case "OR":
                        if (Left.IsBool && Right.IsBool)
                        {
                            IsBool = true;
                            BoolValue = Left.BoolValue || Right.BoolValue;
                            return BoolValue ? 1.0 : 0.0;
                        }
                        IsBool = false;
                        return (int)Left.cal() | (int)Right.cal();
                    case "XOR":
                        if (Left.IsBool && Right.IsBool)
                        {
                            BoolValue = Left.BoolValue ^ Right.BoolValue;
                            return BoolValue ? 1.0 : 0.0;
                        }
                        IsBool = false;
                        return (int)Left.cal() ^ (int)Right.cal();
                    default:
                        return Left.cal();
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
