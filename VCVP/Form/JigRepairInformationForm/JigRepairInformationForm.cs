using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.Framework;


using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    public partial class JigRepairInformationForm : Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.FormCommonNCVP
    {
        public JigRepairInformationForm()
        {
            InitializeComponent();
            jig_repair_information_dgv.AutoGenerateColumns = false;
        }

     

        private void JigRepairInformationForm_Load(object sender, EventArgs e)
        {


            ValueObjectList<ModelVo> modelvolist = (ValueObjectList<ModelVo>)DefaultCbmInvoker.Invoke(new GetModelCbm(), new ModelVo());
            model_cmb.DisplayMember = "ModelCode";
            BindingSource b1 = new BindingSource(modelvolist.GetList(), null);
            model_cmb.DataSource = b1;
            model_cmb.Text = "";

            ProcessWorkVo processw = (ProcessWorkVo)DefaultCbmInvoker.Invoke(new GetProcessWorkMasterMntCbm(), new ProcessWorkVo());
            process_work_cmb.DisplayMember = "ProcessWorkName";
            BindingSource b2 = new BindingSource(processw.ProcessWorkListVo, null);
            process_work_cmb.DataSource = b2;
            process_work_cmb.Text = "";

            ValueObjectList<JigResponseVo> respmachinevolist = (ValueObjectList<JigResponseVo>)DefaultCbmInvoker.Invoke(new GetJigResponseCbm(),
                new JigResponseVo());
            jigresponse_cmb.DisplayMember = "JigResponseName";
            jigresponse_cmb.DataSource = respmachinevolist.GetList();
            jigresponse_cmb.Text = "";

            ValueObjectList<JigCauseVo> respmachinevolist12 = (ValueObjectList<JigCauseVo>)DefaultCbmInvoker.Invoke(new GetJigCauseCbm(),
                new JigCauseVo());
            jigause_cmb.DisplayMember = "JigCauseName";
            jigause_cmb.DataSource = respmachinevolist12.GetList();
            jigause_cmb.Text = "";

            line_cmb.Text = "";
        }

        private void model_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (model_cmb.SelectedItem != null)
            {
                ModelVo mvo = (ModelVo)model_cmb.SelectedItem;
                ValueObjectList<LineVo> linevo = (ValueObjectList<LineVo>)DefaultCbmInvoker.Invoke(new GetLineMoCbm(), new LineVo { LineId = mvo.ModelId });
                line_cmb.DisplayMember = "LineCode";
                line_cmb.DataSource = linevo.GetList();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (model_cmb.SelectedIndex == -1)
            {
                MessageData messageData = new MessageData("mmce00002", Properties.Resources.mmce00002, model_lbl.Text);
                logger.Info(messageData);
                DialogResult dialogResult = popUpMessage.ConfirmationOkCancel(messageData, Text);
                return;
            }
            jig_repair_information_dgv.DataSource = null;

            try
            {
                ValueObjectList<JigRepairInformationVo> getList = (ValueObjectList<JigRepairInformationVo>)DefaultCbmInvoker.Invoke(new SearchJigRepairInformationCbm(), new JigRepairInformationVo
                {
                    ModelCode = model_cmb.Text,
                    JigRepairCode = jig_code_txt.Text,
                    ProcessWorkName = process_work_cmb.Text,
                    LineCode = line_cmb.Text,
                    JigCauseName = jigause_cmb.Text,
                    JigResponseName = jigresponse_cmb.Text,
                    TimeFrom = timefrom_dtp.Value,
                    TimeTo = timeto_dtp.Value
                });
                jig_repair_information_dgv.DataSource = getList.GetList();

            }
            catch
            { }

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (new AddJigRepairInformationForm().ShowDialog() == DialogResult.OK)
            {
                search_btn_Click(null, null);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (jig_repair_information_dgv.CurrentRow != null)
            {
                if (new AddJigRepairInformationForm { jvo = (JigRepairInformationVo)jig_repair_information_dgv.CurrentRow.DataBoundItem }.ShowDialog() == DialogResult.OK)
                {
                    search_btn_Click(null, null);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            model_cmb.Text = "";
            jig_code_txt.Text = "";
            process_work_cmb.Text = "";
            line_cmb.Text = "";
            jigause_cmb.Text = "";
            jigresponse_cmb.Text = "";
        }  
    }
}
