using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserApp.Maps
{
    public class UserMap : Profile
    {
        public override string ProfileName
        {
            get { return "UserMapping"; }
        }

        protected override void Configure()
        {
            CreateMap<Models.User, Domain.User>();
            CreateMap<Domain.User, Models.User>();
        }
    }
}