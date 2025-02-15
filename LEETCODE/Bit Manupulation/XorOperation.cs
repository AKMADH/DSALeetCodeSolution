using System;
namespace Application
{
	public class XorOperation
	{
        public int XorOperation(int n, int start)
        {
            int Res = 0;
            for (int i = 0; i < n; i++)
            {
                
                Res ^=  start * 2 + i;
            }
            return Res;
        }
    }
}

