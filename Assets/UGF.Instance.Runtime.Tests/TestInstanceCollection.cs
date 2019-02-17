using NUnit.Framework;
using UGF.Instance.Runtime.Collections;

namespace UGF.Instance.Runtime.Tests
{
    public class TestInstanceCollection
    {
        private class Instance
        {
        }

        [Test]
        public void Contains()
        {
            var collection = new InstanceCollectionInt32<Instance>();
            var instance = new Instance();
            int id = collection.Add(instance);
            
            Assert.IsTrue(collection.Contains(id), "collection.Contains(id)");

            collection.Remove(id);
            
            Assert.IsFalse(collection.Contains(id), "collection.Contains(id)");
        }
        
        [Test]
        public void Add()
        {
            var collection = new InstanceCollectionInt32<Instance>();
            var instance = new Instance();
            int id = collection.Add(instance);

            Assert.AreEqual(id, collection.Generator.PreviousIdentifier);
            Assert.IsTrue(collection.Contains(id), "collection.Contains(id)");
            Assert.IsTrue(collection.Generator.IsValid(id), "collection.Generator.IsValid(id)");
        }

        [Test]
        public void Remove()
        {
            var collection = new InstanceCollectionInt32Cached<Instance>();
            var instance = new Instance();
            int id = collection.Add(instance);
            
            Assert.IsTrue(collection.Contains(id), "collection.Contains(id)");
            
            bool removeResult = collection.Remove(id);

            Assert.IsTrue(removeResult, "removeResult");
            Assert.AreEqual(1, collection.CacheCount);
            
            int id2 = collection.Add(instance);

            Assert.AreEqual(0, collection.CacheCount);
            Assert.AreEqual(id2, id);
        }

        [Test]
        public void Clear()
        {
            var collection = new InstanceCollectionInt32Cached<Instance>();
            var instance = new Instance();

            int id = collection.Add(instance);

            Assert.AreEqual(1, collection.Count);
            Assert.AreEqual(id, collection.Generator.PreviousIdentifier);

            collection.Clear();
            collection.Generator.Reset();

            Assert.AreEqual(0, collection.Count);
            Assert.AreEqual(0, collection.CacheCount);
            Assert.AreEqual(collection.Generator.PreviousIdentifier, collection.Generator.DefaultIdentifier);
            
            int id2 = collection.Add(instance);
            
            Assert.AreEqual(id2, id);
        }

        [Test]
        public void TryGetInstance()
        {
            var collection = new InstanceCollectionInt32<Instance>();
            var instance = new Instance();
            int id = collection.Add(instance);

            collection.TryGetInstance(id, out var result);
            
            Assert.NotNull(result);
            Assert.AreEqual(result, instance);

            collection.Remove(id);
            collection.TryGetInstance(id, out result);
            
            Assert.Null(result);
        }

        [Test]
        public void GetEnumerator()
        {
            var collection = new InstanceCollectionInt32<Instance>();

            foreach (var pair in collection)
            {
            }
        }
    }
}