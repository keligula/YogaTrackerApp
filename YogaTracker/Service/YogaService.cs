using KellyProject.Data;
using KellyProject.Services;
using KellyProject.Models.Requests;
using KellyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KellyProject.Services
{
    public class YogaService : BaseService, IYogaService
    {

        // POST: Add a practice
        public int AddYogaPractice(YogaPracticeRequestModel model)

        {
            int id = 0;

            DataProvider.ExecuteNonQuery(GetConnection, "dbo.YogaPractice_Insert"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@YogiId", model.YogiId);
                   paramCollection.AddWithValue("@PracticeDate", model.PracticeDate);
                   paramCollection.AddWithValue("@InstructorName", model.InstructorName);

                   SqlParameter p = new SqlParameter("@PracticeId", System.Data.SqlDbType.Int);
                   p.Direction = System.Data.ParameterDirection.Output;

                   paramCollection.Add(p);

               }, returnParameters: delegate (SqlParameterCollection param)

               {
                   int.TryParse(param["@PracticeId"].Value.ToString(), out id);
               }
               );

            return id;
        }


        // GET: List All Practices Index
        public List<Domain.YogaPractice> List()
        {

            List<Domain.YogaPractice> returnList = null;
            DataProvider.ExecuteCmd(GetConnection, "dbo.YogaPractice_ListAll"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {

               }, map: delegate (IDataReader reader, short set)
               {

                   Domain.YogaPractice p = new Domain.YogaPractice();
                   int startingIndex = 0;

                   p.PracticeId = reader.GetSafeInt32(startingIndex++);
                   p.YogiId = reader.GetSafeInt32(startingIndex++);
                   p.PracticeDate = reader.GetSafeDateTime(startingIndex++);
                   p.InstructorName = reader.GetSafeString(startingIndex++);

                   if (returnList == null)
                   {
                       returnList = new List<Domain.YogaPractice>();
                   }

                   returnList.Add(p);

               });

            return returnList;
        }


        // GET: Select Practices by YogiId
        public List<Domain.YogaPractice> GetPracticesByYogiId(int YogiId)
        {
            List<Domain.YogaPractice> list = null;

            DataProvider.ExecuteCmd(GetConnection, "dbo.YogaPractice_GetByYogiId"
              , inputParamMapper: delegate (SqlParameterCollection paramCollection)
              {
                  paramCollection.AddWithValue("@YogiId", YogiId);

              }, map: delegate (IDataReader reader, short set)

              {
                  Domain.YogaPractice p = new Domain.YogaPractice();
                  int startingIndex = 0;

                  p.PracticeId = reader.GetSafeInt32(startingIndex++);
                  p.YogiId = reader.GetSafeInt32(startingIndex++);
                  p.PracticeDate = reader.GetSafeDateTime(startingIndex++);
                  p.InstructorName = reader.GetSafeString(startingIndex++);

                  if (list == null)
                  {
                      list = new List<Domain.YogaPractice>();
                  }
                  list.Add(p);
              }
              );

            return list;
        }

        // PUT: Update Practice by PracticeId
        public void UpdatePracticeById(YogaPracticeRequestModel model, int PracticeId)

        {
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.YogaPractice_UpdatePracticeById"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@YogiId", model.YogiId);
                   paramCollection.AddWithValue("@PracticeDate", model.PracticeDate);
                   paramCollection.AddWithValue("@InstructorName", model.InstructorName);

               }, returnParameters: delegate (SqlParameterCollection param)
               {

               });
        }


        // DELETE: Practice by PracticeId
        public void DeletePracticeById(int PracticeId)
        {
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.YogaPractice_DeleteByPracticeId"
              , inputParamMapper: delegate (SqlParameterCollection paramCollection)
              {
                  paramCollection.AddWithValue("@PracticeId", PracticeId);

              }, returnParameters: delegate (SqlParameterCollection param)
              {

              }
               );
        }


    }
}
