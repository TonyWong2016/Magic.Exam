using System;
using System.Collections.Generic;
using System.Text;
using Magic.Exam.Localization;
using Volo.Abp.Application.Services;

namespace Magic.Exam;

/* Inherit your application services from this class.
 */
public abstract class ExamAppService : ApplicationService
{
    protected ExamAppService()
    {
        LocalizationResource = typeof(ExamResource);
    }
}
