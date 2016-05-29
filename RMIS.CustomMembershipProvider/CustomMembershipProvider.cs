using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using RMIS.Domain.RiceMill;
using RMIS.Domain.Business;
using RMIS.Binder.BackEnd;
using AllInOne.Common.Library.Util;

namespace RMIS.CustomMembershipProvider
{
    public class CustomMembershipProvider : MembershipProvider
    {
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

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }


        public MembershipUser CreateUser(string username, string password, string customerId, out MembershipCreateStatus status)
        {
            ValidatePasswordEventArgs args = new ValidatePasswordEventArgs(username, password, true);
            OnValidatingPassword(args);

            if (args.Cancel)
            {
                status = MembershipCreateStatus.InvalidPassword;
                return null;
            }
            MembershipUser user = GetUser(username, true);
            if (user == null)
            {
                status = MembershipCreateStatus.Success;
                return GetUser(username, true);
            }
            else
            {
                status = MembershipCreateStatus.DuplicateUserName;
            }

            return null;
        }


       

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            if (username.IsUserNameValid())
            {
                ValidatePasswordEventArgs args = new ValidatePasswordEventArgs(username, password, true);
                OnValidatingPassword(args);
                if (args.Cancel)
                {
                    status = MembershipCreateStatus.InvalidPassword;
                    return null;
                }
                MembershipUser user = GetUser(username, true);
                if (user == null)
                {
                    ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                    imp.SaveÜserInfo(username.Split(CommonUtil.splilChar)[1], password, username.Split(CommonUtil.splilChar)[0]);
                    status = MembershipCreateStatus.Success;
                    return GetUser(username, true);
                }
                else
                {
                    status = MembershipCreateStatus.DuplicateUserName;
                }
            }
            else
            {
                status = MembershipCreateStatus.InvalidUserName;
                return null;
            }

            return null;
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }

        public override bool EnablePasswordReset
        {
            get { throw new NotImplementedException(); }
        }

        public override bool EnablePasswordRetrieval
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            return null;
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {

            ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
            UsersEntity user = imp.GetUsersEntity(username.Split(CommonUtil.splilChar)[1], username.Split(CommonUtil.splilChar)[0]);     
            //EmployeeBusiness userRep = new EmployeeBusiness();
            //EmployeeInfo user = userRep.GetUserObjByUserName(username);
            //// EmployeeDetail userDetail = userRep.GetAllEmployeeDetails().SingleOrDefault(u => u.EmployeeId == username);

            if (user != null)
            {
                MembershipUser memUser = new MembershipUser("CustomMembershipProvider", username, string.Empty, string.Empty,
                                                            string.Empty, string.Empty,
                                                            true, false, DateTime.MinValue,
                                                            DateTime.MinValue,
                                                            DateTime.MinValue,
                                                            DateTime.Now, DateTime.Now);
                return memUser;
            }
            return null;
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredPasswordLength
        {
            get { return 6; }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException(); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { return false; }
        }

        public override bool RequiresUniqueEmail
        {
            get { return false; }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            if (username.IsUserNameValid())
            {
                ITransactionBusiness imp = BinderSingleton.Instance.GetInstance<ITransactionBusiness>();
                UsersEntity userObj = imp.ValidateUsersEntity(username.Split(CommonUtil.splilChar)[1], username.Split(CommonUtil.splilChar)[0], password);
                if (userObj != null)
                    return true;
            }
            return false;
        }


       
    }
}
