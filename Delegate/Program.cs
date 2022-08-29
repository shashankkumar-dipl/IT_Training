namespace Delegate
{
    public class Program
    {
        delegate void multiCastDelegate(ref string str);
        public static void Main (String[] args)
        {
            multiCastDelegate multi;
            multiCastDelegate multi1 = ReplaceString;
            multiCastDelegate multi2 = RemoveSpaces;
            multiCastDelegate multi3 = ReverseString;

            string str = " This is the string that will accept operations";
            multi = multi1;
            multi += multi2;
            multi += multi3;
            multi(ref str);


            static void ReplaceString(ref string str)
            {
                Console.WriteLine("Replacing String");
                str = str.Replace('r', '-');
                Console.WriteLine(str + "\n");
            }

            static void RemoveSpaces(ref string str)
            {
                Console.WriteLine("Removing Spaces");
                for (int i = 0, j = str.Length; i < j; i++)
                {
                    if (str[i] == ' ')
                    {
                        str.Remove(i);
                    }
                }
                Console.WriteLine(str + "\n");
            }

            static void ReverseString(ref string str)
            {
                var temp = "";
                for (int i = 0, j = str.Length - 1; j >= 0; i++, j--)
                {
                    temp += str[j];
                }
                str = temp;
                Console.WriteLine("Reversing String");

                Console.WriteLine(str);
            }

        }
    }
}