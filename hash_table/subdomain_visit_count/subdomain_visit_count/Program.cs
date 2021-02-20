using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace subdomain_visit_count
{
    class Program
    {
        public static IEnumerable<string> SplitTld(string tld)
        {
            string[] tldSplit = tld.Split('.');
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < tldSplit.Length; i++)
            {
                builder.Append(tldSplit[i]);
                for (int j = i + 1; j < tldSplit.Length; j++)
                {
                   builder.AppendFormat(".{0}", tldSplit[j]);
                }

                string res = builder.ToString();
                builder.Length = 0;
                yield return res;
            }
        }

        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> lookup = new Dictionary<string, int>();
            List<string> domains = new List<string>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
                string[] split = cpdomains[i].Split(' ');
                string strCount = split[0];
                foreach (var item in SplitTld(split[1]))
                {
                    domains.Add(string.Format("{0} {1}", strCount, item));
                }
            }

            for (int i = 0; i < domains.Count; i++)
            {
                string[] split = domains[i].Split(' ');
                int count = Convert.ToInt32(split[0]);
                string tld = split[1];

                if (!lookup.ContainsKey(tld))
                {
                    lookup[tld] = count;
                }
                else
                {
                    lookup[tld] += count;
                }
            }

            return lookup.Aggregate(new List<string>(), (acc, curr) =>
            {
                acc.Add($"{curr.Value} {curr.Key}");
                return acc;
            });
        }

        static void Main(string[] args)
        {
            IList<string> res1 = SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });
        }
    }
}
