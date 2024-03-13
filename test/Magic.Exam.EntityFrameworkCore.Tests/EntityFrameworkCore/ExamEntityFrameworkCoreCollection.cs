using Xunit;

namespace Magic.Exam.EntityFrameworkCore;

[CollectionDefinition(ExamTestConsts.CollectionDefinitionName)]
public class ExamEntityFrameworkCoreCollection : ICollectionFixture<ExamEntityFrameworkCoreFixture>
{

}
