using Magic.Exam.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Magic.Exam.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ExamEntityFrameworkCoreModule),
    typeof(ExamApplicationContractsModule)
    )]
public class ExamDbMigratorModule : AbpModule
{
}
