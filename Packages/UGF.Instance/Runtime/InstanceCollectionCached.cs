using System.Collections.Generic;

namespace UGF.Instance.Runtime
{
    /// <summary>
    /// Implementation of <see cref="InstanceCollection{TIdentifier,TInstance}"/> with identifiers cache.
    /// <para>
    /// After remove of the instance it will store unused id for the next added instance.
    /// </para>
    /// </summary>
    public class InstanceCollectionCached<TIdentifier, TInstance> : InstanceCollection<TIdentifier, TInstance>
    {
        /// <summary>
        /// Gets the count of the identifiers in cache.
        /// </summary>
        public int CacheCount { get { return m_cache.Count; } }
        
        private readonly Stack<TIdentifier> m_cache = new Stack<TIdentifier>();

        public InstanceCollectionCached(IInstanceIdentifierGenerator<TIdentifier> generator) : base(generator)
        {
        }

        protected override TIdentifier OnGenerateIdentifier()
        {
            return m_cache.Count > 0 ? m_cache.Pop() : base.OnGenerateIdentifier();
        }

        public override bool Remove(TIdentifier identifier)
        {
            if (base.Remove(identifier))
            {
                m_cache.Push(identifier);
                
                return true;
            }

            return false;
        }

        public override void Clear()
        {
            base.Clear();
            
            m_cache.Clear();
        }
    }
}