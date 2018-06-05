using System;
using System.Collections.Generic;
using System.Linq;
using _811.Subdomain_Visit_Count;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();
            string[] testData = { "9001 discuss.leetcode.com" };
            var result=sln.SubdomainVisits(testData);
            IList<string> ans = new List<string>() { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" };
            Assert.AreEqual(JsonConvert.SerializeObject(result.OrderBy(r=>r)), JsonConvert.SerializeObject(ans.OrderBy(a=> a)));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();
            string[] testData = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            var result = sln.SubdomainVisits(testData);
            IList<string> ans = new List<string>() { "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com", "951 com" };
            Assert.AreEqual(JsonConvert.SerializeObject(result.OrderBy(r => r)), JsonConvert.SerializeObject(ans.OrderBy(a => a)));
        }
    }
}
