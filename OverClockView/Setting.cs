using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverClockView
{
    public class SettingJson
    {
        public float FontSize { get; set; }
        public string FontColorCode { get; set; }
        public int WindowPosX { get; set; }
        public int WindowPosY { get; set; }
    }
    public class Setting
    {
        public float FontSize { get; set; }
        public Color FontColor { get; set; }
        public Point WindowPoint { get; set; }
        public Setting()
        {
            string json = File.ReadAllText("setting.json");
            SettingJson? setting = System.Text.Json.JsonSerializer.Deserialize<SettingJson>(json);
            if (setting == null) throw new Exception();
            FontSize = setting.FontSize;
            FontColor = ColorTranslator.FromHtml(setting.FontColorCode);
            WindowPoint = new(setting.WindowPosX, setting.WindowPosY);
        }
    }
}
