namespace Test
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.btnLogMe = new System.Windows.Forms.Button();
            this.btnException = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.tbException = new System.Windows.Forms.TextBox();
            this.tbWarning = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cbExpandErrors = new System.Windows.Forms.CheckBox();
            this.cbExpandWarnings = new System.Windows.Forms.CheckBox();
            this.cbExpandMessages = new System.Windows.Forms.CheckBox();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.tbHeader = new System.Windows.Forms.TextBox();
            this.tbPageTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProjectPath = new System.Windows.Forms.TextBox();
            this.tbSuccess = new System.Windows.Forms.TextBox();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.cbExpandSuccesses = new System.Windows.Forms.CheckBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogMe
            // 
            this.btnLogMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogMe.Location = new System.Drawing.Point(392, 292);
            this.btnLogMe.Name = "btnLogMe";
            this.btnLogMe.Size = new System.Drawing.Size(120, 37);
            this.btnLogMe.TabIndex = 0;
            this.btnLogMe.Text = "Log Me!";
            this.btnLogMe.UseVisualStyleBackColor = false;
            this.btnLogMe.Click += new System.EventHandler(this.btnLogMe_Click);
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(12, 11);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(120, 26);
            this.btnException.TabIndex = 1;
            this.btnException.Text = "Add Exceptions";
            this.btnException.UseVisualStyleBackColor = false;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(12, 40);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(120, 26);
            this.btnWarning.TabIndex = 2;
            this.btnWarning.Text = "Add Warning";
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(12, 69);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(120, 26);
            this.btnMessage.TabIndex = 3;
            this.btnMessage.Text = "Add Message";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // tbException
            // 
            this.tbException.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbException.Location = new System.Drawing.Point(138, 12);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(374, 23);
            this.tbException.TabIndex = 4;
            this.tbException.Text = "<strong>Master Error!</strong> Everything aborted.";
            // 
            // tbWarning
            // 
            this.tbWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWarning.Location = new System.Drawing.Point(138, 41);
            this.tbWarning.Name = "tbWarning";
            this.tbWarning.Size = new System.Drawing.Size(374, 23);
            this.tbWarning.TabIndex = 5;
            this.tbWarning.Text = "A typical warning that you\'ll ignore. :D";
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(138, 70);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(374, 23);
            this.tbMessage.TabIndex = 6;
            this.tbMessage.Text = "Beautiful blue message.";
            // 
            // cbExpandErrors
            // 
            this.cbExpandErrors.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbExpandErrors.AutoSize = true;
            this.cbExpandErrors.Checked = true;
            this.cbExpandErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpandErrors.Location = new System.Drawing.Point(28, 255);
            this.cbExpandErrors.Name = "cbExpandErrors";
            this.cbExpandErrors.Size = new System.Drawing.Size(97, 19);
            this.cbExpandErrors.TabIndex = 7;
            this.cbExpandErrors.Text = "Expand Errors";
            this.cbExpandErrors.UseVisualStyleBackColor = true;
            // 
            // cbExpandWarnings
            // 
            this.cbExpandWarnings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbExpandWarnings.AutoSize = true;
            this.cbExpandWarnings.Location = new System.Drawing.Point(131, 255);
            this.cbExpandWarnings.Name = "cbExpandWarnings";
            this.cbExpandWarnings.Size = new System.Drawing.Size(117, 19);
            this.cbExpandWarnings.TabIndex = 8;
            this.cbExpandWarnings.Text = "Expand Warnings";
            this.cbExpandWarnings.UseVisualStyleBackColor = true;
            // 
            // cbExpandMessages
            // 
            this.cbExpandMessages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbExpandMessages.AutoSize = true;
            this.cbExpandMessages.Location = new System.Drawing.Point(254, 255);
            this.cbExpandMessages.Name = "cbExpandMessages";
            this.cbExpandMessages.Size = new System.Drawing.Size(118, 19);
            this.cbExpandMessages.TabIndex = 9;
            this.cbExpandMessages.Text = "Expand Messages";
            this.cbExpandMessages.UseVisualStyleBackColor = true;
            // 
            // tbProject
            // 
            this.tbProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProject.Location = new System.Drawing.Point(138, 186);
            this.tbProject.Name = "tbProject";
            this.tbProject.Size = new System.Drawing.Size(374, 23);
            this.tbProject.TabIndex = 10;
            this.tbProject.Text = "ProjectName";
            // 
            // tbHeader
            // 
            this.tbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeader.Location = new System.Drawing.Point(138, 157);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.Size = new System.Drawing.Size(374, 23);
            this.tbHeader.TabIndex = 11;
            this.tbHeader.Text = "Header Content";
            // 
            // tbPageTitle
            // 
            this.tbPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPageTitle.Location = new System.Drawing.Point(138, 128);
            this.tbPageTitle.Name = "tbPageTitle";
            this.tbPageTitle.Size = new System.Drawing.Size(374, 23);
            this.tbPageTitle.TabIndex = 12;
            this.tbPageTitle.Text = "Page Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Page Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Header Content:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Project Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Project Path:";
            // 
            // tbProjectPath
            // 
            this.tbProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProjectPath.Location = new System.Drawing.Point(138, 215);
            this.tbProjectPath.Name = "tbProjectPath";
            this.tbProjectPath.Size = new System.Drawing.Size(374, 23);
            this.tbProjectPath.TabIndex = 16;
            this.tbProjectPath.Text = "Project Path.csproj";
            // 
            // tbSuccess
            // 
            this.tbSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSuccess.Location = new System.Drawing.Point(138, 99);
            this.tbSuccess.Name = "tbSuccess";
            this.tbSuccess.Size = new System.Drawing.Size(374, 23);
            this.tbSuccess.TabIndex = 19;
            this.tbSuccess.Text = "WHOA! It works.";
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(12, 98);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(120, 26);
            this.btnSuccess.TabIndex = 18;
            this.btnSuccess.Text = "Add Success";
            this.btnSuccess.UseVisualStyleBackColor = false;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // cbExpandSuccesses
            // 
            this.cbExpandSuccesses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbExpandSuccesses.AutoSize = true;
            this.cbExpandSuccesses.Location = new System.Drawing.Point(378, 255);
            this.cbExpandSuccesses.Name = "cbExpandSuccesses";
            this.cbExpandSuccesses.Size = new System.Drawing.Size(119, 19);
            this.cbExpandSuccesses.TabIndex = 20;
            this.cbExpandSuccesses.Text = "Expand Successes";
            this.cbExpandSuccesses.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.Location = new System.Drawing.Point(12, 292);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(120, 37);
            this.btnClean.TabIndex = 21;
            this.btnClean.Text = "Clean Me!";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 341);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cbExpandSuccesses);
            this.Controls.Add(this.tbSuccess);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProjectPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPageTitle);
            this.Controls.Add(this.tbHeader);
            this.Controls.Add(this.tbProject);
            this.Controls.Add(this.cbExpandMessages);
            this.Controls.Add(this.cbExpandWarnings);
            this.Controls.Add(this.cbExpandErrors);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbWarning);
            this.Controls.Add(this.tbException);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnException);
            this.Controls.Add(this.btnLogMe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 380);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogMe;
        private System.Windows.Forms.Button btnException;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.TextBox tbWarning;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.CheckBox cbExpandErrors;
        private System.Windows.Forms.CheckBox cbExpandWarnings;
        private System.Windows.Forms.CheckBox cbExpandMessages;
        private System.Windows.Forms.TextBox tbProject;
        private System.Windows.Forms.TextBox tbHeader;
        private System.Windows.Forms.TextBox tbPageTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProjectPath;
        private System.Windows.Forms.TextBox tbSuccess;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.CheckBox cbExpandSuccesses;
        private System.Windows.Forms.Button btnClean;
    }
}

