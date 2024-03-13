using Magic.Exam.Examinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace Magic.Exam.Data
{
    public class ExamDataSeedContributor:IDataSeedContributor,ITransientDependency
    {
        private readonly IRepository<Examination, Guid> _examinationRepository;
        private readonly IGuidGenerator _IGuidGenerator;

        public ExamDataSeedContributor(IRepository<Examination, Guid> examinationRepository,IGuidGenerator guidGenerator)
        {
            _examinationRepository = examinationRepository;
            _IGuidGenerator = guidGenerator;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _examinationRepository.GetCountAsync() <= 0)
            {
                await _examinationRepository.InsertAsync(new Examination
                {
                    Title = "小学组-测试",
                    ExamType = ExaminationType.Exam,
                    AssociationId = "",
                    AssociationName = "无",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddMinutes(60),
                    Remark = "测试数据",
                    CreationTime = DateTime.Now,
                    CreatorId = _IGuidGenerator.Create()
                });
            }
        }
    }
}
