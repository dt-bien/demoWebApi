using DemoApp.DAL;
using DemoApp.DatabaseContext;
using DemoApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.BUS
{
    public class UserBUS : DataAccess
    {
        UserDAL userDAL;
        public UserBUS()
        {
            userDAL = new UserDAL();
        }
        public RelatedMember GetAllRelatedMember(string userid)
        {
            RelatedMember relatedMember = new RelatedMember();
            relatedMember.Supervisor = GetSupervisorOfUser(userid);
            relatedMember.Member = GetMemberOfSupervisor(userid);
            return relatedMember;
        }
        public List<UserInfo> GetSupervisorOfUser(string userid)
        {
            List<UserInfo> Supervisor_lst = new List<UserInfo>();
            try
            {
                UserInfo user_str = userDAL.GetById(userid);
                
                if (user_str != null)
                {
                    
                 
                    string supervisor_id = user_str.Supervisor_Id;
                    while (supervisor_id != null)
                    {
                        // lay ra supervisor cua userid
                        UserInfo supervisor_user = userDAL.GetById(supervisor_id);
                        if (supervisor_user != null)
                        {
                            Supervisor_lst.Add(supervisor_user);
                            supervisor_id = supervisor_user.Supervisor_Id;
                           
                        }
                        else
                        {
                            break;
                        }


                    }
                } else
                {
                    return Supervisor_lst;
                }
                return Supervisor_lst;

            }
            catch (Exception)
            {
                return Supervisor_lst;
               
            }
        }
        
        public List<UserInfo> GetMemberOfSupervisor(string supid)
        {
            List<UserInfo> user_lst = context.UserInfo.Where(x => x.Supervisor_Id== supid).ToList();
            List<UserInfo> result = new List<UserInfo>();
            result.AddRange(user_lst);

            foreach (var user in user_lst)
            {
                List<UserInfo> temp = GetMemberOfSupervisor(user.Id);
                result.AddRange(temp);
               

            }
            return result;
            

            //bool checkfl = false;
            //do
            //{
              
            //    foreach (var item in user_lst)
            //    {
            //        if (!string.IsNullOrEmpty(item.Supervisor_Id))
            //        {
            //            checkfl = true;
            //            if (!temp_lst.Contains(item.Supervisor_Id))
            //            {
            //                temp_lst.Add(item.Supervisor_Id);
            //            }
                        
            //        }

            //    }

            //} while (checkfl);
            



        }
    }
}