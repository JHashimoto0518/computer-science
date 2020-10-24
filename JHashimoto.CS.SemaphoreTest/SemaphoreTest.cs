using Microsoft.VisualStudio.TestTools.UnitTesting;
using JHashimoto.CS.Semaphore;

namespace JHashimoto.CS.SemaphoreTest {
    [TestClass]
    public class SemaphoreTest {
        [TestMethod]
        public void DecrementAfterPOperation() {
            var s = new JHashimoto.CS.Semaphore.Semaphore();
            s.POperation();
            var actual = s.SemaphoreVariable;
            var expected = 0;
            Assert.AreEqual(actual, expected);
        }
    }
}