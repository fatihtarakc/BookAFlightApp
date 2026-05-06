global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Storage;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Options;
global using System.Linq.Expressions;

global using App.Core.Enums;
global using App.Core.Repositories.Abstract;
global using App.Core.Options;
global using App.Core.UnitOfWorks.Interfaces;
global using App.DataAccess.Abstract.Repositories.Abstract;
global using App.DataAccess.Concrete.Repositories.Concrete;
global using App.DataAccess.Concrete.SeedDatas;
global using App.DataAccess.Concrete.UnitOfWorks.Concrete;
global using App.DataAccess.Context;
global using App.Entity.Entities;