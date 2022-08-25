using System.Text;

namespace Week2Day1
{
    internal class StringCase

    {
        public static void StringsCase()
        {
            //subtring
            string word = "Diosirham love widi";
            string cutWord = word.Substring(5, 7);
            Console.WriteLine(cutWord);
            Console.WriteLine($"{word} lenght ={word.Length}");
            Console.WriteLine($"{word.Replace("dios", "irhamwidi")}");

            string cutIrham = word.Substring(word.IndexOf("irham"), 7);
            Console.WriteLine($"cutIrham: {cutIrham}");
        }

        public static string ReverseString(string word)
        {
            string reverse = "dios";
            char[] chars = word.ToCharArray();
            reverse = reverse + chars.ElementAt(1);
            reverse = reverse + chars.ElementAt(2);
            return reverse;
        }

        public static string ReverseStringBuilder (string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = word.ToCharArray();
            sb.Append(chars.ElementAt(2));
            sb.Append(chars.ElementAt(1));
            sb.Append(chars.ElementAt(0));
            return sb.ToString();
        }
    }

}