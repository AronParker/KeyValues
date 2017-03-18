using System;

namespace KeyValues
{
    public class KeyValueParseException : Exception
    {
        public KeyValueParseException(string message, int startIndex, int length) : base(message)
        {
            StartIndex = startIndex;
            Length = length;
        }
        
        public int StartIndex { get; }
        public int Length { get; }
    }
}
