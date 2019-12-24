using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal_dll_csharp
{
    
    public class Calculate
    {
        public static Number root;

        public static Number createNode(string s)
        {
            Number node = null;
            int number_int = 0;
            double number_double = 0.0;
            bool success_int = Int32.TryParse(s, out number_int);
            bool success_double = Double.TryParse(s, out number_double);
            if (success_int || success_double)
            {
                node = new Number();
                node.IsBool = false;
                node.IsDouble = !success_int;
                node.Value = success_int ? number_int : number_double ;
            }
            else if(s.Equals("True") || s.Equals("False"))
            {
                node = new Number();
                node.IsBool = true;
                node.IsDouble = false;
                node.BoolValue = s.Equals("True");
                node.Value = node.BoolValue ? 1.0 : 0.0;
            }
            return node;
        }

        public static void createCalTree(List<string> calString)
        {
            root = new Number();
        }

        public static void postOederCalTree(Number node)
        {
            if (node == null)
                return;
            if (node.GetType() == typeof(Number))
                return;
            if(node.GetType() == typeof(UnaryOperator))
            {
                UnaryOperator n = (UnaryOperator)node;
                postOederCalTree(n.Next);
                node.IsDouble = n.Next.IsDouble;
                if (!node.IsDouble)
                    node.Value = (int)n.cal();
                else
                    node.Value = n.cal();
            }
            if (node.GetType() == typeof(BinaryOperator))
            {
                BinaryOperator n = (BinaryOperator)node;
                postOederCalTree(n.Left);
                postOederCalTree(n.Right);
                node.IsDouble = n.Left.IsDouble || n.Right.IsDouble;
                if (!node.IsDouble)
                    node.Value = (int)n.cal();
                else
                    node.Value = n.cal();
            }
        }

    }
}
