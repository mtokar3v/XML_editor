using XML_editor.Models;

namespace XML_editor.Builders
{
    public class TabPageBuilder
    {
        private readonly TabPage _tabPage;
        private static int number = 1;
        public TabPageBuilder()
        {
            number++;
            _tabPage = new TabPage();
            _tabPage.SuspendLayout();
            _tabPage.TabIndex = number;

            _tabPage.Width = (int)Constants.WorkPanelWidth;
            _tabPage.Height = (int)Constants.WorkPanelHeight;
        }

        public TabPage Build() => _tabPage;

        public TabPageBuilder WithColor(Color color)
        {
            _tabPage.BackColor = color;
            return this;
        }

        public TabPageBuilder WithControls(Control control)
        {
            _tabPage.Controls.Add(control);
            return this;
        }

        public TabPageBuilder WithLocation(int x,int y)
        {
            _tabPage.Location = new Point(x, y);
            return this;
        }

        public TabPageBuilder WithSize(int w, int h)
        {
            _tabPage.Size = new Size(w, h);
            return this;
        }

        public TabPageBuilder With3dBorders()
        {
            _tabPage.BorderStyle = BorderStyle.Fixed3D;
            return this;
        }

        public TabPageBuilder WithNameAndText(string? name = null)
        {
            var maxLength = 24;

            if(string.IsNullOrEmpty(name))
            {
                name = $"New {number}";
            }

            var lastIndex = name.Length <= maxLength ? name.Length : maxLength;
            var formatName = name.Substring(0, lastIndex);
            var spaces = new string(' ', maxLength - lastIndex);
            formatName = formatName.Insert(lastIndex, $"{spaces} x");

            _tabPage.Text = formatName;
            _tabPage.Name = formatName;
            return this;
        }
    }
}
