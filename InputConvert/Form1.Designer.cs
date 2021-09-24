
namespace InputConvert
{
    partial class InputConvert
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
            this.cSharpLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.toStringBuilderCommand = new System.Windows.Forms.Button();
            this.toArrayCommand = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.unquotedIn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cSharpLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.Location = new System.Drawing.Point(0, 0);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputText.Size = new System.Drawing.Size(1703, 646);
            this.inputText.TabIndex = 0;
            // 
            // cSharpLayout
            // 
            this.cSharpLayout.Controls.Add(this.toStringBuilderCommand);
            this.cSharpLayout.Controls.Add(this.toArrayCommand);
            this.cSharpLayout.Controls.Add(this.button1);
            this.cSharpLayout.Controls.Add(this.unquotedIn);
            this.cSharpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSharpLayout.Location = new System.Drawing.Point(3, 3);
            this.cSharpLayout.Name = "cSharpLayout";
            this.cSharpLayout.Size = new System.Drawing.Size(1703, 113);
            this.cSharpLayout.TabIndex = 0;
            // 
            // toStringBuilderCommand
            // 
            this.toStringBuilderCommand.Location = new System.Drawing.Point(3, 3);
            this.toStringBuilderCommand.Name = "toStringBuilderCommand";
            this.toStringBuilderCommand.Size = new System.Drawing.Size(362, 58);
            this.toStringBuilderCommand.TabIndex = 0;
            this.toStringBuilderCommand.Text = "C# StringBuilder";
            this.toStringBuilderCommand.UseVisualStyleBackColor = true;
            this.toStringBuilderCommand.Click += new System.EventHandler(this.toStringBuilderCommand_Click);
            // 
            // toArrayCommand
            // 
            this.toArrayCommand.Location = new System.Drawing.Point(371, 3);
            this.toArrayCommand.Name = "toArrayCommand";
            this.toArrayCommand.Size = new System.Drawing.Size(289, 58);
            this.toArrayCommand.TabIndex = 1;
            this.toArrayCommand.Text = "C# Array";
            this.toArrayCommand.UseVisualStyleBackColor = true;
            this.toArrayCommand.Click += new System.EventHandler(this.toArrayCommand_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "SQL IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unquotedIn
            // 
            this.unquotedIn.Location = new System.Drawing.Point(860, 3);
            this.unquotedIn.Name = "unquotedIn";
            this.unquotedIn.Size = new System.Drawing.Size(295, 58);
            this.unquotedIn.TabIndex = 3;
            this.unquotedIn.Text = "Unquoted SQL IN";
            this.unquotedIn.UseVisualStyleBackColor = true;
            this.unquotedIn.Click += new System.EventHandler(this.unquotedIn_Click);
            // 
            // outputText
            // 
            this.outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputText.Location = new System.Drawing.Point(0, 0);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputText.Size = new System.Drawing.Size(1703, 301);
            this.outputText.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cSharpLayout, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1709, 1097);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 122);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.outputText);
            this.splitContainer1.Size = new System.Drawing.Size(1703, 951);
            this.splitContainer1.SplitterDistance = 646;
            this.splitContainer1.TabIndex = 2;
            // 
            // InputConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 1097);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InputConvert";
            this.Text = "Input Convert";
            this.cSharpLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.FlowLayoutPanel cSharpLayout;
        private System.Windows.Forms.Button toStringBuilderCommand;
        private System.Windows.Forms.Button toArrayCommand;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button unquotedIn;
    }
}

