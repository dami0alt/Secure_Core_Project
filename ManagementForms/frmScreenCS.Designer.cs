
namespace ManagementForms
{
    partial class frmScreenCS
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.swTextbox2 = new SecureCoreInheritedControl.SWTextbox();
            this.swTextbox1 = new SecureCoreInheritedControl.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 38);
            this.pnlHeader.TabIndex = 4;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(0, 336);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(1070, 278);
            this.dgvData.TabIndex = 5;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(941, 274);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // swTextbox2
            // 
            this.swTextbox2.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox2.ControlID = null;
            this.swTextbox2.DatabaseName = "";
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(85, 138);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NullSpace = true;
            this.swTextbox2.Size = new System.Drawing.Size(254, 26);
            this.swTextbox2.TabIndex = 8;
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox1.ControlID = "id";
            this.swTextbox1.DatabaseName = "DescRank";
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(85, 80);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NullSpace = true;
            this.swTextbox1.Size = new System.Drawing.Size(254, 26);
            this.swTextbox1.TabIndex = 7;
            // 
            // frmScreenCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1070, 643);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmScreenCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.frmScreenCS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSearch;
        private SecureCoreInheritedControl.SWTextbox swTextbox1;
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
    }
}