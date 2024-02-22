namespace MISA.WebFresher052023.Demo
{
    public class Calculator
    {
        public long Add(int x, int y)
        {
            return x + (long)y;
        }

        public long Sub(int x, int y) 
        {
            return x - (long)y; 
        }

        public long Mul(int x, int y) 
        {
            return x * (long)y;
        }

        public double Div(int x, int y)
        {
            if(y == 0)
            {
                throw new Exception("Không chia được cho 0");
            }

            return x / (double)y;
        }

        public int Add(string s)
        {
            string[] numbersArray = s.Split(',');
            List<int> negativeList = new List<int>();
            int sum = 0, kt = 0;
            string negativeException = "Không chấp nhận toán tử âm: ";
            foreach (string number in numbersArray)
            {
                if(number == "")
                {
                    sum += 0;
                }
                else
                {
                    int x = int.Parse(number);
                    if(x < 0)
                    {
                        negativeException = negativeException + x + ", ";
                        kt++;
                    }
                    else
                    {
                        sum += x;
                    }
                }
            }
            if(kt != 0)
            {
                negativeException = negativeException.Substring(0, negativeException.Length - 2);
                throw new Exception(negativeException);
            }
            return sum;
        }
    }
}
