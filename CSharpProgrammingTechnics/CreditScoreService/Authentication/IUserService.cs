using CreditScore.Entites.Authentication;
using CreditScore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditScore.DAL.Authentication
{
    public interface IUserService
    {
        AuthenticateResponseDTO Authenticate(AuthenticateRequestDTO model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
