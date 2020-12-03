﻿//using ceTe.DynamicPDF.Merger;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using O2S.Components.PDF4NET.PDFFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DataDetectionSystem
{
    public partial class SplitPageWindow : Form
    {
        string ExChoices = null;
        private List<string> cells;
        private Dictionary<string, int> cell2value;
        private Dictionary<string, string> docs;


        private List<string> allFiles;

        List<string> Loglist = new List<string>();

        Dictionary<string, string> datas = new Dictionary<string, string>();
        Dictionary<string, string> aj2 = new Dictionary<string, string>();


        private void Clear()
        {
            cells.Clear();
            cell2value.Clear();
        }

        private void Enble(bool start)
        {
            Btn_ExChoice.Enabled = start;
            Btn_PartsChoice.Enabled = start;
            Btn_ArchiveChoice.Enabled = start;
            Btn_ArchiveCateChoice.Enabled = start;

            ArchiveChoicePath.Enabled = start;
            ArchiveCatePath.Enabled = start;
            PartsChoicePath.Enabled = start;
            ExChoice.Enabled = start;

            Btn_Start.Text = "分件中";
            Btn_Start.Enabled = start;

        }


        public SplitPageWindow()
        {
            InitializeComponent();
            datas.Clear();
            aj2.Clear();

            cells = new List<string>();
            cell2value = new Dictionary<string, int>();
            docs = new Dictionary<string, string>();

            allFiles = new List<string>();
        }

        private void SplitPageWindow_Load(object sender, EventArgs e)
        {

        }
        //选择案卷条目
        private void Btn_ArchiveChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择案卷条目文件";
            ofd.Filter = "excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ArchiveChoicePath.Text = ofd.FileName;
            }
        }
        //选择案卷目录
        private void Btn_ArchiveCateChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择案卷目录文件";
            ofd.Filter = "excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ArchiveCatePath.Text = ofd.FileName;
            }
        }

        //选择分件目录
        private void Btn_PartsChoice_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sPath = fbd.SelectedPath;
                PartsChoicePath.Text = sPath;
            }
        }

        //选择输出目录
        private void Btn_ExChoice_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sPath = fbd.SelectedPath;
                ExChoice.Text = sPath;
                ExChoices = sPath;
            }
        }
        //开始分卷
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            datas.Clear();
            aj2.Clear();
            if (String.IsNullOrEmpty(ArchiveChoicePath.Text) || String.IsNullOrEmpty(PartsChoicePath.Text) || String.IsNullOrEmpty(ExChoice.Text) || String.IsNullOrEmpty(ArchiveCatePath.Text))
            {
                MessageBox.Show("请选择路径");
            }
            else
            {
                Enble(false);
                var pdf_path = PartsChoicePath.Text;
                IWorkbook wk = null;
                IWorkbook ajml = null;
                string extension = Path.GetExtension(ArchiveChoicePath.Text);
                string ajml_extension = Path.GetExtension(ArchiveCatePath.Text);
                try
                {
                    //创建文件流
                    FileStream fs = File.OpenRead(ArchiveChoicePath.Text);
                    FileStream ajml_fs = File.OpenRead(ArchiveCatePath.Text);

                    if (extension.Equals(".xls"))
                        wk = new HSSFWorkbook(fs);
                    if (extension.Equals(".xlsx"))
                        wk = new XSSFWorkbook(fs);
                    if (ajml_extension.Equals(".xls"))
                        ajml = new HSSFWorkbook(ajml_fs);
                    if (ajml_extension.Equals(".xlsx"))
                        ajml = new XSSFWorkbook(ajml_fs);

                    //关闭文件流
                    fs.Close();
                    ajml_fs.Close();



                    // 读取案卷表
                    ISheet ajml_sheet = ajml.GetSheetAt(0);
                    int ajrow = ajml_sheet.LastRowNum;
                    int index = 0;
                    try
                    {
                        for (int i = 1; i <= ajrow; i++)
                        {
                            index = i;
                            var row = ajml_sheet.GetRow(i);


                            var dh = row.GetCell(0).ToString();

                            int wj_num = int.Parse(row.GetCell(6).ToString());

                            int wj_page = int.Parse(row.GetCell(10).ToString());

                            aj2.Add(dh,  wj_page + "," + wj_num);
                        }
                    }
                    catch (Exception)
                    {

                    }

                    //读取文件表
                    ISheet sheet = wk.GetSheetAt(0);

                    int nrow = sheet.LastRowNum;
                    for (int i = 1; i <= nrow; i++)
                    {
                        var row = sheet.GetRow(i);  //读取当前行数据

                        var page = 0;
                        //案卷级档号
                        string aj_dh = row.Cells[0].StringCellValue;
                        //文件级档号
                        string wj_dh = row.Cells[1].StringCellValue;

                        var cp = row.GetCell(5).StringCellValue;
                        page = Convert.ToInt32(cp);

                        var next_page = page;
                        var j = i + 1;
                        if (j <= nrow)
                        {
                            var nextRow = sheet.GetRow(j);
                            if (nextRow != null)
                            {
                                var str_end_page = nextRow.Cells[5].StringCellValue;
                                if (str_end_page.Length > 1)
                                {
                                    next_page = Convert.ToInt32(str_end_page);
                                }
                            }
                        }
                        try
                        {
                            datas.Add(aj_dh + ',' + wj_dh, page + "," + next_page);
                        }
                        catch (Exception)
                        {
                        }
                    }

                    //创建文件夹
                    foreach (var pageinfo in datas)
                    {
                        List<string> tempfilelist = new List<string>();
                        tempfilelist.Clear();

                        var dh = pageinfo.Key;
                        var page = pageinfo.Value;

                        var dharr = dh.Split(new char[1] { ',' });
                        var pagearr = page.Split(new char[1] { ',' });

                        var aj_dh = dharr[0];
                        var wj_dh = dharr[1];

                        var s_page = int.Parse(pagearr[0]);
                        var e_page = int.Parse(pagearr[1]);


                        var out_path = ExChoices + "\\" + wj_dh;
                        if (!Directory.Exists(out_path))
                        {
                            Directory.CreateDirectory(out_path);
                        }
                        try
                        {
                            string _o = aj2[aj_dh];
                            var infoarr = _o.Split(new char[1] { ',' });
                            var p1 = int.Parse(infoarr[0]);
                            var num = int.Parse( infoarr[1] );
                            if(num == 1 || s_page > e_page)
                            {
                                e_page = p1;
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        int count = 0;
                        if (s_page < e_page)
                        {
                            for (int i = s_page; i < e_page; i++)
                            {
                                var fileinfo = new FileInfo(pdf_path + "\\" + aj_dh + "-" + i.ToString().PadLeft(3, '0') + ".pdf");
                                if (fileinfo.Exists)
                                {
                                    tempfilelist.Add(fileinfo.FullName);
                                    count++;
                                }
                            }
                        }
                        else
                        {

                            var fileinfo = new FileInfo(pdf_path + "\\" + aj_dh + "-" + s_page.ToString().PadLeft(3, '0') + ".pdf");
                            if (fileinfo.Exists)
                            {
                                tempfilelist.Add(fileinfo.FullName);
                                count++;
                            }
                        }
                        if (count == 1)
                        {
                            var fileinfo = new FileInfo(pdf_path + "\\" + aj_dh + "-" + s_page.ToString().PadLeft(3, '0') + ".pdf");
                            File.Copy(fileinfo.FullName, out_path + "\\" + fileinfo.Name);
                            Loglist.Add(fileinfo.Name + ".pdf分件成功");
                        }
                        if (count > 1)
                        {
                            PDFFile.MergeFiles(out_path + @"\" + wj_dh + ".pdf", tempfilelist.ToArray());
                            Loglist.Add(wj_dh + ".pdf分件成功");
                        }
                    }

                    foreach (var item in Loglist)
                    {
                        ListLog.Items.Add(item);
                    }
                    MessageBox.Show("分件结束");
                    Enble(true);
                    Btn_Start.Text = "开始分件";
                }
                catch (Exception)
                {
                }
            }
        }

    }
}
