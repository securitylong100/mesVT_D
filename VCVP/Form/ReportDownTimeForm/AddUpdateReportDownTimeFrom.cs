﻿using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;


using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    public partial class AddUpdateReportDownTimeFrom : Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.FormCommonNCVP
    {
        public AddUpdateReportDownTimeFrom()
        {
            InitializeComponent();
        }
        public ReportDownTimeVo reportDownTimeVo = new ReportDownTimeVo();
        private void model_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelVo mvo = (ModelVo)model_cmb.SelectedItem;
            ValueObjectList<LineVo> linevo = (ValueObjectList<LineVo>)DefaultCbmInvoker.Invoke(new GetLineMoCbm(), new LineVo { LineId = mvo.ModelId });
            line_cmb.DisplayMember = "LineCode";
            line_cmb.DataSource = linevo.GetList();
        }

        private void process_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (process_cmb.SelectedIndex >= 0)
            {
                process_work_cmb.Text = "";
                ProcessWorkVo processworkms = (ProcessWorkVo)DefaultCbmInvoker.Invoke(new GetProcessWorkMasterMntCbm(), new ProcessWorkVo { ProcessId = ((ProcessVo)process_cmb.SelectedItem).ProcessId });
                process_work_cmb.DisplayMember = "ProcessWorkName";
                BindingSource b5 = new BindingSource(processworkms.ProcessWorkListVo, null);
                process_work_cmb.DataSource = b5;
            }
        }

        private void machine_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (machine_cmb.SelectedItem != null)
            {
                MachineVo mvo = (MachineVo)machine_cmb.SelectedItem;
                ValueObjectList<DefectiveReasonVo> defectivereasonvo = (ValueObjectList<DefectiveReasonVo>)DefaultCbmInvoker.Invoke(new GetCauseAndDefectiveCbm(), new DefectiveReasonVo { DefectiveReasonId = mvo.MachineId });
                cause_cmb.DisplayMember = "DefectiveReasonName";
                cause_cmb.DataSource = defectivereasonvo.GetList();

                ValueObjectList<ProdutionWorkContentVo> respmachinevolist = (ValueObjectList<ProdutionWorkContentVo>)DefaultCbmInvoker.Invoke(new GetActicAndContentCbm(), new ProdutionWorkContentVo { ProdutionWorkContentId = mvo.MachineId });
                action_cmb.DisplayMember = "ProdutionWorkContentName";
                action_cmb.DataSource = respmachinevolist.GetList();
            }
        }

        private void AddUpdateReportDownTimeFrom_Load(object sender, EventArgs e)
        {
            ValueObjectList<ModelVo> modelvolist = (ValueObjectList<ModelVo>)DefaultCbmInvoker.Invoke(new GetModelCbm(), new ModelVo());
            model_cmb.DisplayMember = "ModelCode";
            BindingSource b1 = new BindingSource(modelvolist.GetList(), null);
            model_cmb.DataSource = b1;
            model_cmb.Text = "";

            ProcessVo processvo = (ProcessVo)DefaultCbmInvoker.Invoke(new GetProcessMasterMntCbm(), new ProcessVo());
            process_cmb.DisplayMember = "ProcessName";
            BindingSource b2 = new BindingSource(processvo.ProcessListVo, null);
            process_cmb.DataSource = b2;
            process_cmb.Text = "";

            MachineVo machinevo = (MachineVo)DefaultCbmInvoker.Invoke(new GetMachineMasterMntCbm(), new MachineVo());
            machine_cmb.DisplayMember = "MachineName";
            BindingSource b4 = new BindingSource(machinevo.MachineListVo, null);
            machine_cmb.DataSource = b4;
            machine_cmb.Text = "";

            process_work_cmb.Text = "";
            line_cmb.Text = "";
            cause_cmb.Text = "";
            action_cmb.Text = "";

            if (reportDownTimeVo.DowntimeReportId > 0)
            {
                model_cmb.Text = reportDownTimeVo.ModelCode;
                machine_cmb.Enabled = false;
                process_cmb.Text = reportDownTimeVo.ProcessName;
                process_work_cmb.Text = reportDownTimeVo.ProcessWorkName;
                line_cmb.Text = reportDownTimeVo.LineCode;
                cause_cmb.Text = reportDownTimeVo.DefectiveReasonName;
                action_cmb.Text = reportDownTimeVo.ProductionWorkContentName;
                remake_txt.Text = reportDownTimeVo.Remakes;
            }
        }
        bool checkdata()
        {
            if (model_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, model_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                model_cmb.Focus();
                return false;
            }
            if (process_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, process_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                process_cmb.Focus();
                return false;
            }
            if (process_work_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, process_work_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                process_work_cmb.Focus();
                return false;
            }
            if (line_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, line_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                line_cmb.Focus();
                return false;
            }
            if (machine_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, machine_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                machine_cmb.Focus();
                return false;
            }
            if (action_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, action_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                action_cmb.Focus();
                return false;
            }
            if (cause_cmb.SelectedItem ==null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, cause_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                cause_cmb.Focus();
                return false;
            }
            if (timefrom_dtp.Value> timeto_dtp.Value)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, "Time Error");
                popUpMessage.Warning(messageData, Text);
                timefrom_dtp.Focus();
                return false;
            }

            return true;
        }
        private void buttonCommon1_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                ReportDownTimeVo outVo = new ReportDownTimeVo();
                ReportDownTimeVo inVo = new ReportDownTimeVo
                {
                    DowntimeReportId = this.reportDownTimeVo.DowntimeReportId,
                    TimeFrom = this.timefrom_dtp.Value,
                    TimeTo = this.timeto_dtp.Value,
                    Remakes = this.remake_txt.Text,
                    LineId = ((LineVo)this.line_cmb.SelectedItem).LineId,
                    MachineId = ((MachineVo)this.machine_cmb.SelectedItem).MachineId,
                    ModelId = ((ModelVo)this.model_cmb.SelectedItem).ModelId,
                    ProcessWorkId = ((ProcessWorkVo)this.process_work_cmb.SelectedItem).ProcessId,
                    ProductionWorkContentId = ((ProdutionWorkContentVo)this.action_cmb.SelectedItem).ProdutionWorkContentId,
                    DefectiveReasonId = ((DefectiveReasonVo)this.cause_cmb.SelectedItem).DefectiveReasonId,
                    RegistrationUserCode = UserData.GetUserData().UserCode,
                    FactoryCode = UserData.GetUserData().FactoryCode
                };
                try
                {

                    if (inVo.DowntimeReportId > 0)
                    {
                        outVo = (ReportDownTimeVo)DefaultCbmInvoker.Invoke(new UpdateReportDownTimeCbm(), inVo);
                    }
                    else
                    {
                        outVo = (ReportDownTimeVo)DefaultCbmInvoker.Invoke(new AddReportDownTimeCbm(), inVo);
                    }
                }
                catch (Com.Nidec.Mes.Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                    return;
                }
                if (outVo.AffectedCount > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }

        private void buttonCommon2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}