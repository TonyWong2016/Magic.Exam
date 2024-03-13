using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Magic.Exam.Pages;

public class Index_Tests : ExamWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
