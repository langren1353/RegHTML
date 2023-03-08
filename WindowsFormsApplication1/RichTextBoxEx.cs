using System;
using System.Windows.Forms;

class RichTextBoxEx : RichTextBox
{
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        if (!base.AutoWordSelection)
        {
            base.AutoWordSelection = true;
            base.AutoWordSelection = false;
        }
    }
}

