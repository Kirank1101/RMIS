using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
//using AI_HRnPayrollBusiness;

/// <summary>
/// Summary description for CustomRoleProvider
/// </summary>
public class CustomRoleProvider : RoleProvider
{
    public override bool IsUserInRole(string username, string roleName)
    {

        //EmployeeBusiness business = new EmployeeBusiness();
        //return business.IsUserInRole(username, roleName);
        throw new NotImplementedException();
    }

    public override string[] GetRolesForUser(string username)
    {
        //EmployeeBusiness business = new EmployeeBusiness();
        //return business.GetRolesForUser(username);
        throw new NotImplementedException();
    }

    // -- Snip --

    public override string[] GetAllRoles()
    {
        //EmployeeBusiness business = new EmployeeBusiness();
        //return business.GetAllRoles().Select(u => u.RoleName).ToArray();
        throw new NotImplementedException();
    }

    // -- Snip --

    public override void AddUsersToRoles(string[] usernames, string[] roleNames)
    {
        //EmployeeBusiness business = new EmployeeBusiness();
        //business.AddUsersToRoles(usernames, roleNames);
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}