using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RecruiterManager.Models
{
    public class JobPosting
    {
        [Key]
        public int Id { get; set; }
        public string InterviewerFirstName { get; set; }
        public string InterviewerLastName { get; set; }
        public DateTime DateApplied { get; set; }
        public string ApplicaionStatus { get; set; }
        public double? PostedComp { get; set; }
        public string InterviewerPhoneNumber { get; set; }
        public string InterviewerEmail { get; set; }
        [ForeignKey("Recruiter")]
        public int RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
