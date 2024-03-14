using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Magic.Exam.Examinations
{
    public class ExaminationDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string AssociationId { get; set; } = string.Empty;

        public string AssociationName { get; set; } = string.Empty;

        public string FilterJson { get; set; } = string.Empty;

        public double BaseScore { get; set; }

        public double BaseDuration { get; set; }

        public ExaminationType ExamType { get; set; }

        public ExaminationStatus Status { get; set; }

        public ExaminationStrict IsStrict { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        public int OrderIndex { get; set; }

        public string GroupCode { get; set; } = string.Empty;
        public string Remark { get; set; } = string.Empty;
    }
}
