﻿using Autofac;
using Resgrid.Model.Repositories;
using Resgrid.Model.Repositories.Connection;
using Resgrid.Model.Repositories.Queries;
using Resgrid.Model.Repositories.Queries.Contracts;
using Resgrid.Repositories.DataRepository.Configs;
using Resgrid.Repositories.DataRepository.Contexts;
using Resgrid.Repositories.DataRepository.Queries;
using Resgrid.Repositories.DataRepository.Servers.SqlServer;
using Resgrid.Repositories.DataRepository.Transactions;

namespace Resgrid.Repositories.DataRepository
{
	public class TestingDataModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterGeneric(typeof(GenericDataRepository<>)).As(typeof(IGenericDataRepository<>)).InstancePerLifetimeScope();
			builder.RegisterType<DataContext>().As<DataContext>().InstancePerLifetimeScope();
			builder.RegisterType<StandardIsolation>().As<IISolationLevel>().InstancePerLifetimeScope();

			// Custom Repositories
			builder.RegisterType<UserStatesRepository>().As<IUserStatesRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentsRepository>().As<IDepartmentsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentSettingsRepository>().As<IDepartmentSettingsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<UnitStatesRepository>().As<IUnitStatesRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentMembersRepository>().As<IDepartmentMembersRepository>().InstancePerLifetimeScope();
			builder.RegisterType<PaymentRepository>().As<IPaymentRepository>().InstancePerLifetimeScope();
			builder.RegisterType<UserProfilesRepository>().As<IUserProfilesRepository>().InstancePerLifetimeScope();
			builder.RegisterType<CallsRepository>().As<ICallsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<ActionLogsRepository>().As<IActionLogsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<IdentityRepository>().As<IIdentityRepository>().InstancePerLifetimeScope();
			builder.RegisterType<ScheduledTaskLogsRepository>().As<IScheduledTaskLogsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<CalendarItemsRepository>().As<ICalendarItemsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<ScheduledTasksRepository>().As<IScheduledTasksRepository>().InstancePerLifetimeScope();

			// Dapper Repositories
			builder.RegisterType<IdentityRepository>().As<IIdentityRepository>().InstancePerLifetimeScope();
			builder.RegisterType<ResourceOrdersRepository>().As<IResourceOrdersRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentNotificationRepository>().As<IDepartmentNotificationRepository>().InstancePerLifetimeScope();
			builder.RegisterType<TrainingRepository>().As<ITrainingRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentCallEmailsRepository>().As<IDepartmentCallEmailsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<MessageRepository>().As<IMessageRepository>().InstancePerLifetimeScope();
			builder.RegisterType<UnitLocationRepository>().As<IUnitLocationRepository>().InstancePerLifetimeScope();
			builder.RegisterType<PushUriRepository>().As<IPushUriRepository>().InstancePerLifetimeScope();
			builder.RegisterType<PlansRepository>().As<IPlansRepository>().InstancePerLifetimeScope();
			builder.RegisterType<CallTypesRepository>().As<ICallTypesRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentGroupsRepository>().As<IDepartmentGroupsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<AddressRepository>().As<IAddressRepository>().InstancePerLifetimeScope();
			builder.RegisterType<HealthRepository>().As<IHealthRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentGroupMembersRepository>().As<IDepartmentGroupMembersRepository>().InstancePerLifetimeScope();
			builder.RegisterType<DepartmentCallPruningRepository>().As<IDepartmentCallPruningRepository>().InstancePerLifetimeScope();
			builder.RegisterType<ShiftsRepository>().As<IShiftsRepository>().InstancePerLifetimeScope();
			builder.RegisterType<ClaimsRepository>().As<IClaimsRepository>().InstancePerLifetimeScope();

			builder.RegisterType<QueryList>().As<IQueryList>().InstancePerLifetimeScope();
			builder.RegisterType<SqlServerConfiguration>().As<SqlConfiguration>().InstancePerLifetimeScope();
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
			builder.RegisterType<QueryFactory>().As<IQueryFactory>().InstancePerLifetimeScope();
			builder.RegisterType<SqlServerConnectionProvider>().As<IConnectionProvider>().InstancePerLifetimeScope();
			builder.RegisterType<IdentityRoleRepository>().As<IIdentityRoleRepository>().InstancePerLifetimeScope();
			builder.RegisterType<IdentityUserRepository>().As<IIdentityUserRepository>().InstancePerLifetimeScope();
		}
	}
}
