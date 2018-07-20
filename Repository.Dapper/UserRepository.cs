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
        public bool Create(AddUserRptParameter parameter)
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


        /// <summary>
        /// 更新User
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool Update(UpdateUserRptParameter parameter)
        {
            if (string.IsNullOrEmpty(parameter.UserId))
            {
                throw new Exception("User ID should not be null or empty!");
            }
            var Result = false;
            using (var conn = new SqlConnection(connStr))
            {
                DynamicParameters sqlParameters = new DynamicParameters();
                var sql = new StringBuilder();
                sql.AppendLine(@"UPDATE [User] SET");

                if (!string.IsNullOrEmpty(parameter.Name))
                {
                    sql.AppendLine("Name = @Name, ");
                    sqlParameters.Add("Name", parameter.Name);
                }

                if (parameter.IsBlocked.HasValue)
                {
                    sql.AppendLine("IsBlocked = @IsBlocked, ");
                    sqlParameters.Add("IsBlocked",parameter.IsBlocked);
                }

                sql.AppendLine("UpdateTime = @UpdateTime, ");
                sqlParameters.Add("UpdateTime", DateTime.UtcNow);
                sql.AppendLine("WHERE Userid = @Userid, ");
                sqlParameters.Add("Userid", parameter.UserId);

                Result = conn.Execute(sql.ToString(), sqlParameters) > 0;
            }
            return Result;
        }
    }
}
