using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseProject.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseProject.DATA
{
    public class BaseProjectDbContext: IdentityDbContext<BaseProjectUser>
    {
        public BaseProjectDbContext():base(nameOrConnectionString: "BaseProjectConnection")
        {

        }
        public static BaseProjectDbContext Create()
        {
            return new BaseProjectDbContext();
        }

    }
}
