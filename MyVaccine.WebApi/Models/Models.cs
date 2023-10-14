using System;
using System.Collections.Generic;

namespace MyVaccine.WebApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Dependent> Dependents { get; set; }
        public List<FamilyGroup> FamilyGroups { get; set; }
        public List<VaccineRecord> VaccineRecords { get; set; }
        public List<Allergy> Allergies { get; set; }

    }

    public class Dependent
    {
        public int DependentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<VaccineRecord> VaccineRecords { get; set; }

    }

    public class VaccineCategory
    {
        public int VaccineCategoryId { get; set; }
        public string Name { get; set; }
        public List<Vaccine> Vaccines { get; set; }
    }

    public class Vaccine
    {
        public int VaccineId { get; set; }
        public string Name { get; set; }
        public List<VaccineCategory> Categories { get; set; }
        public bool RequiresBooster { get; set; }
    }

    public class VaccineRecord
    {
        public int VaccineRecordId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DependentId { get; set; }
        public Dependent Dependent { get; set; }
        public int VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }
        public DateTime DateAdministered { get; set; }
        public string AdministeredLocation { get; set; }
        public string AdministeredBy { get; set; }
    }

    public class Allergy
    {
        public int AllergyId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class FamilyGroup
    {
        public int FamilyGroupId { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}


