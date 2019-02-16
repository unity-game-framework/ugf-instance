using System;
using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Collections
{
    /// <summary>
    /// The implementation of the <see cref="InstanceCollection{TIdentifier,TInstance}"/> with Guid as identifier.
    /// </summary>
    public class InstanceCollectionGuid<TInstance> : InstanceCollection<Guid, TInstance>
    {
        /// <summary>
        /// Creates new instance collection with specified instance identifier generator, if present, otherwise will use <see cref="InstanceIdentifierGeneratorGuid"/>.
        /// </summary>
        /// <param name="generator">The generator used to create new identifiers.</param>
        public InstanceCollectionGuid(IInstanceIdentifierGenerator<Guid> generator = null) : base(generator ?? new InstanceIdentifierGeneratorGuid())
        {
        }
    }
}