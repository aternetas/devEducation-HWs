using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomeworks.Test
{
    public static class TwoDimensionalArraysMock
    {
        public static int[,] GetMock(Enums.TwoDimensionalArraysMockType type)
        {
            switch (type)
            {
                case Enums.TwoDimensionalArraysMockType.ZeroOnly:
                    return new int[,]
                    {
                        { 0, 0, 0 },
                        { 0, 0, 0 },
                        { 0, 0, 0 },
                    };
                case Enums.TwoDimensionalArraysMockType.First:
                    return new int[,]
                    {
                        { 1, 14, 4 },
                        { -2, 0, 11 },
                        { -15, 8, -9 },
                    };
                case Enums.TwoDimensionalArraysMockType.Empty:
                    return new int[,] { };

                default:
                    throw new Exception();
            }
        }
    }
}
