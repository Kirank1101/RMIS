


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using log4net;
using System.Data;
using System.ComponentModel;
namespace AllInOne.Common.Library.Util
{
    public static class CommonUtil
    {
        private static string OpenDocUrl = "/_layouts/IELS/DMS/OpenDocument.aspx?DocId={0}&DocStatus={1}";
        private static string OutgoingCorrespondenceCaseTypeUrl = "/_layouts/IELS/OutgoingCorrespondence/OutgoingCorrespondence.aspx?Doccode={0}&CaseInfoID={1}&WorkItem=wi";
        private static string OGCSubCaseMultipleDocUrl = "/_layouts/IELS/OutgoingCorrespondence/OutgoingCorrespondence.aspx?Doccode={0}&CaseInfoID={1}&SubCaseInfoID={2}&WFSNo={3}&IsMultipleWI=true";
        private static string OutgoingCorrespondenceFeeDocTypeUrl = "/_layouts/IELS/OutgoingCorrespondence/OutgoingCorrespondence.aspx?Doccode={0}&CaseInfoID={1}&DocType=fees&type=AUTO";
        private static string ScheduleHearingUrl = "/_layouts/IELS/ScheduleHearing/ScheduleHearing.aspx";
        //private static string ScheduleHearingUrlWithWFSno = "/_layouts/IELS/ScheduleHearing/ScheduleHearing.aspx?caseNo={0}&WFSNo={1}";

        /// <summary>
        /// ELIT's format for DateTime in dd-MMM-yyyy hh:mm tt.
        /// </summary>
        private const string ELITFormatDateTime = "dd-MMM-yyyy hh:mm tt";
        private const string ELITFormatDate = "dd-MMM-yyyy";
        public const Char splilChar = '\\';

        private static ILog log = LogManager.GetLogger(typeof(CommonUtil));

        public static string GetOpenDocumentURL(string docId, string docStatusCode)
        {
            string dmsOpenDocURL = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(docId) && !string.IsNullOrEmpty(docStatusCode))
                {
                    dmsOpenDocURL = string.Format(OpenDocUrl, docId, docStatusCode);
                }
                log.Debug("dmsOpenDocURL - " + dmsOpenDocURL);
            }
            catch (Exception ex)
            {
                log.Error("exception in common Util", ex);
                throw;
            }
            return dmsOpenDocURL;
        }

        public static string GetOutgoingCorrespondenceCaseTypeURL(string docCode, string caseInfoId)
        {
            string ogcURL = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(docCode) && !string.IsNullOrEmpty(caseInfoId))
                {
                    ogcURL = string.Format(OutgoingCorrespondenceCaseTypeUrl, docCode, caseInfoId);
                }
                log.Debug("OutgoingCorrespondenceUrl - " + ogcURL);
            }
            catch (Exception ex)
            {
                log.Error("exception in common Util", ex);
                throw;
            }
            return ogcURL;
        }

        public static string GetOutgoingCorrespondenceFeeDocTypeURL(string docCode, string caseInfoId)
        {
            string ogcURL = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(docCode) && !string.IsNullOrEmpty(caseInfoId))
                {
                    ogcURL = string.Format(OutgoingCorrespondenceFeeDocTypeUrl, docCode, caseInfoId);
                }
                log.Debug("OutgoingCorrespondenceUrl - " + ogcURL);
            }
            catch (Exception ex)
            {
                log.Error("exception in common Util", ex);
                throw;
            }
            return ogcURL;
        }

        public static string GetOGCSubCaseMultipleDocURL(List<string> docCodes, string caseInfoId, string subCaseInfoId, string wfSno)
        {
            string ogcURL = string.Empty;
            try
            {
                if (docCodes != null && docCodes.Count > 0 && !string.IsNullOrEmpty(caseInfoId) && !string.IsNullOrEmpty(subCaseInfoId))
                {
                    string delimitedDocCodes = string.Join("|", docCodes.ToArray());
                    ogcURL = string.Format(OGCSubCaseMultipleDocUrl, delimitedDocCodes, caseInfoId, subCaseInfoId, wfSno);
                }
                log.Debug("OutgoingCorrespondenceUrl - " + ogcURL);
            }
            catch (Exception ex)
            {
                log.Error("exception in common Util", ex);
                throw;
            }
            return ogcURL;
        }

        public static string GetScheduleHearingURL(NameValueCollection nvc)
        {
            string scheduleHearingURL = string.Empty;

            scheduleHearingURL = ScheduleHearingUrl + "?" + string.Join("&", Array.ConvertAll(nvc.AllKeys, key => string.Format("{0}={1}", key, nvc[key])));

            log.Debug("ScheduleHearingURL - " + scheduleHearingURL);

            return scheduleHearingURL;
        }

        /// <summary>
        /// Gets the ELIT format date time.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public static string GetELITFormatDateTime(DateTime dateTime)
        {
            return (dateTime != DateTime.MinValue) ? dateTime.ToString(ELITFormatDateTime) : string.Empty;
        }

        /// <summary>
        /// Gets the ELIT format date.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public static string GetELITFormatDate(DateTime dateTime)
        {
            return (dateTime != DateTime.MinValue) ? dateTime.ToString(ELITFormatDate) : string.Empty;
        }

        /// <summary>
        /// Gets the ELIT format date time.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public static string GetELITFormatDateTime(DateTime? dateTime)
        {
            if (dateTime == null || dateTime == DateTime.MinValue)
            {
                return string.Empty;
            }
            else
            {
                DateTime updatedTime = dateTime ?? DateTime.Now;
                return updatedTime.ToString(ELITFormatDateTime);
            }
        }

        /// <summary>
        /// Gets the ELIT format date time.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public static string GetELITFormatDate(DateTime? dateTime)
        {
            if (dateTime == null || dateTime == DateTime.MinValue)
            {
                return string.Empty;
            }
            else
            {
                DateTime updatedTime = dateTime ?? DateTime.Now;
                return updatedTime.ToString(ELITFormatDate);
            }
        }

        public static string CreateUniqueID(string prefixText)
        {
            string returnValue = string.Empty;
            Random objRnd = new Random();
            returnValue = string.Format("{0}{1:yyyyMMddHHmmssffffff}{2}", prefixText, DateTime.Now,
                                                                        objRnd.Next(10000, 99999));
            return returnValue;
        }

        public static int ConvertToInt(this string prefixText)
        {
            if (string.IsNullOrEmpty(prefixText))
                return 0;
            int value = 0;
            Int32.TryParse(prefixText, out value);
            return value;
        }

        public static bool IsDate(this string prefixText)
        {
            if (string.IsNullOrEmpty(prefixText))
                return false;
            DateTime dtTemp;
            return DateTime.TryParse(prefixText, out dtTemp);
        }

        public static bool IsUserNameValid(this string username)
        {

            if (!string.IsNullOrEmpty(username))
            {
                string[] splitWord = username.Split('\\');
                if (splitWord != null && splitWord.Length != 2)
                {

                    return false;
                }
                else
                    return true;
            }

            return false;
        }

    }

    // Sorry about indentation
    public class CollectionHelper
    {
        private CollectionHelper()
        {
        }

        // this is the method I have been using
        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (T item in list)
            {
                DataRow row = table.NewRow();

                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);

            foreach (PropertyDescriptor prop in properties)
            {
                // HERE IS WHERE THE ERROR IS THROWN FOR NULLABLE TYPES
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(
            prop.PropertyType) ?? prop.PropertyType);
            }

            return table;
        }
    }
}
