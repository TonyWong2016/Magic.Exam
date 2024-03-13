using System.Threading.Tasks;

namespace Magic.Exam.Data;

public interface IExamDbSchemaMigrator
{
    Task MigrateAsync();
}
