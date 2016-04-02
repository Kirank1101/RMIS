// Copyright (c) iucon GmbH. All rights reserved.
// For more information about our work, visit http://www.iucon.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace iucon.web.Controls
{
    class ClientScriptRegister
    {
        public void RegisterScripts(ScriptManager scriptManager, Page parentPage)
        {
            ScriptManager parentScript = ScriptManager.GetCurrent(parentPage);
            ClientScriptManager clientScript = parentPage.ClientScript;

            foreach (RegisteredScript script in scriptManager.GetRegisteredStartupScripts())
            {
                // overwrite UniqueScript-ID 
                // because it could conflict with these generated inside the PartialUpdatePanel
                string key = script.Key;
                if (key.StartsWith("UniqueScript"))
                    key = "UpdatePanel" + key;

                if (!clientScript.IsStartupScriptRegistered(script.Type, key))
                {
                    ScriptManager.RegisterStartupScript(parentPage, script.Type, key, script.Script, script.AddScriptTags);
                }
            }

            foreach (RegisteredScript script in scriptManager.GetRegisteredClientScriptBlocks())
            {
                if (script.ScriptType == RegisteredScriptType.ClientScriptInclude)
                {
                    if (!clientScript.IsClientScriptIncludeRegistered(script.Type, script.Key))
                        ScriptManager.RegisterClientScriptInclude(parentPage, script.Type, script.Key, script.Url);
                }
                else
                {
                    if (!clientScript.IsClientScriptBlockRegistered(script.Type, script.Key))
                        ScriptManager.RegisterClientScriptBlock(parentPage, script.Type, script.Key, script.Script, script.AddScriptTags);
                }
            }
        }
    }
}
