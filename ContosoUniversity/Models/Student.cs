using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required, StringLength(50,MinimumLength =1), Display(Name = "名")]
        public string LastName { get; set; }
        [Required, StringLength(50, ErrorMessage = "你tm有这么长的名字吗"), Display(Name = "姓")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}", ApplyFormatInEditMode = true), Display(Name = "注册时间")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "全名")]
        public string FullName
        {
            get
            {
                return LastName + " " + FirstMidName;
            }
        }
        public string EmailAddress { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}