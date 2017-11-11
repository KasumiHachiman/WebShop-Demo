using System.Collections.Generic;
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Service.Repository
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        PostCategory Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAlByParentId(int parentId);

        PostCategory GetById(int id);

        void Save();
    }

    public class PostCategoryService : IPostCategoryService
    {
        public IPostCategoryRepository _postCategoryRepository;

        public PostCategoryService(IPostCategoryRepository postCategory)
        {
            this._postCategoryRepository = postCategory;
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        public PostCategory Delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAlByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _postCategoryRepository.Save();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}