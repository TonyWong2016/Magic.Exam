﻿using Volo.Abp.Settings;

namespace Magic.Exam.Settings;

public class ExamSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ExamSettings.MySetting1));
    }
}
