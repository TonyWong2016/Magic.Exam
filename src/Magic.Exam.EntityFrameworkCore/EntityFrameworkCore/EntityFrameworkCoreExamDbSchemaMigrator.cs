﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Magic.Exam.Data;
using Volo.Abp.DependencyInjection;

namespace Magic.Exam.EntityFrameworkCore;

public class EntityFrameworkCoreExamDbSchemaMigrator
    : IExamDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreExamDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ExamDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ExamDbContext>()
            .Database
            .MigrateAsync();
    }
}
