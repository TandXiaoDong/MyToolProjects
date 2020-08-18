using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.SQLite;

/// <summary>
/// ������������Ŀǰ֧��SQL Server����������MYSQL��ORACLE��
/// </summary>
namespace CodeGenerator
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
            this.Init();
        }

        #region ��ʼ��
        public void Init()
        {
            try
            {
                string file = Application.ExecutablePath;
                file = Path.GetDirectoryName(file) + "/config.txt";
                if (File.Exists(file))
                {
                    GlobalConfig.Item = ConfigFileUtil<ConfigItem>.GetFromFile(file);
                }
                this.txtServer.Text = GlobalConfig.Item.Server;
                this.txtUid.Text = GlobalConfig.Item.UID;
                this.txtPwd.Text = GlobalConfig.Item.PWD;
                this.cbDataBase.Text = GlobalConfig.Item.DataBase;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ˢ������
        private void RefreshConfig()
        {
            GlobalConfig.Item.Server = this.txtServer.Text;
            GlobalConfig.Item.UID = this.txtUid.Text;
            GlobalConfig.Item.PWD = this.txtPwd.Text;
            GlobalConfig.Item.DataBase = this.cbDataBase.Text;
        }
        #endregion
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.RefreshConfig();
            Thread t = new Thread(new ThreadStart(DoTask));
            t.Start();
            this.Close();
        }

        public void DoTask()
        {
            FrmConfig fc = new FrmConfig();
            Application.Run(fc);
        }

        private void cbDataBase_Enter(object sender, EventArgs e)
        {
            try
            {
                this.RefreshConfig();
                string constr = "Server={0};Database={1};uid={2};pwd={3}";
                constr = String.Format(constr, GlobalConfig.Item.Server, "master", GlobalConfig.Item.UID, GlobalConfig.Item.PWD);
                SqlConnection con = new SqlConnection(constr);
                SqlDataAdapter adapter = new SqlDataAdapter("sp_helpdb", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this.cbDataBase.DataSource = ds.Tables[0];
                this.cbDataBase.DisplayMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            this.RefreshConfig();
            if (this.tabControl1.SelectedTab == this.tabPage_SQLServer)
            {
                GlobalConfig.Item.DataBaseType = ConfigItem.DataBaseTypeEnum.SQLServer;
                this.ConnectSQLServer();
            }
            else if (this.tabControl1.SelectedTab == this.tabPage_SQLite)
            {
                GlobalConfig.Item.DataBaseType = ConfigItem.DataBaseTypeEnum.SQLite;
                ConnectSQLite();
            }
        }

        /// <summary>
        /// �������ӵķ���
        /// </summary>
        private void ConnectSQLServer()
        {
            try
            {
                string constr = "Server={0};Database={1};uid={2};pwd={3}";
                constr = String.Format(constr, GlobalConfig.Item.Server, GlobalConfig.Item.DataBase, GlobalConfig.Item.UID, GlobalConfig.Item.PWD);
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                bool flag = false;
                if (con.State == ConnectionState.Open)
                {
                    flag = true;
                }
                con.Close();
                if (flag)
                {
                    MessageBox.Show("�������ӳɹ�!");
                    string file = Application.ExecutablePath;
                    file = Path.GetDirectoryName(file) + "/config.txt";
                    if (File.Exists(file)) File.Delete(file);
                    ConfigFileUtil<ConfigItem>.SaveToFile(GlobalConfig.Item, file);
                    this.btnNext.Enabled = true;
                }
                else
                {
                    MessageBox.Show("��������ʧ��!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConnectSQLite()
        {
            try
            {
                var connectString = "Data Source=cabledata.db";
                //var path = @"F:\work\MyRepository\FigkeyRepository\CableTestSystem\project\CableTestManager\CableTestManager\bin\Debug\cabledata.db";
                //var connectString = "Data Source=" + path + ";Version=3";
                SQLiteConnection sQLiteConnection = new SQLiteConnection(connectString);
                sQLiteConnection.Open();
                if (sQLiteConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("�������ӳɹ�!");
                    string file = Application.ExecutablePath;
                    file = Path.GetDirectoryName(file) + "/config.txt";
                    if (File.Exists(file)) File.Delete(file);
                    ConfigFileUtil<ConfigItem>.SaveToFile(GlobalConfig.Item, file);
                    this.btnNext.Enabled = true;
                }
                else
                {
                }
                sQLiteConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }
    }
}