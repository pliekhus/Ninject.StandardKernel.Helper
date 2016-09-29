using Ninject.Modules;
using System;

namespace Ninject.StandardKernelHelper
{
	/// <summary>
	/// DependencyHelper creates a wrapper around dependency injection tools to make it easier to use.
	/// </summary>
	public static class DependencyHelper
	{
		private static IKernel _kernel;

		/// <summary>
		/// Configures the dependency injection engine with the specified modules.
		/// </summary>
		/// <param name="modules">The modules that contain the configuration information</param>
		public static void Configure(INinjectModule[] modules)
		{
			_kernel = new StandardKernel(modules);
		}

		/// <summary>
		/// Gets an instance of the specified type from the dependency injection engine
		/// </summary>
		/// <typeparam name="T">The type to get an instance of</typeparam>
		/// <returns>An instance of the type requested</returns>
		public static T Get<T>()
		{
			if (_kernel == null) { throw new NullReferenceException("You must configure the kernel prior to calling it."); }
			return _kernel.Get<T>();
		}
	}
}