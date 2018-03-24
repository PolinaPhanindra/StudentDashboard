using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class CustomHandlerErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public string View { get; set; }
        public int StatusCode { get; set; }
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            //Logging goes here
            filterContext.Result = new ViewResult { ViewName = View,
                                                    ViewData = new ViewDataDictionary
                                                  { { "ErrorMsg", filterContext.Exception.Message } } };
            
        }
        
    }
    public class CustomResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}