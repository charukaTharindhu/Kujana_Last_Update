using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Summerising
    {
        [Key]
        public int SummerisingID { get; set; }
        public String PrivacyAndConsent_Date_Signed { get; set; }
        public String PrivacyAndConsent_Reason { get; set; }
        public String PrivacyAndConsent_Date { get; set; }
        public String RightAndResponsibilities_DateExplained { get; set; }
        public String RightAndResponsibilities_Date { get; set; }
        public String RightAndResponsibilities_Reason { get; set; }
        public String ExitInterviewConsent_ConsentAtExite { get; set; }
        public String ExitInterviewConsent_Date { get; set; }
        public String ExitInterviewConsent_Comment { get; set; }
        public String Complaints_dateExplained{ get; set; }
        public String Complaints_Date { get; set; }
        public String Complaints_Reason { get; set; }
        public String MedicalConsent_MedicalConsent { get; set; }
        public String MedicalConsent_Date { get; set; }
        public String MedicalConsent_Consent { get; set; }
        public String InformationSharingWithThirdParties_informationSharingWithThirdParties { get; set; }
        public String InformationSharingWithThirdParties_Date { get; set; }
        public String InformationSharingWithThirdParties_ConsentToShareInformation { get; set; }
        public String ourWayOfWorkingOutComes_DateCompleted { get; set; }
        public String Primary_model_of_service_while_Involved_with_program_selection { get; set; }
        public String Primary_model_of_service_while_Involved_with_program_Comment { get; set; }
        public String Participants_level_of_Engagement_In_this_Program_sellection { get; set; }
        public String Participants_level_of_Engagement_In_this_Program_Comment { get; set; }
        public String View_of_self_Sufficient_at_Commencement{ get; set; }
        public String View_of_self_Worse { get; set; }
        public String View_of_self_NoChange { get; set; }
        public String View_of_self_MinimalImprovement { get; set; }
        public String View_of_self_ModerateImprovement { get; set; }
        public String View_of_self_SubstantialImprovement { get; set; }
        public String View_of_self_Comments { get; set; }
        public String Connection_to_family_and_Significant_people_Sufficient_at_Commencement { get; set; }
        public String Connection_to_family_and_Significant_people_Worse { get; set; }
        public String Connection_to_family_and_Significant_people_NoChange { get; set; }
        public String Connection_to_family_and_Significant_people_MinimalImprovement { get; set; }
        public String Connection_to_family_and_Significant_people_ModerateImprovement { get; set; }
        public String Connection_to_family_and_Significant_people_SubstantialImprovement { get; set; }
        public String Connection_to_family_and_Significant_people_View_of_self_Comments { get; set; }
        public String View_of_future_Sufficient_at_Commencement { get; set; }
        public String View_of_future_Worse { get; set; }
        public String View_of_future_NoChange { get; set; }
        public String View_of_future_MinimalImprovement { get; set; }
        public String View_of_future_ModerateImprovement { get; set; }
        public String View_of_future_SubstantialImprovement { get; set; }
        public String View_of_future_Comments { get; set; }
        public String Test_question_Sufficient_at_Commencement { get; set; }
        public String Test_question_Worse { get; set; }
        public String Test_question_NoChange { get; set; }
        public String Test_question_MinimalImprovement { get; set; }
        public String Test_question_ModerateImprovement { get; set; }
        public String Test_question_SubstantialImprovement { get; set; }
        public String Test_question_Comments { get; set; }
        public String Date_of_exit { get; set; }
        public String Reason_of_exit_Selection { get; set; }
        public String Reason_of_exit_Comment { get; set; }
        public String Goals_Achived_at_exit_Selection { get; set; }
        public String Goals_Achived_at_exit_Comment { get; set; }

    }
}
