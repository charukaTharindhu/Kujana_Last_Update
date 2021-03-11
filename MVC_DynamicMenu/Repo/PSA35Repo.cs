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
    public class PSA35Repo
    {
        private readonly DynamicMenuDBContext _context = null;

        public PSA35Repo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewPSA35(NewPSA35 psa)
        {
            var newPSA = new NewPSA35
            {
                ClientID = psa.ClientID,
                Client_name = psa.Client_name,
                Entry_date = psa.Entry_date,
                Absent_from_school = psa.Absent_from_school,
                Acts_as_if_driven_by_a_motor = psa.Acts_as_if_driven_by_a_motor,
                Acts_younger_than_children_his_or_her_age = psa.Acts_younger_than_children_his_or_her_age,
                Blames_others_for_his_or_her_troubles = psa.Blames_others_for_his_or_her_troubles,
                Complains_of_aches_and_pains = psa.Complains_of_aches_and_pains,
                Daydreams_too_much = psa.Daydreams_too_much,
                Distracted_easily = psa.Distracted_easily,
                Does_not_listen_to_rules = psa.Does_not_listen_to_rules,
                Does_not_show_feelings = psa.Does_not_show_feelings,
                Does_not_understand_feelings_of_other_people = psa.Does_not_understand_feelings_of_other_people,
                Feels_he_or_she_is_bad = psa.Feels_he_or_she_is_bad,
                Feels_hopeless = psa.Feels_hopeless,
                Feels_sad_unhappy = psa.Feels_sad_unhappy,
                Fidgety_unable_to_sit_still = psa.Fidgety_unable_to_sit_still,
                Fights_with_other_children = psa.Fights_with_other_children,
                Gets_hurt_frequently = psa.Gets_hurt_frequently,
                Has_trouble_concentrating = psa.Has_trouble_concentrating,
                Has_trouble_sleeping = psa.Has_trouble_sleeping,
                Has_trouble_with_teacher = psa.Has_trouble_with_teacher,
                Hierarchy = psa.Hierarchy,
                Is_afraid_of_new_situations = psa.Is_afraid_of_new_situations,
                Is_down_on_him_or_herself = psa.Is_down_on_him_or_herself,
                Is_irritable_angry = psa.Is_irritable_angry,
                Less_interested_in_friends = psa.Less_interested_in_friends,
                Less_interested_in_school = psa.Less_interested_in_school,
                Refuses_to_share = psa.Refuses_to_share,
                School_grades_dropping = psa.School_grades_dropping,
                Seems_to_be_having_less_fun = psa.Seems_to_be_having_less_fun,
                Spends_more_time_alone = psa.Spends_more_time_alone,
                Takes_unnecessary_risks = psa.Takes_unnecessary_risks,
                Teases_others = psa.Teases_others,
                Tires_easily_has_little_energy = psa.Tires_easily_has_little_energy,
                Wants_to_be_with_you_more_than_before = psa.Wants_to_be_with_you_more_than_before,
                Worries_a_lot = psa.Worries_a_lot
            };
            _context.NewPSA35.Add(newPSA);
            _context.SaveChanges();
        }

        public List<NewPSA35> GetAllSPAs()
        {
            var obj = _context.NewPSA35
                .FromSqlRaw("SELECT * FROM dbo.NewPSA35")
                .ToList();

            return obj;
        }

        public NewPSA35 getPSAByID(int id)
        {
            var obj = _context.NewPSA35
            .FromSqlRaw("SELECT * FROM dbo.NewPSA35 WHERE ClientID=" + id)
            .ToList();

            return obj[0];

        }

        public void UpdatePSA35(NewPSA35 model)
        {
            _context.NewPSA35.Update(model);
            _context.SaveChanges();
        }

        public void DeletePSA35(int id)
        {
            var psa = _context.NewPSA35.FirstOrDefault(x => x.ClientID == id);
            if (psa != null)
            {
                _context.NewPSA35.Remove(psa);
                _context.SaveChanges();
            }
        }

        public string GetPatients()
        {
            var obj = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }

    }
}
