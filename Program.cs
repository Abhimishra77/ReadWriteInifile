using System;

namespace ReadWriteIni
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
             IniFile settingsIni = new IniFile (@".\\Testdata.ini");
 
            string executionMode = settingsIni.Read ("BrowserName", "BrowserInfo").ToLower ();
            Console.WriteLine (executionMode);
 
            string WebdriverToUse = settingsIni.Read ("WebDriverLocation", "BrowserInfo").ToLower ();
            Console.WriteLine (WebdriverToUse);
            settingsIni.Write("TimeOut","4000","BrowserInfo");

            string WebdriverTotime = settingsIni.Read ("TimeOut", "BrowserInfo");
            Console.WriteLine (WebdriverTotime);
            settingsIni.Write("BrowserName","IE","BrowserInfo");
            settingsIni.Write("Url","www.amazon.in","AppUnderTest");
            settingsIni.Write("Browser","CH","AppUnderTest");
            settingsIni.Write("Timeout","6000","AppUnderTest");


            

        }
    }
}
