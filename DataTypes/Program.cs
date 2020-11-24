using System;

namespace DataTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Quebrar o valor de pi
            double pi = 3.14;
            int piQuebrado = (int) pi;
            Console.WriteLine(piQuebrado);
        }
    }

    public class TiposPrimitivos
    {
        bool tipoBooleano;// true ou false (1 byte)
        byte tipoByte;// 0 a 255 (1 byte)
        sbyte tipoSbyte;// -128 a 127 (1 byte)
        short tipoShort;// -32768 a 32767 (2 bytes)
        ushort tipoUnshort;// 0 a 65535 (2 bytes)
        int tipoInt;// -2147483648 a 2147483647 (4 bytes)
        uint tipoUint;// 0 a 4294967295 (4 bytes)
        long tipoLong;// -9223372036854775808 a 9223372036854775807 (8 bytes)
        ulong tipoUlong;// 0 a 18446744073709551615 (8 bytes)
        float tipoFloat;// 1.5 x 10^-45 a 1.5 x 10^38 (4 bytes)
        double tipoDouble;// (8 bytes)
        decimal tipoDecimal;// (16 bytes)
        char tipoChar;// 0 a 65535(2 bytes)

        /* Como realizar um casting em csharp
        tipoInt = 1;
        tipoShort = (short) tipoInt;
        */
    }
}
