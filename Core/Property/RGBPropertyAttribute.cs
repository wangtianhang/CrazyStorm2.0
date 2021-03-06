﻿/*
 * The MIT License (MIT)
 * Copyright (c) StarX 2017 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CrazyStorm.Core
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class RGBPropertyAttribute : PropertyAttribute
    {
        public override bool IsLegal(string newValue, out object value)
        {
            value = null;
            RGB typeValue;
            bool result = RGB.TryParse(newValue, out typeValue);
            if (result)
            {
                value = typeValue;
                return true;
            }
            return false;
        }
    }
}
