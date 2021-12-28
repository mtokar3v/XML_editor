using FastColoredTextBoxNS;
using XML_editor.Actions;
using XML_editor.Models;

namespace XML_editor.Builders
{
    public class FastColoredTextBoxBuilder
    {
        private readonly FastColoredTextBox _fctb;

        public FastColoredTextBoxBuilder()
        {
            _fctb = new FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(_fctb)).BeginInit();
        }

        public FastColoredTextBox Build() => _fctb;

        public FastColoredTextBoxBuilder WithDefaultSettings()
        {
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
            _fctb.Language = Language.XML;
            //_fctb.DescriptionFile = "htmlDesc.xml";
            _fctb.AutoScrollMinSize = new Size(179, 14);
            _fctb.CharHeight = 14;
            _fctb.CharWidth = 8;
            _fctb.Cursor = Cursors.IBeam;
            _fctb.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            _fctb.Dock = DockStyle.Fill;
            _fctb.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            _fctb.IsReplaceMode = false;
            _fctb.Name = "fastColoredTextBox";
            _fctb.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            _fctb.Size = new Size((int)Constants.WorkPanelWidth, (int)Constants.WorkPanelHeight);
            _fctb.Zoom = 100;
            _fctb.LeftBracket = '<';
            _fctb.LeftBracket2 = '(';
            _fctb.RightBracket = '>';
            _fctb.RightBracket2 = ')';
            _fctb.AutoIndentCharsPatterns = "";
            return this;
        }

        public FastColoredTextBoxBuilder WithText(string text)
        {
            _fctb.Text = text;
            return this;
        }

        public FastColoredTextBoxBuilder WithUndoRedoEvent()
        {
            _fctb.KeyDown += new KeyEventHandler((object sender, KeyEventArgs e)
                => BaseActions.SetUpUndoRedoButtons(_fctb, e));

            return this;
        }

        public FastColoredTextBoxBuilder WithGetInfoEvent(TabControl mainPanel, FlowLayoutPanel infoPanel)
        {
            _fctb.TextChanged += new EventHandler<TextChangedEventArgs>((object sender, TextChangedEventArgs e)
                => BaseActions.PrintFileStatistics(mainPanel, infoPanel));

            return this;
        }
    }
}
