namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddUpdateReportDownTimeFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateReportDownTimeFrom));
            this.timefrom_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timefrom_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.timeto_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.timeto_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.action_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.line_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.cause_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.process_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.action_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.process_work_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.line_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.cause_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.process_work_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.process_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.buttonCommon1 = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.remake_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.remake_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.buttonCommon2 = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.SuspendLayout();
            // 
            // timefrom_lbl
            // 
            resources.ApplyResources(this.timefrom_lbl, "timefrom_lbl");
            this.timefrom_lbl.ControlId = null;
            this.timefrom_lbl.Name = "timefrom_lbl";
            // 
            // timefrom_dtp
            // 
            this.timefrom_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timefrom_dtp.ControlId = null;
            resources.ApplyResources(this.timefrom_dtp, "timefrom_dtp");
            this.timefrom_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timefrom_dtp.Name = "timefrom_dtp";
            // 
            // timeto_dtp
            // 
            this.timeto_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timeto_dtp.ControlId = null;
            resources.ApplyResources(this.timeto_dtp, "timeto_dtp");
            this.timeto_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeto_dtp.Name = "timeto_dtp";
            // 
            // timeto_lbl
            // 
            resources.ApplyResources(this.timeto_lbl, "timeto_lbl");
            this.timeto_lbl.ControlId = null;
            this.timeto_lbl.Name = "timeto_lbl";
            // 
            // action_lbl
            // 
            resources.ApplyResources(this.action_lbl, "action_lbl");
            this.action_lbl.ControlId = null;
            this.action_lbl.Name = "action_lbl";
            // 
            // line_cmb
            // 
            this.line_cmb.ControlId = null;
            resources.ApplyResources(this.line_cmb, "line_cmb");
            this.line_cmb.FormattingEnabled = true;
            this.line_cmb.Name = "line_cmb";
            // 
            // cause_cmb
            // 
            this.cause_cmb.ControlId = null;
            resources.ApplyResources(this.cause_cmb, "cause_cmb");
            this.cause_cmb.FormattingEnabled = true;
            this.cause_cmb.Name = "cause_cmb";
            // 
            // process_cmb
            // 
            this.process_cmb.ControlId = null;
            resources.ApplyResources(this.process_cmb, "process_cmb");
            this.process_cmb.FormattingEnabled = true;
            this.process_cmb.Name = "process_cmb";
            this.process_cmb.SelectedIndexChanged += new System.EventHandler(this.process_cmb_SelectedIndexChanged);
            // 
            // action_cmb
            // 
            this.action_cmb.ControlId = null;
            resources.ApplyResources(this.action_cmb, "action_cmb");
            this.action_cmb.FormattingEnabled = true;
            this.action_cmb.Name = "action_cmb";
            // 
            // process_work_cmb
            // 
            this.process_work_cmb.ControlId = null;
            resources.ApplyResources(this.process_work_cmb, "process_work_cmb");
            this.process_work_cmb.FormattingEnabled = true;
            this.process_work_cmb.Name = "process_work_cmb";
            // 
            // line_lbl
            // 
            resources.ApplyResources(this.line_lbl, "line_lbl");
            this.line_lbl.ControlId = null;
            this.line_lbl.Name = "line_lbl";
            // 
            // machine_cmb
            // 
            this.machine_cmb.ControlId = null;
            resources.ApplyResources(this.machine_cmb, "machine_cmb");
            this.machine_cmb.FormattingEnabled = true;
            this.machine_cmb.Name = "machine_cmb";
            this.machine_cmb.SelectedIndexChanged += new System.EventHandler(this.machine_cmb_SelectedIndexChanged);
            // 
            // model_cmb
            // 
            this.model_cmb.ControlId = null;
            resources.ApplyResources(this.model_cmb, "model_cmb");
            this.model_cmb.FormattingEnabled = true;
            this.model_cmb.Name = "model_cmb";
            this.model_cmb.SelectedIndexChanged += new System.EventHandler(this.model_cmb_SelectedIndexChanged);
            // 
            // cause_lbl
            // 
            resources.ApplyResources(this.cause_lbl, "cause_lbl");
            this.cause_lbl.ControlId = null;
            this.cause_lbl.Name = "cause_lbl";
            // 
            // process_work_lbl
            // 
            resources.ApplyResources(this.process_work_lbl, "process_work_lbl");
            this.process_work_lbl.ControlId = null;
            this.process_work_lbl.Name = "process_work_lbl";
            // 
            // machine_lbl
            // 
            resources.ApplyResources(this.machine_lbl, "machine_lbl");
            this.machine_lbl.ControlId = null;
            this.machine_lbl.Name = "machine_lbl";
            // 
            // process_lbl
            // 
            resources.ApplyResources(this.process_lbl, "process_lbl");
            this.process_lbl.ControlId = null;
            this.process_lbl.Name = "process_lbl";
            // 
            // model_lbl
            // 
            resources.ApplyResources(this.model_lbl, "model_lbl");
            this.model_lbl.ControlId = null;
            this.model_lbl.Name = "model_lbl";
            // 
            // buttonCommon1
            // 
            this.buttonCommon1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCommon1.ControlId = null;
            resources.ApplyResources(this.buttonCommon1, "buttonCommon1");
            this.buttonCommon1.Name = "buttonCommon1";
            this.buttonCommon1.UseVisualStyleBackColor = false;
            this.buttonCommon1.Click += new System.EventHandler(this.buttonCommon1_Click);
            // 
            // remake_txt
            // 
            this.remake_txt.ControlId = null;
            resources.ApplyResources(this.remake_txt, "remake_txt");
            this.remake_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.remake_txt.Name = "remake_txt";
            // 
            // remake_lbl
            // 
            resources.ApplyResources(this.remake_lbl, "remake_lbl");
            this.remake_lbl.ControlId = null;
            this.remake_lbl.Name = "remake_lbl";
            // 
            // buttonCommon2
            // 
            this.buttonCommon2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCommon2.ControlId = null;
            resources.ApplyResources(this.buttonCommon2, "buttonCommon2");
            this.buttonCommon2.Name = "buttonCommon2";
            this.buttonCommon2.UseVisualStyleBackColor = false;
            this.buttonCommon2.Click += new System.EventHandler(this.buttonCommon2_Click);
            // 
            // AddUpdateReportDownTimeFrom
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.buttonCommon2);
            this.Controls.Add(this.remake_lbl);
            this.Controls.Add(this.remake_txt);
            this.Controls.Add(this.buttonCommon1);
            this.Controls.Add(this.timefrom_lbl);
            this.Controls.Add(this.timefrom_dtp);
            this.Controls.Add(this.timeto_dtp);
            this.Controls.Add(this.timeto_lbl);
            this.Controls.Add(this.action_lbl);
            this.Controls.Add(this.line_cmb);
            this.Controls.Add(this.cause_cmb);
            this.Controls.Add(this.process_cmb);
            this.Controls.Add(this.action_cmb);
            this.Controls.Add(this.process_work_cmb);
            this.Controls.Add(this.line_lbl);
            this.Controls.Add(this.machine_cmb);
            this.Controls.Add(this.model_cmb);
            this.Controls.Add(this.cause_lbl);
            this.Controls.Add(this.process_work_lbl);
            this.Controls.Add(this.machine_lbl);
            this.Controls.Add(this.process_lbl);
            this.Controls.Add(this.model_lbl);
            this.Name = "AddUpdateReportDownTimeFrom";
            this.Load += new System.EventHandler(this.AddUpdateReportDownTimeFrom_Load);
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.process_lbl, 0);
            this.Controls.SetChildIndex(this.machine_lbl, 0);
            this.Controls.SetChildIndex(this.process_work_lbl, 0);
            this.Controls.SetChildIndex(this.cause_lbl, 0);
            this.Controls.SetChildIndex(this.model_cmb, 0);
            this.Controls.SetChildIndex(this.machine_cmb, 0);
            this.Controls.SetChildIndex(this.line_lbl, 0);
            this.Controls.SetChildIndex(this.process_work_cmb, 0);
            this.Controls.SetChildIndex(this.action_cmb, 0);
            this.Controls.SetChildIndex(this.process_cmb, 0);
            this.Controls.SetChildIndex(this.cause_cmb, 0);
            this.Controls.SetChildIndex(this.line_cmb, 0);
            this.Controls.SetChildIndex(this.action_lbl, 0);
            this.Controls.SetChildIndex(this.timeto_lbl, 0);
            this.Controls.SetChildIndex(this.timeto_dtp, 0);
            this.Controls.SetChildIndex(this.timefrom_dtp, 0);
            this.Controls.SetChildIndex(this.timefrom_lbl, 0);
            this.Controls.SetChildIndex(this.buttonCommon1, 0);
            this.Controls.SetChildIndex(this.remake_txt, 0);
            this.Controls.SetChildIndex(this.remake_lbl, 0);
            this.Controls.SetChildIndex(this.buttonCommon2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.LabelCommon timefrom_lbl;
        private Framework.DateTimePickerCommon timefrom_dtp;
        private Framework.DateTimePickerCommon timeto_dtp;
        private Framework.LabelCommon timeto_lbl;
        private Framework.LabelCommon action_lbl;
        private Framework.ComboBoxCommon line_cmb;
        private Framework.ComboBoxCommon cause_cmb;
        private Framework.ComboBoxCommon process_cmb;
        private Framework.ComboBoxCommon action_cmb;
        private Framework.ComboBoxCommon process_work_cmb;
        private Framework.LabelCommon line_lbl;
        private Framework.ComboBoxCommon machine_cmb;
        private Framework.ComboBoxCommon model_cmb;
        private Framework.LabelCommon cause_lbl;
        private Framework.LabelCommon process_work_lbl;
        private Framework.LabelCommon machine_lbl;
        private Framework.LabelCommon process_lbl;
        private Framework.LabelCommon model_lbl;
        private Framework.ButtonCommon buttonCommon1;
        private Framework.TextBoxCommon remake_txt;
        private Framework.LabelCommon remake_lbl;
        private Framework.ButtonCommon buttonCommon2;
    }
}
