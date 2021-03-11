using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class NewIncidentLog
    {
        [Key]
        public int ClientID { get; set; }
        public String  Client { get; set; }
        public String EntryDtae { get; set; }
        public String Heirarchy { get; set; }
        public String IncidentType { get; set; }
        public String IncidentDate { get; set; }
        public String IncidentTime { get; set; }
        public String IncidentLocation { get; set; }
        public String IncidentWitnesses { get; set; }
        public String EmergencyAssistance { get; set; }
        public String PoliceInvolvement { get; set; }
        public String PersonSearch { get; set; }
        public String PersonRoomSearch { get; set; }
        public String PRNProvided { get; set; }
        public String Actions { get; set; }

        public String Who_On_Call_Contacted { get; set; }
        
        public String PRN_Approved { get; set; }
        public String Agitation_Hyperarousal { get; set; }
        public String Attempted_Minor { get; set; }
        public String Client_Complaint { get; set; }
        public String Disruption_to_Routine { get; set; }
        public String Incident_Involving_Family { get; set; }
        public String Inappropriate_or_Anti_Social_Client_Interaction { get; set; }
        public String Injury_Minor_Client_Injury_First_Aid_Only { get; set; }
        public String Non_Compliance_Task_Refusal { get; set; }
        public String Attempted_Minor_Property_Damage{ get; set; }
        public String Client_Complaint_or_issue { get; set; }
        public String IncidentInvolvingFamily { get; set; }
        public String Non_Compliance_Refusal { get; set; }
        public String Absconding_Requiring_Missing_Persons_Report { get; set; }
        public String Assault_Requiring_Medical_Support { get; set; }
        public String Behaviour_or_Challenges_Attracting_Community_Concern { get; set; }
        public String Behaviour_or_Challenges_Attracting_Media_Attention { get; set; }
        public String Criminal_Behaviour_Resulting_in_Police_Engagment_or_Charges { get; set; }
        public String Disclosure_Requireing_Mandatory_Reporting { get; set; }
        public String PRNApproved { get; set; }
        public String What_was_happening_in_the_time_Before_the_Incident { get; set; }
        public String Behaviour { get; set; }
        public String How_did_you_de_escalate_the_incident { get; set; }
        public String PossibleFunction { get; set; }
        public String Consequence { get; set; }
        public String Abuse_or_neglect_of_the_Client_ { get; set; }
        public String Criminal_Behaviour_Resulting_in_client_being_held_in_Custody { get; set; }
        public String Death_of_fatal_injury_of_a_carer_community_member { get; set; }
        public String Death_or_fatal_injury_of_a_client_serious_injury_of_the_client { get; set; }
        public String Unlawful_sexual_or_physical_contact_with_or_assault_of_the_client { get; set; }
        public String Sexual_misconduct_committed_against_or_in_the_presence_of_the_client_including_grooming_of_the_client_for_sexual_activity { get; set; }
        public String Unautherized_use_of_restriced_practice_in_relation_to_the_client { get; set; }
        public String Reportable_conduct_by_a_carer_staff_member { get; set; }
        public String Category_of_incident { get; set; }
        public String Rating_of_Incident { get; set; }
        public String Risk_of_significant_ham_reported { get; set; }
        public String SignificantHamDate { get; set; }
        public String SignificantHamTIme { get; set; }
        public String SignificantHamReferanceNumber { get; set; }
        public String PhysicalIntervention { get; set; }
        public String Type_of_physical_intervention { get; set; }
        public String How_long_did_the_physical_intervention_last { get; set; }
        public String ClientInjury { get; set; }
        public String StaffInjury { get; set; }
        public String Has_the_client_been_offered_diffusion_or_debrief { get; set; }
        public String Has_the_client_disclosed_or_made_accusation_of_assult_or_abuse { get; set; }
        public String Has_the_client_or_guardian_been_made_aware_of_their_right_to_involve_the_police_and_potentially_press_changes { get; set; }
        public String Has_the_staff_been_offered_diffusion_or_debrief { get; set; }
        public String Has_the_staff_member_been_made_aware_of_their_right_of_involve_the_police_and_potentially_press_charges { get; set; }
        public String FollowUpRequired { get; set; }
        public String WasOnCallContacted { get; set; }
        public String NatureOfAll { get; set; }
        public String Result { get; set; }
        public String FollowUp { get; set; }
        public String StaffMember { get; set; }
        public String Signature { get; set; }
        public String Name { get; set; }
    }
}
