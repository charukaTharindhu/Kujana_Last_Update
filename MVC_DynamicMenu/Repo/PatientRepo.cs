using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_DynamicMenu.Controllers;
using MVC_DynamicMenu.Data;
using MVC_DynamicMenu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Repo
{
    public class PatientRepo
    {
        private readonly DynamicMenuDBContext _context = null;

        public PatientRepo(DynamicMenuDBContext context)
        {
            _context = context;
        }

        public void AddNewPatient(Patient patient)
        {
            var newPatient = new Patient
            {
                PatientID = patient.PatientID,
                Full_Name = patient.Full_Name,
                Address = patient.Address,
                Age = patient.Age,
                Email = patient.Email,
                Gender = patient.Gender,
                Telephone = patient.Telephone,
                Supervisor = patient.Supervisor,
                Emergency_Contact_Name = patient.Emergency_Contact_Name,
                Emergency_Contact_No = patient.Emergency_Contact_No
            };

            _context.Patient.Add(newPatient);
            _context.SaveChanges();
        }
        public List<Patient> getAllPatients()
        {
            var obj = _context.Patient
            .FromSqlRaw("SELECT * FROM dbo.Patient")
            .ToList();

            return obj;
        }
        public Patient getUserById(int id)
        {
            var obj = _context.Patient
            .FromSqlRaw("SELECT * FROM dbo.Patient WHERE PatientID=" + id)
            .ToList();

            return obj[0];
        }
        public void UpdatePatient(Patient model)
        {
            _context.Patient.Update(model);
            _context.SaveChanges();
        }

        public void DeletePatient(int id)
        {
            var patient = getUserById(id);
            //var patient = _context.Patient.FirstOrDefault(x => x.PatientID == id);
            //if (patient != null)
            //{
                _context.Patient.Remove(patient);
                _context.SaveChanges();
           // }
        }

        public string GetPatients()
        {
            var obj = _context.Patient.FromSqlRaw("SELECT * FROM dbo.Patient").ToList();
            var patients = JsonConvert.SerializeObject(obj);
            return patients;
        }


    }
}
