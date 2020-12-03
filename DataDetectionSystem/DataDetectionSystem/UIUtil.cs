using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using BLL;
using Model;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing;

namespace DataDetectionSystem
{
    //UI层的公共类，封装UI层的通用操作，如果分层，建议将与UI无关的通用功能放到公共层
    public class UIUtil
    {
        public static string logpaths;
        /// <summary>
        /// 读取配置节，根据键返回配置值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>配置字符串</returns>
        public static string ReadSetting(string key)
        {
            if (!string.IsNullOrWhiteSpace(key) && ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                string setting = ConfigurationManager.AppSettings[key];
                return setting;
            }
            return "";
        }

        /// <summary>
        /// 读取全部配置
        /// </summary>
        /// <returns>将App.config读取成CLR键值对</returns>
        public static Dictionary<string, string> ReadSettings()
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            if (ConfigurationManager.AppSettings.Count > 0)
            {
                string[] keys = ConfigurationManager.AppSettings.AllKeys;
                foreach (string key in keys)
                {
                    if (!String.IsNullOrWhiteSpace(key))
                    {
                        string setting = ConfigurationManager.AppSettings[key];
                        keyValues.Add(key, setting);
                    }
                }
            }
            return keyValues;
        }

        /// <summary>
        /// 保存配置，如果不存在指定的配置节，则将其添加到appSettings
        /// </summary>
        /// <param name="keyValues">表示配置节键及设置的键值对的集合</param>
        public static void SetConfig(Dictionary<string, string> keyValues)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (string key in keyValues.Keys)
            {
                //键不能为空
                if (!String.IsNullOrWhiteSpace(key))
                {
                    string setting = keyValues[key];
                    //配置节值可以为空，但键值不能为null
                    if (setting != null)
                    {
                        if (configuration.AppSettings.Settings.AllKeys.Contains(key))
                            configuration.AppSettings.Settings[key].Value = setting;
                        else
                            configuration.AppSettings.Settings.Add(key, setting);
                    }
                }
            }
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 保存配置，如果指定了需要清除之前的设置，根据模式匹配需要清除的配置节
        /// </summary>
        /// <param name="keyValues">表示配置节键及设置的键值对的集合</param>
        /// <param name="reset">是否需要清除之前的设置</param>
        /// <param name="pattern">匹配模式</param>
        public static void SetConfig(Dictionary<string, string> keyValues, bool reset, string pattern)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (reset)
            {
                Regex regex = new Regex(pattern);
                foreach (string key in configuration.AppSettings.Settings.AllKeys)
                {
                    if (regex.IsMatch(key))
                    {
                        configuration.AppSettings.Settings.Remove(key);
                    }
                }
            }
            foreach (string key in keyValues.Keys)
            {
                //键不能为空
                if (!String.IsNullOrWhiteSpace(key))
                {
                    string setting = keyValues[key];
                    //配置节值可以为空，但键值不能为null
                    if (setting != null)
                    {
                        if (configuration.AppSettings.Settings.AllKeys.Contains(key))
                            configuration.AppSettings.Settings[key].Value = setting;
                        else
                            configuration.AppSettings.Settings.Add(key, setting);
                    }
                }
            }
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 获取下拉框的选择值字符串
        /// </summary>
        /// <param name="combo">下拉框</param>
        /// <returns>选择值字符串</returns>
        public static string GetComboSelectedStrVal(ComboBox combo)
        {
            object selectedValue = combo.SelectedValue;
            if (selectedValue == null)
                return "";
            else
            {
                return selectedValue as string;
            }
        }

        /// <summary>
        /// 获取指定设置项的值
        /// </summary>
        /// <param name="settings">表示设置的键值对</param>
        /// <param name="key">键</param>
        /// <returns>值</returns>
        public static string GetDictionaryValue(Dictionary<string, string> settings, string key)
        {
            if (settings.ContainsKey(key))
            {
                string kkk = settings[key];
                return settings[key];
            }
            return "";
        }

