using System;
using System.Collections;

namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Non generic interface to access to <see cref="InstanceCollection{TIdentifier,TInstance}"/>.
    /// </summary>
    public interface IInstanceCollection : IEnumerable
    {
        /// <summary>
        /// Gets the count of the instances in the collection.
        /// </summary>
        int Count { get; }
        
        /// <summary>
        /// Gets the generator used to create new unique identifiers.
        /// </summary>
        IInstanceIdentifierGenerator Generator { get; }

        /// <summary>
        /// Gets the type of the identifier.
        /// </summary>
        Type GetIdentifierType();

        /// <summary>
        /// Gets the type of the instance.
        /// </summary>
        Type GetInstanceType();
    }
}