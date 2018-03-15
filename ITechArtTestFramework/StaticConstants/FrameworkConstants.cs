using OpenQA.Selenium;
using System;
using System.Reflection;
using ITechArtTestFramework.PageObjects;
using ITechArtTestFramework.Steps;

namespace ITechArtTestFramework.StaticConstants
{
    public static class FrameworkConstants
    {
        public static readonly Type WebElementType = typeof(IWebElement);
        public static readonly Type PageObjectType = typeof(PageObject);
        public static readonly Type BaseStepsType = typeof(BaseSteps);
        public static readonly string StartPage = "https://www.kinopoisk.ru/";
        public static readonly BindingFlags BindingFlags = BindingFlags.Instance |
                 BindingFlags.NonPublic |
                 BindingFlags.Public;
    }
}
