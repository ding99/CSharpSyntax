using System;

namespace Temp01
{
	public class Verify01
	{
        public int StringPatternMatching(string pattern, string s)
        {
            int lp = pattern.Length, ls = s.Length;
            if (lp > ls)
                return 0;

            int n = 0;
            for (int i = 0; i + lp <= ls; i++)
                if (SubMatch(pattern, s.Substring(i, lp)))
                    n++;

            return n;
        }

        bool SubMatch(string p, string sub)
        {
            int l = p.Length;
            string t;
            bool res = true;

            for (int i = 0; i < l; i++)
            {
                if (p.Substring(i, 1) == "0")
                {
                    if ((t = sub.Substring(i, 1)) != "a" && t != "e" && t != "i" && t != "o" && t != "u" && t != "y")
                    {
                        res = false;
                        break;
                    }
                }
                else if (p.Substring(i, 1) == "1")
                {
                    if ((t = sub.Substring(i, 1)) == "a" || t == "e" || t == "i" || t == "o" || t == "u" || t == "y")
                    {
                        res = false;
                        break;
                    }
                }
            }

            Console.WriteLine(p + " / " + sub + " / " + res);
            return res;
        }
    }
}
