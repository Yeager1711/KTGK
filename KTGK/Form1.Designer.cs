namespace KTGK
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
            UserName = new Label();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(145, 100);
            UserName.Name = "UserName";
            UserName.Size = new Size(76, 20);
            UserName.TabIndex = 0;
            UserName.Text = "userName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(259, 100);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(222, 27);
            txtUserName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserName);
            Controls.Add(UserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private TextBox txtUserName;
    }
}