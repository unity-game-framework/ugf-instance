using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollection{TIdentifier,TInstance}"/> with UInt16 as identifier.
    /// </summary>
    public class InstanceCollectionUInt16<TInstance> : InstanceCollection<ushort, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorUInt16"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionUInt16(IInstanceIdentifierGenerator<ushort> generator) : base(generator ?? new InstanceIdentifierGeneratorUInt16())
        {
        }
    }
}