using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class Patient_ContactRepo
    {
        private readonly DynamicMenuDBContext _c = null;

        public Patient_ContactRepo(DynamicMenuDBContext c)
        {
           _c = c;
        }

		public void AddNewPatient_Contact(Patient_Contact model)
		{
			var NewPcontact = new Patient_Contact
			{
				PatientID = model.PatientID,
				Line2 = model.Line2,
				Patient = model.Patient,
				Can_text = model.Can_text,
				City = model.City,
				Country = model.Country,
				ContactID = model.ContactID,
				Email = model.Email,
				Disclose_Address = model.Disclose_Address,
				Comment = model.Comment,
				emargencyPhone = model.emargencyPhone,
				Line1 = model.Line1,
				LivingWith = model.LivingWith,
				Name = model.Name,
				Phone = model.Phone,
				Relationship = model.Relationship,
				Security = model.Security,
				Start_Date = model.Start_Date,
				State = model.State,
				Type_of_housing = model.Type_of_housing,
				
			};
			_c.Patient_Contact.Add(NewPcontact);
			_c.SaveChanges();
		}

		public void AddNewPatient_Info(Patient_Info model)
		{
			var NewPInfo = new Patient_Info
			{
				CeterLink_Number = model.CeterLink_Number,
				COB_Comment = model.COB_Comment,
				Comments = model.Comments,
				Country = model.Country,
				DateOfBirth = model.DateOfBirth,
				Effective_date = model.Effective_date,
				FirstName = model.FirstName,
				Gender = model.Gender,
				Indegenous_status = model.Indegenous_status,
				Interpreted_needed = model.Interpreted_needed,
				Language_spoken_at_home = model.Language_spoken_at_home,
				LastName = model.LastName,
				NDIS_Number = model.NDIS_Number,
				Office = model.Office,
				Other_Cultural_Issues = model.Other_Cultural_Issues,
				Patient = model.Patient,
				Primary_income_source = model.Primary_income_source,
				PatientID = model.PatientID,
				Patient_InfoID = model.Patient_InfoID
			};
			_c.Patient_Info.Add(NewPInfo);
			_c.SaveChanges();
		}

		public void AddNewSummerising(Summerising model)
		{
			var NewSummerising = new Summerising
			{
				Complaints_Date = model.Complaints_Date,
				Complaints_dateExplained = model.Complaints_dateExplained,
				Complaints_Reason = model.Complaints_Reason,
				Connection_to_family_and_Significant_people_MinimalImprovement = model.Connection_to_family_and_Significant_people_MinimalImprovement,
				Connection_to_family_and_Significant_people_ModerateImprovement = model.Connection_to_family_and_Significant_people_ModerateImprovement,
				Connection_to_family_and_Significant_people_NoChange = model.Connection_to_family_and_Significant_people_NoChange,
				Connection_to_family_and_Significant_people_SubstantialImprovement = model.Connection_to_family_and_Significant_people_SubstantialImprovement,
				Connection_to_family_and_Significant_people_Sufficient_at_Commencement = model.Connection_to_family_and_Significant_people_Sufficient_at_Commencement,
				Connection_to_family_and_Significant_people_View_of_self_Comments = model.Connection_to_family_and_Significant_people_View_of_self_Comments,
				Connection_to_family_and_Significant_people_Worse = model.Connection_to_family_and_Significant_people_Worse,
				Date_of_exit = model.Date_of_exit,
				ExitInterviewConsent_Comment = model.ExitInterviewConsent_Comment,
				ExitInterviewConsent_ConsentAtExite = model.ExitInterviewConsent_ConsentAtExite,
				ExitInterviewConsent_Date = model.ExitInterviewConsent_Date,
				Goals_Achived_at_exit_Comment = model.Goals_Achived_at_exit_Comment,
				Goals_Achived_at_exit_Selection = model.Goals_Achived_at_exit_Selection,
				InformationSharingWithThirdParties_ConsentToShareInformation = model.InformationSharingWithThirdParties_ConsentToShareInformation,
				InformationSharingWithThirdParties_Date = model.InformationSharingWithThirdParties_Date,
				InformationSharingWithThirdParties_informationSharingWithThirdParties = model.InformationSharingWithThirdParties_informationSharingWithThirdParties,
				MedicalConsent_Consent  = model.MedicalConsent_Consent,
				MedicalConsent_Date = model.MedicalConsent_Date,
				MedicalConsent_MedicalConsent = model.MedicalConsent_MedicalConsent,
				ourWayOfWorkingOutComes_DateCompleted = model.ourWayOfWorkingOutComes_DateCompleted,
				Participants_level_of_Engagement_In_this_Program_Comment = model.Participants_level_of_Engagement_In_this_Program_Comment,
				Participants_level_of_Engagement_In_this_Program_sellection = model.Participants_level_of_Engagement_In_this_Program_sellection,
				Primary_model_of_service_while_Involved_with_program_Comment = model.Primary_model_of_service_while_Involved_with_program_Comment,
				Primary_model_of_service_while_Involved_with_program_selection =  model.Primary_model_of_service_while_Involved_with_program_selection,
				PrivacyAndConsent_Date = model.PrivacyAndConsent_Date,
				PrivacyAndConsent_Date_Signed = model.PrivacyAndConsent_Date_Signed,
				PrivacyAndConsent_Reason = model.PrivacyAndConsent_Reason,
				Reason_of_exit_Comment = model.Reason_of_exit_Comment,
				Reason_of_exit_Selection = model.Reason_of_exit_Selection,
				RightAndResponsibilities_Date = model.RightAndResponsibilities_Date,
				RightAndResponsibilities_DateExplained = model.RightAndResponsibilities_DateExplained,
				RightAndResponsibilities_Reason = model.RightAndResponsibilities_Reason,
				SummerisingID = model.SummerisingID,
				Test_question_Comments = model.Test_question_Comments,
				Test_question_MinimalImprovement = model.Test_question_MinimalImprovement,
				Test_question_ModerateImprovement = model.Test_question_ModerateImprovement,
				Test_question_NoChange = model.Test_question_NoChange,
				Test_question_SubstantialImprovement = model.Test_question_SubstantialImprovement,
				Test_question_Sufficient_at_Commencement = model.Test_question_Sufficient_at_Commencement,
				Test_question_Worse = model.Test_question_Worse,
				View_of_future_Comments = model.View_of_future_Comments,
				View_of_future_MinimalImprovement = model.View_of_future_MinimalImprovement,
				View_of_future_ModerateImprovement = model.View_of_future_ModerateImprovement,
				View_of_future_NoChange = model.View_of_future_NoChange,
				View_of_future_SubstantialImprovement = model.View_of_future_SubstantialImprovement,
				View_of_future_Sufficient_at_Commencement = model.View_of_future_Sufficient_at_Commencement,
				View_of_future_Worse = model.View_of_future_Worse,
				View_of_self_Comments = model.View_of_self_Comments,
				View_of_self_MinimalImprovement = model.View_of_self_MinimalImprovement,
				View_of_self_ModerateImprovement = model.View_of_self_ModerateImprovement,
				View_of_self_NoChange = model.View_of_self_NoChange,
				View_of_self_SubstantialImprovement = model.View_of_self_SubstantialImprovement,
				View_of_self_Sufficient_at_Commencement = model.View_of_self_Sufficient_at_Commencement,
				View_of_self_Worse = model.View_of_self_Worse
				
			};
			_c.Summerising.Add(NewSummerising);
			_c.SaveChanges();
		}

		public void AddNewPatient_Helth(Patient_Helth model)
		{
			var NewPHelth = new Patient_Helth
			{
				Acquried_brain_injury = model.Acquried_brain_injury,
				Allergies = model.Allergies,
				Cardiovscular = model.Cardiovscular,
				Chronic_pain = model.Chronic_pain,
				Diabetes = model.Diabetes,
				Dissabilities_none = model.Dissabilities_none,
				Down_Syndrome = model.Down_Syndrome,
				Epilepsy = model.Epilepsy,
				Exp = model.Exp,
				Hearing_inmpairment = model.Hearing_inmpairment,
				Infectious_Disease = model.Infectious_Disease,
				Interlrctual_disability = model.Interlrctual_disability,
				Medicare_number = model.Medicare_number,
				Obesity = model.Obesity,
				Other = model.Other,
				Patient = model.Patient,
				PatientHelthID = model.PatientHelthID,
				PatientID = model.PatientID,
				Physical_disability = model.Physical_disability,
				Repiratory =model.Repiratory,
				Skin_condition = model.Skin_condition,
				Suffix = model.Suffix,
				Suspected_ABI = model.Suspected_ABI,
				Unknown = model.Unknown,
				Vission_impa = model.Vission_impa
						
			};
			_c.Patient_Helth.Add(NewPHelth);
			_c.SaveChanges();
		}

		public void AddNewProgramm(Programs model)
		{
			var NewProgramm = new Programs
			{
				Commenced =model.Commenced,
				DateOfExit = model.DateOfExit,
				Pause = model.Pause,
				Program = model.Program,
				ProgramID = model.ProgramID,
				Resume = model.Resume,
				Setting = model.Setting,
				Status = model.Status
			};
			_c.Programs.Add(NewProgramm);
			_c.SaveChanges();
		}

		public void AddNewCase_Worker(Case_Worker model)
		{
			var NewCase_Worker = new Case_Worker
			{
				DateAllocated = model.DateAllocated,
				DateDeallocated = model.DateDeallocated,
				KeyWorker =model.KeyWorker,
				Patient =model.Patient,
				PatientID = model.PatientID,
				WorkerID = model.WorkerID
			};
			_c.Case_Worker.Add(NewCase_Worker);
			_c.SaveChanges();
		}

		public void Addhouser(Housing_Register_Application model)
		{
			var NewHouse = new Housing_Register_Application
			{
				PatientID = model.PatientID,
				AolicationType = model.AolicationType,
				ApplicationID = model.ApplicationID,
				Application_number = model.Application_number,
				Date_Submited = model.Date_Submited,
				Location_Submited  = model.Location_Submited,
				Patient = model.Patient,
				priority_catogory = model.priority_catogory
				
			};
			_c.Housing_Register_Application.Add(NewHouse);
			_c.SaveChanges();
		}

		public void AddNewCareTeams(CareTeams model)
		{
			var NewCase_Worker = new CareTeams
			{
				PatientID = model.PatientID,
				Patient = model.Patient,
				Address = model.Address,
				Agency_name = model.Agency_name,
				CareTeameID = model.CareTeameID,
				Group = model.Group,
				Phone = model.Phone,
				Referal_Date = model.Referal_Date,
				Referal_name = model.Referal_name,
				Referal_source = model.Referal_source,
				Sub_Program = model.Sub_Program
			};
			_c.CareTeams.Add(NewCase_Worker);
			_c.SaveChanges();
		}

		public void AddNewCommencement_Issuse(Commencement_Issuse model)
		{
			var issuse = new Commencement_Issuse
			{
				Patient = model.Patient,
				Aduocacy = model.Aduocacy,
				anger = model.anger,
				Arts_cultural_development = model.Arts_cultural_development,
				CommencementID = model.CommencementID,
				Comments = model.Comments,
				Counselling = model.Counselling,
				Discrimination_including_ = model.Discrimination_including_,
				Education_Training = model.Education_Training,
				Employeement = model.Employeement,
				Family_Community_Support = model.Family_Community_Support,
				Housing_Accomadation = model.Housing_Accomadation,
				Living_Skills = model.Living_Skills,
				PatientID = model.PatientID,
				Program_Details_and_Support_needs = model.Program_Details_and_Support_needs
				
			};
			_c.Commencement_Issuse.Add(issuse);
			_c.SaveChanges();
		}
	}
}
