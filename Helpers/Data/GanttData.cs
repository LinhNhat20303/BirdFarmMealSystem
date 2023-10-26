﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
#if !DXCORE3
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DevAV;
using DevExpress.Internal;
using DevExpress.LookAndFeel;

namespace DevExpress.HTML.Demos.Helpers {
    public class GanttControlTask {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public TimeSpan Duration { get; set; }
        public double Progress { get; set; }
        public string Employee { get; set; }
        public Image EmployeePhoto { get; set; }
        public string Resource { get; set; }
        public Color Color { get; set; }
        public IList<int> Predecessors { get; } = new List<int>();
        public static IList<GanttControlTask> LoadData() => TaskStorage.LoadData();
    }

    public class TaskStorage {
#if DXCORE3
        static string GetDatabaseFilePath() {
            var filePath = DevAVDataDirectoryHelper.GetFile("devav.sqlite3", DevAVDataDirectoryHelper.DataFolderName);
            try {
                var attributes = File.GetAttributes(filePath);
                if(attributes.HasFlag(FileAttributes.ReadOnly)) {
                    File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                }
            }
            catch { }
            return filePath;
        }
#endif
        static Dictionary<string, Employee> employeesCore = new Dictionary<string, Employee>();
        public static IList<GanttControlTask> LoadData() {
#if DXCORE3
            DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3", DevAVDataDirectoryHelper.DataFolderName)}");
#else
            DevAVDb devAvDb = new DevAVDb();
#endif
            devAvDb.Employees.Load();
            employeesCore = devAvDb.Employees.Local.ToDictionary(employee => employee.FullName);
            var tasks = new List<GanttControlTask>();
            GanttControlTask softwareDevelopment = CreateTask(tasks, "Software Development", 0, -1, DateTime.Now, 1, 24, "John Heart", DXSkinColors.FillColors.Danger, "Management");
            GanttControlTask analyzeRequirements = CreateTask(tasks, "Analyze Requirements", 1, softwareDevelopment.Id, softwareDevelopment.StartDate, 1, 100, "Ed Holmes", DXSkinColors.FillColors.Primary, "Analyst");
            GanttControlTask developFunctionalSpecifications = CreateTask(tasks, "Develop Functional Specifications", 2, softwareDevelopment.Id, analyzeRequirements.FinishDate, 1, 100, "Robert Reagan", DXSkinColors.FillColors.Warning,"Project Manager", 1);
            GanttControlTask developSoftware = CreateTask(tasks, "Develop Software", 3, softwareDevelopment.Id, developFunctionalSpecifications.FinishDate, 5, 40, "Brett Wade", DXSkinColors.FillColors.Question,"Developer", developFunctionalSpecifications.Id);
            GanttControlTask developHelpSystem = CreateTask(tasks, "Develop Help System", 4, softwareDevelopment.Id, developFunctionalSpecifications.FinishDate, 1, 90, "Greta Sims", DXSkinColors.FillColors.Success, "Developer", developFunctionalSpecifications.Id);
            GanttControlTask developUserManuals = CreateTask(tasks, "Develop User Manuals", 5, softwareDevelopment.Id, developHelpSystem.FinishDate, 1, 0, "Mary Stern", DXSkinColors.FillColors.Warning, "Developer", developHelpSystem.Id);
            GanttControlTask testSoftware = CreateTask(tasks, "Test Software", 6, softwareDevelopment.Id, developSoftware.FinishDate, 2, 0, "Samantha Piper", DXSkinColors.FillColors.Primary,"Testers", developSoftware.Id);
            GanttControlTask deployBeta = CreateTask(tasks, "Deploy Beta", 7, softwareDevelopment.Id, testSoftware.FinishDate, 0, 0, "John Heart", DXSkinColors.FillColors.Danger, "Management", testSoftware.Id);
            GanttControlTask collectFeedback = CreateTask(tasks, "Collect Feedback", 8, softwareDevelopment.Id, deployBeta.FinishDate, 2, 0, "Robert Reagan", DXSkinColors.FillColors.Warning, "Project Manager", deployBeta.Id);
            GanttControlTask fixBugs = CreateTask(tasks, "Fix Bugs", 9, softwareDevelopment.Id, collectFeedback.FinishDate, 2, 0, "Robert Reagan", DXSkinColors.FillColors.Warning, "Project Manager", collectFeedback.Id);
            GanttControlTask incorporateFeedBack = CreateTask(tasks, "Incorporate Feedback", 10, softwareDevelopment.Id, collectFeedback.FinishDate, 3, 0, "Ed Holmes", DXSkinColors.FillColors.Primary, "Analyst", collectFeedback.Id);
            GanttControlTask releaseSoftware = CreateTask(tasks, "Release Software", 11, softwareDevelopment.Id, incorporateFeedBack.FinishDate, 2, 0, "Brett Wade", DXSkinColors.FillColors.Question, "Developer", fixBugs.Id, incorporateFeedBack.Id);
            GanttControlTask createSoftwareMaintenanceTeam = CreateTask(tasks, "Create Software Maintenance Team", 12, softwareDevelopment.Id, deployBeta.FinishDate, 1, 0, "John Heart", DXSkinColors.FillColors.Danger, "Management", developSoftware.Id);
            GanttControlTask softwareDevelopmentComplete = CreateTask(tasks, "Software Development Complete", 13, softwareDevelopment.Id, releaseSoftware.FinishDate, 0, 0, "John Heart", DXSkinColors.FillColors.Danger, "Management", releaseSoftware.Id);
            softwareDevelopment.FinishDate = softwareDevelopmentComplete.FinishDate;
            TryUpdateDates(tasks);
            return tasks;
        }
        static GanttControlTask CreateTask(ICollection<GanttControlTask> tasks, string name, int id, int parentId, DateTime start, int duration, double progress, string employee, Color color, string resource, params int[] predecessors) {
            GanttControlTask ganttControlTask = new GanttControlTask();
            ganttControlTask.Id = id;
            ganttControlTask.ParentId = parentId;
            ganttControlTask.Name = name;
            ganttControlTask.StartDate = start;
            ganttControlTask.FinishDate = start + TimeSpan.FromDays(duration);
            ganttControlTask.Duration = TimeSpan.FromDays(duration);
            ganttControlTask.Progress = progress;
            ganttControlTask.Employee = employee;
            ganttControlTask.Color = color;
            ganttControlTask.EmployeePhoto = LoadPhoto(employee);
            ganttControlTask.Resource = resource; 
            for(int i = 0; i < predecessors.Length; i++) {
                int pid = predecessors[i];
                if(pid < 0) continue;
                ganttControlTask.Predecessors.Add(pid);
            }
            tasks.Add(ganttControlTask);
            return ganttControlTask;
        }
        static Image LoadPhoto(string resourceName) {
            Employee employee = null;
            if(employeesCore.TryGetValue(resourceName, out employee))
                return employee.Photo;
            return null;
        }
        static void TryUpdateDates(IList<GanttControlTask> tasks) {
            if(tasks != null && tasks.Count > 0) {
                DateTime actualProjectStart = CalcActualProjectStart();
                DateTime projectStart = tasks[0].StartDate;
                for(int i = 0; i < tasks.Count; i++) {
                    var task = tasks[i];
                    task.StartDate = actualProjectStart + TimeSpan.FromTicks(task.StartDate.Ticks - projectStart.Ticks);
                    task.FinishDate = actualProjectStart + TimeSpan.FromTicks(task.FinishDate.Ticks - projectStart.Ticks);
                }
            }
        }
        static DateTime CalcActualProjectStart() {
            DateTime now = DateTime.Now;
            return now + TimeSpan.FromDays(4 - (int) now.DayOfWeek);
        }
    }
}
