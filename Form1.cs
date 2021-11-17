using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mlsfmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtRawText.TextPasted += TxtRawText_TextPasted;

            splitContainer1.Focus();
            splitContainer1.ActiveControl = txtRawText;
        }

        private string FormatText()
        {
            string rawText = txtRawText.Text;
            if (string.IsNullOrEmpty(rawText))
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            // add 1st empty line
            if (cbBlank1stLine.Checked)
            {
                sb.AppendLine("  '' |");
            }

            // all raw lines
            string[] lines = rawText.Split(
                new string[] { Environment.NewLine },
                cbRemoveEmptyLines.Checked ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None
            );

            // handle special chars {, <, ', tabs
            if (!cbToUtf16.Checked)
            {
                string apostropheString = cbApostropheAs39.Checked ? "<39>" : "''";
                string tabString = "        ";

                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Replace("{", "{{").Replace("<", "<<").Replace("'", apostropheString).Replace("\t", tabString);
                }
            }

            // shift left
            if (cbLeftShift.Checked)
            {
                // find minimum number of spaces to shift left.
                int nMinLeftSpaces = lines.Max(x => x.Length);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length > 0)
                    {
                        int nSpaceCount = lines[i].TakeWhile(c => char.IsWhiteSpace(c)).Count();
                        if (nSpaceCount < nMinLeftSpaces)
                            nMinLeftSpaces = nSpaceCount;
                    }
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length > nMinLeftSpaces)
                        lines[i] = lines[i].Substring(nMinLeftSpaces);
                }
            }

            // to Utf-16
            if (cbToUtf16.Checked)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    StringBuilder sbLine = new StringBuilder();

                    for (int j=0; j < lines[i].Length; j++)
                    {
                        int c = (int)lines[i][j];
                        byte lowByte = (byte)(c % 256);
                        byte hiByte = (byte)(c / 256);

                        // if hiByte is 0 then show ascii symbol and <0>, otherwise show byte codes
                        if (hiByte == 0)
                        {
                            string sChar;

                            switch ((char)c)
                            {
                                case '{':
                                    sChar = "{{";
                                    break;
                                case '<':
                                    sChar = "<<";
                                    break;
                                case '\'':
                                    sChar = cbApostropheAs39.Checked ? "<39>" : "''";
                                    break;
                                case '\t':
                                    sChar = "<9>";
                                    break;
                                default:
                                    sChar = ((char)c).ToString();
                                    break;
                            }
                            sbLine.AppendFormat("{0}<0>", sChar);
                        }
                        else
                            sbLine.AppendFormat("<{0},{1}>", lowByte, hiByte);
                    }

                    lines[i] = sbLine.ToString();
                }
            }

            // string concatenator position: 2 chars at the right of max string length
            int strConcatPos = lines.Max(x => x.Length) + 2;

            // new line chars
            string newLine = cbToUtf16.Checked ? "<13,0><10,0>" : "<13,10>";

            // process...
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                // is it last line?
                bool bIsLastLine = (i == lines.Length - 1);

                // should prepend &
                bool bPrependAmpersand = (i > 0) || cbBlank1stLine.Checked;

                // add <13,10> at the end of line
                bool bAddNewLine = !bIsLastLine && cbKeepNewLines.Checked;

                sb.AppendFormat("{0}'{1}{2}'",
                    bPrependAmpersand ? "& " : "  ", 
                    line, 
                    bAddNewLine ? newLine : "");

                if (!bIsLastLine)
                {
                    // align string concatenator |
                    int numSpaces = strConcatPos - line.Length;
                    if (numSpaces <= 0)
                        numSpaces = 4;

                    string spaces = new string(' ', numSpaces);
                    sb.AppendFormat("{0}|", spaces);
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        private void TxtRawText_TextPasted(object sender, EventArgs e)
        {
            // fromat raw text
            txtFormattedText.Text = FormatText();
        }

        private void cbBlank1stLine_CheckedChanged(object sender, EventArgs e)
        {
            txtFormattedText.Text = FormatText();
        }

        private void cbKeepNewLines_CheckedChanged(object sender, EventArgs e)
        {
            txtFormattedText.Text = FormatText();
        }

        private void cbLeftShift_CheckedChanged(object sender, EventArgs e)
        {
            txtFormattedText.Text = FormatText();
        }

        private void cbRemoveEmptyLines_CheckedChanged(object sender, EventArgs e)
        {
            txtFormattedText.Text = FormatText();
        }

        private void cbToUtf16_CheckedChanged(object sender, EventArgs e)
        {
            txtFormattedText.Text = FormatText();
        }

        private void cbApostropheAs39_CheckedChanged(object sender, EventArgs e)
        {
            txtFormattedText.Text = FormatText();
        }

        private void txtFormattedText_TextChanged(object sender, EventArgs e)
        {
            if (cbCopyToClipboard.Checked && !string.IsNullOrEmpty(txtFormattedText.Text))
                Clipboard.SetText(txtFormattedText.Text, TextDataFormat.Text);
        }
    }
}
