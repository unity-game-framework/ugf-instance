using System.Collections.Generic;

namespace UGF.Instance.Runtime
{
    /// <summary>
    /// The generic implementation of the <see cref="T:UGF.Instance.Runtime.IInstanceCollection" />.
    /// </summary>
    public interface IInstanceCollection<TIdentifier, TInstance> : IInstanceCollection, IEnumerable<KeyValuePair<TIdentifier, TInstance>>
    {
        /// <summary>
        /// Gets the generator used to create new unique identifiers.
        /// </summary>
        new IInstanceIdentifierGenerator<TIdentifier> Generator { get; }
        
        /// <summary>
        /// Determines whether this collection contains the instance with the specified identifier.
        /// </summary>
        /// <param name="identifier">The identifier of the instance to check.</param>
        bool Contains(TIdentifier identifier);

        /// <summary>
        /// Adds the specified instance and generate new id for it and returns it.
        /// </summary>
        /// <param name="instance">The instance to add.</param>
        TIdentifier Add(TInstance instance);
        
        /// <summary>
        /// Removes the instance with the specified identifier.
        /// <para>
        /// Returns false is there no instance with the specified identifier.
        /// </para>
        /// </summary>
        /// <param name="identifier">The identifier of the instance to remove.</param>
        bool Remove(TIdentifier identifier);
        
        /// <summary>
        /// Tries the get instance with the specified identifier.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <param name="instance">The instance.</param>
        bool TryGetInstance(TIdentifier identifier, out TInstance instance);
        
        /// <summary>
        /// Removes all instances from the collection.
        /// </summary>
        void Clear();
    }
}