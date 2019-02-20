namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Implementation of <see cref="T:UGF.Instance.Runtime.IInstanceIdentifierGenerator`1" /> with specified generator handler.
    /// </summary>
    public class InstanceIdentifierGenerator<TIdentifier> : InstanceIdentifierGeneratorBase<TIdentifier>
    {
        /// <summary>
        /// Gets the user defined generator handler used to generate new identifier.
        /// </summary>
        public InstanceIdentifierGeneratorHandler<TIdentifier> Handler { get; }
        
        /// <inheritdoc />
        /// <summary>
        /// Creates new identifier generator with specified generator handler and initial identifier.
        /// </summary>
        /// <param name="handler">The handler used to generator new identifier.</param>
        /// <param name="defaultIdentifier">The default identifier.</param>
        /// <param name="invalidIdentifier">The invalid identifier.</param>
        public InstanceIdentifierGenerator(InstanceIdentifierGeneratorHandler<TIdentifier> handler, TIdentifier defaultIdentifier, TIdentifier invalidIdentifier) : base(defaultIdentifier, invalidIdentifier)
        {
            Handler = handler;
            PreviousIdentifier = defaultIdentifier;
        }

        public override TIdentifier Generate()
        {
            PreviousIdentifier = Handler(PreviousIdentifier);

            return PreviousIdentifier;
        }
    }
}