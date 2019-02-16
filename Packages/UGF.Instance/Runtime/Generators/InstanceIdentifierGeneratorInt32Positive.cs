namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the Int32 type in positive range.
    /// </summary>
    public class InstanceIdentifierGeneratorInt32Positive : InstanceIdentifierGeneratorPrimitive<int>
    {
        public InstanceIdentifierGeneratorInt32Positive() : base(0, int.MaxValue)
        {
        }

        public override int Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(int identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}