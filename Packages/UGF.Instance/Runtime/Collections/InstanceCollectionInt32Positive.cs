using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollection{TIdentifier,TInstance}"/> with Int32 as identifier with only positive values range.
    /// </summary>
    public class InstanceCollectionInt32Positive<TInstance> : InstanceCollection<int, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorInt32Positive"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionInt32Positive(IInstanceIdentifierGenerator<int> generator = null) : base(generator ?? new InstanceIdentifierGeneratorInt32Positive())
        {
        }
    }
}