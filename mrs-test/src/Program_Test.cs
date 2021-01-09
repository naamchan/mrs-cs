using NUnit.Framework;
using MRS;

namespace MRS_Test
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            MRS.Program.Main(new string[] {
                "--execute",
                "print(\"hello world\")"
            });
        }
    }
}