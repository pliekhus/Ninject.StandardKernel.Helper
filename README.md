# Ninject.StandardKernel.Helper
Standard kernel dependency wrapper for Ninject.

You must configure your application using standard Ninject modules.  Here is an example on how to bind your references to the objects.

```c#
  public class DomainNHibernateNinjectModule : NinjectModule
  {
    public override void Load()
    {
      Bind<IRepository>().To<DomainNHibernateRepository>();
    }
  }
```

Then in your Program.cs (or other starting point, i.e. Global.asax) you would need to register this as such.

```c#
  DependencyHelper.Configure(new INinjectModule[]
  {
    new DomainNHibernateNinjectModule()
  });
```

And finally when you want to call the class for consumption you would call this

```c#
  IRepository repository = DependencyHelper.Get<IRepository>();
```
