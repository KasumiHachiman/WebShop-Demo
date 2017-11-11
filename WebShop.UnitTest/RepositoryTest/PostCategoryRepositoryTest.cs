using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebShop.Data.EntityFramworkRepository;
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IWebShopDbContextFactory dbFactory;
        IPostCategoryRepository objRepository;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new WebShopDbContextFactory();
            objRepository = new PostCategoryRepository(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList(); ;
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory pCategory = new PostCategory();
            pCategory.Name = "category 3";
            pCategory.Alias = "category-3";
            pCategory.Status = true;
            var result = objRepository.Add(pCategory);
            objRepository.Save();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);

        }

    }
}