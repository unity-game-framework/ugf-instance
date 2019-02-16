using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollectionCached{TIdentifier,TInstance}"/> with UInt32 as identifier.
    /// </summary>
    public class InstanceCollectionUInt32<TInstance> : InstanceCollectionCached<uint, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorUInt32"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionUInt32(IInstanceIdentifierGenerator<uint> generator) : base(generator ?? new InstanceIdentifierGeneratorUInt32())
        {
        }
    }
}