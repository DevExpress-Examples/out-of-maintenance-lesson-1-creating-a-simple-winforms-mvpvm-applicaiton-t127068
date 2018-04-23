using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyMvpvmApplication.ViewModels;
using DevExpress.Mvvm.POCO;

namespace MyMvpvmApplication.Views {
    public partial class TaskCollectionView : UserControl {
        public TaskCollectionView() {
            InitializeComponent();
            viewModelCore = ViewModelSource.Create<TaskCollectionViewModel>();
        }
        TaskCollectionViewModel viewModelCore;
        public TaskCollectionViewModel ViewModel {
            get { return viewModelCore; }
        }

        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            taskBindingSource.DataSource = ViewModel.Tasks;
        }
    }
}
