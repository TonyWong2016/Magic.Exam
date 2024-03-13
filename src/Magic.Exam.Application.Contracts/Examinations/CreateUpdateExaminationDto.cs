using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Magic.Exam.Examinations
{
    public class CreateUpdateExaminationDto
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;


        public string Description { get; set; } = string.Empty;

        [StringLength(50)]
        public string AssociationId { get; set;} = string.Empty;

        [StringLength(200)]
        public string AssociationName { get; set; } = "无";

        public string FilterJson { get; set; } = string.Empty;

        [Required]
        public double BaseScore { get; set; } = 100d;

        [Required]
        public double BaseDuration { get; set; } = 60d;


        public ExaminationType ExamType { get; set; } = ExaminationType.Undefined;

        public ExaminationStatus Status { get; set; } = ExaminationStatus.Undefined;

        public ExaminationStrict IsStrict { get; set; } = ExaminationStrict.No;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndTime 
        {
            get
            {
                return StartTime.AddMinutes(BaseDuration);
            }
            set {  }
        }

        [Required]
        public int OrderIndex { get; set; } = 1;

        public string GroupCode { get; set; }= string.Empty;

        public string Remark { get; set; } = string.Empty;
    }
}
