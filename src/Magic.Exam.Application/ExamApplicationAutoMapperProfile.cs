using AutoMapper;
using Magic.Exam.Examinations;

namespace Magic.Exam;

public class ExamApplicationAutoMapperProfile : Profile
{
    public ExamApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Examination, ExaminationDto>();
        CreateMap<CreateUpdateExaminationDto, Examination>();
    }
}
