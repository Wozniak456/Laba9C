using System;

namespace MyLib
{
    public static class FirstLab
    {
        public static string Novi_str(int number, string str)
        {
            string delimiterChars = "- ,.:!?;";
            string ps = "", ns = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (delimiterChars.Contains(str[i]))
                {
                    if (ps.Length >= number)
                    {
                        ns += ps;
                    }
                    ns += str[i];
                    ps = "";
                }
                else
                {
                    ps += str[i];
                }
            }
            if (ps.Length >= number)
            {
                ns += ps;
            }
            return ns;
        }
    }
}
