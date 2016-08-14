using KellyProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KellyProject.Services.Interfaces
{
    public interface IYogaService
    {
        int AddYogaPractice(YogaPracticeRequestModel model);

        List<Domain.YogaPractice> List();

        List<Domain.YogaPractice> GetPracticesByYogiId(int YogiId);

        void UpdatePracticeById(YogaPracticeRequestModel model, int PracticeId);

        void DeletePracticeById(int PracticeId);

    }
}