using Magic.Exam.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Magic.Exam.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ExamPageModel : AbpPageModel
{
    protected ExamPageModel()
    {
        LocalizationResourceType = typeof(ExamResource);
    }
}
