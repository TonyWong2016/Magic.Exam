using Magic.Exam.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Magic.Exam.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ExamController : AbpControllerBase
{
    protected ExamController()
    {
        LocalizationResource = typeof(ExamResource);
    }
}
