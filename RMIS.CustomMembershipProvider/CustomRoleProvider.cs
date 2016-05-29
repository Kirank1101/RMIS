using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using RMIS.Domain.RiceMill;
using AllInOne.Common.Library.Util;

namespace RMIS.CustomMembershipProvider
{
    public class CustomRoleProvider : RoleProvider
    {
        public override bool IsUserInRole(string username, string roleName)
        {
            if (username.IsUserNameValid())
            {

                ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                List<RMUserRoleEntity> listRMUserRoleEntity = imp.GetUserRoles(username.Split(CommonUtil.splilChar)[1], username.Split(CommonUtil.splilChar)[0]);
                if (listRMUserRoleEntity != null && listRMUserRoleEntity.Count > 0)
                {
                    IMasterPaddyBusiness impMaster = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
                    List<MRolesEntity> listMRolesEntity = impMaster.GetAllRolesEntities();
                    if (listMRolesEntity != null)
                    {
                        listMRolesEntity = listMRolesEntity.FindAll(A => A.RoleName == roleName).ToList();
                        foreach (MRolesEntity objlistMRolesEntity in listMRolesEntity)
                        {
                            if (listRMUserRoleEntity.Find(A => A.RoleId == objlistMRolesEntity.RoleId) != null)
                            {
                                return true;
                            }
                        }

                    }

                }
            }
            return false;
        }

        public override string[] GetRolesForUser(string username)
        {
            List<string> roles = null;
            if (username.IsUserNameValid())
            {
                roles = new List<string>();
                ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                List<RMUserRoleEntity> listRMUserRoleEntity = imp.GetUserRoles(username.Split(CommonUtil.splilChar)[1], username.Split(CommonUtil.splilChar)[0]);
                if (listRMUserRoleEntity != null && listRMUserRoleEntity.Count > 0)
                {
                    IMasterPaddyBusiness impMaster = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
                    List<MRolesEntity> listMRolesEntity = impMaster.GetAllRolesEntities();
                    if (listMRolesEntity != null)
                    {
                        foreach (MRolesEntity objlistMRolesEntity in listMRolesEntity)
                        {
                            if (listRMUserRoleEntity.Find(A => A.RoleId == objlistMRolesEntity.RoleId) != null)
                                roles.Add(objlistMRolesEntity.RoleName);
                        }

                    }

                }
                //EmployeeBusiness business = new EmployeeBusiness();
                //return business.GetRolesForUser(username);
                return roles.ToArray();
            }
            return null;
        }

        // -- Snip --

        public override string[] GetAllRoles()
        {

            IMasterPaddyBusiness imp = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            List<MRolesEntity> listMRolesEntity = imp.GetAllRolesEntities();
            if (listMRolesEntity != null)
                return listMRolesEntity.Select(u => u.RoleName).ToArray();
            return null;
        }

        // -- Snip --

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            if (usernames != null)
            {
                foreach (string username in usernames)
                {
                    if (username.IsUserNameValid())
                    {
                        ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                        UsersEntity user = imp.GetUsersEntity(username.Split(CommonUtil.splilChar)[1], username.Split(CommonUtil.splilChar)[0]);
                        if (user is UsersEntity)
                        {
                            if (roleNames != null)
                            {
                                foreach (string roleName in roleNames)
                                {

                                    IMasterPaddyBusiness impMaster = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
                                    List<MRolesEntity> listMRolesEntity = impMaster.GetAllRolesEntities();
                                    if (listMRolesEntity != null)
                                    {
                                        MRolesEntity roleEntity = listMRolesEntity.FindAll(A => A.RoleName == roleName).FirstOrDefault();
                                        if (roleEntity != null)
                                        {
                                            imp.SaveÜserRole(user.UserID, roleEntity.RoleId, user.CustID);
                                        }

                                    }

                                }

                            }
                        }

                    }

                }
            }

            //EmployeeBusiness business = new EmployeeBusiness();
            //business.AddUsersToRoles(usernames, roleNames);
            // throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            IMasterPaddyBusiness impMaster = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            // impMaster.SaveimpMaster
            impMaster.SaveRoleEntity(roleName);
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            return true;
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            IMasterPaddyBusiness impMaster = BinderSingleton.Instance.GetInstance<IMasterPaddyBusiness>();
            List<MRolesEntity> listMRolesEntity = impMaster.GetAllRolesEntities();
            if (listMRolesEntity != null)
            {
                listMRolesEntity = listMRolesEntity.FindAll(A => A.RoleName == roleName).ToList();
                if (listMRolesEntity != null && listMRolesEntity.Count > 0)
                    return true;
            }
            return false;
        }
    }
}
