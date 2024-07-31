using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Newtonsoft.Json.Linq;
using TheOtherRoles.Patches;
using UnityEngine;


namespace TheOtherRoles
{
	public class TranslationInfo
	{
        public TranslationInfo(string text)
            : this(text, Color.white)
        {
        }

        public TranslationInfo(string text, Color color)
		{
            this.text = text;
            this.color = color;
        }

        public TranslationInfo(string category, int id)
            : this(category, id, Color.white)
        {
        }

        public TranslationInfo(string category, int id, Color color)
		{
            this.category = category;
            this.id = id;
            this.color = color;
        }

        public TranslationInfo(RoleId roleId)
            : this(roleId, Color.white)
        {
        }

        public TranslationInfo(RoleId roleId, Color color)
        {
            this.roleId = roleId;
            this.color = color;
        }

        public void AddHeadText(string text)
		{
            headText = text;
        }
        public void AddTailText(string text)
        {
            tailText = text;
        }

        public string GetString()
		{
            if (!string.IsNullOrEmpty(text))
                return Helpers.cs(color, headText + text + tailText);
            if (roleId != RoleId.Max)
                return Helpers.cs(color, headText + ModTranslation.GetRoleName(roleId, color) + tailText);
            return Helpers.cs(color, headText + ModTranslation.GetString(category, id) + tailText);
		}

        public override string ToString()
        {
            return GetString();
        }

        string headText;
        string text;
        string tailText;
        string category;
        int id;
        Color color;
        RoleId roleId = RoleId.Max;
    }


	
    public class ModTranslation
    {
        // Dictionary<Category, Dictionary<Category-Id, Dictionary<Lang-Id, Str>>>
        public static Dictionary<string, Dictionary<int, Dictionary<int, string>>> stringTable;

        public static void Load()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("TheOtherRoles.Resources.stringData.json");
            var byteArray = new byte[stream.Length];
            var read = stream.Read(byteArray, 0, (int)stream.Length);
            string json = System.Text.Encoding.UTF8.GetString(byteArray);
            stringTable = new();
            JObject parsed = JObject.Parse(json);

            for (int i = 0; i < parsed.Count; i++)
            {
                JProperty token = parsed.ChildrenTokens[i].TryCast<JProperty>();
                if (token == null) continue;
                var val = token.Value.TryCast<JObject>();
                if (token.HasValues)
                {
                    string categoryStr = token.Name;
                    int index = categoryStr.IndexOf(",");
                    string categoryName = categoryStr.Substring(0, index);
                    int categoryId = int.Parse(categoryStr.Substring(index + 1));
                    
                    if (!stringTable.TryGetValue(categoryName, out var t))
					{
						t = new();
                        stringTable.Add(categoryName, t);
                    }

                    var strings = new Dictionary<int, string>();
                    for (int j = 0; j < (int)SupportedLangs.Irish + 1; j++)
                    {
                        string key = j.ToString();
                        var text = val[key]?.TryCast<JValue>().Value.ToString();

                        if (text != null && text.Length > 0)
                        {
                            if (text == blankText) strings[j] = "";
                            else strings[j] = text;
                        }
                    }

                    t[categoryId] = strings;
                }
            }
            //TheOtherRolesPlugin.Instance.Log.LogMessage($"Language: {stringTable.Keys}");
        }

        public static string GetString(string category, int id, string def = null)
        {
            //TheOtherRolesPlugin.Instance.Log.LogMessage($"category:{category}, id:{id}, def:{def}");
            if (!stringTable.TryGetValue(category, out var t))
                return def;
            if (!t.TryGetValue(id, out var t2))
                return def;
            int langId = (int)AmongUs.Data.DataManager.Settings.Language.CurrentLanguage;
            if (t2.ContainsKey(langId))
                return t2[langId];
            else if (t2.ContainsKey(defaultLangId))
                return t2[defaultLangId];

            return def;
        }

        public static TranslationInfo GetRoleName(RoleId roleId, Color? color = null)
        {
            return new TranslationInfo("Role-Name", GetRoleStringId(roleId), color.HasValue ? color.Value : Color.white);
        }

        public static TranslationInfo GetRoleIntroDesc(RoleId roleId, Color? color = null)
        {
            return new TranslationInfo("Role-IntroDesc", GetRoleStringId(roleId), color.HasValue ? color.Value : Color.white);
        }

        public static TranslationInfo GetRoleShortDesc(RoleId roleId, Color? color = null)
        {
            return new TranslationInfo("Role-ShortDesc", GetRoleStringId(roleId), color.HasValue ? color.Value : Color.white);
        }

        static int GetRoleStringId(RoleId roleId)
		{
            int id = -1;
            switch (roleId)
			{
                case RoleId.Jester:        id = 1; break;
                case RoleId.Mayor:         id = 2; break;
            }

            return id;
		}

        const string blankText = "[BLANK]";
        const int defaultLangId = (int)SupportedLangs.English;
    }

    [HarmonyPatch(typeof(LanguageSetter), nameof(LanguageSetter.SetLanguage))]
    class SetLanguagePatch
    {
        static void Postfix()
        {
            ClientOptionsPatch.UpdateTranslations();
        }
    }
}
