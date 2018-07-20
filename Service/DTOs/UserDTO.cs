using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    /// <summary>
    /// class UserDTO
    /// </summary>
    public class UserDTO
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
