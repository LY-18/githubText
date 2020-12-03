using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDetectionSystem.Setting
{
    public partial class NewDest : Form
    {
        string Catalog;
        public NewDest(string ChoosePath)
        {
            InitializeComponent();
            Catalog = ChoosePath;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        //常规检测
        private void label7_Click(object sender, EventArgs e)
        {
            CommonSettings commonSettings = new CommonSettings(false, false);
            if (commonSettings.ShowDialog() == DialogResult.OK)
                label7.Text = "已设置";
        }
        //挂接检测
        private void label8_Click(object sender, EventArgs e)
        {
            HookSettings hookSettings = new HookSettings(false, false);
            if (hookSettings.ShowDialog() == DialogResult.OK)
                label8.Text = "已设置";
        }
        //条目检测
        private void label9_Click(object sender, EventArgs e)
        {
            DirectoriesSettings directoriesSettings = new DirectoriesSettings(false, false);
            if (directoriesSettings.ShowDialog() == DialogResult.OK)
                label9.Text = "已设置";
        }
        //设置完成
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            //if (label7.Text != "已设置" || label8.Text != "已设置" || label9.Text != "已设置")
                //MessageBox.Show("请完成设置");
            //else
            //{
                if (Txt_PlanName.Text != "")
                    Model.BindItem.PlanList.Add(Txt_PlanName.Text);
            //}
        }

        private void NewDest_Load(object sender, EventArgs e)
        {
            DesCatalog.Items.Add(Catalog);
        }
    }
}
