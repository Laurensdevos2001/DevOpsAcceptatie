using Ardalis.GuardClauses;
using Oogarts.Domain.Common;
using Oogarts.Domain.Patients;
using Oogarts.Domain.Staffs;
using System;
using System.Net;

namespace Oogarts.Domain.Appointments
{
    public class Appointment : Entity
    {
        private Appointment() { }
        
        public Appointment(Staff staff, Patient patient, DateTime datetimeappointment, string description, string status)
        {
            Staff = staff;
            Patient = patient;
            DateTimeAppointment = datetimeappointment;
            Description = description;
            Status = status;
        }
        

        private Staff? staff;
        public Staff? Staff { 
            get => staff;
            set => staff = Guard.Against.Null(value, nameof(Staff));
        }
        private Patient? patient;
        public Patient? Patient
        {
            get => patient;
            set => patient = Guard.Against.Null(value, nameof(Patient));
        }
        private DateTime datetimeappointment;
        public DateTime DateTimeAppointment { 
            get => datetimeappointment;
            set => datetimeappointment = Guard.Against.Null(value, nameof(DateTimeAppointment));
        }
        private string description;
        public string? Description
        {
            get => description;
            set => description = Guard.Against.NullOrWhiteSpace(value, nameof(Description));
        }
        private string status;
        public string Status
        {
            get => status;
            set => status = Guard.Against.NullOrWhiteSpace(value, nameof(Status));
        }


    }
}
