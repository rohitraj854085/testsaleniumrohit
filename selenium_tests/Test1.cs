using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using selenium_tests;


namespace Test1
{
    public class TestArray
    {
        [Test]
        public void Array1()
        {
         
            string[] Emp = new string[3];
            Emp[0] = "Nitish";
            Emp[1] = "Rakesh";
            Emp[2] = "Vineet";

            string[][] JaggedArray = new string[3][];
            JaggedArray[0] = new string[3];
            JaggedArray[1] = new string[1];
            JaggedArray[2] = new string[2];

            JaggedArray[0][0] = "Bachelors";
            JaggedArray[0][1] = "Masters";
            JaggedArray[0][2] = "Doctorate";

            JaggedArray[1][0] = "Bachelors";

            JaggedArray[2][0] = "Masters";
            JaggedArray[2][1] = "Bachelors";

            for(int i=0;i<JaggedArray.Length;i++)
            {
                TestContext.Progress.WriteLine(Emp[i]);
                TestContext.Progress.WriteLine("------------------");
                string[] InnerArray = JaggedArray[i];
                for(int j=0;j<InnerArray.Length;j++)
                {
                    TestContext.Progress.WriteLine(InnerArray[j]);
                }
                TestContext.Progress.WriteLine("");
            }

         
        }
         
    }

}