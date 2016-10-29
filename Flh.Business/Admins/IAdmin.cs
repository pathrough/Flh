﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flh.Business.Admins
{
    public interface IAdmin : IUser
    {
        DateTime CreateTime { get; }
    }

    internal class Admin : IAdmin
    {
        private readonly IUser _User;
        private readonly Data.Admin _Entity;

        public Admin(Data.Admin entity, IUser user)
        {
            _Entity = entity;
            _User = user;
        }

        public long Uid
        {
            get { return _User.Uid; }
        }

        public string Name
        {
            get { return _User.Name; }
        }


        public string Mobile
        {
            get { return _User.Mobile; }
        }

        public DateTime CreateTime
        {
            get { return _Entity.created; }
        }
    }
}
