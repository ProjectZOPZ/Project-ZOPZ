using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZOPZZ
{
    public static class SettingsManager
    {
        // Token: 0x060000B5 RID: 181 RVA: 0x00006098 File Offset: 0x00004298
        public static void Save(this SettingsModel model)
        {
            if (!Directory.Exists(SettingsManager.datapath))
            {
                Directory.CreateDirectory(SettingsManager.datapath);
            }
            SettingsManager.settings = model;
            string contents = JsonConvert.SerializeObject(model, Formatting.Indented);
            File.WriteAllText(SettingsManager.jsonpath, contents);
        }

        // Token: 0x060000B6 RID: 182 RVA: 0x000060D8 File Offset: 0x000042D8
        public static SettingsModel Load()
        {
            SettingsModel result;
            if (SettingsManager.settings != null)
            {
                result = SettingsManager.settings;
            }
            else
            {
                if (!Directory.Exists(SettingsManager.datapath))
                {
                    Directory.CreateDirectory(SettingsManager.datapath);
                }
                if (!File.Exists(SettingsManager.jsonpath))
                {
                    SettingsModel model = new SettingsModel();
                    model.Save();
                }
                string value = File.ReadAllText(SettingsManager.jsonpath);
                SettingsModel settingsModel = JsonConvert.DeserializeObject<SettingsModel>(value);
                SettingsManager.settings = settingsModel;
                result = settingsModel;
            }
            return result;
        }

        // Token: 0x04000119 RID: 281
        private static string datapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Project ZOPZ");

        // Token: 0x0400011A RID: 282
        private static string jsonpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Project ZOPZ", "settings.json");

        // Token: 0x0400011B RID: 283
        private static SettingsModel settings = null;
    }
   
}
