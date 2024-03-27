namespace Projrct1
{
    partial class Registrations
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
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblJD = new System.Windows.Forms.Label();
            this.lblNat = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtJD = new System.Windows.Forms.TextBox();
            this.txtNat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(169, 18);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(184, 33);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Add Student";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(24, 140);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(117, 25);
            this.lblLN.TabIndex = 2;
            this.lblLN.Text = "Last Name :";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(24, 207);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(136, 25);
            this.lblFN.TabIndex = 3;
            this.lblFN.Text = "Father Name :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(24, 271);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(134, 25);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth :";
            // 
            // lblJD
            // 
            this.lblJD.AutoSize = true;
            this.lblJD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJD.Location = new System.Drawing.Point(24, 339);
            this.lblJD.Name = "lblJD";
            this.lblJD.Size = new System.Drawing.Size(106, 25);
            this.lblJD.TabIndex = 5;
            this.lblJD.Text = "Join Date :";
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNat.Location = new System.Drawing.Point(24, 409);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(113, 25);
            this.lblNat.TabIndex = 6;
            this.lblNat.Text = "Nationality :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(24, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(309, 543);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(175, 88);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(280, 22);
            this.textName.TabIndex = 9;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(175, 144);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(280, 22);
            this.txtLN.TabIndex = 10;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(175, 211);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(280, 22);
            this.txtFN.TabIndex = 11;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(175, 275);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(280, 22);
            this.txtDOB.TabIndex = 12;
            // 
            // txtJD
            // 
            this.txtJD.Location = new System.Drawing.Point(175, 343);
            this.txtJD.Name = "txtJD";
            this.txtJD.Size = new System.Drawing.Size(280, 22);
            this.txtJD.TabIndex = 13;
            // 
            // txtNat
            // 
            this.txtNat.Location = new System.Drawing.Point(175, 409);
            this.txtNat.Name = "txtNat";
            this.txtNat.Size = new System.Drawing.Size(280, 22);
            this.txtNat.TabIndex = 14;
            // 
            // Registrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(508, 622);
            this.Controls.Add(this.txtNat);
            this.Controls.Add(this.txtJD);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNat);
            this.Controls.Add(this.lblJD);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle2);
            this.Name = "Registrations";
            this.Text = "Registrations";
            this.Load += new System.EventHandler(this.Registrations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblJD;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtJD;
        private System.Windows.Forms.TextBox txtNat;
    }
}