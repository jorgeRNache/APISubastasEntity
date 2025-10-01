using ApiSubastasEntity.Services;
using Microsoft.AspNetCore.Mvc;

namespace APISubastasEntity.Controllers.Base
{
    public class BaseControlador : ControllerBase
    {

        public ApiSubastasDbContext _context;

        public void SetContext(ApiSubastasDbContext context)
        {
            _context = context;
        }


    }
}
