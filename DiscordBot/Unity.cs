using DiscordBot.Storage;
using DiscordBot.Storage.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;
using System.Diagnostics.Contracts;
using Unity.Lifetime;
using Discord.WebSocket;
using Unity.Injection;
using DiscordBot.Discord;

namespace DiscordBot
{
    public static class Unity
    {
        private static UnityContainer _container;


        public static UnityContainer Container
        {
            get
            {
                if(_container == null)                
                    RegiterTypes();
                    return _container;
                
            }
        }


        public static void RegiterTypes()
        {
            _container = new UnityContainer();

            //only one instance will be created because of this
            // ContainerControlledLifetimeManager
            //_container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
            //_container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
            //    _container.RegisterType<Discord.Connection>(new ContainerControlledLifetimeManager());

            _container.RegisterSingleton<IDataStorage, JsonStorage>();
            _container.RegisterSingleton<ILogger, Logger>();
            _container.RegisterType<DiscordSocketConfig>(new InjectionFactory(i => SocketConfig.GetDefault()));
            _container.RegisterSingleton<DiscordSocketClient>(new InjectionConstructor(typeof(DiscordSocketConfig)));
            _container.RegisterSingleton<Discord.Connection>();


         }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        }


        //public static T Resolve<T>()
        //{
        //    return Container.Resolve<T>();
        //}

    }


}
