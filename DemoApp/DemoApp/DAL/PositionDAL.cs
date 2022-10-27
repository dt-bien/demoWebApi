using DemoApp.DatabaseContext;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.DAL
{
    public class PositionDAL : DataAccess
    {
        public int Create(Position data)
        {
            try
            {
                data.Id = Guid.NewGuid().ToString();
                context.Position.Add(data);
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
                Position temp_data = context.Position.Find(id);
                context.Position.Remove(temp_data);
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public List<Position> GetAll()
        {
            try
            {
                List<Position> position_lst = context.Position.ToList();
                return position_lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Position GetById(string id)
        {
            try
            {
                Position position_lst = context.Position.Where(x => x.Id == id).FirstOrDefault();
                return position_lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int Update(string id, Position data)
        {
            try
            {

                Position db_position = context.Position.Find(id);
                if (db_position != null)
                {
                    db_position.PositionName = data.PositionName;
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