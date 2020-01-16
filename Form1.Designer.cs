namespace GetServerDatabase
{
    partial class Form1
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
            this.数据服务器 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cboDatabase = new System.Windows.Forms.ComboBox();
            this.m_serverText = new System.Windows.Forms.TextBox();
            this.m_searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 数据服务器
            // 
            this.数据服务器.AutoSize = true;
            this.数据服务器.Location = new System.Drawing.Point(214, 136);
            this.数据服务器.Name = "数据服务器";
            this.数据服务器.Size = new System.Drawing.Size(65, 12);
            this.数据服务器.TabIndex = 1;
            this.数据服务器.Text = "数据服务器";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择数据库";
            // 
            // m_cboDatabase
            // 
            this.m_cboDatabase.FormattingEnabled = true;
            this.m_cboDatabase.Location = new System.Drawing.Point(285, 168);
            this.m_cboDatabase.Name = "m_cboDatabase";
            this.m_cboDatabase.Size = new System.Drawing.Size(121, 20);
            this.m_cboDatabase.TabIndex = 0;
            // 
            // m_serverText
            // 
            this.m_serverText.Location = new System.Drawing.Point(285, 133);
            this.m_serverText.Name = "m_serverText";
            this.m_serverText.Size = new System.Drawing.Size(121, 21);
            this.m_serverText.TabIndex = 2;
            // 
            // m_searchButton
            // 
            this.m_searchButton.Location = new System.Drawing.Point(412, 131);
            this.m_searchButton.Name = "m_searchButton";
            this.m_searchButton.Size = new System.Drawing.Size(46, 23);
            this.m_searchButton.TabIndex = 3;
            this.m_searchButton.Text = "查询";
            this.m_searchButton.UseVisualStyleBackColor = true;
            this.m_searchButton.Click += new System.EventHandler(this.OnSearchButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_searchButton);
            this.Controls.Add(this.m_serverText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.数据服务器);
            this.Controls.Add(this.m_cboDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 数据服务器;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cboDatabase;
        private System.Windows.Forms.TextBox m_serverText;
        private System.Windows.Forms.Button m_searchButton;
    }
}

