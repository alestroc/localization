using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace test1.Models
{
    public class CultureSwitcherModel
    {
        public CultureInfo CurrentUICulture { get; set; }
        public List<CultureInfo> SupportedCultures { get; set; }
    }
}
