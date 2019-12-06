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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cities = new System.Windows.Forms.TextBox();
            this.txt_CityName = new System.Windows.Forms.TextBox();
            this.btn_OKcityName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OKcities = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // txt_cities
            // 
            this.txt_cities.Location = new System.Drawing.Point(339, 149);
            this.txt_cities.Name = "txt_cities";
            this.txt_cities.Size = new System.Drawing.Size(139, 20);
            this.txt_cities.TabIndex = 4;
            this.txt_cities.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txt_cities.Validating += new System.ComponentModel.CancelEventHandler(this.txt_cities_validating);
            // 
            // txt_CityName
            // 
            this.txt_CityName.Location = new System.Drawing.Point(339, 249);
            this.txt_CityName.Name = "txt_CityName";
            this.txt_CityName.Size = new System.Drawing.Size(139, 20);
            this.txt_CityName.TabIndex = 5;
            this.txt_CityName.TextChanged += new System.EventHandler(this.Textnameofcities_TextChanged);
            // 
            // btn_OKcityName
            // 
            this.btn_OKcityName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_OKcityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKcityName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OKcityName.Location = new System.Drawing.Point(544, 231);
            this.btn_OKcityName.Name = "btn_OKcityName";
            this.btn_OKcityName.Size = new System.Drawing.Size(80, 38);
            this.btn_OKcityName.TabIndex = 7;
            this.btn_OKcityName.Text = "OK";
            this.btn_OKcityName.UseVisualStyleBackColor = false;
            this.btn_OKcityName.Click += new System.EventHandler(this.Button1_Click);
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
            // btn_OKcities
            // 
            this.btn_OKcities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_OKcities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OKcities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OKcities.Location = new System.Drawing.Point(544, 131);
            this.btn_OKcities.Name = "btn_OKcities";
            this.btn_OKcities.Size = new System.Drawing.Size(80, 38);
            this.btn_OKcities.TabIndex = 9;
            this.btn_OKcities.Text = "OK";
            this.btn_OKcities.UseVisualStyleBackColor = false;
            this.btn_OKcities.Click += new System.EventHandler(this.Button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OKcities);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OKcityName);
            this.Controls.Add(this.txt_CityName);
            this.Controls.Add(this.txt_cities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Data";
            this.Text = "Data";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cities;
        private System.Windows.Forms.TextBox txt_CityName;
        private System.Windows.Forms.Button btn_OKcityName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OKcities;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}