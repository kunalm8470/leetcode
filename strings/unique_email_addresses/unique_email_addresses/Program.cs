using System;
using System.Collections.Generic;
using System.Text;

namespace unique_email_addresses
{
    class Program
    {
        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> hs = new HashSet<string>();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < emails.Length; i++)
            {
                string currentEmail = emails[i];
                string[] emailSplit = currentEmail.Split('@');
                string localName = emailSplit[0];
                string domainName = emailSplit[1];

                string[] localNameSplit = localName.Split('+');

                if (localNameSplit != default(string[]))
                {
                    string beforePlus = localNameSplit[0];
                    for (int j = 0; j < beforePlus.Length; j++)
                    {
                        if (beforePlus[j] != '.')
                        {
                            builder.Append(beforePlus[j]);
                        }
                    }
                    hs.Add($"{builder}@{domainName}");
                    builder.Length = 0;
                }
                else
                {
                    for (int j = 0; j < localName.Length; j++)
                    {
                        if (localName[j] != '.')
                        {
                            builder.Append(localName[j]);
                        }
                    }
                    hs.Add($"{builder}@{domainName}");
                    builder.Length = 0;
                }
            }

            return hs.Count;
        }

        static void Main(string[] args)
        {
            int res1 = NumUniqueEmails(new[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });
            int res2 = NumUniqueEmails(new[] { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" });
        }
    }
}
