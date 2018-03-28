using System.Diagnostics;
using LibraryForUnitTestingBasics;
using NUnit.Framework;

namespace LibraryForUnitTestingBasicsTests
{
    [TestFixture]
    public class ShoppingCartTestInitTests
    {
        private ShoppingCart _cart;
        private Item _item;

        [OneTimeSetUp]
        public void TestInitialize()
        {
            Debug.WriteLine("Test Initialize");
            _item = new Item
            {
                Name = "Unit Test",
                Quantity = 10
            };

            _cart = new ShoppingCart();
            _cart.Add(_item);
        }
        
        [Test]
        public void CheckOutContainsItem()
        {
            CollectionAssert.Contains(_cart.Items, _item);
        }

        [Test]
        public void RemoveItemEmpty()
        {
            int expected = 0;

            _cart.Remove(0);

            Assert.AreEqual(expected, _cart.Count);
        }

        [OneTimeTearDown]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            _cart.Dispose();
        }
    }
}