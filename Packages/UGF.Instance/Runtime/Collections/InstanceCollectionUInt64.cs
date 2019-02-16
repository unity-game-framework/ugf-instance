using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollectionCached{TIdentifier,TInstance}"/> with UInt64 as identifier.
    /// </summary>
    public class InstanceCollectionUInt64<TInstance> : InstanceCollectionCached<ulong, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorUInt64"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionUInt64(IInstanceIdentifierGenerator<ulong> generator) : base(generator ?? new InstanceIdentifierGeneratorUInt64())
        {
        }
    }
}