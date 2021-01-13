//Autogenerated by BlazorBoilerplate.EntityGenerator
using BlazorBoilerplate.Constants;
using BlazorBoilerplate.Shared.DataInterfaces;
using Breeze.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BlazorBoilerplate.Shared.Dto.Db
{
    public partial class ApplicationUser : BaseEntity, IApplicationUser
    {
        public String TenantId
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String FirstName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String LastName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String FullName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String PasswordHash
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String SecurityStamp
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        ICollection<IApplicationUserRole> IApplicationUser.UserRoles { get => UserRoles.Select(i => (IApplicationUserRole)i).ToList(); }

        public NavigationSet<ApplicationUserRole> UserRoles
        {
            get { return GetValue<NavigationSet<ApplicationUserRole>>(); }
        }

        ICollection<IApiLogItem> IApplicationUser.ApiLogItems { get => ApiLogItems.Select(i => (IApiLogItem)i).ToList(); }

        public NavigationSet<ApiLogItem> ApiLogItems
        {
            get { return GetValue<NavigationSet<ApiLogItem>>(); }
        }

        IUserProfile IApplicationUser.Profile { get => Profile; set => Profile = (UserProfile)value; }

        public UserProfile Profile
        {
            get { return GetValue<UserProfile>(); }
            set { SetValue(value); }
        }

        ICollection<IMessage> IApplicationUser.Messages { get => Messages.Select(i => (IMessage)i).ToList(); }

        public NavigationSet<Message> Messages
        {
            get { return GetValue<NavigationSet<Message>>(); }
        }

        public Guid Id
        {
            get { return GetValue<Guid>(); }
            set { SetValue(value); }
        }

        public String UserName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String NormalizedUserName
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String Email
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String NormalizedEmail
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public Boolean EmailConfirmed
        {
            get { return GetValue<Boolean>(); }
            set { SetValue(value); }
        }

        public String ConcurrencyStamp
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public String PhoneNumber
        {
            get { return GetValue<String>(); }
            set { SetValue(value); }
        }

        public Boolean PhoneNumberConfirmed
        {
            get { return GetValue<Boolean>(); }
            set { SetValue(value); }
        }

        public Boolean TwoFactorEnabled
        {
            get { return GetValue<Boolean>(); }
            set { SetValue(value); }
        }

        public DateTimeOffset? LockoutEnd
        {
            get { return GetValue<DateTimeOffset?>(); }
            set { SetValue(value); }
        }

        public Boolean LockoutEnabled
        {
            get { return GetValue<Boolean>(); }
            set { SetValue(value); }
        }

        public Int32 AccessFailedCount
        {
            get { return GetValue<Int32>(); }
            set { SetValue(value); }
        }

    }
}