namespace Robocopier
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxSource = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxTarget = new TextBox();
            buttonRobocopy = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxSource
            // 
            textBoxSource.Location = new Point(63, 12);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(427, 23);
            textBoxSource.TabIndex = 0;
            textBoxSource.TextChanged += textBoxSource_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Source:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Target:";
            // 
            // textBoxTarget
            // 
            textBoxTarget.Location = new Point(63, 41);
            textBoxTarget.Name = "textBoxTarget";
            textBoxTarget.Size = new Size(427, 23);
            textBoxTarget.TabIndex = 2;
            textBoxTarget.TextChanged += textBoxTarget_TextChanged;
            // 
            // buttonRobocopy
            // 
            buttonRobocopy.Enabled = false;
            buttonRobocopy.Location = new Point(496, 41);
            buttonRobocopy.Name = "buttonRobocopy";
            buttonRobocopy.Size = new Size(75, 23);
            buttonRobocopy.TabIndex = 4;
            buttonRobocopy.Text = "Robocopy";
            buttonRobocopy.UseVisualStyleBackColor = true;
            buttonRobocopy.Click += buttonRobocopy_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 75);
            Controls.Add(buttonRobocopy);
            Controls.Add(label2);
            Controls.Add(textBoxTarget);
            Controls.Add(label1);
            Controls.Add(textBoxSource);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Robocopier";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSource;
        private Label label1;
        private Label label2;
        private TextBox textBoxTarget;
        private Button buttonRobocopy;
        private ToolTip toolTip1;
    }
}