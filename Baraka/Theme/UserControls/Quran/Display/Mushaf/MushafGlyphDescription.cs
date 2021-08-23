﻿using Baraka.Data.Descriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraka.Theme.UserControls.Quran.Display.Mushaf
{
    // This is the class describing each glyph from the Madani mushaf
    // The glyph is then displayed as a word or a mark according to the font of its associated page
    // Fonts were found from quran.com
    public class MushafGlyphDescription
    {
        public char DecodedData { get; private set; } // Unicode glyph
        public VerseDescription AssociatedVerse { get; private set; } // Seed is 1:1
        public MushafGlyphType Type { get; private set; }

        public MushafGlyphDescription(char decodedData, VerseDescription associatedVerse, MushafGlyphType type)
        {
            DecodedData = decodedData;
            AssociatedVerse = associatedVerse;
            Type = type;
        }
    }
}