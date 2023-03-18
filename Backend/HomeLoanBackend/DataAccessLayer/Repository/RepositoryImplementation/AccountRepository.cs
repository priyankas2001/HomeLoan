using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.RepositoryImplementation
{
    public class AccountRepository
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountRepository(IServiceProvider serviceProvider, UserManager<User> userManager, SignInManager<User> signInManager
            )
        {
            _serviceProvider = serviceProvider;
            _userManager = userManager;
        }

        public async Task CreateRoleAsync(IServiceProvider _serviceProvider)
        {
            var roles = new string[] { "User", "Advisor" };

            var roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole { Name = role });

                }
            }

        }

        public async Task<dynamic> createUserAsync(User userModel)
        {

            var userManager = _serviceProvider.GetRequiredService<UserManager<User>>();
            var email = userManager.Users.Where(x => x.Email == userModel.Email).FirstOrDefault();
            if (email == null)
            {
                return ("user not found");

            }
            else
            {
                var user = new User()
                {
                    Email = userModel.Email,
                    MobileNumber = userModel.MobileNumber,
                    StateCode = userModel.StateCode,
                    CityCode = userModel.CityCode,
                    CountryCode = userModel.CountryCode,


                };

                var res = await _userManager.CreateAsync(user, userModel.Password);
                return res;
            }
        }

        User user1 = new User
        {

        };
        createUserAsync(user1);


    }
}
