namespace WinFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetDllFiles = new Button();
            lbxMethodNames = new ListBox();
            txtOperant1 = new TextBox();
            txtOperant2 = new TextBox();
            lblResult = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // btnGetDllFiles
            // 
            btnGetDllFiles.Location = new Point(52, 43);
            btnGetDllFiles.Name = "btnGetDllFiles";
            btnGetDllFiles.Size = new Size(179, 23);
            btnGetDllFiles.TabIndex = 0;
            btnGetDllFiles.Text = "Lood Plagins";
            btnGetDllFiles.UseVisualStyleBackColor = true;
            btnGetDllFiles.Click += btnGetDllFiles_Click;
            // 
            // lbxMethodNames
            // 
            lbxMethodNames.FormattingEnabled = true;
            lbxMethodNames.ItemHeight = 15;
            lbxMethodNames.Location = new Point(52, 90);
            lbxMethodNames.Name = "lbxMethodNames";
            lbxMethodNames.Size = new Size(179, 229);
            lbxMethodNames.TabIndex = 1;
            // 
            // txtOperant1
            // 
            txtOperant1.Location = new Point(324, 53);
            txtOperant1.Name = "txtOperant1";
            txtOperant1.Size = new Size(148, 23);
            txtOperant1.TabIndex = 2;
            // 
            // txtOperant2
            // 
            txtOperant2.Location = new Point(324, 82);
            txtOperant2.Name = "txtOperant2";
            txtOperant2.Size = new Size(148, 23);
            txtOperant2.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(324, 136);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(148, 23);
            lblResult.TabIndex = 4;
            lblResult.Text = "label";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(324, 197);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(148, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(txtOperant2);
            Controls.Add(txtOperant1);
            Controls.Add(lbxMethodNames);
            Controls.Add(btnGetDllFiles);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetDllFiles;
        private ListBox lbxMethodNames;
        private TextBox txtOperant1;
        private TextBox txtOperant2;
        private Label lblResult;
        private Button btnCalculate;
    }
}