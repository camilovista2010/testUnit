﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;

namespace NUnitTestProject1
{
    [TestFixture]
    public class PRUEBA1Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> Vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            Vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void pRUEBA1()
        {

            var Preuba = JsonConvert.DeserializeObject<DtoPreuba[]>(File.ReadAllText(@"D:\Prueba\Testestructura.json"));
            driver.Navigate().GoToUrl("https://www.teaediciones.net/portal/asp/teacorrige/entradappal.asp");
            driver.Manage().Window.Size = new System.Drawing.Size(1024, 728);
            driver.SwitchTo().Frame(0);
            driver.FindElement(By.Id("Codigo")).Click();
            driver.FindElement(By.Id("Codigo")).SendKeys("velasquezlina@yahoo.es");
            driver.FindElement(By.Id("userPass")).Click();
            driver.FindElement(By.Id("userPass")).SendKeys("colombo");
            driver.FindElement(By.Id("btnLogin")).Click();
            driver.FindElement(By.CssSelector("body > div.ui-dialog.ui-widget.ui-widget-content.ui-corner-all.ui-front.ui-dialog-buttons.ui-draggable > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button")).Click();
            driver.FindElement(By.Id("PestanyaTest5")).Click();
            driver.FindElement(By.XPath("//*[@id='PestanyaTest5']/div/div[7]/div[1]/a")).Click();

