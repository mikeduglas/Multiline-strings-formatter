
namespace mlsfmt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFormattedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKeepNewLines = new System.Windows.Forms.CheckBox();
            this.cbBlank1stLine = new System.Windows.Forms.CheckBox();
            this.cbLeftShift = new System.Windows.Forms.CheckBox();
            this.cbRemoveEmptyLines = new System.Windows.Forms.CheckBox();
            this.cbCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbToUtf16 = new System.Windows.Forms.CheckBox();
            this.cbApostropheAs39 = new System.Windows.Forms.CheckBox();
            this.txtRawText = new mlsfmt.TextBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFormattedText
            // 
            this.txtFormattedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormattedText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFormattedText.Location = new System.Drawing.Point(3, 35);
            this.txtFormattedText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormattedText.Multiline = true;
            this.txtFormattedText.Name = "txtFormattedText";
            this.txtFormattedText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFormattedText.Size = new System.Drawing.Size(987, 318);
            this.txtFormattedText.TabIndex = 11;
            this.txtFormattedText.WordWrap = false;
            this.txtFormattedText.TextChanged += new System.EventHandler(this.txtFormattedText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Raw text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Formatted string:";
            // 
            // cbKeepNewLines
            // 
            this.cbKeepNewLines.AutoSize = true;
            this.cbKeepNewLines.Location = new System.Drawing.Point(19, 43);
            this.cbKeepNewLines.Name = "cbKeepNewLines";
            this.cbKeepNewLines.Size = new System.Drawing.Size(146, 25);
            this.cbKeepNewLines.TabIndex = 5;
            this.cbKeepNewLines.Text = "Keep New lines";
            this.cbKeepNewLines.UseVisualStyleBackColor = true;
            this.cbKeepNewLines.CheckedChanged += new System.EventHandler(this.cbKeepNewLines_CheckedChanged);
            // 
            // cbBlank1stLine
            // 
            this.cbBlank1stLine.AutoSize = true;
            this.cbBlank1stLine.Location = new System.Drawing.Point(225, 12);
            this.cbBlank1stLine.Name = "cbBlank1stLine";
            this.cbBlank1stLine.Size = new System.Drawing.Size(137, 25);
            this.cbBlank1stLine.TabIndex = 2;
            this.cbBlank1stLine.Text = "Blank first line";
            this.cbBlank1stLine.UseVisualStyleBackColor = true;
            this.cbBlank1stLine.CheckedChanged += new System.EventHandler(this.cbBlank1stLine_CheckedChanged);
            // 
            // cbLeftShift
            // 
            this.cbLeftShift.AutoSize = true;
            this.cbLeftShift.Location = new System.Drawing.Point(409, 12);
            this.cbLeftShift.Name = "cbLeftShift";
            this.cbLeftShift.Size = new System.Drawing.Size(140, 25);
            this.cbLeftShift.TabIndex = 3;
            this.cbLeftShift.Text = "Smart left trim";
            this.cbLeftShift.UseVisualStyleBackColor = true;
            this.cbLeftShift.CheckedChanged += new System.EventHandler(this.cbLeftShift_CheckedChanged);
            // 
            // cbRemoveEmptyLines
            // 
            this.cbRemoveEmptyLines.AutoSize = true;
            this.cbRemoveEmptyLines.Checked = true;
            this.cbRemoveEmptyLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveEmptyLines.Location = new System.Drawing.Point(19, 12);
            this.cbRemoveEmptyLines.Name = "cbRemoveEmptyLines";
            this.cbRemoveEmptyLines.Size = new System.Drawing.Size(182, 25);
            this.cbRemoveEmptyLines.TabIndex = 1;
            this.cbRemoveEmptyLines.Text = "Remove empty lines";
            this.cbRemoveEmptyLines.UseVisualStyleBackColor = true;
            this.cbRemoveEmptyLines.CheckedChanged += new System.EventHandler(this.cbRemoveEmptyLines_CheckedChanged);
            // 
            // cbCopyToClipboard
            // 
            this.cbCopyToClipboard.AutoSize = true;
            this.cbCopyToClipboard.Checked = true;
            this.cbCopyToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCopyToClipboard.Location = new System.Drawing.Point(409, 43);
            this.cbCopyToClipboard.Name = "cbCopyToClipboard";
            this.cbCopyToClipboard.Size = new System.Drawing.Size(162, 25);
            this.cbCopyToClipboard.TabIndex = 7;
            this.cbCopyToClipboard.Text = "Copy to Clipboard";
            this.cbCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 75);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtRawText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtFormattedText);
            this.splitContainer1.Size = new System.Drawing.Size(993, 713);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbToUtf16
            // 
            this.cbToUtf16.AutoSize = true;
            this.cbToUtf16.Location = new System.Drawing.Point(225, 43);
            this.cbToUtf16.Name = "cbToUtf16";
            this.cbToUtf16.Size = new System.Drawing.Size(78, 25);
            this.cbToUtf16.TabIndex = 6;
            this.cbToUtf16.Text = "Utf-16";
            this.cbToUtf16.UseVisualStyleBackColor = true;
            this.cbToUtf16.CheckedChanged += new System.EventHandler(this.cbToUtf16_CheckedChanged);
            // 
            // cbApostropheAs39
            // 
            this.cbApostropheAs39.AutoSize = true;
            this.cbApostropheAs39.Location = new System.Drawing.Point(603, 12);
            this.cbApostropheAs39.Name = "cbApostropheAs39";
            this.cbApostropheAs39.Size = new System.Drawing.Size(194, 25);
            this.cbApostropheAs39.TabIndex = 4;
            this.cbApostropheAs39.Text = "Apostrophes as <39>";
            this.cbApostropheAs39.UseVisualStyleBackColor = true;
            this.cbApostropheAs39.CheckedChanged += new System.EventHandler(this.cbApostropheAs39_CheckedChanged);
            // 
            // txtRawText
            // 
            this.txtRawText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRawText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRawText.Location = new System.Drawing.Point(3, 41);
            this.txtRawText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRawText.Multiline = true;
            this.txtRawText.Name = "txtRawText";
            this.txtRawText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRawText.Size = new System.Drawing.Size(987, 311);
            this.txtRawText.TabIndex = 9;
            this.txtRawText.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 788);
            this.Controls.Add(this.cbApostropheAs39);
            this.Controls.Add(this.cbToUtf16);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cbRemoveEmptyLines);
            this.Controls.Add(this.cbCopyToClipboard);
            this.Controls.Add(this.cbLeftShift);
            this.Controls.Add(this.cbBlank1stLine);
            this.Controls.Add(this.cbKeepNewLines);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiline strings formatter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxEx txtRawText;
        private System.Windows.Forms.TextBox txtFormattedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbKeepNewLines;
        private System.Windows.Forms.CheckBox cbBlank1stLine;
        private System.Windows.Forms.CheckBox cbLeftShift;
        private System.Windows.Forms.CheckBox cbRemoveEmptyLines;
        private System.Windows.Forms.CheckBox cbCopyToClipboard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox cbToUtf16;
        private System.Windows.Forms.CheckBox cbApostropheAs39;
    }
}

