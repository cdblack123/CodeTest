
namespace CodeTest
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dgExcelData = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbAggregate = new System.Windows.Forms.ToolStripComboBox();
            this.btnUpdateText = new System.Windows.Forms.ToolStripButton();
            this.btnSelectedComboIndex = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcelData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgExcelData
            // 
            this.dgExcelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcelData.Location = new System.Drawing.Point(0, 30);
            this.dgExcelData.Name = "dgExcelData";
            this.dgExcelData.RowHeadersWidth = 51;
            this.dgExcelData.RowTemplate.Height = 24;
            this.dgExcelData.Size = new System.Drawing.Size(1239, 646);
            this.dgExcelData.TabIndex = 0;
            this.dgExcelData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgExcelData_ColumnHeaderMouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.cmbAggregate,
            this.btnUpdateText,
            this.btnSelectedComboIndex});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1558, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(69, 36);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.ToolTipText = "Load CSV File";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1246, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // cmbAggregate
            // 
            this.cmbAggregate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAggregate.DropDownWidth = 200;
            this.cmbAggregate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAggregate.Name = "cmbAggregate";
            this.cmbAggregate.Size = new System.Drawing.Size(121, 28);
            this.cmbAggregate.SelectedIndexChanged += new System.EventHandler(this.cmbAggregate_SelectedIndexChanged);
            // 
            // btnUpdateText
            // 
            this.btnUpdateText.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateText.Image")));
            this.btnUpdateText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateText.Name = "btnUpdateText";
            this.btnUpdateText.Size = new System.Drawing.Size(142, 25);
            this.btnUpdateText.Text = "Update \'a\' to \'@\'";
            this.btnUpdateText.Click += new System.EventHandler(this.btnUpdateText_Click);
            // 
            // btnSelectedComboIndex
            // 
            this.btnSelectedComboIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectedComboIndex.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectedComboIndex.Image")));
            this.btnSelectedComboIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectedComboIndex.Name = "btnSelectedComboIndex";
            this.btnSelectedComboIndex.Size = new System.Drawing.Size(29, 25);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 701);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgExcelData);
            this.Name = "FrmMain";
            this.Text = "Data Loader";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgExcelData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgExcelData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripComboBox cmbAggregate;
        private System.Windows.Forms.ToolStripButton btnUpdateText;
        private System.Windows.Forms.ToolStripButton btnSelectedComboIndex;
    }
}

