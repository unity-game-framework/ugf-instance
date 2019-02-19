using NUnit.Framework;
using UGF.Instance.Runtime.Generators;

namespace UGF.Instance.Runtime.Tests
{
    public class TestInstanceIdentifierGenerator
    {
        private class Generator : InstanceIdentifierGeneratorBase<int>
        {
            public Generator() : base(int.MinValue, int.MaxValue)
            {
            }

            public override int Generate()
            {
                return ++PreviousIdentifier;
            }
        }
        
        [Test]
        public void IsValid()
        {
            var generator = new InstanceIdentifierGeneratorInt32();
            int id = generator.Generate();
            
            Assert.IsTrue(generator.IsValid(generator.DefaultIdentifier));
            Assert.IsFalse(generator.IsValid(generator.InvalidIdentifier));
            Assert.IsTrue(generator.IsValid(id));
        }

        [Test]
        public void IsValid2()
        {
            var generator = new Generator();
            int id = generator.Generate();
            
            Assert.IsTrue(generator.IsValid(generator.DefaultIdentifier));
            Assert.IsFalse(generator.IsValid(generator.InvalidIdentifier));
            Assert.IsTrue(generator.IsValid(id));
        }
    }
}