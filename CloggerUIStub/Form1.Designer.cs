namespace CloggerUIStub
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
            CmdTestFileLogger = new Button();
            CmdBrowse = new Button();
            LblOutPath = new Label();
            SuspendLayout();
            // 
            // CmdTestFileLogger
            // 
            CmdTestFileLogger.Location = new Point(126, 76);
            CmdTestFileLogger.Name = "CmdTestFileLogger";
            CmdTestFileLogger.Size = new Size(75, 23);
            CmdTestFileLogger.TabIndex = 0;
            CmdTestFileLogger.Text = "File Logger";
            CmdTestFileLogger.UseVisualStyleBackColor = true;
            CmdTestFileLogger.Click += CmdTestFileLogger_Click;
            // 
            // CmdBrowse
            // 
            CmdBrowse.Location = new Point(218, 76);
            CmdBrowse.Name = "CmdBrowse";
            CmdBrowse.Size = new Size(75, 23);
            CmdBrowse.TabIndex = 1;
            CmdBrowse.Text = "Browse";
            CmdBrowse.UseVisualStyleBackColor = true;
            CmdBrowse.Click += CmdBrowse_Click;
            // 
            // LblOutPath
            // 
            LblOutPath.BorderStyle = BorderStyle.Fixed3D;
            LblOutPath.Location = new Point(95, 115);
            LblOutPath.Name = "LblOutPath";
            LblOutPath.Size = new Size(237, 23);
            LblOutPath.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblOutPath);
            Controls.Add(CmdBrowse);
            Controls.Add(CmdTestFileLogger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdTestFileLogger;
        private Button CmdBrowse;
        private Label LblOutPath;
    }
}
