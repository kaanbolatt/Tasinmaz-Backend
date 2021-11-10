using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{

        public class EfUserDal : EfEntityRepositoryBase<User, TasinmazContext>, IUserDal
        {
            public List<Rol> GetClaims(User user)
            {
                using (var context = new TasinmazContext())
                {
                    var result = from rol in context.Rol
                                 join uRol in context.Users
                                     on rol.Id equals user.Rol
                                 select new Rol { Id = rol.Id, Name = rol.Name };
                
                    return result.ToList();

                }
            }
        public List<UserDetailDto> GetUserDetails()
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                var result = from u in context.Users
                             join t in context.Tasinmaz
                             on u.Id equals t.Id
                             select new UserDetailDto
                             {
                                 userID = u.Id,
                                 ada = t.Ada,
                                 //cID = t.countryID,
                                 koordinatX = t.KoordinatX,
                                 koordinatY = t.KoordinatY,
                                 nbID = t.NeighbourhoodsId,
                                 nitelik = t.Nitelik,
                                 parsel = t.Parsel,
                                 //pID = t.provinceID,
                                 tID = t.Id
                             };
                return result.ToList();
            }
        }
        public void DeleteUser(int id)
        {
            using(TasinmazContext context = new TasinmazContext())
            {
                var deletedUser = GetUserById(id);
                context.Users.Remove(deletedUser);
                context.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                return context.Users.Find(id);
            }
        }

        public void UpdateUser(int id, User user)
        {
            using (TasinmazContext context = new TasinmazContext())
            {

                var itemToUpdate =  context.Users.Find(id);

                if (itemToUpdate == null)
                    throw new NullReferenceException();

                itemToUpdate.Name = user.Name;
                itemToUpdate.Surname= user.Surname;
                itemToUpdate.Mail = user.Mail;
                itemToUpdate.PasswordHash= user.PasswordHash;
                itemToUpdate.PasswordSalt = user.PasswordSalt;
                itemToUpdate.Rol = user.Rol;
                context.Users.Update(itemToUpdate);
                context.SaveChangesAsync();
            }
        }

       
    }
    }

