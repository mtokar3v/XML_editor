namespace XML_editor
{
    partial class XmlEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlEditorForm));
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.newFileButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.New1 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.MainPanel = new System.Windows.Forms.TabControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToolsPanel.SuspendLayout();
            this.New1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ToolsPanel.Controls.Add(this.OpenFileButton);
            this.ToolsPanel.Controls.Add(this.saveFileButton);
            this.ToolsPanel.Controls.Add(this.newFileButton);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(1362, 45);
            this.ToolsPanel.TabIndex = 1;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackgroundImage = global::XML_editor.Properties.Resources.openFile1;
            this.OpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(104, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(40, 40);
            this.OpenFileButton.TabIndex = 2;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveFileButton
            // 
            this.saveFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveFileButton.BackgroundImage")));
            this.saveFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileButton.Location = new System.Drawing.Point(58, 3);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(40, 40);
            this.saveFileButton.TabIndex = 1;
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFile);
            // 
            // newFileButton
            // 
            this.newFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newFileButton.BackgroundImage")));
            this.newFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFileButton.Location = new System.Drawing.Point(12, 3);
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(40, 40);
            this.newFileButton.TabIndex = 0;
            this.newFileButton.UseVisualStyleBackColor = true;
            this.newFileButton.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 585);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1362, 27);
            this.InfoPanel.TabIndex = 2;
            // 
            // New1
            // 
            this.New1.BackColor = System.Drawing.Color.Transparent;
            this.New1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.New1.Controls.Add(this.fastColoredTextBox1);
            this.New1.Location = new System.Drawing.Point(4, 24);
            this.New1.Name = "New1";
            this.New1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.New1.Size = new System.Drawing.Size(1354, 512);
            this.New1.TabIndex = 0;
            this.New1.Text = "New1        x";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(187, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DescriptionFile = "htmlDesc.xml";
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1350, 508);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "<p>Hello, world!</p>";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.New1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.SelectedIndex = 0;
            this.MainPanel.Size = new System.Drawing.Size(1362, 540);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "eXtensible Markup Language (*.xml)|*.xml|Normal text file(*.txt)|*.txt";
            // 
            // XmlEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 612);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.ToolsPanel);
            this.Name = "XmlEditorForm";
            this.Text = "XML Editor";
            this.ToolsPanel.ResumeLayout(false);
            this.New1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ToolsPanel;
        private FlowLayoutPanel InfoPanel;
        private Button newFileButton;
        private TabPage New1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private TabControl MainPanel;
        private Button saveFileButton;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button OpenFileButton;
    }
}