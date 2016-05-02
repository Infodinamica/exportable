﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infodinamica.Framework.Exportable.Attribute;
using Infodinamica.Framework.Exportable.Tools;

namespace Infodinamica.Framework.Test.Tools
{
    [ExportableExcelHeader(BackColor = "#0FF707", BorderColor = "#0737F7", FontColor = "#FFFFFF", FontName = "Arial", FontSize = 30)]
    class DummyPersonWithHeaderAttribute
    {
        public string Name { get; set; }

        [Exportable(1, "-- Birth Date --", FieldValueType.Date, "MM-yyyy")]
        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        [Exportable(4, "Is Adult", FieldValueType.Bool)]
        public bool IsAdult { get; set; }
    }
}
