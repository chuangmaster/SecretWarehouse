using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Dapper.Parameters
{
    /// <summary>
    /// class AddUserParameter
    /// </summary>
    public class AddUserRptParameter
    {
        /// <summary>
        /// Line user id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }
    }
}
