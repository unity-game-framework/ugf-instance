using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollection{TIdentifier,TInstance}"/> with Byte as identifier.
    /// </summary>
    public class InstanceCollectionByte<TInstance> : InstanceCollection<byte, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorByte"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionByte(IInstanceIdentifierGenerator<byte> generator = null) : base(generator ?? new InstanceIdentifierGeneratorByte())
        {
        }
    }
}