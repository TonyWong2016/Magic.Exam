using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Magic.Exam.Examinations
{
    public class Examination: AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string AssociationId {  get; set; } = string.Empty;

        public string AssociationName { get; set; }=string.Empty;

        public string FilterJson { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double BaseScore { get; set; }

        public double BaseDuration { get; set; }

        public ExaminationType ExamType { get; set; }

        public ExaminationStatus Status { get; set; }

        public int OrderIndex { get; set; } = 1;

        public string GroupCode { get; set; } = string.Empty;

        public ExaminationStrict IsStrict { get; set; } 
        public string Remark { get; set; } = string.Empty;

    }
}
