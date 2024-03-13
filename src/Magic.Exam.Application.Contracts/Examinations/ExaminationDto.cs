using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Magic.Exam.Examinations
{
    public class ExaminationDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string AssociationId { get; set; }

        public string AssociationName { get; set; }

        public string FilterJson { get; set; }

        public double BaseScore { get; set; }

        public double BaseDuration { get; set; }

        public ExaminationType ExamType { get; set; }

        public ExaminationStatus Status { get; set; }

        public ExaminationStrict IsStrict { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        public int OrderIndex { get; set; }

        public string GroupCode { get; set; }
        public string Remark { get; set; }
    }
}
