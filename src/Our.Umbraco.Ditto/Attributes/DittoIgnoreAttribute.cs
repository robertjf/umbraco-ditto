﻿namespace Our.Umbraco.Ditto
{
    using System;

    /// <summary>
    /// The Ditto ignore property attribute.
    /// Used for specifying that Ditto should ignore this property during conversion.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DittoIgnoreAttribute : Attribute
    {
    }
}