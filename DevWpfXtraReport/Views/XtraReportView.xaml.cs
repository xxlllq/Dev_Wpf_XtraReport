using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevWpfXtraReport.Views
{
    /// <summary>
    /// Interaction logic for XtraReportView.xaml
    /// </summary>
    public partial class XtraReportView : UserControl
    {
        public XtraReportView()
        {
            InitializeComponent();
        }

        //打印
        private void XtraReportViewPrint(object sender, ItemClickEventArgs e)
        {

            XtraReport report = new XtraReportDemo();
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            PrintHelper.ShowPrintPreview(this, report);
        }
    }
}
