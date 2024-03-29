namespace task88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "salam,      Dunya";
            metin = BosluqlariDuzelt(metin);
            Console.WriteLine(metin);
        }

        static string BosluqlariDuzelt(string input)
        {
            char[] chars = input.ToCharArray();
            bool bosluqTapildisukur = false;
            int index = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ' && !bosluqTapildisukur)
                {
                    bosluqTapildisukur = true;
                    chars[index++] = chars[i];
                }
                else if (chars[i] != ' ')
                {
                    bosluqTapildisukur = false;
                    chars[index++] = chars[i];
                }
            }

            return new string(chars, 0, index);




            string user = "Aysa91";
            bool duzdurse = true;

            bool number = false;
            bool upper = false;
            bool lower = false;

            for (int i = 0; i < user.Length; i++)
            {
                char c = user[i];
                if (c >= '0' && c <= '9')
                    number = true;
                else if (c >= 'A' && c <= 'Z')
                    upper = true;
                else if (c >= 'a' && c <= 'z')
                    lower = true;
            }

            if (!number || !upper || !lower)
                duzdurse = false;

            Console.WriteLine(duzdurse);




            {
                string text = "ay muellim kollektvium ola ola butun gece yatmadan task yazmaq derd olarmis insana ve sehven silinib tezeden sabahin 7de yazmaq daha pis derd olarmis insana ";
                string firstWord = Getthefirstword(text);
                Console.WriteLine("ilk soz : " + firstWord);
            }

            static string Getthefirstword(string metin)
            {

                string[] words = metin.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                if (words.Length == 0)
                {
                    return null;
                }

                return words[0];
            }



        }

        
    }
}
