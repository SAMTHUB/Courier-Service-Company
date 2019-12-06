namespace Courier_Service_Company
{
    partial class Data
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textcities = new System.Windows.Forms.TextBox();
            this.textnameofcities = new System.Windows.Forms.TextBox();
            this.btnNameofCities = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNoofCities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(120, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "No of Cities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(120, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of Cities";
            // 
            // textcities
            // 
            this.textcities.Location = new System.Drawing.Point(339, 149);
            this.textcities.Name = "textcities";
            this.textcities.Size = new System.Drawing.Size(139, 20);
            this.textcities.TabIndex = 4;
            this.textcities.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textnameofcities
            // 
            this.textnameofcities.Location = new System.Drawing.Point(339, 249);
            this.textnameofcities.Name = "textnameofcities";
            this.textnameofcities.Size = new System.Drawing.Size(139, 20);
            this.textnameofcities.TabIndex = 5;
            this.textnameofcities.TextChanged += new System.EventHandler(this.Textnameofcities_TextChanged);
            // 
            // btnNameofCities
            // 
            this.btnNameofCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNameofCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameofCities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNameofCities.Location = new System.Drawing.Point(544, 231);
            this.btnNameofCities.Name = "btnNameofCities";
            this.btnNameofCities.Size = new System.Drawing.Size(80, 38);
            this.btnNameofCities.TabIndex = 7;
            this.btnNameofCities.Text = "OK";
            this.btnNameofCities.UseVisualStyleBackColor = false;
            this.btnNameofCities.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(242, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cities Data";
            // 
            // btnNoofCities
            // 
            this.btnNoofCities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNoofCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoofCities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNoofCities.Location = new System.Drawing.Point(544, 131);
            this.btnNoofCities.Name = "btnNoofCities";
            this.btnNoofCities.Size = new System.Drawing.Size(80, 38);
            this.btnNoofCities.TabIndex = 9;
            this.btnNoofCities.Text = "OK";
            this.btnNoofCities.UseVisualStyleBackColor = false;
            this.btnNoofCities.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoofCities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNameofCities);
            this.Controls.Add(this.textnameofcities);
            this.Controls.Add(this.textcities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcities;
        private System.Windows.Forms.TextBox textnameofcities;
        private System.Windows.Forms.Button btnNameofCities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNoofCities;
    }
}