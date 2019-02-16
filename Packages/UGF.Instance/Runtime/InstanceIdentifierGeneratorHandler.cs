namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Delegate used in <see cref="InstanceIdentifierGenerator{TIdentifier}"/> to handle new identifiers generation.
    /// </summary>
    /// <param name="previous">The previous identifier.</param>
    public delegate TIdentifier InstanceIdentifierGeneratorHandler<TIdentifier>(TIdentifier previous);
}