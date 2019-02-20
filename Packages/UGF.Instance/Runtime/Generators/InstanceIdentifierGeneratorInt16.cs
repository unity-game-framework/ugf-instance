namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the Int16 type.
    /// </summary>
    public sealed class InstanceIdentifierGeneratorInt16 : InstanceIdentifierGeneratorBase<short>
    {
        public InstanceIdentifierGeneratorInt16() : base(short.MinValue, short.MaxValue)
        {
        }

        public override short Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(short identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}