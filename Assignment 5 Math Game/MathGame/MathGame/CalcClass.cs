using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MathGame
{
    class CalcClass
    {
        GameInfo gInfo;
        public bool solResult(int num1, int num2, GameInfo gameInfo, int result)
        {
            gInfo = gameInfo;
            if(gameInfo.gType == 1)
            {
                if(num1 + num2 == result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(gameInfo.gType == 2)
            {
                if(num1 - num2 == result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(gameInfo.gType == 3)
            {
                if(num1 * num2 == result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(num1 / num2 == result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int createRand()
        {
            int num = 0;
            Random rand1 = new Random();
            num = rand1.Next(1, 11);
            return num;
        }

        public bool validRand(int num1, int num2, GameInfo gInfo)
        {
            if (gInfo.gType == 2)
            {
                if (num1 - num2 < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (num1 % num2 == 0)
                {
                    if (num2 == 1)
                    {
                        return false;
                    }
                    else if (num1 == num2)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
