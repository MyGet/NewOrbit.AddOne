namespace UnitTests
{
    using NewOrbit.AddOne;

    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void CanAddOne()
        {
            var subject = new Adder();
            var actual = subject.AddOne(100);
            Assert.Equal(101, actual);
        }
    }
}
