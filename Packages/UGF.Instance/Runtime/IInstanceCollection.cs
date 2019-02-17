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
        /// Determines whether this collection contains the instance with the specified identifier.
        /// </summary>
        /// <param name="identifier">The identifier of the instance to check.</param>
        bool Contains(object identifier);

        /// <summary>
        /// Adds the specified instance and generate new id for it and returns it.
        /// </summary>
        /// <param name="instance">The instance to add.</param>
        object Add(object instance);

        /// <summary>
        /// Removes the instance with the specified identifier.
        /// <para>
        /// Returns false is there no instance with the specified identifier.
        /// </para>
        /// </summary>
        /// <param name="identifier">The identifier of the instance to remove.</param>
        bool Remove(object identifier);

        /// <summary>
        /// Tries the get instance with the specified identifier.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <param name="instance">The instance.</param>
        bool TryGetInstance(object identifier, out object instance);

        /// <summary>
        /// Removes all instances from the collection.
        /// </summary>
        void Clear();

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