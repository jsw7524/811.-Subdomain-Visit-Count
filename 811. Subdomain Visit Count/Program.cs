using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _811.Subdomain_Visit_Count
{
    public class Solution
    {
        private Dictionary<string, int> dic;
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            dic = new Dictionary<string, int>();
            foreach (string cpd in cpdomains)
            {
                var tmp = cpd.Split(' ');
                int number = int.Parse(tmp[0]);
                string domain = tmp[1];
                string subDomain = "";
                foreach (var s in domain.Split('.').Reverse())
                {
                    if ("" == subDomain)
                    {
                        subDomain = s;
                    }
                    else
                    {
                        subDomain = s + "." + subDomain;
                    }

                    if (dic.ContainsKey(subDomain))
                    {
                        dic[subDomain] = dic[subDomain]+number;
                    }
                    else
                    {
                        dic.Add(subDomain, number);
                    }
                }
            }
            return dic.Select(kp => kp.Value + " " + kp.Key).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
