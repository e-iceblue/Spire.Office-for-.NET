using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using Spire.Pdf.Graphics;

namespace GridSL
{
    internal class PdfInternalFont
    {
        private PdfTrueTypeFont internalFont = null;

        public PdfInternalFont(Font font)
        {
            using (Stream stream = this.GetFontStream(font))
            {
                this.internalFont = new PdfTrueTypeFont(stream, font.Size, font.Style);
            }
        }

        public PdfInternalFont(Font font, bool unicode)
        {
            using (Stream stream = this.GetFontStream(font))
            {
                this.internalFont = new PdfTrueTypeFont(stream, font.Size, font.Style);
            }
        }

        public static implicit operator PdfTrueTypeFont(PdfInternalFont font)
        {
            return font.internalFont;
        }

        private Stream GetFontStream(Font font)
        {
            String fontFileName = null;
            if (font.Name == "Arial")
            {
                int advancedStyle = (int)(PdfFontStyle.Strikeout | PdfFontStyle.Underline);
                advancedStyle = advancedStyle & (int)font.Style;
                int normalStyle = (int)(PdfFontStyle.Regular | PdfFontStyle.Bold | PdfFontStyle.Italic);
                normalStyle = normalStyle & (int)font.Style;
                PdfFontStyle style = (PdfFontStyle)normalStyle;

                if (style == PdfFontStyle.Regular)
                {
                    fontFileName = "arial.ttf";
                }
                else if (style == PdfFontStyle.Bold)
                {
                    fontFileName = "arialbd.ttf";
                }
                else if (style == PdfFontStyle.Italic)
                {
                    fontFileName = "ariali.ttf";
                }
                else if (style == (PdfFontStyle.Bold | PdfFontStyle.Italic))
                {
                    fontFileName = "arialbi.ttf";
                }
                font.Style = (PdfFontStyle)advancedStyle;
            }

            if (fontFileName == null)
            {
                throw new ArgumentException("fontName");
            }

            return GetFontStream(fontFileName);
        }

        private Stream GetFontStream(String fontFileName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            foreach (String resName in assembly.GetManifestResourceNames())
            {
                if (resName.EndsWith(fontFileName))
                {
                    return assembly.GetManifestResourceStream(resName);
                }
            }
            return null;
        }
    }
}
namespace System.Drawing
{
    public enum FontStyle
    {
        // Summary:
        //     Normal text.
        Regular = 0,
        //
        // Summary:
        //     Bold text.
        Bold = 1,
        //
        // Summary:
        //     Italic text.
        Italic = 2,
        //
        // Summary:
        //     Underlined text.
        Underline = 4,
        //
        // Summary:
        //     Text with a line through the middle.
        Strikeout = 8,
    }

    public class Font
    {
        public Font(String name, float size)
            : this(name, size, FontStyle.Regular)
        {
        }

        public Font(String name, float size, FontStyle style)
        {
            this.Name = name;
            this.Size = size;
            this.Style = GetPdfFontStyle(style);
        }

        private PdfFontStyle GetPdfFontStyle(FontStyle style)
        {
            return (PdfFontStyle)Enum.Parse(typeof(PdfFontStyle), style.ToString(), false);
        }

        internal String Name { get; set; }
        internal float Size { get; set; }
        internal PdfFontStyle Style { get; set; }
    }
}
