namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Generic interface of instance identifier generator.
    /// </summary>
    public interface IInstanceIdentifierGenerator<TIdentifier> : IInstanceIdentifierGenerator
    {
        /// <summary>
        /// Gets the previous used identifier.
        /// </summary>
        TIdentifier PreviousIdentifier { get; }

        /// <summary>
        /// Gets the default identifier.
        /// </summary>
        TIdentifier DefaultIdentifier { get; }
        
        /// <summary>
        /// Gets the invalid identifier.
        /// </summary>
        TIdentifier InvalidIdentifier { get; }

        /// <summary>
        /// Generates the new identifier.
        /// </summary>
        TIdentifier Generate();
        
        /// <summary>
        /// Returns true if the specified identifier is valid.
        /// <para>
        /// This method checks if the specified identifier is not equal to <see cref="InvalidIdentifier"/>.
        /// </para>
        /// </summary>
        bool IsValid(TIdentifier identifier);
    }
}