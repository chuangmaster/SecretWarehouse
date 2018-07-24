using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Dapper.Models
{
    /// <summary>
    /// class UserModel
    /// </summary>
    public class UserModel
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
        /// 寫入日期
        /// </summary>
        public DateTime DateIn { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsBlocked { get; set; }
    }
}
