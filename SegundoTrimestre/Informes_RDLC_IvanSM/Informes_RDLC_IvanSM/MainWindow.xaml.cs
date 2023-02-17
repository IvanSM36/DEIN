using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Informes_RDLC_IvanSM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _reportViewer.Load += ReportViewer_Load;
        }

        private bool _isReportViewerLoaded;

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (!_isReportViewerLoaded)
            {
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                TestDBDataSet dataset = new TestDBDataSet();

                dataset.BeginInit();

                reportDataSource1.Name = "DataSetStock"; //Name of the report dataset in our .RDLC file
                reportDataSource1.Value = dataset.Stock;
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this._reportViewer.LocalReport.ReportPath = "../../Report1.rdlc";

                dataset.EndInit();

                TestDBDataSetTableAdapters.StockTableAdapter stockTableAdapter = new TestDBDataSetTableAdapters.StockTableAdapter();

                stockTableAdapter.ClearBeforeFill = true;
                stockTableAdapter.Fill(dataset.Stock);

                _reportViewer.RefreshReport();

                _isReportViewerLoaded = true;
            }
        }
    }
}
