using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal_dll_csharp
{
    //自定义操作数类
    public class Number
    {
        //数值
        public object value = 0.0;
        //是否为double类型
        public bool isDouble = true;
        //是否为bool类型
        public bool isBool = false;
        //bool值
        public bool boolValue = false;

        public void copy(Number number)
        {
            value = number.value;
            isDouble = number.isDouble;
            isBool = number.isBool;
            boolValue = number.boolValue;
        }
    }

    //自定义运算符类
    public class Operator : Number
    {
        //运算符
        public string operatorType = null;
        //优先级
        public int priority = 0;
        //是否为一元运算符
        public bool isUnary = false;
    }

}
