using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Magic.Exam.Examinations
{
    public interface IExaminationAppService: ICrudAppService<
        ExaminationDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateExaminationDto
        >
    {

    }
}
