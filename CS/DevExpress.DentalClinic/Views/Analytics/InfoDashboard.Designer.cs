namespace DevExpress.DentalClinic.View {
    partial class InfoDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField3 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField4 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField5 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField6 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField7 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters sqLiteConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.SQLiteConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDashboard));
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry1 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry2 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry3 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry4 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry5 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry6 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry7 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry8 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry9 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeMeasureKey colorSchemeMeasureKey1 = new DevExpress.DashboardCommon.ColorSchemeMeasureKey();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardParameter dashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
            DevExpress.DashboardCommon.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.DashboardCommon.StaticListLookUpSettings();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
            this.chartDashboardItem4 = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "Appointment";
            calculatedField1.Expression = "Iif([Status] = 0, \'Active\', [Status] = 1, \'Finished\', \'Canceled\')";
            calculatedField1.Name = "StatusDisplayName";
            calculatedField2.DataMember = "Appointment";
            calculatedField2.Expression = "Iif([PaymentStatus] = 0, \'Projected\', [PaymentStatus] = 1, \'Collected\', \'Refund\')" +
    "";
            calculatedField2.Name = "PaymentStatusDisplayName";
            calculatedField3.DataMember = "Appointment";
            calculatedField3.Expression = "AGGR(CountDistinct([OID]))";
            calculatedField3.Name = "TotalInvoicesCount";
            calculatedField4.DataMember = "Appointment";
            calculatedField4.Expression = "Iif([Status] = 2, [Status], null)";
            calculatedField4.Name = "MissedApp";
            calculatedField5.DataMember = "Appointment";
            calculatedField5.Expression = "Iif([PaymentMethod] = 0, \'Cash\', \'Card\')";
            calculatedField5.Name = "PaymentMethidDisplayName";
            calculatedField6.DataMember = "Appointment";
            calculatedField6.Expression = "Iif([Parameters.Period]==\'Last Week\', AddDays(Today(), -6), AddDays(Today(), -30)" +
    ")";
            calculatedField6.Name = "Period Start";
            calculatedField7.DataMember = "Appointment";
            calculatedField7.Expression = "Today()";
            calculatedField7.Name = "Period End";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2,
            calculatedField3,
            calculatedField4,
            calculatedField5,
            calculatedField6,
            calculatedField7});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "DentalCabinet";
            sqLiteConnectionParameters1.FileName = "C:\\Code\\v20.2\\Demos.RealLife\\DevExpress.DentalClinic\\Data\\DentalCabinet.db";
            this.dashboardSqlDataSource1.ConnectionParameters = sqLiteConnectionParameters1;
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            table1.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"276\" />";
            table1.Name = "Invoice";
            allColumns1.Table = table1;
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"222\" />";
            table2.Name = "Appointment";
            allColumns2.Table = table2;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Columns.Add(allColumns2);
            selectQuery1.Name = "Appointment";
            relationColumnInfo1.NestedKeyColumn = "Appointment";
            relationColumnInfo1.ParentKeyColumn = "OID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table1;
            join1.Parent = table2;
            join1.SqlJoinType = ((DevExpress.DataAccess.Sql.SqlJoinType)(DevExpress.DataAccess.Sql.SqlJoinType.LeftOuter));
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table1);
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // pieDashboardItem1
            // 
            dimension1.DataMember = "StatusDisplayName";
            this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
            measure1.DataMember = "Appointment_OID";
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            dimension2.DataMember = "Appointment_Date";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            this.pieDashboardItem1.DataItemRepository.Clear();
            this.pieDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.pieDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2");
            this.pieDashboardItem1.DataItemRepository.Add(dimension2, "DataItem4");
            this.pieDashboardItem1.DataMember = "Appointment";
            this.pieDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.pieDashboardItem1.HiddenDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pieDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieDashboardItem1.LabelContentType = ((DevExpress.DashboardCommon.PieValueType)((DevExpress.DashboardCommon.PieValueType.Argument | DevExpress.DashboardCommon.PieValueType.Value)));
            this.pieDashboardItem1.Name = "Appointments";
            this.pieDashboardItem1.PieType = DevExpress.DashboardCommon.PieType.Donut;
            this.pieDashboardItem1.ShowCaption = true;
            this.pieDashboardItem1.ShowPieCaptions = false;
            this.pieDashboardItem1.TooltipContentType = DevExpress.DashboardCommon.PieValueType.None;
            this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // chartDashboardItem4
            // 
            dimension3.DataMember = "Appointment_Date";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            this.chartDashboardItem4.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartDashboardItem4.AxisX.LimitVisiblePoints = true;
            this.chartDashboardItem4.AxisX.TitleVisible = false;
            this.chartDashboardItem4.AxisX.VisiblePointsCount = 7;
            this.chartDashboardItem4.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue;
            this.chartDashboardItem4.ComponentName = "chartDashboardItem4";
            dimension4.DataMember = "Status";
            measure2.DataMember = "Appointment_OID";
            measure2.Name = "Appointment (Count)";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.chartDashboardItem4.DataItemRepository.Clear();
            this.chartDashboardItem4.DataItemRepository.Add(dimension4, "DataItem2");
            this.chartDashboardItem4.DataItemRepository.Add(measure2, "DataItem0");
            this.chartDashboardItem4.DataItemRepository.Add(dimension3, "DataItem1");
            this.chartDashboardItem4.DataMember = "Appointment";
            this.chartDashboardItem4.DataSource = this.dashboardSqlDataSource1;
            this.chartDashboardItem4.FilterString = "[DataItem2] In (0L, 1L)";
            this.chartDashboardItem4.HiddenDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.chartDashboardItem4.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem4.Legend.Visible = false;
            this.chartDashboardItem4.Name = "Visits Statistic";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "visits statistic";
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.AddDataItem("Value", measure2);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem4.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem4.ShowCaption = true;
            // 
            // InfoDashboard
            // 
            colorSchemeEntry1.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-11495173));
            colorSchemeEntry1.DataMember = "Appointment";
            colorSchemeEntry1.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry1.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("StatusDisplayName"), "Active")});
            colorSchemeEntry2.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-1879166));
            colorSchemeEntry2.DataMember = "Appointment";
            colorSchemeEntry2.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry2.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("StatusDisplayName"), "Canceled")});
            colorSchemeEntry3.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-14894985));
            colorSchemeEntry3.DataMember = "Appointment";
            colorSchemeEntry3.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry3.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("StatusDisplayName"), "Finished")});
            colorSchemeEntry4.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-14894985));
            colorSchemeEntry4.DataMember = "Appointment";
            colorSchemeEntry4.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry4.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("PaymentMethidDisplayName"), "Cash")});
            colorSchemeEntry5.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-11495173));
            colorSchemeEntry5.DataMember = "Appointment";
            colorSchemeEntry5.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry5.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("PaymentMethidDisplayName"), "Card")});
            colorSchemeEntry6.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-14894985));
            colorSchemeEntry6.DataMember = "Appointment";
            colorSchemeEntry6.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry6.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("PaymentStatusDisplayName"), "Collected")});
            colorSchemeEntry7.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-7578657));
            colorSchemeEntry7.DataMember = "Appointment";
            colorSchemeEntry7.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry7.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("PaymentStatusDisplayName"), "Projected")});
            colorSchemeEntry8.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-1879166));
            colorSchemeEntry8.DataMember = "Appointment";
            colorSchemeEntry8.DataSource = this.dashboardSqlDataSource1;
            colorSchemeEntry8.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            new DevExpress.DashboardCommon.ColorSchemeDimensionKey(new DevExpress.DashboardCommon.DimensionDefinition("PaymentStatusDisplayName"), "Canceled")});
            colorSchemeEntry9.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-11495173));
            colorSchemeEntry9.DataMember = "Appointment";
            colorSchemeEntry9.DataSource = this.dashboardSqlDataSource1;
            colorSchemeMeasureKey1.MeasureDefinitions.Add(new DevExpress.DashboardCommon.MeasureDefinition("Appointment_OID", DevExpress.DashboardCommon.SummaryType.Count, null, null, null, null));
            colorSchemeEntry9.MeasureKey = colorSchemeMeasureKey1;
            this.ColorScheme.AddRange(new DevExpress.DashboardCommon.ColorSchemeEntry[] {
            colorSchemeEntry1,
            colorSchemeEntry2,
            colorSchemeEntry3,
            colorSchemeEntry4,
            colorSchemeEntry5,
            colorSchemeEntry6,
            colorSchemeEntry7,
            colorSchemeEntry8,
            colorSchemeEntry9});
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pieDashboardItem1,
            this.chartDashboardItem4});
            dashboardLayoutItem1.DashboardItem = this.pieDashboardItem1;
            dashboardLayoutItem1.Weight = 31.321939309382628D;
            dashboardLayoutItem2.DashboardItem = this.chartDashboardItem4;
            dashboardLayoutItem2.Weight = 68.678060690617372D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 32.361733931240657D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            staticListLookUpSettings1.Values = new string[] {
        "Last Week",
        "Last Month"};
            dashboardParameter1.LookUpSettings = staticListLookUpSettings1;
            dashboardParameter1.Name = "Period";
            dashboardParameter1.Type = typeof(string);
            dashboardParameter1.Value = "Last Week";
            this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {
            dashboardParameter1});
            this.Title.Text = "Dashboard";
            this.Title.Visible = false;
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DashboardCommon.PieDashboardItem pieDashboardItem1;
        private DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
        private DashboardCommon.ChartDashboardItem chartDashboardItem4;
    }
}
