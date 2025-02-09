using System;
namespace Application
{
	public class Productoffactorsofnumber
	{
		public int ProductOfFactor(int n)
        {
             long product = 1;
            long mod = 100000007;
            for (int i = 1; i*i <=n ; i++)
            {
                if (n % i == 0)
                {
                    if (n / i == i)
                    {
                        product =(product*i)%mod;
                    }
                    else
                    {
                        product = (product * i * (n / i)) % mod;
                    }
                }
            }
            return product;
        }
	}
}

