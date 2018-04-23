using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MyMvpvmApplication.Model;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace MyMvpvmApplication.ViewModels {
    public class TaskCollectionViewModel {
        IList<Task> tasksCore;

        public TaskCollectionViewModel() {
            tasksCore = new BindingList<Task> { 
                new Task(){ Subject="Test Task", Description = "Test Description"}
            };
        }
        public IList<Task> Tasks {
            get { return tasksCore; }
        }
    }
}
