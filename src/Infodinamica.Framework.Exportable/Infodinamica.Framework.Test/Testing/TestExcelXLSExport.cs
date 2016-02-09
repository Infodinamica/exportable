﻿using System;
using System.Collections.Generic;
using Infodinamica.Framework.Exportable.Engines;
using Infodinamica.Framework.Exportable.Engines.Excel;
using Infodinamica.Framework.Exportable.Tools;
using Infodinamica.Framework.Test.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infodinamica.Framework.Test.Testing
{
    [TestClass]
    public class TestExcelXLSExport
    {
        [TestMethod]
        public void ExportWithPlainClass()
        {
            IList<DummyPerson> dummyPeople = new List<DummyPerson>();
            for (int index = 0; index < 30; index++)
            {
                dummyPeople.Add(DummyFactory.CreateDummyPerson());
            }

            IExportEngine engine = new ExcelExportEngine();
            (engine as IExcelExportEngine).SetFormat(ExcelVersion.XLS);
            engine.AddData(dummyPeople);
            var fileName = Guid.NewGuid().ToString() + "-plain-class.xls";
            var filePath = @"E:\Github\Framework\Exportable\src\Infodinamica.Framework.Exportable\TestElements\" + fileName;
            engine.Export(filePath);
        }

        [TestMethod]
        public void ExportWithPlainClassAndSheetName()
        {
            IList<DummyPerson> dummyPeople = new List<DummyPerson>();
            for (int index = 0; index < 30; index++)
            {
                dummyPeople.Add(DummyFactory.CreateDummyPerson());
            }

            IExcelExportEngine engine = new ExcelExportEngine();
            engine.SetFormat(ExcelVersion.XLS);
            engine.AddData(dummyPeople, "Dummy People");
            var fileName = Guid.NewGuid().ToString() + "-plain-class-sheets-names.xls";
            var filePath = @"E:\Github\Framework\Exportable\src\Infodinamica.Framework.Exportable\TestElements\" + fileName;
            engine.Export(filePath);
        }

        [TestMethod]
        public void ExportWithAttributes()
        {
            IList<DummyPersonWithAttributes> dummyPeople = new List<DummyPersonWithAttributes>();
            for (int index = 0; index < 30; index++)
            {
                dummyPeople.Add(DummyFactory.CreateDummyPersonWithAttributes());
            }

            IExportEngine engine = new ExcelExportEngine();
            (engine as IExcelExportEngine).SetFormat(ExcelVersion.XLS);
            engine.AddData(dummyPeople);
            var fileName = Guid.NewGuid().ToString() + "-with-attributes.xls";
            var filePath = @"E:\Github\Framework\Exportable\src\Infodinamica.Framework.Exportable\TestElements\" + fileName;
            engine.Export(filePath);
        }

        [TestMethod]
        public void ExportWithAttributesAndSomeSheetsNames()
        {
            IList<DummyPersonWithAttributes> dummyPeopleSheet1 = new List<DummyPersonWithAttributes>();
            IList<DummyPersonWithAttributes> dummyPeopleSheet2 = new List<DummyPersonWithAttributes>();
            IList<DummyPersonWithAttributes> dummyPeopleSheet3 = new List<DummyPersonWithAttributes>();
            
            for (int index = 0; index < 30; index++)
            {
                dummyPeopleSheet1.Add(DummyFactory.CreateDummyPersonWithAttributes());
            }

            for (int index = 0; index < 50; index++)
            {
                dummyPeopleSheet2.Add(DummyFactory.CreateDummyPersonWithAttributes());
            }

            for (int index = 0; index < 25; index++)
            {
                dummyPeopleSheet3.Add(DummyFactory.CreateDummyPersonWithAttributes());
            }

            IExcelExportEngine engine = new ExcelExportEngine();
            engine.SetFormat(ExcelVersion.XLS);
            engine.AddData(dummyPeopleSheet1, "Sheet Number 1");
            engine.AddData(dummyPeopleSheet2, "Another Sheet");
            engine.AddData(dummyPeopleSheet3, "Custom Name");
            var fileName = Guid.NewGuid().ToString() + "-with-attributes-some-sheets.xls";
            var filePath = @"E:\Github\Framework\Exportable\src\Infodinamica.Framework.Exportable\TestElements\" + fileName;
            engine.Export(filePath);
        }

        [TestMethod]
        public void ExportWithMixAttributes()
        {
            IList<DummyPersonWIthSomeAttributes> dummyPeople = new List<DummyPersonWIthSomeAttributes>();
            for (int index = 0; index < 30; index++)
            {
                dummyPeople.Add(DummyFactory.CreateDummyPersonWIthSomeAttributes());
            }

            IExportEngine engine = new ExcelExportEngine();
            (engine as IExcelExportEngine).SetFormat(ExcelVersion.XLS);
            engine.AddData(dummyPeople);
            var fileName = Guid.NewGuid().ToString() + "-mix-class.xls";
            var filePath = @"E:\Github\Framework\Exportable\src\Infodinamica.Framework.Exportable\TestElements\" + fileName;
            engine.Export(filePath);
        }

        [TestMethod]
        public void ExportIntensiveUsage()
        {
            IList<DummyPerson> dummyPeople = new List<DummyPerson>();
            for (int index = 0; index < 65000; index++)
            {
                dummyPeople.Add(DummyFactory.CreateDummyPerson());
            }

            IExportEngine engine = new ExcelExportEngine();
            (engine as IExcelExportEngine).SetFormat(ExcelVersion.XLS);
            engine.AddData(dummyPeople);
            var fileName = Guid.NewGuid().ToString() + "-intensive.xls";
            var filePath = @"E:\Github\Framework\Exportable\src\Infodinamica.Framework.Exportable\TestElements\" + fileName;
            engine.Export(filePath);
        }
    }
}
