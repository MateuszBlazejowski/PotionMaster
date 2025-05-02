using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionMaster
{
    public class PastPour
    {
        public Vial source;
        public Vial sink;
        public int pouredColorsNumber;
        public PastPour(Vial source, Vial sink, int pouredColorsNumber)
        {
            this.source = source;
            this.sink = sink;
            this.pouredColorsNumber = pouredColorsNumber;
        }
    }
    public class MenuColors : ProfessionalColorTable
    {
        public ColorPreset colorTheme;

        public MenuColors(ColorPreset colorTheme)
        {
            this.colorTheme = colorTheme;
        }

        public override Color MenuItemSelected => colorTheme.AccentColor;
        public override Color MenuItemSelectedGradientBegin => colorTheme.AccentColor;
        public override Color MenuItemSelectedGradientEnd => colorTheme.AccentColor;
        public override Color MenuItemPressedGradientBegin => colorTheme.AccentColor;
        public override Color MenuItemPressedGradientEnd => colorTheme.AccentColor;
        public override Color MenuItemBorder => colorTheme.Background;
    }
    public class ColorPreset
    {
        public Color Background { get; set; }
        public Color ButtonBackground { get; set; }
        public Color TextColor { get; set; }
        public Color AccentColor { get; set; }  // Used for MenuStrip or other accent items

        public ColorPreset(Color background, Color button, Color text, Color accent)
        {
            Background = background;
            ButtonBackground = button;
            TextColor = text;
            AccentColor = accent;
        }
    }

    public static class Common
    {
        public static readonly int MinVialsCount = 4;
        public static readonly int MaxVialsCount = 25;
        public static readonly int MinSegmentsCount = 2;
        public static readonly int MaxSegmentsCount = 10;

        public static readonly ColorPreset Light = new ColorPreset(
       background: Color.White,
       button: Color.FromKnownColor(KnownColor.Control),
       text: Color.Black,
       accent: Color.Pink // Used for MenuStrip
   );

        public static readonly ColorPreset Dark = new ColorPreset(
            background: Color.FromArgb(60, 60, 60),
            button: Color.FromArgb(40, 40, 40),
            text: Color.White,
            accent: Color.Pink // Used for MenuStrip
        );
    }
}
