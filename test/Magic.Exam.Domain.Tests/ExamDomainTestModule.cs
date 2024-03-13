using Volo.Abp.Modularity;

namespace Magic.Exam;

[DependsOn(
    typeof(ExamDomainModule),
    typeof(ExamTestBaseModule)
)]
public class ExamDomainTestModule : AbpModule
{

}
