namespace App.Core.Constants
{
    public class Messages
    {
        #region Account
        public const string Account_Was_Not_Found = "Account_Was_Not_Found";

        public const string Account_Login_Failed = "Account_Login_Failed";
        public const string Account_Login_Successful = "Account_Login_Successful";

        public const string Account_Email_Has_Already_Been_Exist = "Account_Email_Has_Already_Been_Exist";
        public const string Account_Username_Has_Already_Been_Exist = "Account_Username_Has_Already_Been_Exist";

        public const string Account_Please_Enter_Your_Email = "Account_Please_Enter_Your_Email";
        public const string Account_Please_Enter_Your_Password = "Account_Please_Enter_Your_Password";
        public const string Account_Please_Enter_Your_Email_With_Correct_Format = "Account_Please_Enter_Your_Email_With_Correct_Format";
        #endregion

        #region AppUser
        public const string AppUser_HasBeen_Added = "AppUser_HasBeen_Added";
        public const string AppUser_CouldNotBe_Added = "AppUser_CouldNotBe_Added";
        #endregion

        #region Email
        public const string Email_SendingProcess_Was_Failed = "Email_SendingProcess_Was_Failed";
        public const string Email_SendingProcess_Was_Successful = "Email_SendingProcess_Was_Successful";

        public const string EmailTitle_Has_Been_Sent_For_NewAppUser = "EmailTitle_Has_Been_Sent_For_NewAppUser";
        public const string EmailSubject_Has_Been_Sent_For_NewAppUser = "EmailSubject_Has_Been_Sent_For_NewAppUser";
        public const string EmailContent_Has_Been_Sent_For_NewAppUser = "EmailContent_Has_Been_Sent_For_NewAppUser";

        public const string EmailTitle_Has_Been_Sent_For_EmailVerificationCode = "EmailTitle_Has_Been_Sent_For_EmailVerificationCode";
        public const string EmailSubject_Has_Been_Sent_For_EmailVerificationCode = "EmailSubject_Has_Been_Sent_For_EmailVerificationCode";
        public const string EmailContent_Has_Been_Sent_For_EmailVerificationCode = "EmailContent_Has_Been_Sent_For_EmailVerificationCode";
        #endregion

        #region Redis
        public const string Redis_Cache_Entity_Was_Added = "Redis_Cache_Entity_Was_Added";
        public const string Redis_Cache_Entity_Was_Found = "Redis_Cache_Entity_Was_Found";
        public const string Redis_Cache_Entity_Was_Not_Added = "Redis_Cache_Entity_Was_Not_Added";
        public const string Redis_Cache_Entity_Was_Not_Found = "Redis_Cache_Entity_Was_Not_Found";
        #endregion

        #region Rabbitmq
        public const string Rabbitmq_StartSendingEmailProcess_Was_Failed = "Rabbitmq_StartSendingEmailProcess_Was_Failed";
        public const string Rabbitmq_StartSendingEmailProcess_Was_Successful = "Rabbitmq_StartSendingEmailProcess_Was_Successful";

        public const string Rabbitmq_EnqueueModelProcess_Was_Failed = "Rabbitmq_EnqueueModelProcess_Was_Failed";
        public const string Rabbitmq_EnqueueModelProcess_Was_Successful = "Rabbitmq_EnqueueModelProcess_Was_Successful";
        public const string Rabbitmq_EnqueueModelsProcess_Were_Failed = "Rabbitmq_EnqueueModelsProcess_Were_Failed";
        public const string Rabbitmq_EnqueueModelsProcess_Were_Successful = "Rabbitmq_EnqueueModelsProcess_Were_Successful";
        #endregion
    }
}