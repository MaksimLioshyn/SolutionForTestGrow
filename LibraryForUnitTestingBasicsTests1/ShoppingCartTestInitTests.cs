using System.Diagnostics;
using LibraryForUnitTestingBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForUnitTestingBasicsTestsMSTest
{
    [TestClass()]
    public class ShoppingCartTestInitTests
    {
        private ShoppingCart _cart;
        private Item _item;

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            _item = new Item
            {
                Name = "Unit Test Video Lessons",
                Quantity = 10
            };

            _cart = new ShoppingCart();
            _cart.Add(_item);
        }
        
        [TestMethod]
        public void CheckOutContainsItem()
        {
            CollectionAssert.Contains(_cart.Items, _item);
        }

        [TestMethod]
        public void RemoveItemEmpty()
        {
            int expected = 0;

            _cart.Remove(0);

            Assert.AreEqual(expected, _cart.Count);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            _cart.Dispose();
        }
    }
}