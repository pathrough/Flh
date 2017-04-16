﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Flh.Data;

namespace Flh.Business.Inject
{
    public class DataModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Data.LoginHistory>>().To<Data.DbSetRepository<Data.FlhContext, Data.LoginHistory>>();
            Bind<Data.IUserRepository>().To<Data.UserRepository>();
            Bind<Data.IAdminRepository>().To<Data.AdminRepository>();
            Bind<Data.IClassesRepository>().To<Data.ClassesRepository>();
            Bind<Data.IAdminModifyHistoryRepository>().To<Data.AdminModifyHistoryRepository>();
            Bind<Data.IAreaRepository>().To<Data.AreaRepository>();
            Bind<Data.ITradeRepository>().To<Data.TradeRepository>();
            Bind<Data.IProductRepository>().To<Data.ProductRepository>();
            Bind<Data.IAdvertisementRepository>().To<Data.AdvertisementRepository>();
            Bind<Data.IFollowUpRecordRepository>().To<Data.FollowUpRecordRepository>();
            Bind<IRepository<Data.VerifyCode>>().To<Data.DbSetRepository<Data.FlhContext, Data.VerifyCode>>();
            Bind<IRepository<Data.SmsHistory>>().To<Data.DbSetRepository<Data.FlhContext, Data.SmsHistory>>();
        }
    }
}
