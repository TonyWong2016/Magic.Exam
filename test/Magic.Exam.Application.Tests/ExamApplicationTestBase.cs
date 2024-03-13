using Volo.Abp.Modularity;

namespace Magic.Exam;

public abstract class ExamApplicationTestBase<TStartupModule> : ExamTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
