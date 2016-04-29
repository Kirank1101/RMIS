namespace RMIS.Binder.BackEnd.Windsor
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
    using RMIS.Domain.Mediator;
    using RMIS.Domain.Business;
    using RMIS.Business;
    using RMIS.UserMessageStore;



    /// <summary>
    /// Description of BackEndExtension.
    /// </summary>
    public class RMSExtensions : IWindsorInstaller
    {
        #region Fields

        /// <summary>
        /// logging instance
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RMSExtensions));

        #endregion Fields

        #region Methods

        public virtual void Install(IWindsorContainer container, IConfigurationStore store)
        {
            if (Logger.IsDebugEnabled)
            {
                Logger.Debug("Adding the BackEnd components now...");
            }

            container.Register(
                Component.For<IRMISMapper>().ImplementedBy<RMISMapperDTN>().LifeStyle.Transient ,
                Component.For<IRMISMediator>().ImplementedBy<RMISMediatorImpl>().LifeStyle.Transient,
                 Component.For<ISessionProvider>().ImplementedBy<RMIS.HttpSessionProvider.HttpSessionProvider>().LifeStyle.Transient,
                  Component.For<IUserMessage>().ImplementedBy<UserMessage>().LifeStyle.Transient,
                 Component.For<IMasterPaddyBusiness>().ImplementedBy<MasterPaddyBusiness>().LifeStyle.Transient
                );
        }

        #endregion Methods
    }
}