using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Parameters
{
    /// <summary>
    /// class UpdateUserParameter
    /// </summary>
    public class UpdateUserParameter
    {
        /// <summary>
        /// Line user id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否被封鎖
        /// </summary>
        public bool? IsBlocked { get; set; }
    }
}
