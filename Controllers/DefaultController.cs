using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularAPI.Models;

namespace AngularAPI.Controllers
{
    [RoutePrefix("Api/Deals")]
    public class DefaultController : ApiController
    {
        KCBCREntities objEntity = new AngularAPI.Models.KCBCREntities();
        [HttpGet]
        [Route("GetDealDetails")]
        public IQueryable<UAT_CHR_Deals> GetDeal()
        {
            try
            {
                return objEntity.UAT_CHR_Deals;
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        [Route("GetDealDetailsById/{dealId}")]
        public IHttpActionResult GetDealById(string dealId)
        {
            UAT_CHR_Deals objDeal = new UAT_CHR_Deals();
            int ID = Convert.ToInt32(dealId);
            try
            {
                objDeal = objEntity.UAT_CHR_Deals.Find(ID);
                if (objDeal == null)
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(objDeal);
        }
        [HttpPost]
        [Route("InsertDealDetails")]
        public IHttpActionResult PostDeal(UAT_CHR_Deals data)
        {
            string message = "";
            if (data != null)
            {
                try
                {
                    objEntity.UAT_CHR_Deals.Add(data);
                    int result = objEntity.SaveChanges();
                    if (result > 0)
                    {
                        message = "Deal has been sussfully added";
                    }
                    else
                    {
                        message = "faild";
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return Ok(message);
        }
        [HttpPut]
        [Route("UpdateDealStatus")]
        public IHttpActionResult PutDealMaster(UAT_CHR_Deals deal)
        {
            string message = "";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                UAT_CHR_Deals objDeal = new UAT_CHR_Deals();
                objDeal = objEntity.UAT_CHR_Deals.Find(objDeal.DealId);
                if (objDeal != null)
                {
                    objDeal.DealStatus = deal.DealStatus;

                }
                int result = objEntity.SaveChanges();
                if (result > 0)
                {
                    message = "Deal Status has been sussfully updated";
                }
                else
                {
                    message = "faild";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(message);
        }
        [HttpDelete]
        [Route("DeleteDealDetails")]
        public IHttpActionResult DeleteDealDelete(int id)
        {
            string message = "";
            UAT_CHR_Deals deal = objEntity.UAT_CHR_Deals.Find(id);
            objEntity.UAT_CHR_Deals.Remove(deal);
            int result = objEntity.SaveChanges();
            if (result > 0)
            {
                message = "Deal has been sussfully deleted";
            }
            else
            {
                message = "faild";
            }
            return Ok(message);
        }
    }
}
