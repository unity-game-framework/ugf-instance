using System;

namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Abstract interface of instance identifier generator.
    /// </summary>
    public interface IInstanceIdentifierGenerator
    {
        /// <summary>
        /// Gets the type of the identifier.
        /// </summary>
        Type IdentifierType { get; }

        /// <summary>
        /// Resets this generator state.
        /// </summary>
        void Reset();
    }
}