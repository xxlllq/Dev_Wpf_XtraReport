using System;
using DevExpress.Mvvm;
using DevWpfXtraReport.DataModel;
using System.Collections.ObjectModel;

namespace DevWpfXtraReport.ViewModels
{
    public class XtraReportViewModel : ViewModelBase
    {
        public XtraReportViewModel()
        {
            //初始化数据源
            XtraReportViewItemsSource = new ObservableCollection<XtraReportDataModel>();
            for (var i = 1; i < 11; i++)
            {
                XtraReportViewItemsSource.Add(new XtraReportDataModel
                {
                    Code = "XR" + i.ToString().PadLeft(4, '0'),
                    Date = DateTime.Now.AddDays(i),
                    Length = i,
                    Width = i,
                    Thick = i,
                    Remark = "备注" + i,
                });
            }
        }


        #region 数据源

        public ObservableCollection<XtraReportDataModel> XtraReportViewItemsSource
        {
            get { return GetProperty(() => XtraReportViewItemsSource); }
            set { SetProperty(() => XtraReportViewItemsSource, value); }
        }

        #endregion
    }
}