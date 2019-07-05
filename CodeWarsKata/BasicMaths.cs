namespace Solution
{
    public interface ICalculate
    {
        double Add(double var1, double var2);
        double Subtract(double var1, double var2);
        double Multiply(double var1, double var2);
        double Divide(double var1, double var2);
    }

    public class Calculate : ICalculate
    {
        public virtual double Add(double var1, double var2)
        {
            return var1 + var2;
        }

        public virtual double Subtract(double var1, double var2)
        {
            return var1 - var2;
        }

        public virtual double Multiply(double var1, double var2)
        {
            return var1 * var2;
        }

        public virtual double Divide(double var1, double var2)
        {
            return var1 / var2;
        }
    }

    public static class Program
    {
        private static ICalculate _calculate;

        public static void Main()
        {

        }

        public static double basicOp(char operation, double value1, double value2)
        {
            _calculate = new Calculate();

            switch (operation)
            {
                case '+':
                    return _calculate.Add(value1, value2);
                case '-':
                    return _calculate.Subtract(value1, value2);
                case '*':
                    return _calculate.Multiply(value1, value2);
                case '/':
                    return _calculate.Divide(value1, value2);
                default:
                    return -1;

            }
        }

    }


}
