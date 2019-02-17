namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the UInt16 type.
    /// </summary>
    public class InstanceIdentifierGeneratorUInt16 : InstanceIdentifierGeneratorPrimitive<ushort>
    {
        public InstanceIdentifierGeneratorUInt16() : base(ushort.MinValue, ushort.MaxValue)
        {
        }

        public override ushort Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(ushort identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}