﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Magic.Exam.Web;

[Dependency(ReplaceServices = true)]
public class ExamBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Exam";
}
