namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the UInt32 type.
    /// </summary>
    public class InstanceIdentifierGeneratorUInt32 : InstanceIdentifierGeneratorBase<uint>
    {
        public InstanceIdentifierGeneratorUInt32() : base(uint.MinValue, uint.MaxValue)
        {
        }

        public override uint Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(uint identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}