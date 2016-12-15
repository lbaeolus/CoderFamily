using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderF.DAL
{
    public class CFUser
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public string UserPwd { get; set; }

        public int Sex { get; set; }

        public int CityCode { get; set; }
    }
}
