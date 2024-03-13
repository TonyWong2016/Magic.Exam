using Volo.Abp.Modularity;

namespace Magic.Exam;

[DependsOn(
    typeof(ExamApplicationModule),
    typeof(ExamDomainTestModule)
)]
public class ExamApplicationTestModule : AbpModule
{

}
