using System;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Compressed Strings!!");
            Program p = new Program();
            foreach(string arg in args)
            {
                var compressed = p.CompressString(arg);
                Console.WriteLine($"Original string: {arg}, Compressed string: {compressed}");
            }
        }

        public string CompressString(string originalString)
        {
            var compressedString = new System.Text.StringBuilder();

            var count = 0;

            for(var i = 0; i < originalString.Length; i++)
            {
                if(i == 0)
                {
                    compressedString.Append(originalString[i]);
                    count++;
                }
                else if (i == originalString.Length-1 && originalString[i] == originalString[i-1])
                {
                    count++;
                    compressedString.Append(count.ToString());
                }
                else if (i == originalString.Length-1 && originalString[i] != originalString[i-1])
                {
                    compressedString.Append(count.ToString());
                    count = 1;
                    compressedString.Append(originalString[i]);
                    compressedString.Append(count.ToString());
                }
                else if (originalString[i] == originalString[i-1])
                {
                    count++;
                }

                else if (originalString[i] != originalString[i-1])
                {
                    compressedString.Append(count.ToString());
                    count = 1;
                    compressedString.Append(originalString[i]);
                }
            }

            return compressedString.Length < originalString.Length ? compressedString.ToString() : originalString;
        }
    }
}
