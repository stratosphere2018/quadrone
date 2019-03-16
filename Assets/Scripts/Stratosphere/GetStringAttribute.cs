using System;

namespace Stratosphere
{

    public class StringValueAttribute: Attribute
    {
        public StringValueAttribute(string value)
        {
            StringValue = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string StringValue { get; protected set; }
    }
}
