using Biographies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biographies.Helpers
{
    public static class ResponseFactory
    {
        public static ResponseModel Create(bool Type)
        {
            try
            {
                if (Type)
                {
                    return new ResponseModel()
                    {
                        ID = (int)Helpers.Utils.ErrorCodes.SUCCESS,
                        Code = (int)Helpers.Utils.ErrorCodes.SUCCESS,
                        Message = "Success"
                    };
                }
                else
                {
                    return new ResponseModel()
                    {
                        ID = (int)Helpers.Utils.ErrorCodes.ERROR,
                        Code = (int)Helpers.Utils.ErrorCodes.ERROR,
                        Message = "Error"
                    };
                }
            }
            catch (Exception ex)
            {
                Helpers.Utils.RegisterException("ResponseFactory: Create", ex.Message);
                return new ResponseModel()
                {
                    ID = (int)Helpers.Utils.ErrorCodes.EXCEPTION,
                    Code = (int)Helpers.Utils.ErrorCodes.EXCEPTION,
                    Message = "An unexpected error occurred. Please contact your system administrator."
                };
            }
        }
    }
}