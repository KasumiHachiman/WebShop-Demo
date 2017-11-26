using System;
using WebShop.Data.Interface;
using WebShop.Model.Models;

namespace WebShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        public ErrorService(IErrorRepository errorRepository)
        {
            this._errorRepository = errorRepository;
        }
        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _errorRepository.Save();
        }
    }
}