using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Dapper.Parameters
{
    /// <summary>
    /// class UpdateUserParameter
    /// </summary>
    public class UpdateUserRptParameter
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
        /// 更新時間
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 是否被封鎖
        /// </summary>
        public bool? IsBlocked { get; set; }
    }
}
