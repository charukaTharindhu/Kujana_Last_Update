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
    public class ServiceSchedulesRepo
    {
        private readonly DynamicMenuDBContext _c = null;
        public ServiceSchedulesRepo(DynamicMenuDBContext c)
        {
            _c = c;
        }

        public void AddNewServiceSchedule(ServiceSchedules service)
        {
            ServiceSchedules SS = new ServiceSchedules
            {
                ReferenceID = service.ReferenceID,
                Client_name = service.Client_name,
                Day_of_week = service.Day_of_week,
                End_date_and_time = service.End_date_and_time,
                Start_date_and_time = service.Start_date_and_time,
                Hierarchy = service.Hierarchy,
                Service = service.Service,
                Staff = service.Staff
            };
            _c.ServiceSchedules.Add(SS);
            _c.SaveChanges();
        }

        public ServiceSchedules GetSSById(int id)
        {
            var ss = _c.ServiceSchedules
                .FromSqlRaw("Select * from dbo.ServiceSchedules where ReferenceID =" + id)
                .ToList();

            return ss[0];
        }

        public List<ServiceSchedules> GetAllSS()
        {
            var newSS = _c.ServiceSchedules
                .FromSqlRaw("select * from dbo.ServiceSchedules")
                .ToList();

            return newSS;
        }

        public void UpdateSS(ServiceSchedules model)
        {
            _c.ServiceSchedules.Update(model);
            _c.SaveChanges();
        }

        public void DeleteSS(int id)
        {
            var SS = _c.ServiceSchedules.FirstOrDefault(x => x.ReferenceID == id);
            if (SS != null)
            {
                _c.ServiceSchedules.Remove(SS);
                _c.SaveChanges();
            }
        }




             //----------------------------NewServiceLogRepo--------------------------------//

        public void AddNewLogSchedul(LogSchedule model)
        {
            LogSchedule newLog = new LogSchedule
            {
                ReferenceID = model.ReferenceID,
                Persons_attending = model.Persons_attending,
                Scheduled_start_date = model.Scheduled_start_date,
                Activity = model.Activity,
                Activity_category = model.Activity_category,
                Actual_finish_date = model.Actual_finish_date,
                Actual_finish_time = model.Actual_finish_time,
                Actual_start_date = model.Actual_start_date,
                Actual_start_time = model.Actual_start_time,
                Client_name = model.Client_name,
                Describe_outcome = model.Describe_outcome,
                Finish_time = model.Finish_time,
                Issues_and_followup_requried = model.Issues_and_followup_requried,
                Scheduled_finish_date = model.Scheduled_finish_date,
                Scheduled_finish_time = model.Scheduled_finish_time,
                Scheduled_start_time = model.Scheduled_start_time,
                Service_and_billing_note = model.Service_and_billing_note,
                Specific_activity_purpose = model.Specific_activity_purpose,
                Staff = model.Staff,
                Start_time = model.Start_time,
            };
            _c.LogSchedule.Add(newLog);
            _c.SaveChanges();
        }

        public List<LogSchedule> GetAllSL()
        {
            var newSl = _c.LogSchedule
                .FromSqlRaw("select * from dbo.LogSchedule")
                .ToList();           
            return newSl;
        }

        public LogSchedule GetSLByID(int id)
        {
            var newSL = _c.LogSchedule
                .FromSqlRaw("select * from dbo.LogSchedule where Reference =" + id)
                .ToList();
            return newSL[0];
        }

        public void UpdateSL(LogSchedule model)
        {
            _c.LogSchedule.Update(model);
            _c.SaveChanges();
        }

        public void DeleteSL(int id)
        {
            var SL = _c.LogSchedule.FirstOrDefault(x => x.Reference == id);
            if (SL != null)
            {
                _c.LogSchedule.Remove(SL);
                _c.SaveChanges();
            }
        }




              //-------------------------Service Log Approved----------------//

        public LogSchedule GetLogDataByID(int id)
        {
            var logData = _c.NewServiceLog
                .FromSqlRaw("Select * from dbo.LogSchedule where Reference =" + id)
                .ToList();

            return logData[0];
        }

        public void InsertLogdata(ApprovedTb ap)
        {
            ApprovedTb newApp = new ApprovedTb
            {
                Reference = ap.Reference,
                Client_name = ap.Client_name,
                Start_date = ap.Start_date,
                End_date = ap.End_date,
                Service = ap.Service,
                Status = ap.Status
            };
            _c.ApprovedTb.Add(newApp);
            _c.SaveChanges();
        }

        public List<ApprovedTb> GetAll()
        {
            var newAp = _c.ApprovedTb
                .FromSqlRaw("select * from dbo.ApprovedTb")
                .ToList();
            return newAp;
        }



        //-----------------------------invoice--------------------//

        public ApprovedTb GetApprovedDataByID(int id)
        {
            var obj = _c.ApprovedTb
                .FromSqlRaw("select * from dbo.ApprovedTb where Reference ="+id)
                .ToList();

            return obj[0];
        }

        public void InsertDataIntoInvoice(InvoiceTb model)
        {
            InvoiceTb newModel = new InvoiceTb
            {
                Reference = model.Reference,
                Cliam_number = model.Cliam_number,
                Client_name = model.Client_name,
                Service = model.Service,
                End_date = model.End_date,
                Status = model.Status,
                Start_date = model.Start_date
            };
        }
        public void DeleteIN(int id)
        {
            var IN = _c.InvoiceTb.FirstOrDefault(x => x.Reference == id);
            if (IN != null)
            {
                _c.InvoiceTb.Remove(IN);
                _c.SaveChanges();
            }
        }

        public List<InvoiceTb> GetAllInvoiceData()
        {
            var obj = _c.InvoiceTb
                .FromSqlRaw("Select * from dbo.InvoiceTb")
                .ToList();

            return obj;
        }

        public string GetPatients()
        {
            var obj = _c.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }

    }
}
