using Magic.Exam.Samples;
using Xunit;

namespace Magic.Exam.EntityFrameworkCore.Domains;

[Collection(ExamTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ExamEntityFrameworkCoreTestModule>
{

}