        /// <summary>
        /// 获取指定设置项的值的布尔型格式
        /// </summary>
        /// <param name="settings">表示设置的键值对</param>
        /// <param name="key">键</param>
        /// <returns>值</returns>
        public static bool GetDictionaryBooleanVal(Dictionary<string, string> settings, string key)
        {
            if (settings.ContainsKey(key))
            {
                string val = settings[key];
                bool result;
                if (Boolean.TryParse(val, out result))
                {
                    return result;
                }
                return false;
            }
            return false;
        }

        /// <summary>
        /// 获取指定设置项的值的数字型格式
        /// </summary>
        /// <param name="settings">表示设置的键值对</param>
        /// <param name="key">键</param>
        /// <returns>数字类型的值</returns>
        public static decimal GetDictionaryDecimalVal(Dictionary<string, string> settings, string key)
        {
            if (settings.ContainsKey(key))
            {
                string val = settings[key];
                decimal result;
                if (Decimal.TryParse(val, out result))
                {
                    return result;
                }
                return 0;
            }
            return 0;
        }

        /// <summary>
        /// 获取指定设置项的值的时间日期格式
        /// </summary>
        /// <param name="settings">表示设置的键值对</param>
        /// <param name="key">键</param>
        /// <returns>值的时间日期格式</returns>
        public static DateTime GetDictionaryDateTimeVal(Dictionary<string, string> settings, string key)
        {
            if (settings.ContainsKey(key))
            {
                string val = settings[key];
                DateTime result;
                if (DateTime.TryParse(val, out result))
                {
                    return result;
                }
                return DateTime.Now;
            }
            return DateTime.Now;
        }

        /// <summary>
        /// 获取显示布尔值测试结果的文本
        /// </summary>
        /// <param name="result">测试结果</param>
        /// <returns>用于显示的文本</returns>
        public static string BooleanResultToString(bool result)
        {
            return result ? "通过" : "失败";
        }

        /// <summary>
        /// 将字符串转换为布尔型
        /// </summary>
        /// <param name="value">字符串</param>
        /// <returns>布尔型值</returns>
        public static bool ConvertToBoolean(string value)
        {
            bool convertedValue;
            if (String.IsNullOrWhiteSpace(value))
                return false;
            if (!Boolean.TryParse(value, out convertedValue))
                return false;
            return convertedValue;
        }

