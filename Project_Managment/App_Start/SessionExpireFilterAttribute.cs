﻿//using Microsoft.ApplicationInsights.DataContracts;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Project_Managment.Helpers
//{
//    public class SessionExpireFilterAttribute : ActionFilterAttribute
//    {
//        public override void OnActionExecuting(ActionExecutingContext filterContext)
//        {
//            HttpContext ctx = HttpContext.Current;

//            // check if session is supported
//            CurrentCustomer objCurrentCustomer = new CurrentCustomer();
//            objCurrentCustomer = ((CurrentCustomer)SessionState.GetSessionValue(SessionStore.Customer));
//            if (objCurrentCustomer == null)
//            {
//                // check if a new session id was generated
//                filterContext.Result = new RedirectResult("~/Users/Login");
//                return;
//            }

//            base.OnActionExecuting(filterContext);
//        }
//    }
//}