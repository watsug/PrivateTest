namespace PrivateTest
{
#if DEBUG
    using NUnit.Framework;

    public partial class Class1
    {
        [TestFixture]
        private class Class1Test
        {
            [Test]
            public void VerifyAlwaysTrue()
            {
                var v = new Class1();
                Assert.IsTrue(v.AlwaysTrue());
            }
        }
    }
#endif
}
