public class NumberofCommonFactors
{

    public int CommonFactors(int a, int b)
    {
        int gno = Gcd(a, b);
        int res = CountDivision(gno);
        return res;
    }

   public int  Gcd(int a,int b)
    {
        while(b!=0){
            int temp = b;
            b=a%b;
            a=temp;

        }
        return a;

    }
    public int CountDivision(int n)
    {
        int count = 0;
        for (int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0 && n/i!=i)
            {
                count+=2;
            }
            else if (n % i == 0)
            {
                count++;
            }
        }
        return count;
    }

}


