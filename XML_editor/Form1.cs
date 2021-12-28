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
            BaseActions.CreateFile(MainPanel, InfoPanel);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            BaseActions.SaveFile(MainPanel, saveFileDialog1);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            BaseActions.OpenFile(MainPanel, InfoPanel, openFileDialog1);
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            BaseActions.Redo(MainPanel);
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            BaseActions.Undo(MainPanel);
        }

        #endregion

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            BaseActions.CloseTab(MainPanel, e);
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