﻿namespace RMIS.Binder.BackEnd.Windsor
{
    //using CaseConverter.BackEnd;
    //using CaseConverter.BackEnd.Impl;

    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    //using DataSync.BackEnd;

    //using ExternalInterface.BackEnd;
    //using ExternalInterface.BackEnd.Impl;

    using log4net;
    using RMIS.Mediator.BackEnd;
    using RMIS.Mediator.BackEnd.Impl;
    using RMIS.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper;

    
   
    /// <summary>
    /// Description of BackEndExtension.
    /// </summary>
    public  class BackEndExtension : IWindsorInstaller
    {
        #region Fields

        /// <summary>
        /// logging instance
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BackEndExtension));

        #endregion Fields

        #region Methods

        public virtual void Install(IWindsorContainer container, IConfigurationStore store)
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Adding the BackEnd components now...");
            }

            container.Register(
                Component.For<IRMISMapper>().ImplementedBy<RMISMapperDTN>().LifeStyle.Singleton,
                Component.For<IRMISMediator>().ImplementedBy<RMISMediatorImpl>().LifeStyle.Singleton           
                );
        }

        #endregion Methods
    }
}