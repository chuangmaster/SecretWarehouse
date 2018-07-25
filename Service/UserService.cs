using Repository.Dapper;
using Repository.Dapper.Models;
using Repository.Dapper.Parameters;
using Service.DTOs;
using Service.Parameters;
using System;
using System.Collections.Generic;

namespace Service
{
    /// <summary>
    /// class UserService
    /// </summary>
    public class UserService
    {
        UserRepository _UserRepository;
        public UserService(string connectString)
        {
            _UserRepository = new UserRepository(connectString);
        }

        /// <summary>
        /// 取出所有User
        /// </summary>
        /// <returns></returns>
        public List<UserDTO> GetAll()
        {
            var Result = new List<UserDTO>();
            _UserRepository.GetAll().ForEach(x => Result.Add(ConvertToUserDTO(x)));
            return Result;
        }

        /// <summary>
        /// 新增User
        /// </summary>
        /// <returns></returns>
        public bool Create(string Userid, string Name)
        {
            var Result = _UserRepository.Create(new AddUserRptParameter()
            {
                UserId = Userid,
                Name = Name
            });
            return Result;
        }

        /// <summary>
        /// 更新User
        /// </summary>
        /// <returns></returns>
        public bool Update(UpdateUserParameter parameter)
        {
            var Result = _UserRepository.Update(new UpdateUserRptParameter()
            {
                UserId = parameter.UserId,
                Name = parameter.Name,
                IsBlocked = parameter.IsBlocked
            });
            return Result;
        }

        private UserDTO ConvertToUserDTO(UserModel model)
        {
            return new UserDTO()
            {
                UserId = model.UserId,
                Name = model.Name,
                UpdateTime = model.UpdateTime,
                IsBlocked = model.IsBlocked,
                DateIn = model.DateIn
            };
        }
    }
}
