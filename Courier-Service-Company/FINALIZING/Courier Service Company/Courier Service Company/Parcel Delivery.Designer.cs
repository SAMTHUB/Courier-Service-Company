namespace Courier_Service_Company
{
    partial class Parcel_Delivery
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
            this.label3 = new System.Windows.Forms.Label();
            this.textPClaim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPFee = new System.Windows.Forms.TextBox();
            this.textPDate = new System.Windows.Forms.TextBox();
            this.textPNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPDes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPItem = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(220, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parcel Delivery ";
            // 
            // textPClaim
            // 
            this.textPClaim.Location = new System.Drawing.Point(327, 243);
            this.textPClaim.Name = "textPClaim";
            this.textPClaim.Size = new System.Drawing.Size(100, 20);
            this.textPClaim.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(85, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Description";
            // 
            // textPFee
            // 
            this.textPFee.Location = new System.Drawing.Point(327, 161);
            this.textPFee.Name = "textPFee";
            this.textPFee.Size = new System.Drawing.Size(100, 20);
            this.textPFee.TabIndex = 25;
            // 
            // textPDate
            // 
            this.textPDate.Location = new System.Drawing.Point(327, 203);
            this.textPDate.Name = "textPDate";
            this.textPDate.Size = new System.Drawing.Size(100, 20);
            this.textPDate.TabIndex = 24;
            // 
            // textPNum
            // 
            this.textPNum.Location = new System.Drawing.Point(327, 122);
            this.textPNum.Name = "textPNum";
            this.textPNum.Size = new System.Drawing.Size(100, 20);
            this.textPNum.TabIndex = 23;
            this.textPNum.TextChanged += new System.EventHandler(this.textPNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(85, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Previous Claim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(85, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Delivery Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(85, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Delivery Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(85, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Item Type";
            // 
            // textPDes
            // 
            this.textPDes.Location = new System.Drawing.Point(327, 280);
            this.textPDes.Name = "textPDes";
            this.textPDes.Size = new System.Drawing.Size(100, 20);
            this.textPDes.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(85, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Delivery Time";
            // 
            // textPItem
            // 
            this.textPItem.Location = new System.Drawing.Point(327, 319);
            this.textPItem.Name = "textPItem";
            this.textPItem.Size = new System.Drawing.Size(100, 20);
            this.textPItem.TabIndex = 31;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit.Location = new System.Drawing.Point(507, 295);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 44);
            this.submit.TabIndex = 32;
            this.submit.Text = "Next";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Parcel_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textPItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPDes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPClaim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPFee);
            this.Controls.Add(this.textPDate);
            this.Controls.Add(this.textPNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Parcel_Delivery";
            this.Text = "Parcel_Delivery";
            this.Load += new System.EventHandler(this.Parcel_Delivery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPClaim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPFee;
        private System.Windows.Forms.TextBox textPDate;
        private System.Windows.Forms.TextBox textPNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPDes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPItem;
        private System.Windows.Forms.Button submit;
    }
}