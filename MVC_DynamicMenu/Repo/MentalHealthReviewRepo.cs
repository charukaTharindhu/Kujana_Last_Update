using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class MentalHealthReviewRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public MentalHealthReviewRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }

        public void AddNewMHReview(NewMentalHealthReview model)
        {
            var newMH = new NewMentalHealthReview
            {
                ClientID = model.ClientID,
                Client_Name = model.Client_Name,
                Client_status = model.Client_status,
                Entry_date = model.Entry_date,
                Hierarchy = model.Hierarchy,
                Question_1 = model.Question_1,
                Question_2 = model.Question_2,
                Question_3 = model.Question_3,
                Question_4 = model.Question_4,
                Question_5 = model.Question_5,
                Summery = model.Summery
            };
            _c.NewMentalHealthReview.Add(newMH);
            _c.SaveChanges();
        }

        public List<NewMentalHealthReview> GetAllMHReviews()
        {
            var newMH = _c.NewMentalHealthReview
                .FromSqlRaw("Select * from dbo.NewMentalHealthReview")
                .ToList();

            return newMH;
        }

        public NewMentalHealthReview GetMHReviewsById(int id)
        {
            var newMH = _c.NewMentalHealthReview
                .FromSqlRaw("Select * from dbo.NewMentalHealthReview where ClientID =" + id)
                .ToList();

            return newMH[0];
        }

        public void UpdateMHReviews(NewMentalHealthReview model)
        {
            _c.NewMentalHealthReview.Update(model);
            _c.SaveChanges();
        }

        public void DeleteMHReviews(int id)
        {
            var MH = _c.NewMentalHealthReview.FirstOrDefault(x => x.ClientID == id);
            if (MH != null)
            {
                _c.NewMentalHealthReview.Remove(MH);
                _c.SaveChanges();
            }
        }

        public string GetPatients()
        {
            var obj = _c.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }
    }
}
