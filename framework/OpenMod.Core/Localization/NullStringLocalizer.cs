﻿using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Extensions.Localization;

namespace OpenMod.Core.Localization
{
    public class NullStringLocalizer : IStringLocalizer
    {
        private static NullStringLocalizer m_Instance;

        public static NullStringLocalizer Instance
        {
            get { return m_Instance ??= new NullStringLocalizer(); }
        }

        private NullStringLocalizer()
        {
            // private constructor
        }

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            return Enumerable.Empty<LocalizedString>();
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            return this;
        }

        public LocalizedString this[string name]
        {
            get { return new LocalizedString(name, name, true); }

        }

        public LocalizedString this[string name, params object[] arguments]
        {
            get
            {
                return new LocalizedString(name, name, true);
            }
        }
    }
}