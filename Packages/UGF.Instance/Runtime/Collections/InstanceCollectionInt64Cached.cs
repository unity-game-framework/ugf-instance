using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollectionCached{TIdentifier,TInstance}"/> with Int64 as identifier.
    /// </summary>
    public class InstanceCollectionInt64Cached<TInstance> : InstanceCollectionCached<long, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorInt64"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionInt64Cached(IInstanceIdentifierGenerator<long> generator) : base(generator ?? new InstanceIdentifierGeneratorInt64())
        {
        }
    }
}