namespace UGF.Instance.Runtime.Generators
{
    /// <summary>
    /// The abstract class to implement basic generator of the identifiers with primitive types.
    /// </summary>
    public abstract class InstanceIdentifierGeneratorPrimitive<TIdentifier> : InstanceIdentifierGeneratorBase<TIdentifier>
    {
        /// <summary>
        /// Creates new generator with default and invalid identifier.
        /// </summary>
        /// <param name="defaultIdentifier">The default identifier.</param>
        /// <param name="invalidIdentifier">The invalid identifier.</param>
        protected InstanceIdentifierGeneratorPrimitive(TIdentifier defaultIdentifier, TIdentifier invalidIdentifier) : base(defaultIdentifier, invalidIdentifier)
        {
        }
    }
}