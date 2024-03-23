using System;
using System.Linq;

namespace HashExercise
{
    internal class Binarry
    {
        public Binarry()
        {
            Console.WriteLine("Enter your Message");
            string message = Console.ReadLine();
            string[] inForMessage = StringInFore(message);
            string[] reverseMessage = StringReverse(inForMessage);
            int[] asciiValues = ReverseInAscii(reverseMessage);
            string[] BinaCode = ConvertToBinaryCode(asciiValues);
            double MyBinarode = ChangeMyBinarry(BinaCode);
            Console.WriteLine(MyBinarode);
        }

        public string[] StringInFore(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return new string[0];
            }
            int parts = (int)Math.Ceiling((double)message.Length / 4);
            string[] result = new string[parts];
            for (int i = 0; i < parts; i++)
            {
                int indexing = i * 4;
                int length = Math.Min(4, message.Length - indexing);
                result[i] = message.Substring(indexing, length);
            }
            return result;
        }

        static string[] StringReverse(string[] arr)
        {
            string[] result = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = new string(arr[i].Reverse().ToArray());
            }
            return result;
        }

        static int[] ReverseInAscii(string[] reversedArr)
        {
            int[] asciiValues = new int[reversedArr.Sum(s => s.Length)];
            int index = 0;
            foreach (string block in reversedArr)
            {
                foreach (char c in block)
                {
                    asciiValues[index++] = (int)c;
                }
            }
            return asciiValues;
        }
        static string[] ConvertToBinaryCode(int[] asciiValues)
        {
            string[] binaryCodes = new string[asciiValues.Length];

            for (int i = 0; i < asciiValues.Length; i++)
            {
                binaryCodes[i] = Convert.ToString(asciiValues[i], 2).PadLeft(8, '0');
            }

            return binaryCodes;
        }
        static double ChangeMyBinarry(string[] binarCode)
        {
            int count = 0;
            double result = 0;
            while (count < binarCode.Length)
            {
                result += Convert.ToDouble(binarCode[count]);
                count++;
            }
            return (double)result;
        }

    }
}
