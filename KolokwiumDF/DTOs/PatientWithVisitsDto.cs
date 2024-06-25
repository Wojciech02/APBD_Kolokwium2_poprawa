using System;
using System.Collections.Generic;

namespace KolokwiumDF.DTOs
{
    public class PatientWithVisitsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string TotalAmountMoneySpent { get; set; }
        public int NumberOfVisit { get; set; }
        public List<VisitDto> Visits { get; set; }
    }
}
