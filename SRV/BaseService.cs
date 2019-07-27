using AutoMapper;
using BLL;
using BLL.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class BaseService
    {
        private const string _userIDKry = "UserName";
        private const string _userPassWordKey = "UserPassWord";
        private string _currentUserName;
        private int _currentUserId;
        protected UserReporsitory _userReporsitory;
        protected IHttpContextAccessor accessor;

        public BaseService(UserReporsitory reporsitory, IHttpContextAccessor httpContextAccessor)
        {
            _userReporsitory = reporsitory;
            accessor = httpContextAccessor;
        }

        protected static MapperConfiguration autoMapperConfig;
        static BaseService()
        {
            autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Suggest, DTOSuggestModel>();
                cfg.CreateMap<DTOSuggestModel, Suggest>();
                cfg.CreateMap<IList<Suggest>, IList<DTOSuggestModel>>();
            });
#if DEBUG 
            autoMapperConfig.AssertConfigurationIsValid();
#endif
            var mapper = autoMapperConfig.CreateMapper();
        }

        /// <summary>
        /// AotuMapper工具属型
        /// </summary>
        protected IMapper Mapper
        {
            get
            {
                return autoMapperConfig.CreateMapper();
            }
        }

        /// <summary>
        /// 通过 DI 在SRV 层获取Httpcontext 的 Cookie  再获得当前用户的属型！ 
        /// </summary>
        public User currentuser
        {
            get
            {
                if (accessor.HttpContext.Request.Cookies.TryGetValue(_userIDKry, out _currentUserName))
                {
                    return _userReporsitory.GetByName(_currentUserName);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
