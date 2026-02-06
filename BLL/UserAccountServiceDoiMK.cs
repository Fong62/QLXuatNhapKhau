using System;
using DAL;
namespace BLL
{
    public class UserAccountServiceDoiMK
    {
        private readonly UserAccountRepositoryDoiMK repository;

        public UserAccountServiceDoiMK()
        {
            repository = new UserAccountRepositoryDoiMK();
        }

        // Phương thức thay đổi mật khẩu
        public bool ChangePassword(string username, string newPassword)
        {
            return repository.UpdatePassword(username, newPassword); 
        }
    }
}