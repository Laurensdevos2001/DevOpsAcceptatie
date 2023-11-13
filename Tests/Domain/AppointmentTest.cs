using Oogarts.Domain.Appointments;
using Oogarts.Domain.Patients;
using Oogarts.Domain.Staffs;
using System;

namespace Tests.Domain;

public class AppointmentTest
{
    Staff doctor = new Staff("Test1", "Test2", "test@testmail.com", "0470000000", "Test3", 1, "Test4", "Test5");
    Patient patient = new Patient("Test1", "Test2", "test@testmail.com", "0470000000", new DateTime(1995,1,1));

    [Fact]
    public void NewAppointment_CreatedCorrectly()
    {
        DateTime now = DateTime.Now;
        
        Appointment account = new Appointment(doctor, patient, now, "Test3", "Test4");
        Assert.NotNull(account);
        Assert.Equal(doctor, account.Staff);
        Assert.Equal(patient, account.Patient);
        Assert.Equal(now, account.DateTimeAppointment);
        Assert.Equal("Test3", account.Description);
        Assert.Equal("Test4", account.Status);
    }

    [Fact]
    public void NewAppointment_DoctorIsNull()
    {
      Assert.Throws<ArgumentNullException>(() => _ = new Appointment(null, patient, DateTime.Now, "Test3", "Test4"));
    }

    [Fact]
    public void NewAppointment_PatientIsNull()
    {
       Assert.Throws<ArgumentNullException>(() => _ = new Appointment(doctor, null, DateTime.Now, "Test3", "Test4"));
    }

    [Fact]
    public void NewAppointment_DateTimeIncorrect()
    {
        foreach (DateTime time in new[] {new DateTime(2030, 1, 1), new DateTime(2100, 1, 1) })
        {
            Assert.Throws<ArgumentException>(() => _ = new Appointment(doctor, patient, time, "Test3", "Test4"));
        }
    }

    [Fact]
    public void NewAppointment_ReasonIncorrect()
    {
        foreach (string reason in new[] { "", " ", "    " })
        {
            Assert.Throws<ArgumentException>(() => _ = new Appointment(doctor, patient, DateTime.Now, reason, "Test3"));
        }
    }

    [Fact]
    public void NewAppointment_ReasonIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _ = new Appointment(doctor, patient, DateTime.Now, null, "Test3"));
    }

    [Fact]
    public void NewAppointment_StatusIncorrect()
    {
        foreach (string status in new[] { "", " ", "    " })
        {
            Assert.Throws<ArgumentException>(() => _ = new Appointment(doctor, patient, DateTime.Now, "Test3", status));
        }
    }

    [Fact]
    public void NewAppointment_StatusIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _ = new Appointment(doctor, patient, DateTime.Now, "Test3", null));
    }
}
