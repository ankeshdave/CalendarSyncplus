﻿using System.ComponentModel.Composition;
using CalendarSyncPlus.Common.MetaData;
using CalendarSyncPlus.Services.Tasks.Interfaces;

namespace CalendarSyncPlus.ExchangeWebServices.Task
{
    [Export(typeof(ITaskService)),Export(typeof(IExchangeWebTaskService))]
    [ExportMetadata("ServiceType", ServiceType.EWS)]
    public class ExchangeWebTaskService : IExchangeWebTaskService
    {

        public string TaskServiceName
        {
            get { return "ExchangeWeb"; }
        }

        public System.Threading.Tasks.Task<Domain.Wrappers.TasksWrapper> DeleteReminderTasks(System.Collections.Generic.List<Domain.Models.ReminderTask> reminderTasks, System.Collections.Generic.IDictionary<string, object> taskListSpecificData)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<Domain.Wrappers.TasksWrapper> GetReminderTasksInRangeAsync(System.DateTime startDate, System.DateTime endDate, System.Collections.Generic.IDictionary<string, object> taskListSpecificData)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<Domain.Wrappers.TasksWrapper> AddReminderTasks(System.Collections.Generic.List<Domain.Models.ReminderTask> tasks, 
            System.Collections.Generic.IDictionary<string, object> taskListSpecificData)
        {
            throw new System.NotImplementedException();
        }

        public void CheckTaskListSpecificData(System.Collections.Generic.IDictionary<string, object> taskListSpecificData)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<Domain.Wrappers.TasksWrapper> UpdateReminderTasks(System.Collections.Generic.List<Domain.Models.ReminderTask> reminderTasks,  System.Collections.Generic.IDictionary<string, object> taskListSpecificData)
        {
            throw new System.NotImplementedException();
        }

        public System.Threading.Tasks.Task<bool> ClearCalendar(System.Collections.Generic.IDictionary<string, object> taskListSpecificData)
        {
            throw new System.NotImplementedException();
        }
    }
}