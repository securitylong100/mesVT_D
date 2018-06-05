using Com.Nidec.Mes.Framework;
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
    public partial class AddJigDrawForm : Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form.FormCommonNCVP
    {
        public AddJigDrawForm()
        {
            InitializeComponent();
        }
        public JigDrawVo vo = new JigDrawVo();

        private static GetModelCbm getModelCbm = new GetModelCbm();


        private void AddJigDrawForm_Load(object sender, EventArgs e)
        {
            status_cmb.Items.Add("OK");
            status_cmb.Items.Add("NG");

            ValueObjectList<ModelVo> modelvolist = null;
            try
            {
                modelvolist = (ValueObjectList<ModelVo>)DefaultCbmInvoker.Invoke(getModelCbm, new ModelVo());
            }
            catch (Com.Nidec.Mes.Framework.ApplicationException ex)
            {
                logger.Error(ex.GetMessageData());
                popUpMessage.ApplicationError(ex.GetMessageData(), Text);
                return;
            }
            model_cmb.DisplayMember = "ModelCode";
            BindingSource b1 = new BindingSource(modelvolist.GetList(), null);
            model_cmb.DataSource = b1;
            model_cmb.Text = "";

            ValueObjectList<DrawVo> drawvolist = null;
            try
            {
                drawvolist = (ValueObjectList<DrawVo>)DefaultCbmInvoker.Invoke(new GetDrawCbm(), new DrawVo());
            }
            catch (Com.Nidec.Mes.Framework.ApplicationException ex)
            {
                logger.Error(ex.GetMessageData());
                popUpMessage.ApplicationError(ex.GetMessageData(), Text);
                return;
            }
            drawing_cmb.DisplayMember = "DrawCode";
            BindingSource b = new BindingSource(drawvolist.GetList(), null);
            drawing_cmb.DataSource = b;
            drawing_cmb.Text = "";

            LocalSupplierVo suppliervolist = null;
            try
            {
                suppliervolist = (LocalSupplierVo)DefaultCbmInvoker.Invoke(new GetLocalSupplierMasterMntCbm(), new LocalSupplierVo());
            }
            catch (Com.Nidec.Mes.Framework.ApplicationException ex)
            {
                logger.Error(ex.GetMessageData());
                popUpMessage.ApplicationError(ex.GetMessageData(), Text);
                return;
            }
            supplier_cmb.DisplayMember = "LocalSupplierName";
            BindingSource b2 = new BindingSource(suppliervolist.LocalSupplierListVo, null);
            supplier_cmb.DataSource = b2;
            supplier_cmb.Text = "";

            if (vo.JigID > 0)
            {
                model_cmb.Enabled = false;
                supplier_cmb.Enabled = false;
                model_cmb.Text = vo.ModelCode;
                supplier_cmb.Text = vo.SupplierName;
                process_cmb.Text = vo.ProcessName;
                jig_code_txt.Text = vo.JigBCode;
                drawing_cmb.Text = vo.DrawCode;
                place_cmb.Text = vo.JigPlace;
                status_cmb.Text = vo.Status;
                timereceive_dtp.Value = vo.TimeReceive;
            }
        }

        private void model_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (model_cmb.SelectedItem != null)
            {
                ModelVo mvo = (ModelVo)model_cmb.SelectedItem;
                ValueObjectList<ProcessVo> linevo = (ValueObjectList<ProcessVo>)DefaultCbmInvoker.Invoke(new GetProcessModelCbm(), new ProcessVo { ProcessId = mvo.ModelId });
                process_cmb.DisplayMember = "ProcessName";
                process_cmb.DataSource = linevo.GetList();
                process_cmb.Text = "";
            }
        }
        bool checkdata()
        {
            if (model_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, model_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                model_cmb.Focus();
                return false;
            }

            if (process_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, process_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                process_cmb.Focus();
                return false;
            }

            if (jig_code_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, jig_code_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                jig_code_txt.Focus();
                return false;
            }

            if (place_cmb.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, place_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                place_cmb.Focus();
                return false;
            }

            if (status_cmb.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, status_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                status_cmb.Focus();
                return false;
            }

            return true;
        }
        private void buttonCommon1_Click(object sender, EventArgs e) // ok buttion
        {
            if (!checkdata()) { return; }
            JigDrawVo outVo = new JigDrawVo();
            JigDrawVo inVo = new JigDrawVo
            {
                JigID = vo.JigID,
                TimeReceive = this.timereceive_dtp.Value,
                ModelId = ((ModelVo)this.model_cmb.SelectedItem).ModelId,
                ProcessId = ((ProcessVo)this.process_cmb.SelectedItem).ProcessId,
                JigBCode = jig_code_txt.Text,
                SupplierId = ((LocalSupplierVo)this.supplier_cmb.SelectedItem).LocalSupplierId,
                DrawId = ((DrawVo)this.drawing_cmb.SelectedItem).DrawId,
                RegistrationUserCode = UserData.GetUserData().UserCode,
                FactoryCode = UserData.GetUserData().FactoryCode,

                //---------------
                Status = status_cmb.Text,
                JigPlace = place_cmb.Text
            };

            try
            {
                if (inVo.JigID > 0)
                {
                    outVo = (JigDrawVo)DefaultCbmInvoker.Invoke(new UpdateJigDrawCbm(), inVo);
                }
                else
                {
                    outVo = (JigDrawVo)DefaultCbmInvoker.Invoke(new AddJigDrawCbm(), inVo);
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

        private void buttonCommon2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
