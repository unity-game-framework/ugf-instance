namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the Int32 type.
    /// </summary>
    public class InstanceIdentifierGeneratorInt32 : InstanceIdentifierGeneratorPrimitive<int>
    {
        public InstanceIdentifierGeneratorInt32() : base(int.MinValue, int.MaxValue)
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