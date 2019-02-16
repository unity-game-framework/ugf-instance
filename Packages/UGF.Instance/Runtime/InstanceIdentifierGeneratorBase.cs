using System;
using System.Collections.Generic;

namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Abstract implementation of <see cref="T:UGF.Instance.Runtime.IInstanceIdentifierGenerator`1" />.
    /// </summary>
    public abstract class InstanceIdentifierGeneratorBase<TIdentifier> : IInstanceIdentifierGenerator<TIdentifier>
    {
        public Type IdentifierType { get { return typeof(TIdentifier); } }
        public TIdentifier PreviousIdentifier { get; protected set; }
        public TIdentifier DefaultIdentifier { get; }
        public TIdentifier InvalidIdentifier { get; }

        /// <summary>
        /// Creates new generator with default and invalid identifier.
        /// </summary>
        /// <param name="defaultIdentifier">The default identifier.</param>
        /// <param name="invalidIdentifier">The invalid identifier.</param>
        protected InstanceIdentifierGeneratorBase(TIdentifier defaultIdentifier, TIdentifier invalidIdentifier)
        {
            PreviousIdentifier = defaultIdentifier;
            DefaultIdentifier = defaultIdentifier;
            InvalidIdentifier = invalidIdentifier;
        }

        public abstract TIdentifier Generate();
        
        public virtual void Reset()
        {
            PreviousIdentifier = DefaultIdentifier;
        }

        public virtual bool IsValid(TIdentifier identifier)
        {
            return Comparer<TIdentifier>.Default.Compare(identifier, InvalidIdentifier) != 0;
        }
    }
}