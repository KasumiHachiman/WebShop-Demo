namespace WebShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        //nhieu thao cac tren cung 1 giao dich va dam bao tinh toan vien(cac thao tac phai thuc hien thanh cong)
        void Commit();
    }
}