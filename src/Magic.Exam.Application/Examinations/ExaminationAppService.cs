using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Magic.Exam.Examinations
{
    public class ExaminationAppService : 
        CrudAppService<
           Examination,
           ExaminationDto,
           Guid,
           PagedAndSortedResultRequestDto,
           CreateUpdateExaminationDto>,
       IExaminationAppService
    {
        public ExaminationAppService(IRepository<Examination, Guid> repository) : base(repository)
        {

        }
    }

}
