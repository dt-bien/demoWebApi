using DemoApp.DatabaseContext;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.DAL
{
    public class UserDAL : DataAccess
    {
        public  int Create(UserInfo data)
        {
            try
            {
                data.Id = Guid.NewGuid().ToString();
                data.CreatedAt = DateTime.Now;
                context.UserInfo.Add(data);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                return -1;
            }
           
        }

        public int Delete(string id)
        {
            try
            {
                UserInfo temp_user = context.UserInfo.Find(id);
                context.UserInfo.Remove(temp_user);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<UserInfo> GetAll()
        {
            try
            {
                List<UserInfo> user_lst = context.UserInfo.ToList();
                return user_lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public  UserInfo GetById(string id)
        {
            try
            {
                UserInfo user_lst = context.UserInfo.Where(x => x.Id.ToString() == id).FirstOrDefault();
                return user_lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public  int Update(string id, UserInfo data)
        {
            try
            {
               
                UserInfo db_user = context.UserInfo.Where(x => x.Id.ToString() == id).FirstOrDefault();
                if (db_user != null)
                {
                    db_user.UserName = data.UserName;
                    db_user.PositionId = data.PositionId;
                    db_user.Supervisor_Id = data.Supervisor_Id;
                    return context.SaveChanges();
                }
                return -1;
            }
            catch (Exception ex)
            {

                return -2;
            }
        }
    }
}