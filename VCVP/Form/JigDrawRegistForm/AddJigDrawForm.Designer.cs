namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddJigDrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJigDrawForm));
            this.jig_code_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.jig_code_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timereceive_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timereceive_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.buttonCommon2 = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.buttonCommon1 = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.place_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.process_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.drawing_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.drawing_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.status_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.process_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.place_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.status_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.Supplier_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.supplier_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.revision_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.revision_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.SuspendLayout();
            // 
            // jig_code_txt
            // 
            this.jig_code_txt.ControlId = null;
            resources.ApplyResources(this.jig_code_txt, "jig_code_txt");
            this.jig_code_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.jig_code_txt.Name = "jig_code_txt";
            // 
            // jig_code_lbl
            // 
            resources.ApplyResources(this.jig_code_lbl, "jig_code_lbl");
            this.jig_code_lbl.ControlId = null;
            this.jig_code_lbl.Name = "jig_code_lbl";
            // 
            // timereceive_lbl
            // 
            resources.ApplyResources(this.timereceive_lbl, "timereceive_lbl");
            this.timereceive_lbl.ControlId = null;
            this.timereceive_lbl.Name = "timereceive_lbl";
            // 
            // timereceive_dtp
            // 
            this.timereceive_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timereceive_dtp.ControlId = null;
            resources.ApplyResources(this.timereceive_dtp, "timereceive_dtp");
            this.timereceive_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timereceive_dtp.Name = "timereceive_dtp";
            this.timereceive_dtp.Value = new System.DateTime(2017, 7, 11, 0, 0, 0, 0);
            // 
            // model_cmb
            // 
            this.model_cmb.ControlId = null;
            resources.ApplyResources(this.model_cmb, "model_cmb");
            this.model_cmb.FormattingEnabled = true;
            this.model_cmb.Name = "model_cmb";
            this.model_cmb.SelectedIndexChanged += new System.EventHandler(this.model_cmb_SelectedIndexChanged);
            // 
            // model_lbl
            // 
            resources.ApplyResources(this.model_lbl, "model_lbl");
            this.model_lbl.ControlId = null;
            this.model_lbl.Name = "model_lbl";
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
            // buttonCommon1
            // 
            this.buttonCommon1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCommon1.ControlId = null;
            resources.ApplyResources(this.buttonCommon1, "buttonCommon1");
            this.buttonCommon1.Name = "buttonCommon1";
            this.buttonCommon1.UseVisualStyleBackColor = false;
            this.buttonCommon1.Click += new System.EventHandler(this.buttonCommon1_Click);
            // 
            // place_lbl
            // 
            resources.ApplyResources(this.place_lbl, "place_lbl");
            this.place_lbl.ControlId = null;
            this.place_lbl.Name = "place_lbl";
            // 
            // process_lbl
            // 
            resources.ApplyResources(this.process_lbl, "process_lbl");
            this.process_lbl.ControlId = null;
            this.process_lbl.Name = "process_lbl";
            // 
            // drawing_cmb
            // 
            this.drawing_cmb.ControlId = null;
            resources.ApplyResources(this.drawing_cmb, "drawing_cmb");
            this.drawing_cmb.FormattingEnabled = true;
            this.drawing_cmb.Name = "drawing_cmb";
            // 
            // drawing_lbl
            // 
            resources.ApplyResources(this.drawing_lbl, "drawing_lbl");
            this.drawing_lbl.ControlId = null;
            this.drawing_lbl.Name = "drawing_lbl";
            // 
            // status_lbl
            // 
            resources.ApplyResources(this.status_lbl, "status_lbl");
            this.status_lbl.ControlId = null;
            this.status_lbl.Name = "status_lbl";
            // 
            // process_cmb
            // 
            this.process_cmb.ControlId = null;
            resources.ApplyResources(this.process_cmb, "process_cmb");
            this.process_cmb.FormattingEnabled = true;
            this.process_cmb.Name = "process_cmb";
            // 
            // place_cmb
            // 
            this.place_cmb.ControlId = null;
            resources.ApplyResources(this.place_cmb, "place_cmb");
            this.place_cmb.FormattingEnabled = true;
            this.place_cmb.Items.AddRange(new object[] {
            resources.GetString("place_cmb.Items"),
            resources.GetString("place_cmb.Items1")});
            this.place_cmb.Name = "place_cmb";
            // 
            // status_cmb
            // 
            this.status_cmb.ControlId = null;
            resources.ApplyResources(this.status_cmb, "status_cmb");
            this.status_cmb.FormattingEnabled = true;
            this.status_cmb.Name = "status_cmb";
            // 
            // Supplier_lbl
            // 
            resources.ApplyResources(this.Supplier_lbl, "Supplier_lbl");
            this.Supplier_lbl.ControlId = null;
            this.Supplier_lbl.Name = "Supplier_lbl";
            // 
            // supplier_cmb
            // 
            this.supplier_cmb.ControlId = null;
            resources.ApplyResources(this.supplier_cmb, "supplier_cmb");
            this.supplier_cmb.FormattingEnabled = true;
            this.supplier_cmb.Name = "supplier_cmb";
            // 
            // revision_lbl
            // 
            resources.ApplyResources(this.revision_lbl, "revision_lbl");
            this.revision_lbl.ControlId = null;
            this.revision_lbl.Name = "revision_lbl";
            // 
            // revision_txt
            // 
            this.revision_txt.ControlId = null;
            resources.ApplyResources(this.revision_txt, "revision_txt");
            this.revision_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.revision_txt.Name = "revision_txt";
            // 
            // AddJigDrawForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.revision_txt);
            this.Controls.Add(this.status_cmb);
            this.Controls.Add(this.supplier_cmb);
            this.Controls.Add(this.place_cmb);
            this.Controls.Add(this.drawing_cmb);
            this.Controls.Add(this.drawing_lbl);
            this.Controls.Add(this.revision_lbl);
            this.Controls.Add(this.process_lbl);
            this.Controls.Add(this.Supplier_lbl);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.place_lbl);
            this.Controls.Add(this.buttonCommon2);
            this.Controls.Add(this.buttonCommon1);
            this.Controls.Add(this.jig_code_txt);
            this.Controls.Add(this.jig_code_lbl);
            this.Controls.Add(this.timereceive_lbl);
            this.Controls.Add(this.timereceive_dtp);
            this.Controls.Add(this.process_cmb);
            this.Controls.Add(this.model_cmb);
            this.Controls.Add(this.model_lbl);
            this.Name = "AddJigDrawForm";
            this.Load += new System.EventHandler(this.AddJigDrawForm_Load);
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.model_cmb, 0);
            this.Controls.SetChildIndex(this.process_cmb, 0);
            this.Controls.SetChildIndex(this.timereceive_dtp, 0);
            this.Controls.SetChildIndex(this.timereceive_lbl, 0);
            this.Controls.SetChildIndex(this.jig_code_lbl, 0);
            this.Controls.SetChildIndex(this.jig_code_txt, 0);
            this.Controls.SetChildIndex(this.buttonCommon1, 0);
            this.Controls.SetChildIndex(this.buttonCommon2, 0);
            this.Controls.SetChildIndex(this.place_lbl, 0);
            this.Controls.SetChildIndex(this.status_lbl, 0);
            this.Controls.SetChildIndex(this.Supplier_lbl, 0);
            this.Controls.SetChildIndex(this.process_lbl, 0);
            this.Controls.SetChildIndex(this.revision_lbl, 0);
            this.Controls.SetChildIndex(this.drawing_lbl, 0);
            this.Controls.SetChildIndex(this.drawing_cmb, 0);
            this.Controls.SetChildIndex(this.place_cmb, 0);
            this.Controls.SetChildIndex(this.supplier_cmb, 0);
            this.Controls.SetChildIndex(this.status_cmb, 0);
            this.Controls.SetChildIndex(this.revision_txt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.TextBoxCommon jig_code_txt;
        private Framework.LabelCommon jig_code_lbl;
        private Framework.LabelCommon timereceive_lbl;
        private Framework.DateTimePickerCommon timereceive_dtp;
        private Framework.ComboBoxCommon model_cmb;
        private Framework.LabelCommon model_lbl;
        private Framework.ButtonCommon buttonCommon2;
        private Framework.ButtonCommon buttonCommon1;
        private Framework.LabelCommon place_lbl;
        private Framework.LabelCommon process_lbl;
        private Framework.ComboBoxCommon drawing_cmb;
        private Framework.LabelCommon drawing_lbl;
        private Framework.LabelCommon status_lbl;
        private Framework.ComboBoxCommon process_cmb;
        private Framework.ComboBoxCommon place_cmb;
        private Framework.ComboBoxCommon status_cmb;
        private Framework.LabelCommon Supplier_lbl;
        private Framework.ComboBoxCommon supplier_cmb;
        private Framework.LabelCommon revision_lbl;
        private Framework.TextBoxCommon revision_txt;
    }
}
