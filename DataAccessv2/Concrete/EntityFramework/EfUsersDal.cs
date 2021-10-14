﻿using DataAccess.Abstract;
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
            public List<OperationClaim> GetClaims(User user)
            {
                using (var context = new TasinmazContext())
                {
                    var result = from operationClaim in context.OperationClaim
                                 join userOperationClaim in context.UserOperationClaim
                                     on operationClaim.Id equals userOperationClaim.OperationClaimID
                                 where userOperationClaim.UserID == user.uID
                                 select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                    return result.ToList();

                }
            }
        public List<UserDetailDto> GetUserDetails()
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                var result = from u in context.Users
                             join t in context.Tasinmaz
                             on u.uID equals t.uID
                             select new UserDetailDto
                             {
                                 userID = u.uID,
                                 ada = t.ada,
                                 cID = t.countryID,
                                 koordinatX = t.koordinatX,
                                 koordinatY = t.koordinatY,
                                 nbID = t.nbID,
                                 nitelik = t.nitelik,
                                 parsel = t.parsel,
                                 pID = t.provinceID,
                                 tID = t.tID
                             };
                return result.ToList();
            }
        }
    }
    }

