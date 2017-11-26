
using WebShop.Api.Models;
using WebShop.Model.Models;

namespace WebShop.Api.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            //this chi tdinh phuong thuc mo rong cua thang nao
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.CreatedBy = postCategoryViewModel.CreatedBy;
            postCategory.CreatedDate = postCategoryViewModel.CreatedDate;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.UpdatedBy = postCategoryViewModel.UpdatedBy;
            postCategory.UpdatedDate = postCategoryViewModel.UpdatedDate;
            postCategory.Status = postCategoryViewModel.Status;
            //postCategory.Posts = postCategoryViewModel.PostViewModels;
            postCategory.ID = postCategoryViewModel.ID;
        }

        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.Alias = postViewModel.Alias;
            post.Description = postViewModel.Description;
            post.DisplayOrder = postViewModel.DisplayOrder;
            post.HomeFlag = postViewModel.HomeFlag;
            post.Image = postViewModel.Image;
            post.Name = postViewModel.Name;
            post.ParentID = postViewModel.ParentID;
            post.Content = postViewModel.Content;
            post.ViewCount = postViewModel.ViewCount;
            post.CreatedBy = postViewModel.CreatedBy;
            post.CreatedDate = postViewModel.CreatedDate;
            post.MetaDescription = postViewModel.MetaDescription;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.UpdatedBy = postViewModel.UpdatedBy;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.Status = postViewModel.Status;
        }
    }
}