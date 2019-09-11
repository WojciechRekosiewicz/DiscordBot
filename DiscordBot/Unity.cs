﻿using DiscordBot.Storage;
using DiscordBot.Storage.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Resolution;
using System.Diagnostics.Contracts;
using Unity.Lifetime;

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
             _container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
     

        }





        public static T Resolve<T>()
        {
            return Container.Resolve<T>();

        }


        //internal static T Resolve<T>()
        //{
        //    return (T)Container.Resolve(typeof(T), string.Empty, new CompositeResolverOverride());
        //}

        //public static T Resolve<T>()
        //{
        //    return (T)Container.Resolve(typeof(T), string.Empty, new ResolverOverride());

        //}
    }


}