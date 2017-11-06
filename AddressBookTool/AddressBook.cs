using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace AddressBookTool
{
    /// <summary>
    /// A DataSet class used to CRUD the content of address.xml
    /// </summary>
    public partial class AddrList
    {
        /// <summary>
        /// 處理 multicast group ip 記錄專用類別
        /// </summary>
        partial class multicastGroupDataTable
        {
            string m_XmlFilePath;
            public override void EndInit()
            {
                base.EndInit();
                m_XmlFilePath = Program.GetAppFolderPath() + @"\multicastgroupip.xml";
                if (File.Exists(m_XmlFilePath))
                {
                    this.ReadXml(m_XmlFilePath);
                }
                else
                {
                    // add seed here+
                    this.Rows.Add(new Object[] { "239.255.42.42" });
                    this.Rows.Add(new Object[] { "239.255.42.43" });
                    this.Rows.Add(new Object[] { "239.255.42.44" });
                    this.Rows.Add(new Object[] { "239.255.42.45" });
                    this.Rows.Add(new Object[] { "239.255.42.46" });
                    this.Rows.Add(new Object[] { "239.255.42.47" });
                    this.Rows.Add(new Object[] { "239.255.42.48" });
                    this.Rows.Add(new Object[] { "239.255.42.49" });
                    this.Rows.Add(new Object[] { "239.255.42.56" });
                    this.Rows.Add(new Object[] { "239.255.42.57" });
                    this.Rows.Add(new Object[] { "239.255.42.58" });
                    this.Rows.Add(new Object[] { "239.255.42.59" });
                    this.Rows.Add(new Object[] { "239.255.42.60" });
                    this.Rows.Add(new Object[] { "239.255.42.61" });
                    this.Rows.Add(new Object[] { "239.255.42.62" });
                    this.Rows.Add(new Object[] { "239.255.42.63" });
                    this.Rows.Add(new Object[] { "239.255.42.64" });
                    this.Rows.Add(new Object[] { "239.255.42.65" });
                    this.Rows.Add(new Object[] { "239.255.42.66" });
                    this.Rows.Add(new Object[] { "239.255.42.67" });
                    this.Rows.Add(new Object[] { "239.255.42.68" });
                    this.Rows.Add(new Object[] { "239.255.42.69" });
                    this.Rows.Add(new Object[] { "239.255.42.70" });
                    this.Rows.Add(new Object[] { "239.255.42.71" });
                    this.Rows.Add(new Object[] { "239.255.42.72" });
                    this.Rows.Add(new Object[] { "239.255.42.73" });
                    this.Rows.Add(new Object[] { "239.255.42.74" });
                    this.Rows.Add(new Object[] { "239.255.42.75" });
                    this.Rows.Add(new Object[] { "239.255.42.76" });
                    this.Rows.Add(new Object[] { "239.255.42.77" });
                    this.Rows.Add(new Object[] { "239.255.42.78" });
                    this.Rows.Add(new Object[] { "239.255.42.79" });
                    this.Rows.Add(new Object[] { "239.255.42.128" });
                    this.Rows.Add(new Object[] { "239.255.42.129" });
                    this.Rows.Add(new Object[] { "239.255.42.130" });
                    this.Rows.Add(new Object[] { "239.255.42.131" });
                    this.Rows.Add(new Object[] { "239.255.42.132" });
                    this.Rows.Add(new Object[] { "239.255.42.133" });
                    this.Rows.Add(new Object[] { "239.255.42.134" });
                    this.Rows.Add(new Object[] { "239.255.42.135" });
                    this.Rows.Add(new Object[] { "239.255.42.136" });
                    this.Rows.Add(new Object[] { "239.255.42.137" });
                    this.Rows.Add(new Object[] { "239.255.42.138" });
                    this.Rows.Add(new Object[] { "239.255.42.139" });
                    this.Rows.Add(new Object[] { "239.255.42.140" });
                    this.Rows.Add(new Object[] { "239.255.42.141" });
                    this.Rows.Add(new Object[] { "239.255.42.142" });
                    this.Rows.Add(new Object[] { "239.255.42.143" });
                    this.Rows.Add(new Object[] { "239.255.42.192" });
                    this.Rows.Add(new Object[] { "239.255.42.193" });
                    this.Rows.Add(new Object[] { "239.255.42.194" });
                    this.Rows.Add(new Object[] { "239.255.42.195" });
                    this.Rows.Add(new Object[] { "239.255.42.196" });
                    this.Rows.Add(new Object[] { "239.255.42.197" });
                    this.Rows.Add(new Object[] { "239.255.42.198" });
                    this.Rows.Add(new Object[] { "239.255.42.199" });
                    this.Rows.Add(new Object[] { "239.255.42.200" });
                    this.Rows.Add(new Object[] { "239.255.42.201" });
                    this.Rows.Add(new Object[] { "239.255.42.202" });
                    this.Rows.Add(new Object[] { "239.255.42.203" });
                    this.Rows.Add(new Object[] { "239.255.42.204" });
                    this.Rows.Add(new Object[] { "239.255.42.205" });
                    this.Rows.Add(new Object[] { "239.255.42.206" });
                    this.Rows.Add(new Object[] { "239.255.42.207" });
                    this.WriteXml(m_XmlFilePath);
                    // add seed here-
                }
                RowChanged += multicastGroupDataTable_RowChanged;
                RowDeleted += multicastGroupDataTable_RowDeleted;
            }

            void multicastGroupDataTable_RowDeleted(object sender, DataRowChangeEventArgs e)
            {
                this.WriteXml(m_XmlFilePath);
            }

            void multicastGroupDataTable_RowChanged(object sender, DataRowChangeEventArgs e)
            {
                switch (e.Action)
                {
                    case System.Data.DataRowAction.Add:
                    case System.Data.DataRowAction.Change:
                        multicastGroupRow row = e.Row as multicastGroupRow;
                        if (!row.HasErrors)
                        {
                            this.WriteXml(m_XmlFilePath);
                        }
                        break;
                }
            }

        }

        partial class devDataTable
        {
            enum DeviceType : byte
            {
                Control_Server = 0,         //管理中心
                Door_Camera,                //门口摄像头
                Lobby_Phone_Unit,           //单元门口机
                Lobby_Phone_Building,       //楼栋门口机
                Lobby_Phone_Area,           //小区门口机
                Indoor_Phone,               //分机 
                Administrator_Unit,         //管理机
                Indoor_Phone_SD,            //分机带SD卡
                Mobile_Phone,               //手机
                Emergency_Intercom_Unit,    //紧急对讲机
                IP_CAM,                     //IP摄像头
            };

            public override void EndInit()
            {
                base.EndInit();
                ColumnChanged += devDataTable_ColumnChangedEvent;
                RowChanged += devDataTable_RowChanged;
            }

            void devDataTable_RowChanged(object sender, System.Data.DataRowChangeEventArgs e)
            {
                switch (e.Action)
                {
                    case System.Data.DataRowAction.Add:
                    case System.Data.DataRowAction.Change:
                        devRow row = e.Row as devRow;
                        CheckType(row);
                        CheckAddress(row);
                        CheckIP(row);
                        CheckIPCamID(row);
                        CheckIPCamPassword(row);

                        if (!row.HasErrors)
                        {
                            lastInputIP = row.ip;
                            lastInputSubnetMask = row.sm;
                            lastInputGateway = row.gw;
                        }
                        break;
                }
            }

            private void CheckType(devRow row)
            {
                DataColumn dataColumn = tyColumn;
                if (row.ty == (Byte)DeviceType.Control_Server)
                {
                    int deviceCount = (int)this.Compute("Count(ty)", String.Format("ty = {0}", (Byte)DeviceType.Control_Server));
                    if (deviceCount > 1)
                    {
                        string errMsg = "控制伺服器只能有一臺";
                        row.SetColumnError(dataColumn, errMsg);
                        return;
                    }
                }
                row.SetColumnError(dataColumn, null);
            }

            private void CheckAddress(devRow row)
            {
                DataColumn dataColumn = roColumn;
                if (Regex.Match(row.ro, @"^\w{2}-\w{2}-\w{2}-\w{2}-\w{2}-\w{2}$").Length == 0)
                {
                    string errMsg = "格式錯誤";
                    row.SetColumnError(dataColumn, errMsg);
                    return;
                }
                row.SetColumnError(dataColumn, null);
            }

            private void CheckIP(devRow row)
            {
                DataColumn dataColumn = ipColumn;
                if (!IsValidIPAddress(row.ip))
                {
                    string errMsg = "格式錯誤";
                    row.SetColumnError(dataColumn, errMsg);
                    return;
                }
                row.SetColumnError(dataColumn, null);
            }

            private void CheckIPCamID(devRow row)
            {
                DataColumn dataColumn = idColumn;
                if (row.ty == (Byte)DeviceType.IP_CAM)
                {
                    if (row.IsidNull() || string.IsNullOrEmpty(row.id))
                    {
                        string errMsg = "IP Cam ID 不可為空";
                        row.SetColumnError(dataColumn, errMsg);
                        return;
                    }
                }
                row.SetColumnError(dataColumn, null);
            }
            private void CheckIPCamPassword(devRow row)
            {
                DataColumn dataColumn = pwColumn;
                if (row.ty == (Byte)DeviceType.IP_CAM)
                {
                    if (row.IspwNull() || string.IsNullOrEmpty(row.pw))
                    {
                        string errMsg = "IP Cam Password 不可為空";
                        row.SetColumnError(dataColumn, errMsg);
                        return;
                    }
                }
                row.SetColumnError(dataColumn, null);
            }

            private bool IsValidIPAddress(string ip)
            {
                return Regex.Match(ip, @"^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$").Length > 0;
            }

            //private void CheckAlias(devRow row)
            //{
            //    if (DBNull.Value.Equals(aliasColumn) || aliasColumn.)
            //}

            /// <summary>
            /// Do column's value validation here.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void devDataTable_ColumnChangedEvent(object sender, System.Data.DataColumnChangeEventArgs e)
            {
                devRow row = e.Row as devRow;
                if (e.Column.ColumnName == tyColumn.ColumnName)
                    CheckType(row);
                if (e.Column.ColumnName == roColumn.ColumnName)
                    CheckAddress(row);
                if (e.Column.ColumnName == ipColumn.ColumnName)
                    CheckIP(row);
                if (e.Column.ColumnName == idColumn.ColumnName)
                    CheckIPCamID(row);
                if (e.Column.ColumnName == pwColumn.ColumnName)
                    CheckIPCamPassword(row);
            }

            string lastInputIP = null;
            string lastInputSubnetMask = null;
            string lastInputGateway = null;

            public string GetDefaultIP()
            {
                string ip = lastInputIP;
                if (ip == null)
                    ip = GetIPRelatedFieldMaxValue("ip");
                if (ip != null)
                {
                    IPAddress ipObj = IPAddress.Parse(ip);
                    return ipObj.NextIPAddress().ToString();
                }

                return "192.168.1.2";
            }

            public string GetDefaultSubnetMask()
            {
                if (lastInputSubnetMask != null)
                    return lastInputSubnetMask;

                string maxSubnetMask = GetIPRelatedFieldMaxValue("sm");
                return (maxSubnetMask != null) ? maxSubnetMask : "255.255.255.0";
            }

            public string GetDefaultGateway()
            {
                if (lastInputGateway != null)
                    return lastInputGateway;

                string maxGateway = GetIPRelatedFieldMaxValue("gw");
                return (maxGateway != null) ? maxGateway : "192.168.1.1";
            }

            string GetIPRelatedFieldMaxValue(string fieldName)
            {
                var queryResult = this.AsEnumerable()
                    .OrderByDescending(device => device.Field<string>(fieldName), new IPComparer())
                    .Select(device => new { Text = device.Field<string>(fieldName) })
                    .FirstOrDefault();
                if (queryResult != null)
                    return queryResult.Text;
                return null;
            }
        }
    }
}
