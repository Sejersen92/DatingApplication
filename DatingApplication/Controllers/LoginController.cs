﻿using DatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace DatingApplication.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool UserLogin([FromBody] LoginRequest request)
        {
            return UserValidation.Verify(request);
        }

        [HttpPost]
        public void CreateUser([FromBody]User value)
        {
            value.CreateDate = DateTime.UtcNow;
            using (var ctx = new DatingContext())
            {
                ctx.Users.Add(value);
                ctx.SaveChanges();
            }
        }
        [HttpPost]
        public void CreateProfile([FromBody] ProtoProfile profile)
        {
            using(var ctx = new DatingContext())
            {
                Profile p = new Profile()
                {
                    BodyType = profile.BodyType,
                    Picture = profile.Picture,
                    Description = profile.Description,
                    Height = profile.Height,
                    Weight = profile.Weight,
                    Gender = profile.Gender,
                    HairColor = profile.HairColor,
                    EyeColor = profile.EyeColor,
                    User = ctx.Users.FirstOrDefault(x => x.ID == profile.User_ID)
                };
                ctx.Profiles.Add(p);
                ctx.SaveChanges();
            }
        }
    }
}