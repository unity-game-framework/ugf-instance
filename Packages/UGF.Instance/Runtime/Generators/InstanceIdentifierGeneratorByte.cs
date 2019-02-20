namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the Byte type.
    /// </summary>
    public class InstanceIdentifierGeneratorByte : InstanceIdentifierGeneratorBase<byte>
    {
        public InstanceIdentifierGeneratorByte() : base(byte.MinValue, byte.MaxValue)
        {
        }

        public override byte Generate()
        {
            return ++PreviousIdentifier;
        }

        public override bool IsValid(byte identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}