        /// <summary>
        /// 本来将UI逻辑写在公共类里面不符合模块化松耦合的设计理念，但巡检和手动的检测的功能是一样的，涉及到对UI的操作，
        /// 还是需要UI逻辑。所以采用灵活的方式将检测的操作封装到公共类里面，作为一个组件单元供检测和巡检调用，
        /// 可以统一维护。实现了检测逻辑的统一性与通用性、模块化。因为涉及到UI的交互，
        /// 但控件是作为窗体的保护成员出现的，而交互的控件相对固定且数量可以接受，所以将控件作为参数传入方法
        /// </summary>
        /// <param name="label">描述当前操作的Label</param>
        /// <param name="textBox">进度详细信息</param>
        /// <param name="progressBar">进度条</param>
        public static void Test(Label label, TextBox textBox, ProgressBar progressBar, params NotifyIcon[] notifyIcon)
        {
            string errorPath = "";
            if (notifyIcon.Length > 0)
                notifyIcon[0].ShowBalloonTip(10000);
            Dictionary<string, string> settings = UIUtil.ReadSettings();
            string folder = UIUtil.GetDictionaryValue(settings, "Folder"), fileName;
            label.Text = "检测中...";
            label.Refresh();
            textBox.Text = "开始检测";
            textBox.Refresh();
            progressBar.Value = 0;
            progressBar.Refresh();
            Dictionary<string, object> testResult = Index.TestResult;
            testResult.Clear();
            Index.TestResultStr = "";
            bool whiteTest = UIUtil.GetDictionaryBooleanVal(settings, "ValidateWhite");
            bool repeatTest = UIUtil.GetDictionaryBooleanVal(settings, "ValidateRepeat");
            bool repeatMD5Test = UIUtil.GetDictionaryBooleanVal(settings, "ValidateRepeatMD5");
            bool hookTest = UIUtil.GetDictionaryBooleanVal(settings, "ValidateHook");
            bool directoriesTest = UIUtil.GetDictionaryBooleanVal(settings, "ValidateDirectories");
            bool DPITest = UIUtil.GetDictionaryBooleanVal(settings, "ValidateDPI");
            bool ItalicTest = UIUtil.GetDictionaryBooleanVal(settings, "ValidateItalic");

            decimal DPI =UIUtil.GetDictionaryDecimalVal(settings, "DPI");
            decimal Italic = UIUtil.GetDictionaryDecimalVal(settings, "ItalicDegree");
            decimal whitePercent = 0;
            if (whiteTest)
            {
                whitePercent = UIUtil.GetDictionaryDecimalVal(settings, "WhitePercent");
            }
            bool result, whiteResult, repeatResult, repeatMD5Result, DPIResult, ItalicResult;
            if (!String.IsNullOrWhiteSpace(folder) && Directory.Exists(folder))
            {
                List<string> repeatFiles = new List<string>();
                List<string> repeatFilesMD5 = new List<string>();
                List<FileInfo> repeatTestedFiles = new List<FileInfo>();
                List<FileInfo> repeatMD5TestedFiles = new List<FileInfo>();
                DirectoryInfo directoryInfo = new DirectoryInfo(folder);
                DirectoryInfo[] archiveDis = directoryInfo.GetDirectories();
                FileInfo[] fileInfos;
                FileInfo fileInfo;
                int count = 0, passedCount = 0, failCount = 0, archiveCount = archiveDis.Length, length, i, j;
                long passedLength = 0, failLength = 0;
                int nullpage = 0;
                int dpitestpage = 0;
                for (i = 0; i < archiveCount; i++)
                {
                    textBox.Text += "\r\n检测文件夹：\"" + archiveDis[i].Name + "\"";
                    textBox.Refresh();

                    progressBar.Value = 100 * (i + 1) / archiveCount;
                    progressBar.Refresh();

                    fileInfos = archiveDis[i].GetFiles();
                    length = fileInfos.Length;
                    count += length;
                    for (j = 0; j < length; j++)
                    {
                        fileInfo = fileInfos[j];
                        fileName = fileInfo.Name;
                        if (fileName != "Thumbs.db")
                        {
                            textBox.Text += "\r\n检测文件：\"" + fileName + "\"";
                            textBox.Refresh();
                            result = true;
                            if (whiteTest)
                            {
                                textBox.Text += "\r\n空白页检测";
                                textBox.Refresh();
                                whiteResult = Tests.WhiteTest(fileInfo, Convert.ToDouble(whitePercent));
                                result = result && whiteResult;
                                textBox.Text += "\t" + UIUtil.BooleanResultToString(whiteResult);
                                if (!whiteResult)
                                {
                                    errorPath += "空白页检测失败，路径：" + fileInfo.FullName + "\r\n";
                                    nullpage++;
                                }
                            }
                            if (repeatTest)
                            {
                                textBox.Text += "\r\n重复性检测";
                                textBox.Refresh();
                                repeatResult = true;
                                foreach (FileInfo compareFile in repeatTestedFiles)
                                {
                                    repeatResult = repeatResult && Tests.RepeatTest(compareFile, fileInfo);
                                }
                                if (!repeatResult)
                                    repeatFiles.Add(fileInfo.Name);
                                result = result && repeatResult;
                                textBox.Text += "\t" + UIUtil.BooleanResultToString(repeatResult);

                                if (!repeatResult)
                                    errorPath += "重复性检测失败，路径：" + fileInfo.FullName + "\r\n";

                                repeatTestedFiles.Add(fileInfo);
                            }
                            if (repeatMD5Test)
                            {
                                textBox.Text += "\r\n重复性检测(MD5校验)";
                                textBox.Refresh();
                                repeatMD5Result = true;
                                foreach (FileInfo compareFile in repeatMD5TestedFiles)
                                {
                                    repeatMD5Result = repeatMD5Result && Tests.RepeatTestMD5(compareFile, fileInfo);
                                }
                                if (!repeatMD5Result)
                                    repeatFilesMD5.Add(fileInfo.Name);
                                result = result && repeatMD5Result;
                                textBox.Text += "\t" + UIUtil.BooleanResultToString(repeatMD5Result);

                                if (!repeatMD5Result)
                                    errorPath += "重复性检测(MD5校验)失败，路径：" + fileInfo.FullName + "\r\n";
                                repeatMD5TestedFiles.Add(fileInfo);
                            }
                            if (DPITest)
                            {
                                textBox.Text += "\r\nDPI检测";
                                textBox.Refresh();
                                DPIResult = Tests.DPITest(fileInfo, Convert.ToInt32(DPI));
                                result = result && DPIResult;
                                textBox.Text += "\t" + UIUtil.BooleanResultToString(DPIResult);
                                if (!DPIResult)
                                {
                                    errorPath += "DPI低于" + DPI + "，路径：" + fileInfo.FullName + "\r\n";
                                    dpitestpage++;
                                }
                            }
                            if (ItalicTest)
                            {
                                textBox.Text += "\r\n图像倾斜度检测";
                                textBox.Refresh();

                                ItalicResult = Tests.ItalicTest(fileInfo, Convert.ToInt32(Italic));
                                result = result && ItalicResult;
                                textBox.Text += "\t" + UIUtil.BooleanResultToString(ItalicResult);
                                if (!ItalicResult)
                                {
                                    errorPath += "图像倾斜度大于" + Italic + "，路径：" + fileInfo.FullName + "\r\n";
                                    dpitestpage++;
                                }
                            }
                            if (result)
                            {
                                passedCount++;
                                passedLength += fileInfo.Length;
                            }
                            else
                            {
                                failCount++;
                                failLength += fileInfo.Length;
                            }
                        }
                        else
                        {
                            count--;
                        }
                    }
                }
                testResult.Add("Count", count);
                testResult.Add("PassedCount", passedCount);
                testResult.Add("FailCount", failCount);
                testResult.Add("Length", passedLength + failLength);
                testResult.Add("PassedLength", passedLength);
                testResult.Add("FailLength", failLength);
                testResult.Add("nullpagenum", nullpage);
                testResult.Add("DpiNum", dpitestpage);
                testResult.Add("ItalicNum", dpitestpage);
                if (repeatTest)
                {
                    testResult.Add("RepeatFiles", repeatFiles);
                }
                if (repeatMD5Test)
                {
                    testResult.Add("RepeatFilesMD5", repeatFilesMD5);
                }
                if (hookTest)
                {
                    string hookDirectoriesFile = UIUtil.GetDictionaryValue(settings, "HookDirectoriesFile");
                    decimal hookSheet = UIUtil.GetDictionaryDecimalVal(settings, "HookSheet");
                    decimal archiveIdField = UIUtil.GetDictionaryDecimalVal(settings, "ArchiveIdField");
                    decimal pageField = UIUtil.GetDictionaryDecimalVal(settings, "PageField");
                    if (!String.IsNullOrWhiteSpace(hookDirectoriesFile) && File.Exists(hookDirectoriesFile) && hookSheet >= 0 && pageField >= 0)
                    {
                        textBox.Text += "\r\n挂接缺漏页检测";
                        textBox.Refresh();
                        try
                        {
                            Dictionary<string, List<int>> archiveShortOfPages = Tests.ShortOfPagesTest(folder, hookDirectoriesFile, Convert.ToInt32(hookSheet), Convert.ToInt32(archiveIdField), Convert.ToInt32(pageField));
                            List<int> shortOfPages;
                            foreach (string archiveId in archiveShortOfPages.Keys)
                            {
                                shortOfPages = archiveShortOfPages[archiveId];
                                if (shortOfPages != null && shortOfPages.Count > 0)
                                {
                                    textBox.Text += "\r\n档号为" + archiveId + "的案卷缺少第";
                                    for (int k = 0; k < shortOfPages.Count; k++)
                                    {
                                        textBox.Text += shortOfPages[k] + ",";
                                    }
                                    textBox.Text = textBox.Text.TrimEnd(',') + "页";
                                    textBox.Refresh();
                                }
                            }
                            testResult.Add("ShortOfPages", archiveShortOfPages);
                        }
                        catch (IOException exp)
                        {
                            MessageBox.Show("您已打开了挂接条目Excel文件，系统无法访问，请关闭后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        textBox.Text += "\r\n已选择挂接检测，但设置不正确，已跳过挂接检测";
                        textBox.Refresh();
                    }
                }
            }
            else
            {
                textBox.Text += "\r\n未选择检测文件夹或检测文件夹不存在，已跳过文件检测！";
                textBox.Refresh();
            }
            if (directoriesTest)
            {
                string directoriesFile = UIUtil.GetDictionaryValue(settings, "DirectoriesFile");
                decimal directoriesSheet = UIUtil.GetDictionaryDecimalVal(settings, "DirectoriesSheet");
                Dictionary<string, string> filerule = new Dictionary<string, string>();
                Dictionary<string, string> orderrule = new Dictionary<string, string>();
                foreach (string item in settings.Keys)
                {
                    if (item.StartsWith("FieldRule_"))
                    {
                        string sFieldIndex = item.Replace("FieldRule_", "");
                        string rulesetting = settings[item];
                        filerule.Add(item, rulesetting);
                    }
                }
                if (!String.IsNullOrWhiteSpace(directoriesFile) && File.Exists(directoriesFile) && directoriesSheet >= 0)
                {
                    textBox.Text += "\r\n条目检测";
                    textBox.Refresh();
                    try
                    {
                        Dictionary<string, Dictionary<string, Dictionary<string, string>>> directoriesErrors = Tests.DirectoriesTest(directoriesFile, Convert.ToInt32(directoriesSheet), filerule, orderrule);
                        Dictionary<string, Dictionary<string, string>> directoryErrors;
                        Dictionary<string, string> fieldErrors;
                        object error;
                        foreach (string rowIndex in directoriesErrors.Keys)
                        {
                            directoryErrors = directoriesErrors[rowIndex];
                            if (directoryErrors != null && directoryErrors.Count > 0)
                            {
                                if (rowIndex != "排序检测")
                                {
                                    textBox.Text += "\r\n第" + rowIndex + "行条目错误：";
                                }
                                else
                                {
                                    textBox.Text += "\r\n排序检测：";
                                }
                                textBox.Refresh();
                                //foreach (int field in directoryErrors.Keys)
                                //{
                                //    fieldErrors = directoryErrors[field];
                                //    if (fieldErrors != null && fieldErrors.Count > 0)
                                //    {
                                //        textBox.Text += "\r\n第" + (field + 1) + "列：";
                                //        textBox.Refresh();
                                //        foreach (string rule in fieldErrors.Keys)
                                //        {
                                //            error = fieldErrors[rule];
                                //            if (error != null)
                                //                textBox.Text += "[" + rule + ":" + error + "];";
                                //        }
                                //        textBox.Text = textBox.Text.TrimEnd(';');
                                //        textBox.Refresh();
                                //    }
                                //}
                            }
                        }
                        testResult.Add("DirectoriesErrors", directoriesErrors);
                    }
                    catch (IOException exp)
                    {
                        MessageBox.Show("您已打开了需要检测的条目Excel文件，系统无法访问，请关闭后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    textBox.Text += "\r\n已选择条目检测，但设置不正确，已跳过条目检测";
                    textBox.Refresh();
                }
            }
            progressBar.Value = 100;
            progressBar.Refresh();

            textBox.Text += "\r\n检测结束";
            textBox.Refresh();

            Index.TestResultStr = textBox.Text;
            label.Text = "检测完成！";

            CommonSettings.loads();
            ResultUserControl.ins();
            
            //异常文件百分比
            float n = ResultUserControl.errorPers;
            //
            double nd = IndexWindow.testErrorPer;

            IndexWindow.testErrorPer= n + nd;

            //打印报表文件
            logpaths = WriteLogs(CommonSettings.LogsPath, Index.TestResults + "\r\n\r\n详细日志：\r\n" + errorPath + "\r\n");

            //string txtpath = WriteLogss(CommonSettings.LogsPath, Index.TestResults + "\r\n\r\n" + errorPath);
            label.Refresh();
            IndexWindow.testNum++;
        }

        public static void Test(object state)
        {
            ThreadParam threadParam = state as ThreadParam;
            Test(threadParam.label, threadParam.textBox, threadParam.progressBar, threadParam.notifyIcon);
        }

        public static TimeSpan GetTestDueTime()
        {
            Dictionary<string, string> settings = ReadSettings();
            DateTime settedTime = GetDictionaryDateTimeVal(settings, "IntervalTime");
            int hour = settedTime.Hour;
            int minute = settedTime.Minute;
            int second = settedTime.Second;
            DateTime now = DateTime.Now;
            TimeSpan timeOfDay = now.TimeOfDay;
            TimeSpan tickTime = new TimeSpan(hour, minute, second);
            TimeSpan duetime;
            if (timeOfDay > tickTime)
            {
                DateTime tomorrow = new DateTime(now.Year, now.Month, now.Day, hour, minute, second);
                tomorrow = tomorrow.AddDays(1);
                duetime = tomorrow - now;
            }
            else
            {
                duetime = tickTime - timeOfDay;
            }
            return duetime;
        }

        /// <summary>
        /// 生成报表文件
        /// </summary>
        /// <param name="logpath">报表路径</param>
        /// <param name="log">报表内容</param>
        public static string WriteLogs(string logpath, string log)
        {
            string _Date = DateTime.Now.ToString("yyyy-MM-dd-hh-mm");
            Spire.Pdf.PdfDocument document = new Spire.Pdf.PdfDocument();

            PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            PdfMargins margins = new PdfMargins();
            PdfPageBase page = document.Pages.Add(PdfPageSize.A3, margins);

            PdfTrueTypeFont TitleFont = new PdfTrueTypeFont(new Font("宋体", 30f), true);

            PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("宋体", 14f), true);
            PdfPen pen = new PdfPen(Color.Black);

            string text = log
                            + "\r\n\r\n" +
                           "检测时间：" + DateTime.Now;
            page.Canvas.DrawString("检测报告", TitleFont, pen, 350, 10);
            page.Canvas.DrawString(text, font, pen, 100, 50);

            string path = logpath + "\\" + _Date + ".pdf";

            document.SaveToFile(path);
            return path;
        }

        /// <summary>
        /// 获取DPI
        /// </summary>
        /// <param name="filename">文件路径</param>
        /// <returns></returns>
        public static float[] GetDpi(string filename)
        {
            Image image = Image.FromFile(filename);
            float dpiX = image.HorizontalResolution;
            float dpiY = image.VerticalResolution;
            float[] dpi = new float[] { dpiX, dpiY };
            return dpi;
        }

        //public static string WriteLogss(string Exception, string ExceptionSource)
        //{
        //    string _Date = DateTime.Now.Date.ToString("yyyy-MM-dd-hh");
        //    string txtpath = Exception + "\\" + _Date + ".txt";
        //    StreamWriter dout = new StreamWriter(txtpath, true);

        //    dout.Write("日志:" + ExceptionSource);
        //    dout.Write(Environment.NewLine);
        //    dout.Write(Environment.NewLine);
        //    dout.Write(Environment.NewLine);

        //    dout.Close();
        //    return txtpath;
        //}
    }
}
