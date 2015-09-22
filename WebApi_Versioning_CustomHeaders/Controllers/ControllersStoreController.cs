using System.Collections.Generic;
using System.Web.Http;
using WebApi_Versioning_CustomHeaders.Models;

namespace WebApi_Versioning_CustomHeaders.Controllers
{
    //Default API Controller
    public class EmployeeAPIController : ApiController
    {
        public List<EmployeeInfo> Get(int id = 0)
        {
            return new EmployeeInfoDatabase();
        }
    }


    //API Controller with Version1
    public class EmployeeAPIV1Controller : ApiController
    {
        public List<EmployeeInfo> Get(int id = 0)
        {
            return new EmployeeInfoDatabaseV1();
        }
    }

    //API Controller with Version2
    public class EmployeeAPIV2Controller : ApiController
    {
        public List<EmployeeInfo> Get(int id = 0)
        {
            return new EmployeeInfoDatabaseV2();
        }
    }
}
