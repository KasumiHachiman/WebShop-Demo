using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using WebShop.Data.Interface;
using WebShop.Model.Models;
using WebShop.Service.Repository;

namespace WebShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private IPostCategoryService _pCategoryService;
        private List<PostCategory> _listPCategory;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _pCategoryService = new PostCategoryService(_mockRepository.Object);
            _listPCategory = new List<PostCategory>()
            {
                new PostCategory() {Name="DM1",Status=true },
                new PostCategory() {Name="DM2",Status=true },
                new PostCategory() {Name="DM3",Status=true }
            };
        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //set up method
            IQueryable<PostCategory> qPostCategory = _listPCategory.AsQueryable();
            _mockRepository.Setup(m => m.GetAll(null)).Returns(qPostCategory);
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
           
            category.Name = "Category 1";
            category.Alias = "category-1";
            category.Status = true;
            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });
            var result = _pCategoryService.Add(category);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);

        }
    }
}