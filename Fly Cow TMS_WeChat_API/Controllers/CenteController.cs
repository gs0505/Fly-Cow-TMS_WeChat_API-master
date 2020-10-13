using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;

namespace Fly_Cow_TMS_WeChat_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CenteController : ControllerBase
    {
        public WMSContextDb db;
        public CenteController(WMSContextDb db) { this.db = db; }

 #region
        /// <summary>
        /// 分页显示
        /// </summary>
        /// <param name="dangqianye"></param>
        /// <param name="meiyetiaoshu"></param>
        /// <returns></returns>
        public FenYe<OrderForm> Show(int dangqianye = 1, int meiyetiaoshu = 5)
        {
            var list = from o in db.orderform select o;
            if (dangqianye <= 1)
            {
                dangqianye = 1;
            }
            var zongtiaoshu = list.Count();
            int page;
            if (zongtiaoshu % meiyetiaoshu == 0)
            {
                page = zongtiaoshu / meiyetiaoshu;
            }
            else
            {
                page = zongtiaoshu / meiyetiaoshu + 1;
            }
            if (dangqianye >= page)
            {
                dangqianye = page;
            }
            if (zongtiaoshu == 0)
            {
                FenYe<OrderForm> o = new Model.FenYe<OrderForm>();
                o.Zongtiaoshu = zongtiaoshu;
                o.Zongyeshu = page;
                o.Dangqianye = dangqianye;
                return o;
            }
            else
            {
                FenYe<OrderForm> o = new Model.FenYe<OrderForm>();
                o.masd = list.Skip((dangqianye - 1) * meiyetiaoshu).Take(meiyetiaoshu).ToList();
                o.Zongtiaoshu = zongtiaoshu;
                o.Zongyeshu = page;
                o.Dangqianye = dangqianye;
                return o;
            }
        }
        #endregion 
        ///// <summary>
        ///// 删除
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<ActionResult<int>> Del(int id)
        //{
        //    db.orderform.Remove(db.orderform.Find(id));
        //    return await db.SaveChangesAsync();
        //}
        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<ActionResult<int>> ZL(int id)
        //{
        //    OrderForm orderForm = db.orderform.Find(id);
        //    return await db.SaveChangesAsync();
        //}
        ///// <summary>
        ///// 反填
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public async Task<ActionResult<IEnumerable<OrderForm>>> Fan(int id)
        //{
        //    var list = from o in db.orderform select o;
        //    list = list.Where(p => p.DDId == id);
        //    return await list.ToListAsync();
        //}
        ///// <summary>
        ///// 添加
        ///// </summary>
        ///// <returns></returns>
        //public async Task<ActionResult<int>> Add()
        //{
        //    return await db.SaveChangesAsync();
        //}
    }
}
  

    

