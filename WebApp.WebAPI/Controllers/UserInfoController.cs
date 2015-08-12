using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.WebAPI.Models;

namespace WebApp.WebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class UserInfoController : ApiController
    {
        private readonly DbContext _dbContext = new CompanyContext();

        /// <summary>
        /// 分页查询用户信息
        /// </summary>
        /// <param name="page">页码索引</param>
        /// <param name="count">每页显示条数</param>
        /// <returns>指定页面用户信息集合</returns>
        [HttpGet]
        public List<UserInfo> GetList(int page, int count)
        {
            return _dbContext.Set<UserInfo>().OrderByDescending(u => u.RegTime).Skip((page - 1) * count).Take(count).ToList();
        }
    }
}
