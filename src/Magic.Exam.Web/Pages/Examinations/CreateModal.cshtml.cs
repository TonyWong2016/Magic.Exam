using Magic.Exam.Examinations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Magic.Exam.Web.Pages.Examinations
{
    public class CreateModalModel : ExamPageModel
    {
        [BindProperty]
        public CreateUpdateExaminationDto ExaminationDto { get; set; }
        private readonly IExaminationAppService _examinationAppService;

        public CreateModalModel(IExaminationAppService examinationAppService)
        {
            _examinationAppService = examinationAppService;
        }
        public void OnGet()
        {
            ExaminationDto = new CreateUpdateExaminationDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _examinationAppService.CreateAsync(ExaminationDto);
            return NoContent();
        }
    }
}
