using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Persistence.Authenticate;
 
    public static class ExtensionMethods
    {
        public static IEnumerable<Login> WithoutPasswords(this IEnumerable<Login> users) 
        {
            if (users == null) return null;

            return users.Select(x => x.WithoutPassword());
        }

        public static Login WithoutPassword(this Login user) 
        {
            if (user == null) return null;

            user.Password = null;
            return user;
        }
    }
 