using FinalFlowerAPIApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalFlowerAPIApplication.Services
{
    public class UserService
    {
        private readonly CompanyContext _context;
        private readonly ITokenService _tokenService;

        public UserService(CompanyContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public UserDTO Register(UserDTO userDTO)
        {
            try
            {
                using var hmac = new HMACSHA512();
                var user = new User()
                {
                    UserEmail = userDTO.UserEmail,

                    Name = userDTO.Name,
                    Address = userDTO.Address,
                    Phone = userDTO.Phone,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password)),
                    PasswordSalt = hmac.Key

                };

                _context.Users.Add(user);
                _context.SaveChanges();
                userDTO.JwtToken = _tokenService.CreateToken(userDTO);
                userDTO.Password = "";
                return userDTO;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }
        public UserDTO Login(UserDTO userDTO)
        {
            try
            {
                var myUser = _context.Users.SingleOrDefault(u => u.UserEmail == userDTO.UserEmail);
                if (myUser != null)
                {
                    using var hmac = new HMACSHA512(myUser.PasswordSalt);
                    var userPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));

                    for (int i = 0; i < userPassword.Length; i++)
                    {
                        if (userPassword[i] != myUser.PasswordHash[i])
                            return null;
                    }
                    userDTO.JwtToken = _tokenService.CreateToken(userDTO);
                    userDTO.Password = "";
                    return userDTO;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }

        public ICollection<User> GetAll()
        {
            IList<User> user = _context.Users.ToList();
            if (user.Count > 0)

                return user;
            else
                return null;



        }
        public User Get(string id)
        {
            User user = null;
            user = _context.Users.FirstOrDefault(p => p.UserEmail == id);
            return user;

        }
    }
}
