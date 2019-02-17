using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollectionCached{TIdentifier,TInstance}"/> with Int16 as identifier.
    /// </summary>
    public class InstanceCollectionInt16<TInstance> : InstanceCollectionCached<short, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorInt16"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionInt16(IInstanceIdentifierGenerator<short> generator = null) : base(generator ?? new InstanceIdentifierGeneratorInt16())
        {
        }
    }
}