            foreach( DtoPreuba t in Preuba)
            {
                Thread.Sleep(5000);
                driver.FindElement(By.Id("Submit2")).Click();
                for (int i = 0; i < t.nombre.Length; i++)
                { 
                    driver.FindElement(By.Id("nombre")).SendKeys(t.nombre[i].ToString());
                    Thread.Sleep(1000);
                }
                Thread.Sleep(1000);
                //driver.FindElement(By.Id("edad")).Click();
                driver.FindElement(By.Id("edad")).Clear();
                driver.FindElement(By.Id("edad")).SendKeys(t.edad);
                driver.FindElement(By.Id("sexo")).Click();
                {
                    var dropdown = driver.FindElement(By.Id("sexo"));
                    dropdown.FindElement(By.XPath($"//option[. = '{t.sexo}']")).Click();
                }
                driver.FindElement(By.Id("sexo")).Click();
                driver.FindElement(By.Id("guardarafegir")).Click();
                driver.FindElement(By.Id("VCuadernilloCTC")).Click();
                {
                    var dropdown = driver.FindElement(By.Id("VCuadernilloCTC"));
                    dropdown.FindElement(By.XPath("//option[. = 'Español']")).Click();
                }
                driver.FindElement(By.Id("VCuadernilloCTC")).Click();
                driver.FindElement(By.Id("Pais")).Click();
                {
                    var dropdown = driver.FindElement(By.Id("Pais"));
                    dropdown.FindElement(By.XPath("//option[. = 'Colombia']")).Click();
                }
                driver.FindElement(By.Id("Pais")).Click();
                driver.FindElement(By.Id("botonafegir")).Click();//SLEEP 4 - 5 SEGUNDOS
                Thread.Sleep(4000);
                driver.FindElement(By.Id("Aplicador")).Click();
                driver.FindElement(By.Id("Aplicador")).SendKeys("Lina Maria Velasquez");
                driver.FindElement(By.Id("intIdBaremo")).Click();
                {
                    var dropdown = driver.FindElement(By.Id("intIdBaremo"));
                    dropdown.FindElement(By.XPath("//option[. = 'Colombia, baremo general']")).Click();
                }
                driver.FindElement(By.Id("intIdBaremo")).Click();
                driver.FindElement(By.Id("p001")).Click();
                driver.FindElement(By.Id("p001")).SendKeys(t.D1.ToString());
                driver.FindElement(By.Id("p002")).SendKeys(t.D2.ToString());
                driver.FindElement(By.Id("p003")).SendKeys(t.D3.ToString());
                driver.FindElement(By.Id("p004")).SendKeys(t.D4.ToString());
                driver.FindElement(By.Id("p005")).SendKeys(t.D5.ToString());
                driver.FindElement(By.Id("p006")).SendKeys(t.D6.ToString());
                driver.FindElement(By.Id("p007")).SendKeys(t.D7.ToString());
                driver.FindElement(By.Id("p008")).SendKeys(t.D8.ToString());
                driver.FindElement(By.Id("p009")).SendKeys(t.D9.ToString());
                driver.FindElement(By.Id("p010")).SendKeys(t.D10.ToString());
                driver.FindElement(By.Id("p011")).SendKeys(t.D11.ToString());
                driver.FindElement(By.Id("p012")).SendKeys(t.D12.ToString());
                driver.FindElement(By.Id("p013")).SendKeys(t.D13.ToString());
                driver.FindElement(By.Id("p014")).SendKeys(t.D14.ToString());
                driver.FindElement(By.Id("p015")).SendKeys(t.D15.ToString());
                driver.FindElement(By.Id("p016")).SendKeys(t.D16.ToString());
                driver.FindElement(By.Id("p017")).SendKeys(t.D17.ToString());
                driver.FindElement(By.Id("p018")).SendKeys(t.D18.ToString());
                driver.FindElement(By.Id("p019")).SendKeys(t.D19.ToString());
                driver.FindElement(By.Id("p020")).SendKeys(t.D20.ToString());
                driver.FindElement(By.Id("p021")).SendKeys(t.D21.ToString());
                driver.FindElement(By.Id("p022")).SendKeys(t.D22.ToString());
                driver.FindElement(By.Id("p023")).SendKeys(t.D23.ToString());
                driver.FindElement(By.Id("p024")).SendKeys(t.D24.ToString());
                driver.FindElement(By.Id("p025")).SendKeys(t.D25.ToString());
                driver.FindElement(By.Id("p026")).SendKeys(t.D26.ToString());
                driver.FindElement(By.Id("p027")).SendKeys(t.D27.ToString());
                driver.FindElement(By.Id("p028")).SendKeys(t.D28.ToString());
                driver.FindElement(By.Id("p029")).SendKeys(t.D29.ToString());
                driver.FindElement(By.Id("p030")).SendKeys(t.D30.ToString());
                driver.FindElement(By.Id("p031")).SendKeys(t.D31.ToString());
                driver.FindElement(By.Id("p032")).SendKeys(t.D32.ToString());
                driver.FindElement(By.Id("p033")).SendKeys(t.D33.ToString());
                driver.FindElement(By.Id("p034")).SendKeys(t.D34.ToString());
                driver.FindElement(By.Id("p035")).SendKeys(t.D35.ToString());
                driver.FindElement(By.Id("p036")).SendKeys(t.D36.ToString());
                driver.FindElement(By.Id("p037")).SendKeys(t.D37.ToString());
                driver.FindElement(By.Id("p038")).SendKeys(t.D38.ToString());
                driver.FindElement(By.Id("p039")).SendKeys(t.D39.ToString());
                driver.FindElement(By.Id("p040")).SendKeys(t.D40.ToString());
                driver.FindElement(By.Id("p041")).SendKeys(t.D41.ToString());
                driver.FindElement(By.Id("p042")).SendKeys(t.D42.ToString());
                driver.FindElement(By.Id("p043")).SendKeys(t.D43.ToString());
                driver.FindElement(By.Id("p044")).SendKeys(t.D44.ToString());
                driver.FindElement(By.Id("p045")).SendKeys(t.D45.ToString());
                driver.FindElement(By.Id("Pestanya2")).Click();
                driver.FindElement(By.Id("p046")).SendKeys(t.D46.ToString());
                driver.FindElement(By.Id("p047")).SendKeys(t.D47.ToString());
                driver.FindElement(By.Id("p048")).SendKeys(t.D48.ToString());
                driver.FindElement(By.Id("p049")).SendKeys(t.D49.ToString());
                driver.FindElement(By.Id("p050")).SendKeys(t.D50.ToString());
                driver.FindElement(By.Id("p051")).SendKeys(t.D51.ToString());
                driver.FindElement(By.Id("p052")).SendKeys(t.D52.ToString());
                driver.FindElement(By.Id("p053")).SendKeys(t.D53.ToString());
                driver.FindElement(By.Id("p054")).SendKeys(t.D54.ToString());
                driver.FindElement(By.Id("p055")).SendKeys(t.D55.ToString());
                driver.FindElement(By.Id("p056")).SendKeys(t.D56.ToString());
                driver.FindElement(By.Id("p057")).SendKeys(t.D57.ToString());
                driver.FindElement(By.Id("p058")).SendKeys(t.D58.ToString());
                driver.FindElement(By.Id("p059")).SendKeys(t.D59.ToString());
                driver.FindElement(By.Id("p060")).SendKeys(t.D60.ToString());
                driver.FindElement(By.Id("p061")).SendKeys(t.D61.ToString());
                driver.FindElement(By.Id("p062")).SendKeys(t.D62.ToString());
                driver.FindElement(By.Id("p063")).SendKeys(t.D63.ToString());
                driver.FindElement(By.Id("p064")).SendKeys(t.D64.ToString());
                driver.FindElement(By.Id("p065")).SendKeys(t.D65.ToString());
                driver.FindElement(By.Id("p066")).SendKeys(t.D66.ToString());
                driver.FindElement(By.Id("p067")).SendKeys(t.D67.ToString());
                driver.FindElement(By.Id("p068")).SendKeys(t.D68.ToString());
                driver.FindElement(By.Id("p069")).SendKeys(t.D69.ToString());
                driver.FindElement(By.Id("p070")).SendKeys(t.D70.ToString());
                driver.FindElement(By.Id("p071")).SendKeys(t.D71.ToString());
                driver.FindElement(By.Id("p072")).SendKeys(t.D72.ToString());
                driver.FindElement(By.Id("p073")).SendKeys(t.D73.ToString());
                driver.FindElement(By.Id("p074")).SendKeys(t.D74.ToString());
                driver.FindElement(By.Id("p075")).SendKeys(t.D75.ToString());
                driver.FindElement(By.Id("p076")).SendKeys(t.D76.ToString());
                driver.FindElement(By.Id("p077")).SendKeys(t.D77.ToString());
                driver.FindElement(By.Id("p078")).SendKeys(t.D78.ToString());
                driver.FindElement(By.Id("p079")).SendKeys(t.D79.ToString());
                driver.FindElement(By.Id("p080")).SendKeys(t.D80.ToString());
                driver.FindElement(By.Id("p081")).SendKeys(t.D81.ToString());
                driver.FindElement(By.Id("p082")).SendKeys(t.D82.ToString());
                driver.FindElement(By.Id("p083")).SendKeys(t.D83.ToString());
                driver.FindElement(By.Id("p084")).SendKeys(t.D84.ToString());
                driver.FindElement(By.Id("p085")).SendKeys(t.D85.ToString());
                driver.FindElement(By.Id("p086")).SendKeys(t.D86.ToString());
                driver.FindElement(By.Id("p087")).SendKeys(t.D87.ToString());
                driver.FindElement(By.Id("p088")).SendKeys(t.D88.ToString());
                driver.FindElement(By.Id("p089")).SendKeys(t.D89.ToString());
                driver.FindElement(By.Id("p090")).SendKeys(t.D90.ToString());
                driver.FindElement(By.Id("Pestanya3")).Click();
                driver.FindElement(By.Id("p091")).SendKeys(t.D91.ToString());
                driver.FindElement(By.Id("p092")).SendKeys(t.D92.ToString());
                driver.FindElement(By.Id("p093")).SendKeys(t.D93.ToString());
                driver.FindElement(By.Id("p094")).SendKeys(t.D94.ToString());
                driver.FindElement(By.Id("p095")).SendKeys(t.D95.ToString());
                driver.FindElement(By.Id("p096")).SendKeys(t.D96.ToString());
                driver.FindElement(By.Id("p097")).SendKeys(t.D97.ToString());
                driver.FindElement(By.Id("p098")).SendKeys(t.D98.ToString());
                driver.FindElement(By.Id("p099")).SendKeys(t.D99.ToString());
                driver.FindElement(By.Id("p100")).SendKeys(t.D100.ToString());
                driver.FindElement(By.Id("p101")).SendKeys(t.D101.ToString());
                driver.FindElement(By.Id("p102")).SendKeys(t.D102.ToString());
                driver.FindElement(By.Id("p103")).SendKeys(t.D103.ToString());
                driver.FindElement(By.Id("p104")).SendKeys(t.D104.ToString());
                driver.FindElement(By.Id("p105")).SendKeys(t.D105.ToString());
                driver.FindElement(By.Id("p106")).SendKeys(t.D106.ToString());
                driver.FindElement(By.Id("p107")).SendKeys(t.D107.ToString());
                driver.FindElement(By.Id("p108")).SendKeys(t.D108.ToString());
                driver.FindElement(By.Id("p109")).SendKeys(t.D109.ToString());
                driver.FindElement(By.Id("p110")).SendKeys(t.D110.ToString());
                driver.FindElement(By.Id("p111")).SendKeys(t.D111.ToString());
                driver.FindElement(By.Id("p112")).SendKeys(t.D112.ToString());
                driver.FindElement(By.Id("p113")).SendKeys(t.D113.ToString());
                driver.FindElement(By.Id("p114")).SendKeys(t.D114.ToString());
                driver.FindElement(By.Id("p115")).SendKeys(t.D115.ToString());
                driver.FindElement(By.Id("p116")).SendKeys(t.D116.ToString());
                driver.FindElement(By.Id("p117")).SendKeys(t.D117.ToString());
                driver.FindElement(By.Id("p118")).SendKeys(t.D118.ToString());
                driver.FindElement(By.Id("p119")).SendKeys(t.D119.ToString());
                driver.FindElement(By.Id("p120")).SendKeys(t.D120.ToString());
                driver.FindElement(By.Id("p121")).SendKeys(t.D121.ToString());
                driver.FindElement(By.Id("p122")).SendKeys(t.D122.ToString());
                driver.FindElement(By.Id("p123")).SendKeys(t.D123.ToString());
                driver.FindElement(By.Id("p124")).SendKeys(t.D124.ToString());
                driver.FindElement(By.Id("p125")).SendKeys(t.D125.ToString());
                driver.FindElement(By.Id("p126")).SendKeys(t.D126.ToString());
                driver.FindElement(By.Id("p127")).SendKeys(t.D127.ToString());
                driver.FindElement(By.Id("p128")).SendKeys(t.D128.ToString());
                driver.FindElement(By.Id("p129")).SendKeys(t.D129.ToString());
                driver.FindElement(By.Id("p130")).SendKeys(t.D130.ToString());
                driver.FindElement(By.Id("p131")).SendKeys(t.D131.ToString());
                driver.FindElement(By.Id("p132")).SendKeys(t.D132.ToString());
                driver.FindElement(By.Id("p133")).SendKeys(t.D133.ToString());
                driver.FindElement(By.Id("p134")).SendKeys(t.D134.ToString());
                driver.FindElement(By.Id("p135")).SendKeys(t.D135.ToString());
                driver.FindElement(By.Id("Pestanya4")).Click();
                driver.FindElement(By.Id("p136")).SendKeys(t.D136.ToString());
                driver.FindElement(By.Id("p137")).SendKeys(t.D137.ToString());
                driver.FindElement(By.Id("p138")).SendKeys(t.D138.ToString());
                driver.FindElement(By.Id("p139")).SendKeys(t.D139.ToString());
                driver.FindElement(By.Id("p140")).SendKeys(t.D140.ToString());
                driver.FindElement(By.Id("p141")).SendKeys(t.D141.ToString());
                driver.FindElement(By.Id("p142")).SendKeys(t.D142.ToString());
                driver.FindElement(By.Id("p143")).SendKeys(t.D143.ToString());
                driver.FindElement(By.Id("p144")).SendKeys(t.D144.ToString());
                driver.FindElement(By.Id("p145")).SendKeys(t.D145.ToString());
                driver.FindElement(By.Id("p146")).SendKeys(t.D146.ToString());
                driver.FindElement(By.Id("p147")).SendKeys(t.D147.ToString());
                driver.FindElement(By.Id("p148")).SendKeys(t.D148.ToString());
                driver.FindElement(By.Id("p149")).SendKeys(t.D149.ToString());
                driver.FindElement(By.Id("p150")).SendKeys(t.D150.ToString());
                driver.FindElement(By.Id("p151")).SendKeys(t.D151.ToString());
                driver.FindElement(By.Id("p152")).SendKeys(t.D152.ToString());
                driver.FindElement(By.Id("p153")).SendKeys(t.D153.ToString());
                driver.FindElement(By.Id("p154")).SendKeys(t.D154.ToString());
                driver.FindElement(By.Id("p155")).SendKeys(t.D155.ToString());
                driver.FindElement(By.Id("p156")).SendKeys(t.D156.ToString());
                driver.FindElement(By.Id("p157")).SendKeys(t.D157.ToString());
                driver.FindElement(By.Id("p158")).SendKeys(t.D158.ToString());
                driver.FindElement(By.Id("p159")).SendKeys(t.D159.ToString());
                driver.FindElement(By.Id("p160")).SendKeys(t.D160.ToString());
                driver.FindElement(By.Id("p161")).SendKeys(t.D161.ToString());
                driver.FindElement(By.Id("p162")).SendKeys(t.D162.ToString());
                driver.FindElement(By.Id("p163")).SendKeys(t.D163.ToString());
                driver.FindElement(By.Id("p164")).SendKeys(t.D164.ToString());
                driver.FindElement(By.Id("p165")).SendKeys(t.D165.ToString());
                driver.FindElement(By.Id("p166")).SendKeys(t.D166.ToString());
                driver.FindElement(By.Id("p167")).SendKeys(t.D167.ToString());
                driver.FindElement(By.Id("p168")).SendKeys(t.D168.ToString());
                driver.FindElement(By.Id("p169")).SendKeys(t.D169.ToString());
                driver.FindElement(By.Id("p170")).SendKeys(t.D170.ToString());
                driver.FindElement(By.Id("p171")).SendKeys(t.D171.ToString());
                driver.FindElement(By.Id("p172")).SendKeys(t.D172.ToString());
                driver.FindElement(By.Id("p173")).SendKeys(t.D173.ToString());
                driver.FindElement(By.Id("p174")).SendKeys(t.D174.ToString());
                driver.FindElement(By.Id("p175")).SendKeys(t.D175.ToString());
                driver.FindElement(By.Id("p176")).SendKeys(t.D176.ToString());
                driver.FindElement(By.Id("p177")).SendKeys(t.D177.ToString());
                driver.FindElement(By.Id("p178")).SendKeys(t.D178.ToString());
                driver.FindElement(By.Id("p179")).SendKeys(t.D179.ToString());
                driver.FindElement(By.Id("p180")).SendKeys(t.D180.ToString());
                driver.FindElement(By.Id("grabar")).Click();
                driver.FindElement(By.CssSelector("body > div:nth-child(9) > div.ui-dialog-buttonpane.ui-widget-content.ui-helper-clearfix > div > button:nth-child(1)")).Click();
                driver.FindElement(By.Id("submit1")).Click();
                driver.FindElement(By.Id("linkvolver")).Click();
            }
           
        }
    }

}

