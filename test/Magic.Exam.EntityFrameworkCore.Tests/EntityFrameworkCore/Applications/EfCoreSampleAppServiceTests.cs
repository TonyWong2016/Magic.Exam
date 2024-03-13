using Magic.Exam.Samples;
using Xunit;

namespace Magic.Exam.EntityFrameworkCore.Applications;

[Collection(ExamTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ExamEntityFrameworkCoreTestModule>
{

}
