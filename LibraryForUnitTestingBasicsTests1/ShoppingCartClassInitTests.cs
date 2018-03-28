using System.Diagnostics;
using LibraryForUnitTestingBasics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryForUnitTestingBasicsTestsMSTest
{
    [TestClass()]
    public class ShoppingCartClassInitTests
    {
        private static ShoppingCart _cart;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Class Initialize");
            Item item = new Item
            {
                Name = "Unit Test Video Lessons",
                Quantity = 10
            };

            _cart = new ShoppingCart();
            _cart.Add(item);
        }

        [TestMethod]
        public void ShopingCartAddToCart()
        {
            int expected = _cart.Items.Count + 1;

            _cart.Add(new Item() { Name = "Test", Quantity = 1 });

            Assert.AreEqual(expected, _cart.Count);
        }

        [TestMethod]
        public void ShopingCartRemoveFromCart()
        {
            int expected = _cart.Items.Count - 1;

            _cart.Remove(0);

            Assert.AreEqual(expected, _cart.Count);
        }

        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Class CleanUp");
            _cart.Dispose();
        }
    }
}