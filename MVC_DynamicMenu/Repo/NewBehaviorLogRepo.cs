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
    public class NewBehaviorLogRepo
    {
        private readonly DynamicMenuDBContext _context = null;

        public NewBehaviorLogRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewBehavior(NewBehaviorLog model)
        {
            var NewBehavior = new NewBehaviorLog
            {


                Client = model.Client,
                EntryDate = model.EntryDate,
                Hierarchy = model.Hierarchy,
                Genaral_Illness = model.Genaral_Illness,
                Menstruation = model.Menstruation,
                weight_EnterOnecAMonth = model.weight_EnterOnecAMonth,
                Abnormal_perceptions = model.Abnormal_perceptions,
                Alcohol_Substance_Solvent_Use = model.Alcohol_Substance_Solvent_Use,
                Antisocial_Behavior = model.Antisocial_Behavior,
                Anxiety = model.Anxiety,
                Binging_Purging_Refusal_To_Eat = model.Binging_Purging_Refusal_To_Eat,
                Communication_Issues = model.Communication_Issues,
                Difficulties_With_Refusal_To_Engage_independence_Skills = model.Difficulties_With_Refusal_To_Engage_independence_Skills,
                Difficulties_With_Refusal_To_Maintain_Personal_Self_Carfe = model.Difficulties_With_Refusal_To_Maintain_Personal_Self_Carfe,
                Difference_Self_Regulating_Emotions = model.Difference_Self_Regulating_Emotions,
                Distortion_Memory_Loss = model.Distortion_Memory_Loss,
                Distress_Worring_Crying = model.Distress_Worring_Crying,
                Fears_and_Phobias = model.Fears_and_Phobias,
                Impulsive_Behavior_Targeting_Property_of_Others = model.Impulsive_Behavior_Targeting_Property_of_Others,
                Intention_Lack_of_Concentration = model.Intention_Lack_of_Concentration,
                Indiscriminate_Disclosures = model.Indiscriminate_Disclosures,
                Loss_Of_Interest_in_Activities = model.Loss_Of_Interest_in_Activities,
                Mimicking_Other_Behavior = model.Mimicking_Other_Behavior,
                Obsersions_Or_Compulsions = model.Obsersions_Or_Compulsions,
                Odd_and_Or_Bizarre_Behavior = model.Odd_and_Or_Bizarre_Behavior,
                Overactive_Behavior = model.Overactive_Behavior,
                Physical_Aggression = model.Physical_Aggression,
                Problems_With_Peers_Staff_Family = model.Problems_With_Peers_Staff_Family,
                Self_Criticism = model.Self_Criticism,
                Self_Injury_Evidence_of = model.Self_Injury_Evidence_of,
                Self_Injury_Thoughts_of = model.Self_Injury_Thoughts_of,
                Sexualised_Behavior = model.Sexualised_Behavior,
                Signs_Of_Disclosure_Of_Hearing_Voices = model.Signs_Of_Disclosure_Of_Hearing_Voices,
                Sleep_Problems_Chronic_Fatigue_Bed_Wetting = model.Sleep_Problems_Chronic_Fatigue_Bed_Wetting,
                Somatising = model.Somatising,
                Verbal_Aggression = model.Verbal_Aggression,
                Withdrawal_From_Others = model.Withdrawal_From_Others,
                Active_Listening = model.Active_Listening,
                Anger_Management = model.Anger_Management,
                Being_Respectful = model.Being_Respectful,
                Being_Safe = model.Being_Safe,
                Conflict_Management = model.Conflict_Management,
                Cooperation = model.Cooperation,
                Effective_Communication = model.Effective_Communication,
                Following_Directions = model.Following_Directions,
                Helping_Others = model.Helping_Others,
                Increasing_Acceptance_and_Tolerance_of_Diverse_Group = model.Increasing_Acceptance_and_Tolerance_of_Diverse_Group,
                Listening = model.Listening,
                Participation = model.Participation,
                Patience = model.Patience,
                Peer_Pesistance_Skills = model.Peer_Pesistance_Skills,
                Politenss_and_Manners = model.Politenss_and_Manners,
                Positive_Iteraction = model.Positive_Iteraction,
                Praising_others_and_Refraining_From_Nesative_Comments = model.Praising_others_and_Refraining_From_Nesative_Comments,
                Recognising_Understanding_point_of_view_of_others = model.Recognising_Understanding_point_of_view_of_others,
                Remaining_of_task = model.Remaining_of_task,
                Sharing = model.Sharing,
                Social_Problem_Slving = model.Social_Problem_Slving,
                Taking_Turns = model.Taking_Turns,
                Staff_member_name = model.Staff_member_name


            };

            _context.NewBehaviorLog.Add(NewBehavior);
            _context.SaveChanges();


        }

        public List<NewBehaviorLog> getAllBehaviourLog()
        {
            var obj = _context.NewBehaviorLog
                .FromSqlRaw("Select * from dbo.NewBehaviorLog")
                .ToList();
            return obj;
        }

        public NewBehaviorLog getUserById(int id)
        {
            var obj = _context.NewBehaviorLog
            .FromSqlRaw("SELECT * FROM dbo.NewBehaviorLog WHERE BehaviorID =" + id)
            .ToList();

            return obj[0];
        }

        public void UpdateBehaviourLog(NewBehaviorLog model)
        {
            _context.NewBehaviorLog.Update(model);
            _context.SaveChanges();
        }

        public void DeleteBehaviour(int id)
        {
            var behaviour = _context.NewBehaviorLog.FirstOrDefault(x => x.BehaviorID == id);
            if (behaviour != null)
            {
                _context.NewBehaviorLog.Remove(behaviour);
                _context.SaveChanges();
            }
        }

        public string GetPatient()
        {
            var obj = _context.Patient.FromSqlRaw("Select * from dbo.Patient").ToList();
            var patient = JsonConvert.SerializeObject(obj);

            return patient;
        }
    }
}
