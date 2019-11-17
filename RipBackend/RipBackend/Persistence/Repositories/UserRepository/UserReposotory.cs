using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RipBackend.Models.User;
using RipBackend.Models;

namespace RipBackend.Persistence.Repositories.UserRepository
{
    public class UserReposotory
    {
        public void Add(User user)
        {
            using (CatalogOfCar catalog = new CatalogOfCar())
            {
                catalog.User.AddAsync(user);
                catalog.SaveChanges();
            }
        }

        public bool IsSet(string email)
        {
            using (CatalogOfCar catalog = new CatalogOfCar())
            {
                try
                {
                    var user = catalog.User
                        .Single(u => u.email == email);

                    return true;
                }catch(Exception err)
                {
                    return false;
                }
            }
        }

        public bool IsSet(LoginForm loginForm)
        {
            using (CatalogOfCar catalog = new CatalogOfCar())
            {
                try
                {
                    var user = catalog.User
                        .Single(u => u.email == loginForm.email && u.password == loginForm.password);

                    return true;
                }
                catch (Exception err)
                {
                    return false;
                }
            }
        }

        public User GetUser(LoginForm loginForm)
        {
            using (CatalogOfCar catalog = new CatalogOfCar())
            {
                try
                {
                    var user = catalog.User
                        .Single(u => u.email == loginForm.email && u.password == loginForm.password);

                    return user;
                }
                catch (Exception err)
                {
                    return null;
                }
            }
        }
    }
}
