﻿namespace _01.Logger.Layouts.Factory
{
    using Factory.Contracts;
    using System;
    using Logger.Layouts.Contracts;

    public class LayoutFactory : ILayoutFactory
    {
        public ILayouts CreateLayout(string type)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}
