using System;

namespace Attrs
{
    public class NoParamAttribute : Attribute { }

    public class Double1Attribute : Attribute
    {
        public double Value { get; }
        public Double1Attribute(double value)
        {
            Value = value;
        }
    }

    public class Double2Attribute : Attribute
    {
        public double Value { get; }

        public Double2Attribute(double value)
        {
            Value = value;
        }
    }

    public class Double3Attribute : Attribute
    {
        public double Value { get; }

        public Double3Attribute(double value)
        {
            Value = value;
        }
    }



    public class Int1Attribute : Attribute
    {
        public int Value { get; set; }
        public Int1Attribute(int value)
        {
            Value = value;
        }
    }

    public class Int2Attribute : Attribute
    {
        public int Value { get; set; }
        public Int2Attribute(int value)
        {
            Value = value;
        }
    }

    public class Int3Attribute : Attribute
    {
        public int Value { get; set; }
        public Int3Attribute(int value)
        {
            Value = value;
        }
    }

    public class Ulong1Attribute : Attribute
    {
        public ulong Value { get; set; }
        public Ulong1Attribute(ulong value)
        {
            Value = value;
        }
    }

    public class Ulong2Attribute : Attribute
    {
        public ulong Value { get; set; }
        public Ulong2Attribute(ulong value)
        {
            Value = value;
        }
    }

    public class Ulong3Attribute : Attribute
    {
        public ulong Value { get; set; }
        public Ulong3Attribute(ulong value)
        {
            Value = value;
        }
    }

}
