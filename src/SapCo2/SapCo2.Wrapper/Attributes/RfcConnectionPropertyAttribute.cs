using System;

namespace SapCo2.Wrapper.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RfcConnectionPropertyAttribute: Attribute
    {
        internal string Name { get; set; }
        
        public RfcConnectionPropertyAttribute(string name)
        {
            Name = name;
        }
    }

}
