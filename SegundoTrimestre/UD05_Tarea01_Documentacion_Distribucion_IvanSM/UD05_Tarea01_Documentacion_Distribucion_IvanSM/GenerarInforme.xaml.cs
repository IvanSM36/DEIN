using Microsoft.Reporting.WinForms;
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
using System.Windows.Shapes;


/// <summary>
/// The UD05_Tarea01_Documentacion_Distribucion_IvanSM namespace.
/// </summary>
namespace UD05_Tarea01_Documentacion_Distribucion_IvanSM
{
    /// <summary>
    /// Lógica de interacción para GenerarInforme.xaml
    /// </summary>
    public partial class GenerarInforme : Window
    {

        /// <summary>Initializes a new instance of the <see cref="T:UD05_Tarea01_Documentacion_Distribucion_IvanSM.GenerarInforme" /> class.</summary>
        public GenerarInforme()
        {
            InitializeComponent();
            // Cargamos el informe cuando se carga la ventana
            _reportViewer.Load += ReportViewer_Load;
        }

        private bool _isReportViewerLoaded;


        /// <summary>Handles the Load event of the ReportViewer control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            // Comprobamos si el controlador de informes ya ha sido cargado.
            if (!_isReportViewerLoaded)
            {
                // Se crea un objeto ReportDataSource para almacenar los datos del informe.
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

                // Se crea un objeto TestDBDataSet para almacenar los datos del informe.
                TestDBDataSet dataset = new TestDBDataSet();
                dataset.BeginInit();

                // Nombre del conjunto de datos del informe en nuestro archivo .RDLC
                reportDataSource1.Name = "DataSetStock";
                reportDataSource1.Value = dataset.Stock;

                // Se agrega lo datos al informe.
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                // Se establece la ruta del informe.
                this._reportViewer.LocalReport.ReportPath = "../../Report1.rdlc";

                //Cerramos el objeto TestDBDataSet.
                dataset.EndInit();

                // Creamos un StockTableAdapter para llenar TestDBDataSet con los datos de la tabla Stock.
                TestDBDataSetTableAdapters.StockTableAdapter stockTableAdapter = new TestDBDataSetTableAdapters.StockTableAdapter();

                // Lo ponemos en true para borrar los datos existentes en el TestDBDataSet antes de llenarlo con los nuevos datos.
                stockTableAdapter.ClearBeforeFill = true;

                // Rellenamos con los datos de la tabla Stock.
                stockTableAdapter.Fill(dataset.Stock);

                // Actualizamos el informe
                _reportViewer.RefreshReport();

                // Lo ponemos en true para evitar que el método ReportViewer_Load se llame más de una vez.
                _isReportViewerLoaded = true;
            }
        }
    }
}
