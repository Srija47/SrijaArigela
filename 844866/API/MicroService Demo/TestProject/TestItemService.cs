using System;
using System.Collections.Generic;
using System.Text;
using ItemService.Models;
using ItemService.Repositories;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    class TestItemService
    {
        ItemRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new ItemRepository(new ShopDBContext());
        }
        [Test]
        public void TestGetAllItems()
        {
            var result = _repo.GetAllItems();
            Assert.IsNotNull(result);
            Assert.GreaterOrEqual(result.Count, 6);
        }
        [Test]
        public void TestGetById()
        {
            var result = _repo.GetById("I0005");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestAddItem()
        {
            _repo.AddItem(new Items()
            {
                Itemid = "I0007",
                Name = "ABC",
                Price = 10,
                Stock = 100
            });
            var result = _repo.GetById("I0007");
            Assert.NotNull(result);
        }
        [Test]
        public void TestDeleteItem()
        {
            _repo.DeleteItem("10006");
            var result = _repo.GetById("10006");
            Assert.Null(result);
        }
        [Test]
        public void TestUpdate()
        {
            //Arrange
            Items item = _repo.GetById("I0001");
            item.Price = 200;
            _repo.UpdateItem(item);
            Items item1 = _repo.GetById("I0001");
            Assert.AreSame(item, item1);
        }
    }
}
