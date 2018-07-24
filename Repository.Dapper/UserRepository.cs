using Repository.Dapper.Models;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Repository.Dapper.Parameters;

namespace Repository.Dapper
{
    /// <summary>
    /// class UserRepository
    /// </summary>
    public class UserRepository
    {
        string connStr;
        public UserRepository()
        {
            connStr = "DB Connect String";
        }

        /// <summary>
        /// 取出所有User
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAll()
        {
            var Result = new List<UserModel>();
            using (var conn = new SqlConnection(connStr))
            {
                var sql = new StringBuilder();
                sql.AppendLine(@"SELECT *  FROM [dbo].[User]");
                Result = conn.Query<UserModel>(sql.ToString()).ToList();
            }
            return Result;
        }

        /// <summary>
        /// 新增User
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool Create(AddUserParameter parameter)
        {
            var Result = false;
            using (var conn = new SqlConnection(connStr))
            {
                var sql = new StringBuilder();
                sql.AppendLine(@"INSERT [User] (UserId, Name) VALUES(@UserId, @Name);");

                Result = conn.Execute(sql.ToString(), parameter) > 0;
            }
            return Result;
        }
    }
}
