﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop
{
    public class HasCredentialAttribute:AuthorizeAttribute 
    {
        public string RoleID { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var session = (UserLogin)HttpContext.Current.Session[common.CommonConstants.USER_SESSION];
            if (session == null)
            {
                return false;
            }
            List<string> privilegeLevels = this.GetCredentialByLoggedInUser(session.UserName);

            if (privilegeLevels.Contains(this.RoleID)|| session.GroupID==CommonConstants.ADMIN_GROUP)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Areas/Admin/Views/Shared/401.cshtml"
            };
        }

        private List<string> GetCredentialByLoggedInUser(string userName)
        {
            var credentials=(List<string>)HttpContext.Current.Session[common.CommonConstants.SESSION_CREDENTIALS];
            return credentials;
        }
    }
}