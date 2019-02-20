using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollection{TIdentifier,TInstance}"/> with Int32 as identifier.
    /// </summary>
    public class InstanceCollectionInt32<TInstance> : InstanceCollection<int, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorInt32"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionInt32(IInstanceIdentifierGenerator<int> generator = null) : base(generator ?? new InstanceIdentifierGeneratorInt32())
        {
        }
    }
}