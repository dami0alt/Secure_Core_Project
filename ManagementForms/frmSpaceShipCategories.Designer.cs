
namespace ManagementForms
{
    partial class frmSpaceShipCategories
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
            this.lblCodeShip = new System.Windows.Forms.Label();
            this.lblDescShip = new System.Windows.Forms.Label();
            this.swTextbox1 = new SecureCoreInheritedControl.SWTextbox();
            this.swTextbox2 = new SecureCoreInheritedControl.SWTextbox();
            this.SuspendLayout();
            // 
            // lblCodeShip
            // 
            this.lblCodeShip.AutoSize = true;
            this.lblCodeShip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCodeShip.Location = new System.Drawing.Point(59, 104);
            this.lblCodeShip.Name = "lblCodeShip";
            this.lblCodeShip.Size = new System.Drawing.Size(85, 18);
            this.lblCodeShip.TabIndex = 4;
            this.lblCodeShip.Text = "Ship Code";
            // 
            // lblDescShip
            // 
            this.lblDescShip.AutoSize = true;
            this.lblDescShip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDescShip.Location = new System.Drawing.Point(23, 169);
            this.lblDescShip.Name = "lblDescShip";
            this.lblDescShip.Size = new System.Drawing.Size(126, 18);
            this.lblDescShip.TabIndex = 5;
            this.lblDescShip.Text = "Ship Description";
            // 
            // swTextbox1
            // 
            this.swTextbox1.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox1.DatabaseName = "";
            this.swTextbox1.IsForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(165, 104);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NullSpace = true;
            this.swTextbox1.Size = new System.Drawing.Size(131, 21);
            this.swTextbox1.TabIndex = 6;
            // 
            // swTextbox2
            // 
            this.swTextbox2.AllowedData = SecureCoreInheritedControl.DataType.Text;
            this.swTextbox2.DatabaseName = "";
            this.swTextbox2.IsForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(165, 168);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NullSpace = true;
            this.swTextbox2.Size = new System.Drawing.Size(131, 21);
            this.swTextbox2.TabIndex = 7;
            // 
            // frmSpaceShipCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 614);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.lblDescShip);
            this.Controls.Add(this.lblCodeShip);
            this.MinimumSize = new System.Drawing.Size(1067, 653);
            this.Name = "frmSpaceShipCategories";
            this.Text = "frmSpaceShipCategories";
            this.Controls.SetChildIndex(this.lblCodeShip, 0);
            this.Controls.SetChildIndex(this.lblDescShip, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeShip;
        private System.Windows.Forms.Label lblDescShip;
        private SecureCoreInheritedControl.SWTextbox swTextbox1;
        private SecureCoreInheritedControl.SWTextbox swTextbox2;
    }
}