
namespace InputConvert
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.cSharpGroup = new System.Windows.Forms.GroupBox();
            this.cSharpLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.toStringBuilderCommand = new System.Windows.Forms.Button();
            this.toArrayCommand = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.cSharpGroup.SuspendLayout();
            this.cSharpLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Location = new System.Drawing.Point(17, 23);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(1328, 442);
            this.inputText.TabIndex = 0;
            // 
            // cSharpGroup
            // 
            this.cSharpGroup.Controls.Add(this.cSharpLayout);
            this.cSharpGroup.Location = new System.Drawing.Point(17, 500);
            this.cSharpGroup.Name = "cSharpGroup";
            this.cSharpGroup.Size = new System.Drawing.Size(737, 179);
            this.cSharpGroup.TabIndex = 1;
            this.cSharpGroup.TabStop = false;
            this.cSharpGroup.Text = "C#";

            // 
            // cSharpLayout
            // 
            this.cSharpLayout.Controls.Add(this.toStringBuilderCommand);
            this.cSharpLayout.Controls.Add(this.toArrayCommand);
            this.cSharpLayout.Location = new System.Drawing.Point(19, 47);
            this.cSharpLayout.Name = "cSharpLayout";
            this.cSharpLayout.Size = new System.Drawing.Size(671, 70);
            this.cSharpLayout.TabIndex = 0;
            // 
            // toStringBuilderCommand
            // 
            this.toStringBuilderCommand.Location = new System.Drawing.Point(3, 3);
            this.toStringBuilderCommand.Name = "toStringBuilderCommand";
            this.toStringBuilderCommand.Size = new System.Drawing.Size(362, 58);
            this.toStringBuilderCommand.TabIndex = 0;
            this.toStringBuilderCommand.Text = "To StringBuilder";
            this.toStringBuilderCommand.UseVisualStyleBackColor = true;
            this.toStringBuilderCommand.Click += new System.EventHandler(this.toStringBuilderCommand_Click);
            // 
            // toArrayCommand
            // 
            this.toArrayCommand.Location = new System.Drawing.Point(371, 3);
            this.toArrayCommand.Name = "toArrayCommand";
            this.toArrayCommand.Size = new System.Drawing.Size(289, 58);
            this.toArrayCommand.TabIndex = 1;
            this.toArrayCommand.Text = "To Array";
            this.toArrayCommand.UseVisualStyleBackColor = true;
            this.toArrayCommand.Click += new System.EventHandler(this.toArrayCommand_Click);
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.Location = new System.Drawing.Point(17, 661);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(1328, 253);
            this.outputText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 945);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.cSharpGroup);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cSharpGroup.ResumeLayout(false);
            this.cSharpLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.GroupBox cSharpGroup;
        private System.Windows.Forms.FlowLayoutPanel cSharpLayout;
        private System.Windows.Forms.Button toStringBuilderCommand;
        private System.Windows.Forms.Button toArrayCommand;
        private System.Windows.Forms.TextBox outputText;
    }
}

