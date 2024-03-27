namespace Projrct1
{
    partial class ListOfStudents
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
            this.lblLOS = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnBCK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblJD = new System.Windows.Forms.Label();
            this.lblNat = new System.Windows.Forms.Label();
            this.txtNat = new System.Windows.Forms.TextBox();
            this.txtJD = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLOS
            // 
            this.lblLOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLOS.AutoSize = true;
            this.lblLOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOS.Location = new System.Drawing.Point(139, 23);
            this.lblLOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLOS.Name = "lblLOS";
            this.lblLOS.Size = new System.Drawing.Size(451, 39);
            this.lblLOS.TabIndex = 2;
            this.lblLOS.Text = "List of Students Registered";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(48, 86);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 49);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<=";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(612, 86);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 49);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "=>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(348, 94);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(55, 31);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "0/0";
            // 
            // btnBCK
            // 
            this.btnBCK.BackColor = System.Drawing.Color.White;
            this.btnBCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCK.Location = new System.Drawing.Point(48, 644);
            this.btnBCK.Margin = new System.Windows.Forms.Padding(4);
            this.btnBCK.Name = "btnBCK";
            this.btnBCK.Size = new System.Drawing.Size(185, 42);
            this.btnBCK.TabIndex = 21;
            this.btnBCK.Text = "Back";
            this.btnBCK.UseVisualStyleBackColor = false;
            this.btnBCK.Click += new System.EventHandler(this.btnBCK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(484, 644);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 42);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(43, 183);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 25);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name :";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(43, 264);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(117, 25);
            this.lblLN.TabIndex = 24;
            this.lblLN.Text = "Last Name :";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(43, 341);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(136, 25);
            this.lblFN.TabIndex = 25;
            this.lblFN.Text = "Father Name :";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(43, 420);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(134, 25);
            this.lblDOB.TabIndex = 26;
            this.lblDOB.Text = "Date Of Birth :";
            // 
            // lblJD
            // 
            this.lblJD.AutoSize = true;
            this.lblJD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJD.Location = new System.Drawing.Point(43, 499);
            this.lblJD.Name = "lblJD";
            this.lblJD.Size = new System.Drawing.Size(106, 25);
            this.lblJD.TabIndex = 27;
            this.lblJD.Text = "Join Date :";
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNat.Location = new System.Drawing.Point(43, 573);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(113, 25);
            this.lblNat.TabIndex = 28;
            this.lblNat.Text = "Nationality :";
            // 
            // txtNat
            // 
            this.txtNat.Location = new System.Drawing.Point(234, 577);
            this.txtNat.Name = "txtNat";
            this.txtNat.Size = new System.Drawing.Size(435, 22);
            this.txtNat.TabIndex = 34;
            // 
            // txtJD
            // 
            this.txtJD.Location = new System.Drawing.Point(234, 503);
            this.txtJD.Name = "txtJD";
            this.txtJD.Size = new System.Drawing.Size(435, 22);
            this.txtJD.TabIndex = 33;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(234, 424);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(435, 22);
            this.txtDOB.TabIndex = 32;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(234, 345);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(435, 22);
            this.txtFN.TabIndex = 31;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(234, 254);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(435, 22);
            this.txtLN.TabIndex = 30;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(435, 22);
            this.txtName.TabIndex = 29;
            // 
            // ListOfStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(699, 729);
            this.Controls.Add(this.txtNat);
            this.Controls.Add(this.txtJD);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNat);
            this.Controls.Add(this.lblJD);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBCK);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLOS);
            this.Name = "ListOfStudents";
            this.Text = "ListOfStudents";
            this.Load += new System.EventHandler(this.ListOfStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLOS;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnBCK;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblJD;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.TextBox txtNat;
        private System.Windows.Forms.TextBox txtJD;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtName;
    }
}