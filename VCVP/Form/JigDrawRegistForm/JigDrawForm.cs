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
    public partial class JigDrawForm : Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.FormCommonNCVP
    {
        public JigDrawForm()
        {
            InitializeComponent();
            jig_draw_dgv.AutoGenerateColumns = false;
        }

        private void JigDrawForm_Load(object sender, EventArgs e)
        {

            ValueObjectList<ModelVo> modelvolist = (ValueObjectList<ModelVo>)DefaultCbmInvoker.Invoke(new GetModelCbm(), new ModelVo());
            model_cmb.DisplayMember = "ModelCode";
            BindingSource b1 = new BindingSource(modelvolist.GetList(), null);
            model_cmb.DataSource = b1;
            model_cmb.Text = "";

            process_cmb.Text = "";

           LocalSupplierVo suppliervolist = (LocalSupplierVo)DefaultCbmInvoker.Invoke(new GetLocalSupplierMasterMntCbm(),
                new LocalSupplierVo());
            supplier_cmb.DisplayMember = "LocalSupplierName";
            supplier_cmb.DataSource = suppliervolist.LocalSupplierListVo;
            supplier_cmb.Text = "";

            ValueObjectList<DrawVo> drawvolist = (ValueObjectList<DrawVo>)DefaultCbmInvoker.Invoke(new GetDrawCbm(), new DrawVo());
            drawing_cmb.DisplayMember = "DrawCode";
            BindingSource b = new BindingSource(drawvolist.GetList(), null);
            drawing_cmb.DataSource = b;
            drawing_cmb.Text = "";
        }
        private void model_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (model_cmb.SelectedItem != null)
            {
                ModelVo mvo = (ModelVo)model_cmb.SelectedItem;
                ValueObjectList<ProcessVo> linevo = (ValueObjectList<ProcessVo>)DefaultCbmInvoker.Invoke(new GetProcessModelCbm(), new ProcessVo { ProcessId = mvo.ModelId });
                process_cmb.DisplayMember = "ProcessName";
                process_cmb.DataSource = linevo.GetList();
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (model_cmb.SelectedIndex == -1)
            {
                messageData = new MessageData("mmce00002", Properties.Resources.mmce00002, model_lbl.Text);
                logger.Info(messageData);
                DialogResult dialogResult = popUpMessage.ConfirmationOkCancel(messageData, Text);
                return;
            }
            jig_draw_dgv.DataSource = null;

            try
            {
                ValueObjectList<JigDrawVo> getList = (ValueObjectList<JigDrawVo>)DefaultCbmInvoker.Invoke(new SearchJigDrawCbm(), new JigDrawVo
                {
                    ModelCode = model_cmb.Text,
                    ProcessName = process_cmb.Text,
                    SupplierName = supplier_cmb.Text,
                    TimeReceive = timereceive_dtp.Value,
                });
                jig_draw_dgv.DataSource = getList.GetList();

            }
            catch
            { }

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (new AddJigDrawForm().ShowDialog() == DialogResult.OK)
            {
                search_btn_Click(null, null);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (jig_draw_dgv.CurrentRow != null)
            {
                if (new AddJigDrawForm { vo = (JigDrawVo)jig_draw_dgv.CurrentRow.DataBoundItem }.ShowDialog() == DialogResult.OK)
                {
                    search_btn_Click(null, null);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            model_cmb.Text = "";
            process_cmb.Text = "";
            supplier_cmb.Text = "";
        }  
    }
}
