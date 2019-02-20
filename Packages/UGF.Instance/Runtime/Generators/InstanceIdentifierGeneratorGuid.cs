using System;

namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The primitive identifier generator that generate identifiers of the Guid type.
    /// </summary>
    public class InstanceIdentifierGeneratorGuid : InstanceIdentifierGeneratorBase<Guid>
    {
        public InstanceIdentifierGeneratorGuid() : base(Guid.Empty, Guid.Empty)
        {
        }

        public override Guid Generate()
        {
            return Guid.NewGuid();
        }

        public override bool IsValid(Guid identifier)
        {
            return identifier != InvalidIdentifier;
        }
    }
}