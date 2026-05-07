global using Hangfire;
global using Hangfire.Annotations;
global using Hangfire.Dashboard;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Options;
global using System.Security.Claims;

global using App.BackgroundJobs.Services.Abstract;
global using App.BackgroundJobs.Services.Concrete;
global using App.BackgroundJobs.Schedules;
global using App.BackgroundJobs.Managers.FireAndForgetJobs;
global using App.Core.Enums;
global using App.Core.Options;
global using App.Queue.Services.Abstract;