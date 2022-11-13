using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using System;
using System.Collections.Generic;
using FlaUI.Core.AutomationElements;
using System.Threading;
namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MainTest()
        {
            var localCalc = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var mainApp = localCalc.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            var mainCalc = new Calculator(mainApp,cf);

            if (mainCalc == null)
            {
                throw new System.Exception("Calculator not found on main screen");
            }
            else
            {
                var calcButtons = mainCalc.DefineButtons();
                foreach(var btn in calcButtons)
                {
                    if (btn != null)
                    {
                        btn.Click();
                        Thread.Sleep(100);
                    }
                    else
                    {
                        throw new System.Exception("Button not found on main screen");
                    }
                }
            }
        }

        [TestMethod]
        public void AddOpTest()
        {
            var localCalc = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var mainApp = localCalc.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            var mainCalc = new Calculator(mainApp, cf);
            if (mainCalc == null)
            {
                throw new System.Exception("Calculator not found on main screen");
            }
            else
            {
                var calcButtons = mainCalc.DefineButtons();
                calcButtons.Find(btn => btn.AutomationId.Equals("clearButton")).Click();
                calcButtons.Find(btn => btn.AutomationId.Equals("num1Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("plusButton")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("num2Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("equalButton")).Click();
                Thread.Sleep(100);
                AutomationElement[] resultDisplay = mainApp.FindAllDescendants(cf.ByAutomationId("CalculatorResults"));
                String value = resultDisplay[0].Properties.Name;
                if (!(value.Equals("התצוגה היא 3") || (value.Equals("Display is 3"))))
                {
                    throw new System.Exception("The Calculator return wrong answear");
                }
            }
        }
        [TestMethod]
        public void ExtractOpTest()
        {
            var localCalc = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var mainApp = localCalc.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            var mainCalc = new Calculator(mainApp, cf);
            if (mainCalc == null)
            {
                throw new System.Exception("Calculator not found on main screen");
            }
            else
            {
                var calcButtons = mainCalc.DefineButtons();
                calcButtons.Find(btn => btn.AutomationId.Equals("clearButton")).Click();
                calcButtons.Find(btn => btn.AutomationId.Equals("num1Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("minusButton")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("num2Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("equalButton")).Click();
                Thread.Sleep(100);
                AutomationElement[] resultDisplay = mainApp.FindAllDescendants(cf.ByAutomationId("CalculatorResults"));
                String value = resultDisplay[0].Properties.Name;
                if (!(value.Equals("התצוגה היא -1") || (value.Equals("Display is -1"))))
                {
                    throw new System.Exception("The Calculator return wrong answear");
                }

            }
        }
        [TestMethod]
        public void MultiplyOpTest()
        {
            var localCalc = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var mainApp = localCalc.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            var mainCalc = new Calculator(mainApp, cf);
            if (mainCalc == null)
            {
                throw new System.Exception("Calculator not found on main screen");
            }
            else
            {
                var calcButtons = mainCalc.DefineButtons();
                calcButtons.Find(btn => btn.AutomationId.Equals("clearButton")).Click();
                calcButtons.Find(btn => btn.AutomationId.Equals("num3Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("multiplyButton")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("num2Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("equalButton")).Click();
                Thread.Sleep(100);
                AutomationElement[] resultDisplay = mainApp.FindAllDescendants(cf.ByAutomationId("CalculatorResults"));
                String value = resultDisplay[0].Properties.Name;
                if (!(value.Equals("התצוגה היא 6") || (value.Equals("Display is 6"))))
                {
                    throw new System.Exception("The Calculator return wrong answear");
                }
            }
        }
        [TestMethod]
        public void DivideTest()
        {
            var localCalc = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var mainApp = localCalc.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            var mainCalc = new Calculator(mainApp, cf);
            if (mainCalc == null)
            {
                throw new System.Exception("Calculator not found on main screen");
            }
            else
            {
                var calcButtons = mainCalc.DefineButtons();
                calcButtons.Find(btn => btn.AutomationId.Equals("clearButton")).Click();
                calcButtons.Find(btn => btn.AutomationId.Equals("num3Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("divideButton")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("num2Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("equalButton")).Click();
                Thread.Sleep(100);
                AutomationElement[] resultDisplay = mainApp.FindAllDescendants(cf.ByAutomationId("CalculatorResults"));
                String value = resultDisplay[0].Properties.Name;
                if (!(value.Equals("התצוגה היא 1.5") || value.Equals("Display is 1.5")))
                {
                    throw new System.Exception("The Calculator return wrong answear");
                }
                calcButtons.Find(btn => btn.AutomationId.Equals("clearButton")).Click();
                calcButtons.Find(btn => btn.AutomationId.Equals("num1Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("divideButton")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("num0Button")).Click();
                Thread.Sleep(100);
                calcButtons.Find(btn => btn.AutomationId.Equals("equalButton")).Click();
                Thread.Sleep(100);
                resultDisplay = mainApp.FindAllDescendants(cf.ByAutomationId("CalculatorResults"));
                value = resultDisplay[0].Properties.Name;
                if (!(value.Equals("התצוגה היא לא ניתן לחלק באפס")|| !value.Equals("Cannot divide by zero")))
                {
                    throw new System.Exception("The Calculator return impossible expression for test");
                }
            }
        }
    }

    internal class Calculator
    {
        private Window mainApp;
        private ConditionFactory cf;

        public Calculator(Window mainApp, ConditionFactory cf)
        {
            this.mainApp = mainApp;
            this.cf = cf;
        }
        public List<AutomationElement> DefineButtons()
        {
           List<AutomationElement> buttons = new List<AutomationElement>();
           var btn0 = mainApp.FindFirstDescendant(cf.ByAutomationId("num0Button")).AsButton();
           var btn1 = mainApp.FindFirstDescendant(cf.ByAutomationId("num1Button")).AsButton();
           var btn2 = mainApp.FindFirstDescendant(cf.ByAutomationId("num2Button")).AsButton();
           var btn3 = mainApp.FindFirstDescendant(cf.ByAutomationId("num3Button")).AsButton();
           var btn4 = mainApp.FindFirstDescendant(cf.ByAutomationId("num4Button")).AsButton();
           var btn5 = mainApp.FindFirstDescendant(cf.ByAutomationId("num5Button")).AsButton();
           var btn6 = mainApp.FindFirstDescendant(cf.ByAutomationId("num6Button")).AsButton();
           var btn7 = mainApp.FindFirstDescendant(cf.ByAutomationId("num7Button")).AsButton();
           var btn8 = mainApp.FindFirstDescendant(cf.ByAutomationId("num8Button")).AsButton();
           var btn9 = mainApp.FindFirstDescendant(cf.ByAutomationId("num9Button")).AsButton();
           var add = mainApp.FindFirstDescendant(cf.ByAutomationId("plusButton")).AsButton();
           var extract = mainApp.FindFirstDescendant(cf.ByAutomationId("minusButton")).AsButton();
           var multiply = mainApp.FindFirstDescendant(cf.ByAutomationId("multiplyButton")).AsButton();
           var divide = mainApp.FindFirstDescendant(cf.ByAutomationId("divideButton")).AsButton();
           var result = mainApp.FindFirstDescendant(cf.ByAutomationId("equalButton")).AsButton();
           var clear = mainApp.FindFirstDescendant(cf.ByAutomationId("clearButton")).AsButton();

            buttons.Add(btn0);
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(add);
            buttons.Add(extract);
            buttons.Add(multiply);
            buttons.Add(divide);
            buttons.Add(result);
            buttons.Add(clear);

            return buttons;
        }
    }
}
