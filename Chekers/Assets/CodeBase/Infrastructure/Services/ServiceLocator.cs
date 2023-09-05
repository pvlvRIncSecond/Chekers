using System;
using System.Collections.Generic;

namespace CodeBase.Infrastructure.Services
{
    public class ServiceLocator
    {
        public static ServiceLocator Container => _instance ??= new ServiceLocator();
        private static ServiceLocator _instance;

        private Dictionary<Type, IService> _services;
        public ServiceLocator() => 
            _services = new Dictionary<Type, IService>();

        public void RegisterSingle<TService>(TService service) where TService : class, IService => 
            _services.Add(typeof(TService), service);

        public TService Single<TService>() where TService : class, IService => 
            _services[typeof(TService)] as TService;
    }
}