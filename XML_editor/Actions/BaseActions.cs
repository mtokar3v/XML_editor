using FastColoredTextBoxNS;
using XML_editor.Builders;
using XML_editor.Extensions;
using XML_editor.Models;

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

        public static void CloseTab(TabControl mainPanel, MouseEventArgs e)
        {
            var crossSize = new Size(12, 12);
            for (var i = 0; i < mainPanel.TabPages.Count; i++)
            {
                var tab = mainPanel.GetTabRect(i);
                var cross = new Rectangle(
                    tab.Right - crossSize.Width,
                    tab.Top + (tab.Height - crossSize.Height) / 2,
                    crossSize.Width,
                    crossSize.Height);

                if (cross.Contains(e.Location))
                {
                    mainPanel.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        public static void Undo(TabControl mainPanel)
        {
            var fctb = GetCurrentFctb(mainPanel);
            if (fctb != null)
            {
                fctb.Undo();
            }
            else
            {
                MessageBox.Show("TextBox is not found");
            }
        }
        public static void Redo(TabControl mainPanel) 
        { 
            var fctb = GetCurrentFctb(mainPanel);
            if (fctb != null)
            {
                fctb.Redo();
            }
            else
            {
                MessageBox.Show("TextBox is not found");
            }
        } 

        public static void OpenFile(TabControl mainPanel, FlowLayoutPanel infoPanel, OpenFileDialog openFileDialog)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog.SafeFileName.FileNameWithoutExtensions();
            var path = openFileDialog.FileName;
            var fileText = File.ReadAllText(path);

            var fctb = new FastColoredTextBoxBuilder()
                .WithDefaultSettings()
                .WithText(fileText)
                .WithGetInfoEvent(mainPanel, infoPanel)
                .WithUndoRedoEvent()
                .Build();

            var newTab = new TabPageBuilder()
                .WithNameAndText(filename)
                .With3dBorders()
                .WithColor(Color.Black)
                .WithLocation((int)Constants.TabLocationX, (int)Constants.TabLocationY)
                .WithControls(fctb)
                .Build();

            mainPanel.Controls.Add(newTab);
        }

        public static void SaveFile(TabControl mainPanel, SaveFileDialog saveFileDialog)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            var filename = saveFileDialog.FileName;

            var fctb = GetCurrentFctb(mainPanel);
            if(fctb == null)
            {
                MessageBox.Show("TextBox is not found");
                return; 
            }

            var text = fctb.Text;
            File.WriteAllText(filename, text);
        }

        public static void CreateFile(TabControl mainPanel, FlowLayoutPanel infoPanel)
        {
            var fctb = new FastColoredTextBoxBuilder()
                .WithDefaultSettings()
                .WithGetInfoEvent(mainPanel, infoPanel)
                .WithUndoRedoEvent()
                .Build();

            var newTab = new TabPageBuilder()
                .WithNameAndText()
                .With3dBorders()
                .WithColor(Color.Black)
                .WithLocation((int)Constants.TabLocationX, (int)Constants.TabLocationY)
                .WithControls(fctb)
                .Build();

            mainPanel.Controls.Add(newTab);
        }

        #region private methods
        private static FastColoredTextBox? GetCurrentFctb(TabControl mainPanel)
        {
            var fctb = mainPanel.Controls[mainPanel.SelectedIndex].Controls[0];
            if(fctb is FastColoredTextBox)
            {
                return (FastColoredTextBox)fctb;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
