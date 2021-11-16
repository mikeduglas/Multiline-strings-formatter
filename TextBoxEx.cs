using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mlsfmt
{
    public class TextBoxEx : TextBox
    {
        const int WM_PASTE = 0x302;
        public event EventHandler TextPasted;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Trap WM_PASTE:
            if (m.Msg == WM_PASTE && Clipboard.ContainsText())
            {
                OnTextPasted(new EventArgs());
                return;
            }
        }
        protected virtual void OnTextPasted(EventArgs e)
        {
            EventHandler handler = TextPasted;
            handler?.Invoke(this, e);
        }
    }
}
