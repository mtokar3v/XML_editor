using FastColoredTextBoxNS;

namespace XML_editor.Actions
{
    public static class BaseActions
    {
        public static void PrintFileStatistics(TabControl mainPanel, FlowLayoutPanel infoPanel)
        {
            var text = mainPanel.Controls[mainPanel.SelectedIndex].Controls[0].Text;
            var length = text.Length;
            var lines = text.Count(s => s == '\n') + 1;
            infoPanel.Controls[0].Text = $"length: {length} lines: {lines}";
        }

        public static void SetUpUndoRedoButtons(FastColoredTextBox fctb, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                fctb.Undo();
            }

            if (e.KeyCode == Keys.Y && (Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                fctb.Redo();
            }
        }
    }
}
