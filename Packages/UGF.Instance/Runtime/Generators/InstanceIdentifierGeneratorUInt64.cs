namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the UInt64 type.
    /// </summary>
    public class InstanceIdentifierGeneratorUInt64 : InstanceIdentifierGeneratorPrimitive<ulong>
    {
        public InstanceIdentifierGeneratorUInt64() : base(ulong.MinValue, ulong.MaxValue)
        {
        }

        public override ulong Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(ulong identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}