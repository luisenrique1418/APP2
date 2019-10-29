using System;
using System.Web.UI.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP2
{
    public partial class Grafica : System.Web.UI.Page
    {
        DataTable TblAlumnos = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            CreaGraficaFrutas();

            CreaTablaAlumnos();
            RellenaTablaAlumnos();
            CreaGraficaAlumnos();

            /*if (!IsPostBack)
            {
                CmbTipoGrafica.DataSource = Enum.GetNames(typeof(SeriesChartType));
                CmbTipoGrafica.DataBind();
            }*/
        }

        private void CreaTablaAlumnos()
        {
            TblAlumnos.Columns.AddRange(new DataColumn[3] {
                new DataColumn("Control", typeof(string)),
                new DataColumn("Nombre", typeof(string)),
                new DataColumn("Calificacion", typeof(double))});

        }

        private void RellenaTablaAlumnos()
        {
            TblAlumnos.Rows.Add(new Object[] { "16130125", "JOSE PEREZ", 100 });
            TblAlumnos.Rows.Add(new Object[] { "16130126", "ALAN ROBLES", 95 });
            TblAlumnos.Rows.Add(new Object[] { "16130127", "LAURA RUIZ", 85 });
            TblAlumnos.Rows.Add(new Object[] { "16130128", "CARMEN RAMIREZ", 97 });
            TblAlumnos.Rows.Add(new Object[] { "16130129", "ANA LUISA VARGAS", 80 });
        }


        private void CreaGraficaAlumnos()
        {
            Alumnos.Titles.Add("Resultados de Unidad III Desarrollo .Net");
            Alumnos.Series["Series1"].XValueMember = "nombre";
            Alumnos.Series["Series1"].YValueMembers = "calificacion";

            Alumnos.DataSource = TblAlumnos;
            Alumnos.DataBind();

            Alumnos.Series[0].IsValueShownAsLabel = true;
            Alumnos.Series[0].Label = "#VALY{N2}";
            Alumnos.Series[0].LegendText = "#AXISLABEL";

            Alumnos.Legends.Add("Legend1");
            Alumnos.Legends[0].Enabled = true;
            Alumnos.Legends[0].Docking = Docking.Bottom;
            Alumnos.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
            Alumnos.Series[0].LegendText = "CALIFICACION DE ALUMNOS";
        }

        private void CreaGraficaFrutas()
        {
            string[] x = new string[4] { "Mango", "Apple", "Orange", "Banana" };
            int[] y = new int[4] { 200, 112, 55, 96 };

            Ventas.Series[0].Points.DataBindXY(x, y);
            Ventas.Series[0].ChartType = SeriesChartType.Pie;
            Ventas.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Ventas.Legends[0].Enabled = true;
        }

        protected void BtnGrafica_Click(object sender, EventArgs e)
        {
            Alumnos.Visible = true;
            Alumnos.Titles.Add("Resultados de Unidad III Desarrollo .Net");
            Alumnos.Series["Prueba"].XValueMember = "nombre";
            Alumnos.Series["Prueba"].YValueMembers = "calificacion";

            Alumnos.DataSource = TblAlumnos;
            Alumnos.DataBind();

            Alumnos.Series[0].IsValueShownAsLabel = true;
            Alumnos.Series[0].Label = "#VALY{N2}";
            Alumnos.Series[0].LegendText = "#AXISLABEL";

            Alumnos.Legends.Add("Leyenda");
            Alumnos.Legends[0].Enabled = true;
            Alumnos.Legends[0].Docking = Docking.Bottom;
            Alumnos.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            /*Alumnos.Series["Prueba"].ChartTypeName = CmbTipoGrafica.SelectedValue;
            Alumnos.ChartAreas[0].Area3DStyle.Enable3D = ChkAplicar.Checked;
            Alumnos.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(ChkAngulo.SelectedValue);*/

        }

        /*protected void BtnSaveImg_Click(object sender, EventArgs e)
        {
            Grafica.SaveImage(Server.MapPath("~/saveimgs/mychart.png"), ChartImageFormat.Jpeg);
        }

        protected void BtnSavePDF_Click(object sender, EventArgs e)
        {
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            using (MemoryStream stream = new MemoryStream())
            {
                ChartCalificaciones.SaveImage(stream, ChartImageFormat.Png);
                iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(stream.GetBuffer());
                chartImage.ScalePercent(75f);
                pdfDoc.Add(chartImage);
                pdfDoc.Close();

                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=Chart.pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Write(pdfDoc);
                Response.End();
            }
        }*/
    }
}