using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollectionCached{TIdentifier,TInstance}"/> with UInt16 as identifier.
    /// </summary>
    public class InstanceCollectionUInt16Cached<TInstance> : InstanceCollectionCached<ushort, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorUInt16"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionUInt16Cached(IInstanceIdentifierGenerator<ushort> generator) : base(generator ?? new InstanceIdentifierGeneratorUInt16())
        {
        }
    }
}