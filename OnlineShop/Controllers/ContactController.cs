using Common;
using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            var model = new ContactDao().GetActiveContact();
            return View(model);
        }
        [HttpPost]
        public JsonResult Send(string name, string mobile, string address, string email, string content)
        {
            var feedback = new Feedback();
            feedback.Name = name;
            feedback.Email = email;
            feedback.CreatedDate = DateTime.Now;
            feedback.Phone = mobile;
            feedback.Content = content;
            feedback.Address = address;
            feedback.Status = true;

            var id = new ContactDao().InsertFeedBack(feedback);

            string fb = System.IO.File.ReadAllText(Server.MapPath("~/Assest/client/template/Feedback.html"));

            fb = fb.Replace("{{Name}}", name);
            fb = fb.Replace("{{Phone}}", mobile);
            fb = fb.Replace("{{Email}}", email);
            fb = fb.Replace("{{Address}}", address);
            fb = fb.Replace("{{Content}}",content);

            //email của quản trị
           var toEmail = ConfigurationManager.AppSettings["toemailaddress"].ToString();
            //gửi đến email khách hàng
            //new MailHepler().SendMail(email, "Phản hồi/góp ý của khách hàng", fb);
            //Gửi mail đến quản trị
            new MailHepler().SendMail(toEmail, "Phản hồi/góp ý của khách hàng", fb);
            if (id > 0)
                return Json( new {
                    status = true
                });
            else
                return Json(new
                {
                    status = false
                });

        }
    }
}