﻿using Autofac;
//using iSpindel.Core.Services;

namespace iSpindel.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    //builder.RegisterType<ToDoItemSearchService>().As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
