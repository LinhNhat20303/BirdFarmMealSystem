﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.XtraGantt;
using DevExpress.XtraGantt.Chart;
using DevExpress.XtraGantt.Chart.Item.Task;
using DevExpress.HTML.Demos.Helpers;
using DevExpress.Utils.Html;

namespace DevExpress.HTML.Demos {
    public partial class GanttControlModule: TutorialControlBase {
        public GanttControlModule() {
            InitializeComponent();
            LoadData();
            Setup();
            //
            ganttControl1.QueryItemTemplate += GanttControl1_QueryItemTemplate;
            ganttControl1.CustomizeItem += GanttControl1_CustomizeItemTemplate;
        }

        void GanttControl1_CustomizeItemTemplate(object sender, CustomizeItemEventArgs e) {
            GanttChartTaskInfo ti = e.Item as GanttChartTaskInfo;
            if(ti == null) return;
            Color color = (Color)ti.Node.GetValue("Color");
            switch (e.ItemType) {
                case GanttChartItemType.Task:
                case GanttChartItemType.SummaryTask:
                    var task = e.ElementInfo.FindElementById("task");
                    if(task != null) {
                        task.Style.SetProperty("background-color", color.Name);
                        task.Style.SetProperty("border-radius", "4px");
                    }
                    break;
                case GanttChartItemType.TextLabel:
                    var label = e.ElementInfo.FindElementById("label");
                    if(label != null) {
                        label.Style.SetProperty("border-color", color.Name);
                        label.Style.SetProperty("color", color.Name);
                    }
                    break;
            }
        }

        void GanttControl1_QueryItemTemplate(object sender, QueryItemTemplateEventArgs e) {
            switch(e.ItemType) {
                case GanttChartItemType.Task:
                case GanttChartItemType.SummaryTask:
                    e.Template.Assign(TaskTemplate);
                    break;
                case GanttChartItemType.Progress:
                case GanttChartItemType.SummaryTaskProgress:
                    e.Template.Assign(TaskProgressTemplate);
                    break;
                case GanttChartItemType.TextLabel:
                    e.Template.Assign(TaskTextLabelTemplate);
                    break;
            }
        }
        #region Initialization
        void Setup() {
            ganttControl1.OptionsMainTimeRuler.Unit = GanttTimescaleUnit.Hour;
            ganttControl1.OptionsMainTimeRuler.Count = 6;
            ganttControl1.ExpandAll();
            templateViewer.Fill(ganttControl1);
        }
        void LoadData() {
            ganttControl1.TreeListMappings.KeyFieldName = "Id";
            ganttControl1.TreeListMappings.ParentFieldName = "ParentId";
            ganttControl1.ChartMappings.StartDateFieldName = "StartDate";
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name";
            ganttControl1.ChartMappings.FinishDateFieldName = "FinishDate";
            ganttControl1.ChartMappings.DurationFieldName = "Duration";
            ganttControl1.ChartMappings.ProgressFieldName = "Progress";
            ganttControl1.ChartMappings.PredecessorsFieldName = "Predecessors";
            ganttControl1.ChartMappings.TextFieldName = "Resource";
            var tasks = GanttControlTask.LoadData();
            ganttControl1.DataSource = tasks;
            ganttControl1.ScheduleFromStartDate(tasks[0].StartDate);
        }
        #endregion
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] {"GanttControlModule"}; }
        }
    }
}
