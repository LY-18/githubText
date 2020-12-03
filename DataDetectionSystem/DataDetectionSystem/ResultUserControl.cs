using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataDetectionSystem
{
    public partial class ResultUserControl : UserControl
    {
        public static float errorPers = 0;
        public ResultUserControl()
        {
            InitializeComponent();
        }

        private void ResultUserControl_Load(object sender, EventArgs e)
        {
            Results();
        }

        public static void ins()
        {
            ResultUserControl resultUserControl = new ResultUserControl();
            resultUserControl.Results();
            errorPers = resultUserControl.errorPer();
        }
        private void Results()
        {
            Dictionary<string, object> testResult = Index.TestResult;

            if (testResult.Count > 0)
            {
                //文件总数
                if (testResult.ContainsKey("Count"))
                {
                    object count = testResult["Count"];
                    if (count == null)
                        count = 0;
                    lblCount.Text += count;
                }
                //文件大小
                if (testResult.ContainsKey("Length"))
                {
                    object oLength = testResult["Length"];
                    if (oLength == null)
                        oLength = 0;
                    long length = Convert.ToInt64(oLength);
                    if (length > 1024)
                    {
                        length = length / 1024;
                        if (length > 1024)
                        {
                            length = length / 1024;
                            lblLength.Text += length + "MB";
                        }
                        else
                            lblLength.Text += length + "KB";
                    }
                    else
                        lblLength.Text += length + "B";
                }
                //通过文件数量
                if (testResult.ContainsKey("PassedCount"))
                {
                    object passedCount = testResult["PassedCount"];
                    if (passedCount == null)
                        passedCount = 0;
                    lblPassedCount.Text += passedCount;
                }
                //通过文件大小
                if (testResult.ContainsKey("PassedLength"))
                {
                    object oPassedLength = testResult["PassedLength"];
                    if (oPassedLength == null)
                        oPassedLength = 0;
                    long passedLength = Convert.ToInt64(oPassedLength);
                    if (passedLength > 1024)
                    {
                        passedLength = passedLength / 1024;
                        if (passedLength > 1024)
                        {
                            passedLength = passedLength / 1024;
                            lblPassedLength.Text += passedLength + "MB";
                        }
                        else
                            lblPassedLength.Text += passedLength + "KB";
                    }
                    else
                        lblPassedLength.Text += passedLength + "B";
                }
                //疑似文件容量
                if (testResult.ContainsKey("FailLength"))
                {
                    object oFailLength = testResult["FailLength"];
                    if (oFailLength == null)
                        oFailLength = 0;
                    long failLength = Convert.ToInt64(oFailLength);
                    if (failLength > 1024)
                    {
                        failLength = failLength / 1024;
                        if (failLength > 1024)
                        {
                            failLength = failLength / 1024;
                            lblFailLength.Text += failLength + "MB";
                        }
                        else
                            lblFailLength.Text += failLength + "KB";
                    }
                    else
                        lblFailLength.Text += failLength + "B";
                }
                //失败文件数
                if (testResult.ContainsKey("FailCount"))
                {
                    object failCount = testResult["FailCount"];
                    if (failCount == null)
                        failCount = 0;
                    lblFailCount.Text += failCount;
                }
                //重复文件
                if (testResult.ContainsKey("RepeatFilesMD5"))
                {
                    object oRepeatFilesMD5 = testResult["RepeatFilesMD5"];
                    if (oRepeatFilesMD5 != null)
                    {
                        List<string> repeatFilesMD5 = oRepeatFilesMD5 as List<string>;
                        if (repeatFilesMD5 != null)
                            lblRepeatCount.Text += repeatFilesMD5.Count;
                    }
                }
                else if (testResult.ContainsKey("RepeatFiles"))
                {
                    object oRepeatFiles = testResult["RepeatFiles"];
                    if (oRepeatFiles != null)
                    {
                        List<string> repeatFiles = oRepeatFiles as List<string>;
                        if (repeatFiles != null)
                            lblRepeatCount.Text += repeatFiles.Count;
                    }
                }
                //缺页漏页情况
                if (testResult.ContainsKey("ShortOfPages"))
                {
                    object oArchiveShortOfPages = testResult["ShortOfPages"];
                    if (oArchiveShortOfPages != null)
                    {
                        Dictionary<string, List<int>> archiveShortOfPages = oArchiveShortOfPages as Dictionary<string, List<int>>;
                        List<int> shortOfPages;
                        int shortOfPageCount = 0;
                        if (archiveShortOfPages != null)
                        {
                            foreach (string archiveId in archiveShortOfPages.Keys)
                            {
                                shortOfPages = archiveShortOfPages[archiveId];
                                if (shortOfPages != null)
                                {
                                    shortOfPageCount += shortOfPages.Count;
                                }
                            }
                            lblShortOfPages.Text += shortOfPageCount.ToString();
                        }
                    }
                }
                //空白页
                if (testResult.ContainsKey("nullpagenum"))
                {
                    object failCount = testResult["nullpagenum"];
                    if (failCount == null)
                        failCount = 0;
                    lblNullPage.Text += failCount;
                }
                //条目检测情况
                if (testResult.ContainsKey("DirectoriesErrors"))
                {
                    object failCount = testResult["DirectoriesErrors"];
                    if (failCount == null)
                        failCount = 0;
                    label11.Text += (failCount as Dictionary<string, Dictionary<string, Dictionary<string, string>>>).Count.ToString();
                }
                //dpi检测情况
                if (testResult.ContainsKey("DpiNum"))
                {
                    object failCount = testResult["DpiNum"];
                    if (failCount == null)
                        failCount = 0;
                    lblDPI.Text += failCount;
                }
                //图像倾斜度检测
                if (testResult.ContainsKey("ItalicNum"))
                {
                    object failCount = testResult["ItalicNum"];
                    if (failCount == null)
                        failCount = 0;
                    lblDPI.Text += failCount;
                }




                Index.TestResults = "文件总述" + "\r\n"
                                  + lblCount.Text + "\r\n"
                                  + lblLength.Text + "\r\n"
                                  + lblPassedCount.Text + "\r\n"
                                  + lblPassedLength.Text + "\r\n"
                                  + lblFailLength.Text + "\r\n\r\n"
                                  + "异常文件" + "\r\n"
                                  + lblFailCount.Text + "\r\n"
                                  + lblRepeatCount.Text + "\r\n"
                                  + lblNullPage.Text + "\r\n\r\n"
                                  + "通过率：" + Passcent() * 100 + "%" + "\r\n";
                //IndexWindow.testErrorPer += errorPer();
                try
                {
                    IndexWindow.count = splitnum(lblCount.Text.ToString());
                    IndexWindow.errorCount = splitnum(lblFailCount.Text.ToString());

                }
                catch (Exception)
                {

                }
                try
                {
                    int[] vs = new int[] { splitnum(lblFailCount.Text.Trim()), splitnum(lblRepeatCount.Text.Trim()), splitnum(lblNullPage.Text.Trim()) };

                    Chartloads(vs);
                }
                catch (Exception)
                {

                }
            }
        }

        private double Passcent()
        {
            double res;

            try
            {
                double passs = splitnum(lblCount.Text.Trim());
                double passss = splitnum(lblFailCount.Text.Trim());
                res = (passs - passss) / passs;

            }
            catch (Exception)
            {
                res = 0;
            }

            return res;
        }

        private float errorPer()
        {
            float res;

            try
            {
                //文件总数量
                double passs = splitnum(lblCount.Text.Trim());
                //异常文件数量
                double passss = splitnum(lblFailCount.Text.Trim());
                res = (float)(passss / passs);

            }
            catch (Exception)
            {
                res = 0;
            }

            return res;
        }
        private int splitnum(string str)
        {
            string[] arr = str.Split('：');
            return int.Parse(arr[1]);
        }

        //打印报表
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CreatPdf();
            //PrintPdf("tempPdf.pdf");
            string path = UIUtil.logpaths;
            if (!String.IsNullOrEmpty(path))
                PrintPdf(path);
        }

        private void PrintPdf(string pathName)
        {
            //加载PDF文档
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(pathName);

            //设置打印对话框属性
            PrintDialog dialogPrint = new PrintDialog();
            dialogPrint.AllowPrintToFile = true;
            dialogPrint.AllowSomePages = true;
            dialogPrint.PrinterSettings.MinimumPage = 1;
            dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            dialogPrint.PrinterSettings.FromPage = 1;
            dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

            if (dialogPrint.ShowDialog() == DialogResult.OK)
            {
                //指定打印机及打印页码范围
                doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
                doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
                doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;

                //打印文档
                PrintDocument printDoc = doc.PrintDocument;
                dialogPrint.Document = printDoc;
                printDoc.Print();
            }
        }
        private void CreatPdf()
        {
            //初始化一个PdfDocument实例
            PdfDocument document = new PdfDocument();

            //设置边距
            PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            PdfMargins margins = new PdfMargins();

            //添加新页
            PdfPageBase page = document.Pages.Add(PdfPageSize.A4, margins);

            PdfTrueTypeFont TitleFont = new PdfTrueTypeFont(new Font("宋体", 30f), true);
            //PdfPen pen = new PdfPen(Color.Black);


            //自定义PdfTrueTypeFont、PdfPen实例
            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("宋体", 15f), true);
            PdfPen pen = new PdfPen(Color.Black);

            //使用DrawString方法在指定位置写入文本
            string text = @"文件总述" +
                           "\r\n\r\n" +
                           "文件总数：" + FileNum.Text + "\r\n\r\n" +
                           "文件容量：" + FileSize.Text + "\r\n\r\n" +
                           "通过文件数：" + FilePassNun.Text + "\r\n\r\n" +
                           "通过文件容量：" + FilePassSize.Text + "\r\n\r\n" +
                           "疑似文件容量：" + FileSusSize.Text + "\r\n\r\n\r\n" +

                           "异常文件\r\n\r\n" +
                           "失败文件数：" + FileFailNum.Text + "\r\n\r\n" +
                           "重复文件：" + FileRepeat.Text + "\r\n\r\n" +
                           "缺页漏页情况：" + LackPage.Text + "\r\n\r\n" +
                           "全文挂接情况：" + FullHook.Text + "\r\n\r\n" +
                           "挂接条目情况：" + HookCatalog.Text + "\r\n\r\n" +
                           "条目检查情况：" + CatalogDes.Text + "\r\n\r\n" +
                           "打印时间：" + DateTime.Now;
            page.Canvas.DrawString("检测报告", TitleFont, pen, 250, 50);
            page.Canvas.DrawString(text, font, pen, 100, 100);

            //保存文档
            document.SaveToFile("tempPdf.pdf");
        }

        private void Chartloads(int[] resS)
        {
            string[] xValues = { "失败文件数", "重复文件", "空白页" };
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            Series Series1 = new Series();
            chart.Text = "异常文件占比";
            chart.Series.Add(Series1);
            chart.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart.Legends[0].Enabled = true;
            chart.Legends[0].Docking = Docking.Bottom;
            chart.Series["Series1"].LegendText = "#VALX";//开启图例
            chart.Series["Series1"].Label = "#PERCENT";
            chart.Series["Series1"].IsXValueIndexed = false;
            chart.Series["Series1"].IsValueShownAsLabel = false;
            chart.Series["Series1"]["PieLineColor"] = "Black";//连线颜色
            chart.Series["Series1"]["PieLabelStyle"] = "Outside";//标签位置
            chart.Series["Series1"].ToolTip = "#VALX";//显示提示用语
            ChartArea ChartArea1 = new ChartArea();
            chart.ChartAreas.Add(ChartArea1);

            //开启三维模式的原因是为了避免标签重叠
            chart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;//开启三维模式;PointDepth:厚度BorderWidth:边框宽

            chart.ChartAreas["ChartArea1"].Area3DStyle.Rotation = 15;//起始角度
            chart.ChartAreas["ChartArea1"].Area3DStyle.Inclination = 45;//倾斜度(0～90)
            chart.ChartAreas["ChartArea1"].Area3DStyle.LightStyle = LightStyle.Realistic;//表面光泽度
            chart.ChartAreas["ChartArea1"].Position.Width = 100;//绘图区充满
            chart.ChartAreas["ChartArea1"].Position.Height = 100;
            chart.Series["Series1"].Points.DataBindXY(xValues, resS);

            chart.Series["Series1"].Points[0].Color = Color.Green;//控制饼图一部分颜色为绿色
            chart.Series["Series1"].Points[1].Color = Color.Orange;//控制饼图一部分颜色为橙色
            chart.Series["Series1"].Points[2].Color = Color.Red;//控制饼图一部分颜色为红色
        }
    }
}