public class DtoPreuba
{
    public string nombre { get; set;  }
    public string edad { get; set; }
    public string sexo { get; set; }
    public Int32 D1 { get; set; }
    public Int32 D2 { get; set; }
    public Int32 D3 { get; set; }
    public Int32 D4 { get; set; }
    public Int32 D5 { get; set; }
    public Int32 D6 { get; set; }
    public Int32 D7 { get; set; }
    public Int32 D8 { get; set; }
    public Int32 D9 { get; set; }
    public Int32 D10 { get; set; }
    public Int32 D11 { get; set; }
    public Int32 D12 { get; set; }
    public Int32 D13 { get; set; }
    public Int32 D14 { get; set; }
    public Int32 D15 { get; set; }
    public Int32 D16 { get; set; }
    public Int32 D17 { get; set; }
    public Int32 D18 { get; set; }
    public Int32 D19 { get; set; }
    public Int32 D20 { get; set; }
    public Int32 D21 { get; set; }
    public Int32 D22 { get; set; }
    public Int32 D23 { get; set; }
    public Int32 D24 { get; set; }
    public Int32 D25 { get; set; }
    public Int32 D26 { get; set; }
    public Int32 D27 { get; set; }
    public Int32 D28 { get; set; }
    public Int32 D29 { get; set; }
    public Int32 D30 { get; set; }
    public Int32 D31 { get; set; }
    public Int32 D32 { get; set; }
    public Int32 D33 { get; set; }
    public Int32 D34 { get; set; }
    public Int32 D35 { get; set; }
    public Int32 D36 { get; set; }
    public Int32 D37 { get; set; }
    public Int32 D38 { get; set; }
    public Int32 D39 { get; set; }
    public Int32 D40 { get; set; }
    public Int32 D41 { get; set; }
    public Int32 D42 { get; set; }
    public Int32 D43 { get; set; }
    public Int32 D44 { get; set; }
    public Int32 D45 { get; set; }
    public Int32 D46 { get; set; }
    public Int32 D47 { get; set; }
    public Int32 D48 { get; set; }
    public Int32 D49 { get; set; }
    public Int32 D50 { get; set; }
    public Int32 D51 { get; set; }
    public Int32 D52 { get; set; }
    public Int32 D53 { get; set; }
    public Int32 D54 { get; set; }
    public Int32 D55 { get; set; }
    public Int32 D56 { get; set; }
    public Int32 D57 { get; set; }
    public Int32 D58 { get; set; }
    public Int32 D59 { get; set; }
    public Int32 D60 { get; set; }
    public Int32 D61 { get; set; }
    public Int32 D62 { get; set; }
    public Int32 D63 { get; set; }
    public Int32 D64 { get; set; }
    public Int32 D65 { get; set; }
    public Int32 D66 { get; set; }
    public Int32 D67 { get; set; }
    public Int32 D68 { get; set; }
    public Int32 D69 { get; set; }
    public Int32 D70 { get; set; }
    public Int32 D71 { get; set; }
    public Int32 D72 { get; set; }
    public Int32 D73 { get; set; }
    public Int32 D74 { get; set; }
    public Int32 D75 { get; set; }
    public Int32 D76 { get; set; }
    public Int32 D77 { get; set; }
    public Int32 D78 { get; set; }
    public Int32 D79 { get; set; }
    public Int32 D80 { get; set; }
    public Int32 D81 { get; set; }
    public Int32 D82 { get; set; }
    public Int32 D83 { get; set; }
    public Int32 D84 { get; set; }
    public Int32 D85 { get; set; }
    public Int32 D86 { get; set; }
    public Int32 D87 { get; set; }
    public Int32 D88 { get; set; }
    public Int32 D89 { get; set; }
    public Int32 D90 { get; set; }
    public Int32 D91 { get; set; }
    public Int32 D92 { get; set; }
    public Int32 D93 { get; set; }
    public Int32 D94 { get; set; }
    public Int32 D95 { get; set; }
    public Int32 D96 { get; set; }
    public Int32 D97 { get; set; }
    public Int32 D98 { get; set; }
    public Int32 D99 { get; set; }
    public Int32 D100 { get; set; }
    public Int32 D101 { get; set; }
    public Int32 D102 { get; set; }
    public Int32 D103 { get; set; }
    public Int32 D104 { get; set; }
    public Int32 D105 { get; set; }
    public Int32 D106 { get; set; }
    public Int32 D107 { get; set; }
    public Int32 D108 { get; set; }
    public Int32 D109 { get; set; }
    public Int32 D110 { get; set; }
    public Int32 D111 { get; set; }
    public Int32 D112 { get; set; }
    public Int32 D113 { get; set; }
    public Int32 D114 { get; set; }
    public Int32 D115 { get; set; }
    public Int32 D116 { get; set; }
    public Int32 D117 { get; set; }
    public Int32 D118 { get; set; }
    public Int32 D119 { get; set; }
    public Int32 D120 { get; set; }
    public Int32 D121 { get; set; }
    public Int32 D122 { get; set; }
    public Int32 D123 { get; set; }
    public Int32 D124 { get; set; }
    public Int32 D125 { get; set; }
    public Int32 D126 { get; set; }
    public Int32 D127 { get; set; }
    public Int32 D128 { get; set; }
    public Int32 D129 { get; set; }
    public Int32 D130 { get; set; }
    public Int32 D131 { get; set; }
    public Int32 D132 { get; set; }
    public Int32 D133 { get; set; }
    public Int32 D134 { get; set; }
    public Int32 D135 { get; set; }
    public Int32 D136 { get; set; }
    public Int32 D137 { get; set; }
    public Int32 D138 { get; set; }
    public Int32 D139 { get; set; }
    public Int32 D140 { get; set; }
    public Int32 D141 { get; set; }
    public Int32 D142 { get; set; }
    public Int32 D143 { get; set; }
    public Int32 D144 { get; set; }
    public Int32 D145 { get; set; }
    public Int32 D146 { get; set; }
    public Int32 D147 { get; set; }
    public Int32 D148 { get; set; }
    public Int32 D149 { get; set; }
    public Int32 D150 { get; set; }
    public Int32 D151 { get; set; }
    public Int32 D152 { get; set; }
    public Int32 D153 { get; set; }
    public Int32 D154 { get; set; }
    public Int32 D155 { get; set; }
    public Int32 D156 { get; set; }
    public Int32 D157 { get; set; }
    public Int32 D158 { get; set; }
    public Int32 D159 { get; set; }
    public Int32 D160 { get; set; }
    public Int32 D161 { get; set; }
    public Int32 D162 { get; set; }
    public Int32 D163 { get; set; }
    public Int32 D164 { get; set; }
    public Int32 D165 { get; set; }
    public Int32 D166 { get; set; }
    public Int32 D167 { get; set; }
    public Int32 D168 { get; set; }
    public Int32 D169 { get; set; }
    public Int32 D170 { get; set; }
    public Int32 D171 { get; set; }
    public Int32 D172 { get; set; }
    public Int32 D173 { get; set; }
    public Int32 D174 { get; set; }
    public Int32 D175 { get; set; }
    public Int32 D176 { get; set; }
    public Int32 D177 { get; set; }
    public Int32 D178 { get; set; }
    public Int32 D179 { get; set; }
    public Int32 D180 { get; set; }
}

 

