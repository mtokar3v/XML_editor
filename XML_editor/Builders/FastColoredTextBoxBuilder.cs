using FastColoredTextBoxNS;
using XML_editor.Models;

namespace XML_editor.Builders
{
    public class FastColoredTextBoxBuilder
    {
        private readonly FastColoredTextBox _fctb;

        public FastColoredTextBoxBuilder()
        {
            _fctb = new FastColoredTextBox();
        }

        public FastColoredTextBox Build() => _fctb;

        public FastColoredTextBoxBuilder WithDefaultSettings()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlEditorForm));

            _fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            _fctb.DescriptionFile = "htmlDesc.xml";
            _fctb.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            _fctb.BackBrush = null;
            _fctb.CharHeight = 14;
            _fctb.CharWidth = 8;
            _fctb.Cursor = Cursors.IBeam;
            _fctb.DisabledColor = Color.FromArgb(100, 180,180,180);
            _fctb.Dock = DockStyle.Fill;
            _fctb.Font = new Font("Courier New", 9.75F, FontStyle.Regular,GraphicsUnit.Point);
            _fctb.IsReplaceMode = false;
            _fctb.Location = new Point(0, 0);
            _fctb.Name = "fastColoredTextBox";
            _fctb.Paddings = new Padding(0);
            _fctb.SelectionColor = Color.FromArgb(60,0,0,255);
            _fctb.ServiceColors = (ServiceColors)resources.GetObject("_fctb.ServiceColors");
            _fctb.Size = new Size((int)Constants.WorkPanelWidth, (int)Constants.WorkPanelHeight);
            _fctb.TabIndex = 0;
            _fctb.Zoom = 100;

            return this;
        }

        public FastColoredTextBoxBuilder WithText(string text)
        {
            _fctb.Text = text;
            return this;
        }
    }
}
