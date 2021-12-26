using XML_editor.Builders;
using XML_editor.Models;
using XML_editor.Extensions;
using XML_editor.Actions;

namespace XML_editor
{
    public partial class XmlEditorForm : Form
    {
        public XmlEditorForm()
        {
            InitializeComponent();
        }

        #region Tools
        private void CreateNewFile(object sender, EventArgs e)
        {
            var fctb = new FastColoredTextBoxBuilder()
                .WithDefaultSettings()
                .WithGetInfoEvent(MainPanel, InfoPanel)
                .WithUndoRedoEvent()
                .Build();

            var newTab = new TabPageBuilder()
                .WithNameAndText()
                .With3dBorders()
                .WithColor(Color.Black)
                .WithLocation((int)Constants.TabLocationX, (int)Constants.TabLocationY)
                .WithControls(fctb)
                .Build();

            MainPanel.Controls.Add(newTab);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = saveFileDialog1.FileName;
            var text = MainPanel.Controls[MainPanel.SelectedIndex].Controls[0].Text;

            File.WriteAllText(filename, text);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog1.SafeFileName.FileNameWithoutExtensions();
            var path = openFileDialog1.FileName;
            var fileText = File.ReadAllText(path);

            var fctb = new FastColoredTextBoxBuilder()
                .WithDefaultSettings()
                .WithText(fileText)
                .WithGetInfoEvent(MainPanel, InfoPanel)
                .WithUndoRedoEvent()
                .Build();

            var newTab = new TabPageBuilder()
                .WithNameAndText(filename)
                .With3dBorders()
                .WithColor(Color.Black)
                .WithLocation((int)Constants.TabLocationX, (int)Constants.TabLocationY)
                .WithControls(fctb)
                .Build();

            MainPanel.Controls.Add(newTab);
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        #endregion

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var crossSize = new Size(12, 12);
            for(var i = 0; i < MainPanel.TabPages.Count; i++)
            {
                var tab = MainPanel.GetTabRect(i);
                var cross = new Rectangle(
                    tab.Right - crossSize.Width,
                    tab.Top + (tab.Height - crossSize.Height)/2,
                    crossSize.Width,
                    crossSize.Height);

                if (cross.Contains(e.Location))
                {
                    MainPanel.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        private void UndoAndRedoKeys(object sender, KeyEventArgs e)
        {
            BaseActions.SetUpUndoRedoButtons(fastColoredTextBox1, e);
        }

        private void ReadNumberOfCharacters(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            BaseActions.PrintFileStatistics(MainPanel, InfoPanel);
        }

        private void MainPanel_TabIndexChanged(object sender, EventArgs e)
        {
            BaseActions.PrintFileStatistics(MainPanel, InfoPanel);
        }
    }
}