using System.ComponentModel.Design;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DemoIdentity.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData (this ModelBuilder modelBuilder)
        {
            List<IdentityRole> roles = new List<IdentityRole>() {
                new IdentityRole {Name = "Administrator", NormalizedName = "ADMINISTRATOR"},
                new IdentityRole {Name = "Visitor", NormalizedName = "VISITOR"}
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            List<IdentityUser> users = new List<IdentityUser>() {
                new IdentityUser {
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true
                },
                new IdentityUser {
                    UserName = "pqh.cntt@gmail.com",
                    NormalizedUserName = "PQH.CNTT@GMAIL.COM",
                    Email = "pqh.cntt@gmail.com",
                    NormalizedEmail = "PQH.CNTT@GMAIL.COM",
                    EmailConfirmed = true
                },
            };
            modelBuilder.Entity<IdentityUser>().HasData(users);
            var passwordHasher = new PasswordHasher<IdentityUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Mvc123!@#00");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Mvc123!@#00");
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string> {
                UserId = users[0].Id,
                RoleId = roles.First( m => m.Name == "Administrator").Id
            });
            userRoles.Add(new IdentityUserRole<string> {
                UserId = users[1].Id,
                RoleId = roles.First( m => m.Name == "Visitor").Id
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}