using Microsoft.AspNetCore.Builder;
using Magic.Exam;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ExamWebTestModule>();

public partial class Program
{
}
