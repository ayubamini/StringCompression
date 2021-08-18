using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCompression.Test
{
    [TestClass]
    public class CompressionTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidInputString))] 
        public void InputStringIsEmpty_ThrowException()
        {
            var input = string.Empty;
            
            Compression.Compress(input);
        }
    }
}
