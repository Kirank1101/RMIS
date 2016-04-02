// Copyright (c) iucon GmbH. All rights reserved.
// For more information about our work, visit http://www.iucon.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Web;
using System.Web.Script.Serialization;

namespace iucon.web.Controls
{
    public class ParameterCollection : Collection<Parameter>
    {
        #region Constants
       
        private const string PARAMETERS = "__PARAMETERS";

        #endregion

        #region Fields
        
        private bool _isChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Returns singleton instance of this class
        /// </summary>
        public static ParameterCollection Instance
        {
            get
            {
                ParameterCollection parameters = HttpContext.Current.Items[PARAMETERS] as ParameterCollection;
                if (parameters == null)
                {
                    string serializationInfo = HttpContext.Current.Request.Form[PARAMETERS];
                    parameters = new ParameterCollection(serializationInfo);
                }

                return parameters;
            }
        }
        /// <summary>
        /// Indicates wheather parameters have to be serialized or not
        /// </summary>
        public static bool IsDirty
        {
            get
            {
                bool isDirty = false;

                ParameterCollection parameters = HttpContext.Current.Items[PARAMETERS] as ParameterCollection;
                if (parameters != null)
                    isDirty = parameters.IsChanged;

                return isDirty;
            }
        }

        /// <summary>
        /// Has collection changed?
        /// </summary>
        public bool IsChanged
        {
            get { return _isChanged; }
        }
        
        public string this[string name]
        {
            get
            {
                var result = (from p in Items
                              where p.Name == name
                              select p).FirstOrDefault();

                if (result != null)
                    return result.Value;

                return null;
            }
            set
            {
                var result = (from p in Items
                              where p.Name == name
                              select p).FirstOrDefault();

                if (result != null && result.Value != value)
                {
                    result.Value = value;
                    _isChanged = true;
                }
            }
        }

        #endregion

        #region Constructors
        
        public ParameterCollection()
        {
        }

        /// <summary>
        /// Deserializes collection from JSON string
        /// </summary>
        private ParameterCollection(string serializationInfo)
        {
            if (!string.IsNullOrEmpty(serializationInfo))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                Parameter[] parameters = serializer.Deserialize<Parameter[]>(serializationInfo);
                if (parameters != null && parameters.Length > 0)
                {
                    foreach (Parameter p in parameters)
                        Add(p);
                }
            }
            // Cache collection.
            HttpContext.Current.Items[PARAMETERS] = this;
        }

        #endregion
    }
}
