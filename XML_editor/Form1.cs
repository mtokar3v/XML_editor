using XML_editor.Builders;
using XML_editor.Models;
using XML_editor.Extensions;

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



    }
}