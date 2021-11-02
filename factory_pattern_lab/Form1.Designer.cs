
namespace factory_pattern_lab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTextBtn = new System.Windows.Forms.Button();
            this.AddButtonBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ContentInput = new System.Windows.Forms.TextBox();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.TopInput = new System.Windows.Forms.TextBox();
            this.LeftInput = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.DisplayInputs = new System.Windows.Forms.TextBox();
            this.HtmlRadio = new System.Windows.Forms.RadioButton();
            this.XamlRadio = new System.Windows.Forms.RadioButton();
            this.FilenameInput = new System.Windows.Forms.TextBox();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddTextBtn
            // 
            this.AddTextBtn.Location = new System.Drawing.Point(27, 326);
            this.AddTextBtn.Name = "AddTextBtn";
            this.AddTextBtn.Size = new System.Drawing.Size(150, 23);
            this.AddTextBtn.TabIndex = 0;
            this.AddTextBtn.Text = "Add Text Block";
            this.AddTextBtn.UseVisualStyleBackColor = true;
            this.AddTextBtn.Click += new System.EventHandler(this.AddTextBtn_Click);
            // 
            // AddButtonBtn
            // 
            this.AddButtonBtn.Location = new System.Drawing.Point(27, 357);
            this.AddButtonBtn.Name = "AddButtonBtn";
            this.AddButtonBtn.Size = new System.Drawing.Size(150, 23);
            this.AddButtonBtn.TabIndex = 1;
            this.AddButtonBtn.Text = "Add Button";
            this.AddButtonBtn.UseVisualStyleBackColor = true;
            this.AddButtonBtn.Click += new System.EventHandler(this.AddButtonBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(27, 389);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(150, 23);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove Last Element";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ContentInput
            // 
            this.ContentInput.Location = new System.Drawing.Point(27, 50);
            this.ContentInput.Name = "ContentInput";
            this.ContentInput.Size = new System.Drawing.Size(150, 20);
            this.ContentInput.TabIndex = 3;
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(27, 98);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(150, 20);
            this.HeightInput.TabIndex = 4;
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(27, 146);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(150, 20);
            this.WidthInput.TabIndex = 5;
            // 
            // TopInput
            // 
            this.TopInput.Location = new System.Drawing.Point(27, 194);
            this.TopInput.Name = "TopInput";
            this.TopInput.Size = new System.Drawing.Size(150, 20);
            this.TopInput.TabIndex = 6;
            // 
            // LeftInput
            // 
            this.LeftInput.Location = new System.Drawing.Point(27, 243);
            this.LeftInput.Name = "LeftInput";
            this.LeftInput.Size = new System.Drawing.Size(150, 20);
            this.LeftInput.TabIndex = 7;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(24, 34);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 8;
            this.ContentLabel.Text = "Content";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(24, 82);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(24, 130);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Width";
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(24, 178);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(26, 13);
            this.TopLabel.TabIndex = 11;
            this.TopLabel.Text = "Top";
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(27, 227);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(25, 13);
            this.LeftLabel.TabIndex = 12;
            this.LeftLabel.Text = "Left";
            // 
            // DisplayInputs
            // 
            this.DisplayInputs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayInputs.Location = new System.Drawing.Point(309, 24);
            this.DisplayInputs.Multiline = true;
            this.DisplayInputs.Name = "DisplayInputs";
            this.DisplayInputs.ReadOnly = true;
            this.DisplayInputs.Size = new System.Drawing.Size(470, 285);
            this.DisplayInputs.TabIndex = 13;
            // 
            // HtmlRadio
            // 
            this.HtmlRadio.AutoSize = true;
            this.HtmlRadio.Checked = true;
            this.HtmlRadio.Location = new System.Drawing.Point(309, 378);
            this.HtmlRadio.Name = "HtmlRadio";
            this.HtmlRadio.Size = new System.Drawing.Size(55, 17);
            this.HtmlRadio.TabIndex = 14;
            this.HtmlRadio.TabStop = true;
            this.HtmlRadio.Text = "HTML";
            this.HtmlRadio.UseVisualStyleBackColor = true;
            // 
            // XamlRadio
            // 
            this.XamlRadio.AutoSize = true;
            this.XamlRadio.Location = new System.Drawing.Point(380, 378);
            this.XamlRadio.Name = "XamlRadio";
            this.XamlRadio.Size = new System.Drawing.Size(54, 17);
            this.XamlRadio.TabIndex = 15;
            this.XamlRadio.TabStop = true;
            this.XamlRadio.Text = "XAML";
            this.XamlRadio.UseVisualStyleBackColor = true;
            // 
            // FilenameInput
            // 
            this.FilenameInput.Location = new System.Drawing.Point(309, 342);
            this.FilenameInput.Name = "FilenameInput";
            this.FilenameInput.Size = new System.Drawing.Size(150, 20);
            this.FilenameInput.TabIndex = 16;
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(306, 326);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(49, 13);
            this.FilenameLabel.TabIndex = 17;
            this.FilenameLabel.Text = "Filename";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(544, 338);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(100, 23);
            this.ExportBtn.TabIndex = 18;
            this.ExportBtn.Text = "Export To File";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.FilenameInput);
            this.Controls.Add(this.XamlRadio);
            this.Controls.Add(this.HtmlRadio);
            this.Controls.Add(this.DisplayInputs);
            this.Controls.Add(this.LeftLabel);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.LeftInput);
            this.Controls.Add(this.TopInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.ContentInput);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddButtonBtn);
            this.Controls.Add(this.AddTextBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTextBtn;
        private System.Windows.Forms.Button AddButtonBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.TextBox ContentInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox TopInput;
        private System.Windows.Forms.TextBox LeftInput;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.TextBox DisplayInputs;
        private System.Windows.Forms.RadioButton HtmlRadio;
        private System.Windows.Forms.RadioButton XamlRadio;
        private System.Windows.Forms.TextBox FilenameInput;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Button ExportBtn;
    }
}

