namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the Int64 type.
    /// </summary>
    public class InstanceIdentifierGeneratorInt64 : InstanceIdentifierGeneratorBase<long>
    {
        public InstanceIdentifierGeneratorInt64() : base(long.MinValue, long.MaxValue)
        {
        }

        public override long Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(long identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}