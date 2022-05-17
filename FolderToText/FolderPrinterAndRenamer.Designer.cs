namespace FolderToText
{
    partial class FolderPrinterAndRenamer
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkUrlDecodeAndRename = new System.Windows.Forms.CheckBox();
            this.chkNoAlphanumeric = new System.Windows.Forms.CheckBox();
            this.chkExcludeFolderNameHeaders = new System.Windows.Forms.CheckBox();
            this.txtExcludeFilesContaining = new System.Windows.Forms.TextBox();
            this.chkExcludeFilesContaining = new System.Windows.Forms.CheckBox();
            this.txtExcludeFilesStartingWith = new System.Windows.Forms.TextBox();
            this.chkExcludeFilesStartingWith = new System.Windows.Forms.CheckBox();
            this.lblCommaSeparate = new System.Windows.Forms.Label();
            this.txtExcludedExtensions = new System.Windows.Forms.TextBox();
            this.chkExcludeExtensions = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lnklblRegExHelp = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAddQuotes = new System.Windows.Forms.CheckBox();
            this.chkShowOriginalFilename = new System.Windows.Forms.CheckBox();
            this.txtRegExMatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radTitle = new System.Windows.Forms.RadioButton();
            this.radUnderscores = new System.Windows.Forms.RadioButton();
            this.radCamel = new System.Windows.Forms.RadioButton();
            this.radProper = new System.Windows.Forms.RadioButton();
            this.radLower = new System.Windows.Forms.RadioButton();
            this.radUpper = new System.Windows.Forms.RadioButton();
            this.chkChangeCase = new System.Windows.Forms.CheckBox();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.chkRegEx = new System.Windows.Forms.CheckBox();
            this.txtSubstringStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubstringLength = new System.Windows.Forms.TextBox();
            this.chkSubstring = new System.Windows.Forms.CheckBox();
            this.txtRemoveStartIndex = new System.Windows.Forms.TextBox();
            this.lblCharactersStartingAt = new System.Windows.Forms.Label();
            this.txtRemoveLength = new System.Windows.Forms.TextBox();
            this.chkRemove = new System.Windows.Forms.CheckBox();
            this.txtInsertLocation = new System.Windows.Forms.TextBox();
            this.lblAt = new System.Windows.Forms.Label();
            this.txtInsertString = new System.Windows.Forms.TextBox();
            this.chkInsert = new System.Windows.Forms.CheckBox();
            this.txtReplaceWithString = new System.Windows.Forms.TextBox();
            this.lblWith = new System.Windows.Forms.Label();
            this.chkReplace = new System.Windows.Forms.CheckBox();
            this.txtReplaceString = new System.Windows.Forms.TextBox();
            this.chkRemoveCharactersAsWellAfter = new System.Windows.Forms.CheckBox();
            this.chkRemoveCharactersAsWellBefore = new System.Windows.Forms.CheckBox();
            this.txtAfterToken = new System.Windows.Forms.TextBox();
            this.chkRemoveEverythingAfter = new System.Windows.Forms.CheckBox();
            this.txtBeforeToken = new System.Windows.Forms.TextBox();
            this.chkRemoveEverythingBefore = new System.Windows.Forms.CheckBox();
            this.chkRename = new System.Windows.Forms.CheckBox();
            this.chkExcludeFileExtensions = new System.Windows.Forms.CheckBox();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.chooseSourceFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveOutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkAutoClear = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStringLength = new System.Windows.Forms.TextBox();
            this.lblStringLength = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSaveExtension = new System.Windows.Forms.TextBox();
            this.lblSaveExtension = new System.Windows.Forms.Label();
            this.chkHideSkippedFilesInOutput = new System.Windows.Forms.CheckBox();
            this.grpOptions.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(123, 13);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(341, 20);
            this.txtSource.TabIndex = 0;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(13, 13);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(73, 13);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source Folder";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkUrlDecodeAndRename);
            this.grpOptions.Controls.Add(this.chkNoAlphanumeric);
            this.grpOptions.Controls.Add(this.chkExcludeFolderNameHeaders);
            this.grpOptions.Controls.Add(this.txtExcludeFilesContaining);
            this.grpOptions.Controls.Add(this.chkExcludeFilesContaining);
            this.grpOptions.Controls.Add(this.txtExcludeFilesStartingWith);
            this.grpOptions.Controls.Add(this.chkExcludeFilesStartingWith);
            this.grpOptions.Controls.Add(this.lblCommaSeparate);
            this.grpOptions.Controls.Add(this.txtExcludedExtensions);
            this.grpOptions.Controls.Add(this.chkExcludeExtensions);
            this.grpOptions.Controls.Add(this.label9);
            this.grpOptions.Controls.Add(this.label8);
            this.grpOptions.Controls.Add(this.label7);
            this.grpOptions.Controls.Add(this.lnklblRegExHelp);
            this.grpOptions.Controls.Add(this.label5);
            this.grpOptions.Controls.Add(this.chkAddQuotes);
            this.grpOptions.Controls.Add(this.chkShowOriginalFilename);
            this.grpOptions.Controls.Add(this.txtRegExMatch);
            this.grpOptions.Controls.Add(this.label4);
            this.grpOptions.Controls.Add(this.label3);
            this.grpOptions.Controls.Add(this.label2);
            this.grpOptions.Controls.Add(this.radTitle);
            this.grpOptions.Controls.Add(this.radUnderscores);
            this.grpOptions.Controls.Add(this.radCamel);
            this.grpOptions.Controls.Add(this.radProper);
            this.grpOptions.Controls.Add(this.radLower);
            this.grpOptions.Controls.Add(this.radUpper);
            this.grpOptions.Controls.Add(this.chkChangeCase);
            this.grpOptions.Controls.Add(this.txtRegEx);
            this.grpOptions.Controls.Add(this.chkRegEx);
            this.grpOptions.Controls.Add(this.txtSubstringStart);
            this.grpOptions.Controls.Add(this.label1);
            this.grpOptions.Controls.Add(this.txtSubstringLength);
            this.grpOptions.Controls.Add(this.chkSubstring);
            this.grpOptions.Controls.Add(this.txtRemoveStartIndex);
            this.grpOptions.Controls.Add(this.lblCharactersStartingAt);
            this.grpOptions.Controls.Add(this.txtRemoveLength);
            this.grpOptions.Controls.Add(this.chkRemove);
            this.grpOptions.Controls.Add(this.txtInsertLocation);
            this.grpOptions.Controls.Add(this.lblAt);
            this.grpOptions.Controls.Add(this.txtInsertString);
            this.grpOptions.Controls.Add(this.chkInsert);
            this.grpOptions.Controls.Add(this.txtReplaceWithString);
            this.grpOptions.Controls.Add(this.lblWith);
            this.grpOptions.Controls.Add(this.chkReplace);
            this.grpOptions.Controls.Add(this.txtReplaceString);
            this.grpOptions.Controls.Add(this.chkRemoveCharactersAsWellAfter);
            this.grpOptions.Controls.Add(this.chkRemoveCharactersAsWellBefore);
            this.grpOptions.Controls.Add(this.txtAfterToken);
            this.grpOptions.Controls.Add(this.chkRemoveEverythingAfter);
            this.grpOptions.Controls.Add(this.txtBeforeToken);
            this.grpOptions.Controls.Add(this.chkRemoveEverythingBefore);
            this.grpOptions.Controls.Add(this.chkHideSkippedFilesInOutput);
            this.grpOptions.Controls.Add(this.chkRename);
            this.grpOptions.Controls.Add(this.chkExcludeFileExtensions);
            this.grpOptions.Controls.Add(this.chkRecursive);
            this.grpOptions.Location = new System.Drawing.Point(16, 39);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(530, 439);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkUrlDecodeAndRename
            // 
            this.chkUrlDecodeAndRename.AutoSize = true;
            this.chkUrlDecodeAndRename.Location = new System.Drawing.Point(6, 368);
            this.chkUrlDecodeAndRename.Name = "chkUrlDecodeAndRename";
            this.chkUrlDecodeAndRename.Size = new System.Drawing.Size(513, 17);
            this.chkUrlDecodeAndRename.TabIndex = 54;
            this.chkUrlDecodeAndRename.Text = "URL Decode and Rename (For files downloaded from websites containing URL encoding" +
    " such as %20)";
            this.chkUrlDecodeAndRename.UseVisualStyleBackColor = true;
            // 
            // chkNoAlphanumeric
            // 
            this.chkNoAlphanumeric.AutoSize = true;
            this.chkNoAlphanumeric.Location = new System.Drawing.Point(264, 115);
            this.chkNoAlphanumeric.Name = "chkNoAlphanumeric";
            this.chkNoAlphanumeric.Size = new System.Drawing.Size(185, 17);
            this.chkNoAlphanumeric.TabIndex = 53;
            this.chkNoAlphanumeric.Text = "Do Not Use Alphanumeric Sorting";
            this.chkNoAlphanumeric.UseVisualStyleBackColor = true;
            // 
            // chkExcludeFolderNameHeaders
            // 
            this.chkExcludeFolderNameHeaders.AutoSize = true;
            this.chkExcludeFolderNameHeaders.Location = new System.Drawing.Point(6, 116);
            this.chkExcludeFolderNameHeaders.Name = "chkExcludeFolderNameHeaders";
            this.chkExcludeFolderNameHeaders.Size = new System.Drawing.Size(170, 17);
            this.chkExcludeFolderNameHeaders.TabIndex = 52;
            this.chkExcludeFolderNameHeaders.Text = "Exclude Folder Name Headers";
            this.chkExcludeFolderNameHeaders.UseVisualStyleBackColor = true;
            // 
            // txtExcludeFilesContaining
            // 
            this.txtExcludeFilesContaining.Location = new System.Drawing.Point(411, 89);
            this.txtExcludeFilesContaining.Name = "txtExcludeFilesContaining";
            this.txtExcludeFilesContaining.Size = new System.Drawing.Size(100, 20);
            this.txtExcludeFilesContaining.TabIndex = 10;
            // 
            // chkExcludeFilesContaining
            // 
            this.chkExcludeFilesContaining.AutoSize = true;
            this.chkExcludeFilesContaining.Location = new System.Drawing.Point(264, 92);
            this.chkExcludeFilesContaining.Name = "chkExcludeFilesContaining";
            this.chkExcludeFilesContaining.Size = new System.Drawing.Size(141, 17);
            this.chkExcludeFilesContaining.TabIndex = 9;
            this.chkExcludeFilesContaining.Text = "Exclude Files Containing";
            this.chkExcludeFilesContaining.UseVisualStyleBackColor = true;
            // 
            // txtExcludeFilesStartingWith
            // 
            this.txtExcludeFilesStartingWith.Location = new System.Drawing.Point(158, 89);
            this.txtExcludeFilesStartingWith.Name = "txtExcludeFilesStartingWith";
            this.txtExcludeFilesStartingWith.Size = new System.Drawing.Size(100, 20);
            this.txtExcludeFilesStartingWith.TabIndex = 8;
            // 
            // chkExcludeFilesStartingWith
            // 
            this.chkExcludeFilesStartingWith.AutoSize = true;
            this.chkExcludeFilesStartingWith.Location = new System.Drawing.Point(6, 92);
            this.chkExcludeFilesStartingWith.Name = "chkExcludeFilesStartingWith";
            this.chkExcludeFilesStartingWith.Size = new System.Drawing.Size(152, 17);
            this.chkExcludeFilesStartingWith.TabIndex = 7;
            this.chkExcludeFilesStartingWith.Text = "Exclude Files Starting With";
            this.chkExcludeFilesStartingWith.UseVisualStyleBackColor = true;
            // 
            // lblCommaSeparate
            // 
            this.lblCommaSeparate.AutoSize = true;
            this.lblCommaSeparate.Location = new System.Drawing.Point(394, 69);
            this.lblCommaSeparate.Name = "lblCommaSeparate";
            this.lblCommaSeparate.Size = new System.Drawing.Size(118, 13);
            this.lblCommaSeparate.TabIndex = 6;
            this.lblCommaSeparate.Text = "(separate with commas)";
            // 
            // txtExcludedExtensions
            // 
            this.txtExcludedExtensions.Location = new System.Drawing.Point(131, 68);
            this.txtExcludedExtensions.Name = "txtExcludedExtensions";
            this.txtExcludedExtensions.Size = new System.Drawing.Size(257, 20);
            this.txtExcludedExtensions.TabIndex = 5;
            // 
            // chkExcludeExtensions
            // 
            this.chkExcludeExtensions.AutoSize = true;
            this.chkExcludeExtensions.Location = new System.Drawing.Point(6, 68);
            this.chkExcludeExtensions.Name = "chkExcludeExtensions";
            this.chkExcludeExtensions.Size = new System.Drawing.Size(118, 17);
            this.chkExcludeExtensions.TabIndex = 4;
            this.chkExcludeExtensions.Text = "Exclude Extensions";
            this.chkExcludeExtensions.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "(indexes start at 1)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "(indexes start at 1)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "(indexes start at 1)";
            // 
            // lnklblRegExHelp
            // 
            this.lnklblRegExHelp.AutoSize = true;
            this.lnklblRegExHelp.Location = new System.Drawing.Point(6, 346);
            this.lnklblRegExHelp.Name = "lnklblRegExHelp";
            this.lnklblRegExHelp.Size = new System.Drawing.Size(64, 13);
            this.lnklblRegExHelp.TabIndex = 42;
            this.lnklblRegExHelp.TabStop = true;
            this.lnklblRegExHelp.Text = "RegEx Help";
            this.lnklblRegExHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRegExHelp_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "( ) capture groups $1, $2, ... retrieve them";
            // 
            // chkAddQuotes
            // 
            this.chkAddQuotes.AutoSize = true;
            this.chkAddQuotes.Location = new System.Drawing.Point(233, 43);
            this.chkAddQuotes.Name = "chkAddQuotes";
            this.chkAddQuotes.Size = new System.Drawing.Size(224, 17);
            this.chkAddQuotes.TabIndex = 3;
            this.chkAddQuotes.Text = "Show Quotes Around Filenames In Output";
            this.chkAddQuotes.UseVisualStyleBackColor = true;
            // 
            // chkShowOriginalFilename
            // 
            this.chkShowOriginalFilename.AutoSize = true;
            this.chkShowOriginalFilename.Location = new System.Drawing.Point(233, 20);
            this.chkShowOriginalFilename.Name = "chkShowOriginalFilename";
            this.chkShowOriginalFilename.Size = new System.Drawing.Size(182, 17);
            this.chkShowOriginalFilename.TabIndex = 1;
            this.chkShowOriginalFilename.Text = "Show Original Filename in Output";
            this.chkShowOriginalFilename.UseVisualStyleBackColor = true;
            // 
            // txtRegExMatch
            // 
            this.txtRegExMatch.Location = new System.Drawing.Point(366, 324);
            this.txtRegExMatch.Name = "txtRegExMatch";
            this.txtRegExMatch.Size = new System.Drawing.Size(139, 20);
            this.txtRegExMatch.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "with";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Indexes change with each remove or replace operation.  Simulate before renaming.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose One of the Following for the Best Results.  Multiple choices will execute " +
    "in order. ";
            // 
            // radTitle
            // 
            this.radTitle.AutoSize = true;
            this.radTitle.Location = new System.Drawing.Point(224, 391);
            this.radTitle.Name = "radTitle";
            this.radTitle.Size = new System.Drawing.Size(45, 17);
            this.radTitle.TabIndex = 47;
            this.radTitle.TabStop = true;
            this.radTitle.Text = "Title";
            this.radTitle.UseVisualStyleBackColor = true;
            // 
            // radUnderscores
            // 
            this.radUnderscores.AutoSize = true;
            this.radUnderscores.Location = new System.Drawing.Point(397, 391);
            this.radUnderscores.Name = "radUnderscores";
            this.radUnderscores.Size = new System.Drawing.Size(85, 17);
            this.radUnderscores.TabIndex = 50;
            this.radUnderscores.TabStop = true;
            this.radUnderscores.Text = "Underscores";
            this.radUnderscores.UseVisualStyleBackColor = true;
            // 
            // radCamel
            // 
            this.radCamel.AutoSize = true;
            this.radCamel.Location = new System.Drawing.Point(337, 391);
            this.radCamel.Name = "radCamel";
            this.radCamel.Size = new System.Drawing.Size(54, 17);
            this.radCamel.TabIndex = 49;
            this.radCamel.TabStop = true;
            this.radCamel.Text = "Camel";
            this.radCamel.UseVisualStyleBackColor = true;
            // 
            // radProper
            // 
            this.radProper.AutoSize = true;
            this.radProper.Location = new System.Drawing.Point(275, 391);
            this.radProper.Name = "radProper";
            this.radProper.Size = new System.Drawing.Size(56, 17);
            this.radProper.TabIndex = 48;
            this.radProper.TabStop = true;
            this.radProper.Text = "Proper";
            this.radProper.UseVisualStyleBackColor = true;
            // 
            // radLower
            // 
            this.radLower.AutoSize = true;
            this.radLower.Location = new System.Drawing.Point(163, 391);
            this.radLower.Name = "radLower";
            this.radLower.Size = new System.Drawing.Size(54, 17);
            this.radLower.TabIndex = 46;
            this.radLower.TabStop = true;
            this.radLower.Text = "Lower";
            this.radLower.UseVisualStyleBackColor = true;
            // 
            // radUpper
            // 
            this.radUpper.AutoSize = true;
            this.radUpper.Location = new System.Drawing.Point(103, 391);
            this.radUpper.Name = "radUpper";
            this.radUpper.Size = new System.Drawing.Size(54, 17);
            this.radUpper.TabIndex = 45;
            this.radUpper.TabStop = true;
            this.radUpper.Text = "Upper";
            this.radUpper.UseVisualStyleBackColor = true;
            // 
            // chkChangeCase
            // 
            this.chkChangeCase.AutoSize = true;
            this.chkChangeCase.Location = new System.Drawing.Point(6, 391);
            this.chkChangeCase.Name = "chkChangeCase";
            this.chkChangeCase.Size = new System.Drawing.Size(90, 17);
            this.chkChangeCase.TabIndex = 44;
            this.chkChangeCase.Text = "Change Case";
            this.chkChangeCase.UseVisualStyleBackColor = true;
            // 
            // txtRegEx
            // 
            this.txtRegEx.Location = new System.Drawing.Point(186, 323);
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(139, 20);
            this.txtRegEx.TabIndex = 39;
            // 
            // chkRegEx
            // 
            this.chkRegEx.AutoSize = true;
            this.chkRegEx.Location = new System.Drawing.Point(7, 326);
            this.chkRegEx.Name = "chkRegEx";
            this.chkRegEx.Size = new System.Drawing.Size(157, 17);
            this.chkRegEx.TabIndex = 38;
            this.chkRegEx.Text = "Replace Matches of RegEx";
            this.chkRegEx.UseVisualStyleBackColor = true;
            // 
            // txtSubstringStart
            // 
            this.txtSubstringStart.Location = new System.Drawing.Point(233, 253);
            this.txtSubstringStart.Name = "txtSubstringStart";
            this.txtSubstringStart.Size = new System.Drawing.Size(40, 20);
            this.txtSubstringStart.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "characters starting at";
            // 
            // txtSubstringLength
            // 
            this.txtSubstringLength.Location = new System.Drawing.Point(78, 253);
            this.txtSubstringLength.Name = "txtSubstringLength";
            this.txtSubstringLength.Size = new System.Drawing.Size(40, 20);
            this.txtSubstringLength.TabIndex = 28;
            // 
            // chkSubstring
            // 
            this.chkSubstring.AutoSize = true;
            this.chkSubstring.Location = new System.Drawing.Point(6, 255);
            this.chkSubstring.Name = "chkSubstring";
            this.chkSubstring.Size = new System.Drawing.Size(70, 17);
            this.chkSubstring.TabIndex = 27;
            this.chkSubstring.Text = "Substring";
            this.chkSubstring.UseVisualStyleBackColor = true;
            // 
            // txtRemoveStartIndex
            // 
            this.txtRemoveStartIndex.Location = new System.Drawing.Point(234, 230);
            this.txtRemoveStartIndex.Name = "txtRemoveStartIndex";
            this.txtRemoveStartIndex.Size = new System.Drawing.Size(40, 20);
            this.txtRemoveStartIndex.TabIndex = 25;
            // 
            // lblCharactersStartingAt
            // 
            this.lblCharactersStartingAt.AutoSize = true;
            this.lblCharactersStartingAt.Location = new System.Drawing.Point(124, 233);
            this.lblCharactersStartingAt.Name = "lblCharactersStartingAt";
            this.lblCharactersStartingAt.Size = new System.Drawing.Size(106, 13);
            this.lblCharactersStartingAt.TabIndex = 24;
            this.lblCharactersStartingAt.Text = "characters starting at";
            // 
            // txtRemoveLength
            // 
            this.txtRemoveLength.Location = new System.Drawing.Point(79, 230);
            this.txtRemoveLength.Name = "txtRemoveLength";
            this.txtRemoveLength.Size = new System.Drawing.Size(40, 20);
            this.txtRemoveLength.TabIndex = 23;
            // 
            // chkRemove
            // 
            this.chkRemove.AutoSize = true;
            this.chkRemove.Location = new System.Drawing.Point(7, 232);
            this.chkRemove.Name = "chkRemove";
            this.chkRemove.Size = new System.Drawing.Size(66, 17);
            this.chkRemove.TabIndex = 22;
            this.chkRemove.Text = "Remove";
            this.chkRemove.UseVisualStyleBackColor = true;
            // 
            // txtInsertLocation
            // 
            this.txtInsertLocation.Location = new System.Drawing.Point(285, 206);
            this.txtInsertLocation.Name = "txtInsertLocation";
            this.txtInsertLocation.Size = new System.Drawing.Size(40, 20);
            this.txtInsertLocation.TabIndex = 20;
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Location = new System.Drawing.Point(253, 209);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(16, 13);
            this.lblAt.TabIndex = 19;
            this.lblAt.Text = "at";
            // 
            // txtInsertString
            // 
            this.txtInsertString.Location = new System.Drawing.Point(79, 206);
            this.txtInsertString.Name = "txtInsertString";
            this.txtInsertString.Size = new System.Drawing.Size(168, 20);
            this.txtInsertString.TabIndex = 18;
            // 
            // chkInsert
            // 
            this.chkInsert.AutoSize = true;
            this.chkInsert.Location = new System.Drawing.Point(7, 208);
            this.chkInsert.Name = "chkInsert";
            this.chkInsert.Size = new System.Drawing.Size(52, 17);
            this.chkInsert.TabIndex = 17;
            this.chkInsert.Text = "Insert";
            this.chkInsert.UseVisualStyleBackColor = true;
            // 
            // txtReplaceWithString
            // 
            this.txtReplaceWithString.Location = new System.Drawing.Point(285, 182);
            this.txtReplaceWithString.Name = "txtReplaceWithString";
            this.txtReplaceWithString.Size = new System.Drawing.Size(168, 20);
            this.txtReplaceWithString.TabIndex = 16;
            // 
            // lblWith
            // 
            this.lblWith.AutoSize = true;
            this.lblWith.Location = new System.Drawing.Point(253, 185);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(26, 13);
            this.lblWith.TabIndex = 15;
            this.lblWith.Text = "with";
            // 
            // chkReplace
            // 
            this.chkReplace.AutoSize = true;
            this.chkReplace.Location = new System.Drawing.Point(7, 184);
            this.chkReplace.Name = "chkReplace";
            this.chkReplace.Size = new System.Drawing.Size(66, 17);
            this.chkReplace.TabIndex = 13;
            this.chkReplace.Text = "Replace";
            this.chkReplace.UseVisualStyleBackColor = true;
            // 
            // txtReplaceString
            // 
            this.txtReplaceString.Location = new System.Drawing.Point(79, 182);
            this.txtReplaceString.Name = "txtReplaceString";
            this.txtReplaceString.Size = new System.Drawing.Size(168, 20);
            this.txtReplaceString.TabIndex = 14;
            // 
            // chkRemoveCharactersAsWellAfter
            // 
            this.chkRemoveCharactersAsWellAfter.AutoSize = true;
            this.chkRemoveCharactersAsWellAfter.Location = new System.Drawing.Point(303, 301);
            this.chkRemoveCharactersAsWellAfter.Name = "chkRemoveCharactersAsWellAfter";
            this.chkRemoveCharactersAsWellAfter.Size = new System.Drawing.Size(208, 17);
            this.chkRemoveCharactersAsWellAfter.TabIndex = 37;
            this.chkRemoveCharactersAsWellAfter.Text = "Remove Searched Characters As Well";
            this.chkRemoveCharactersAsWellAfter.UseVisualStyleBackColor = true;
            // 
            // chkRemoveCharactersAsWellBefore
            // 
            this.chkRemoveCharactersAsWellBefore.AutoSize = true;
            this.chkRemoveCharactersAsWellBefore.Location = new System.Drawing.Point(303, 279);
            this.chkRemoveCharactersAsWellBefore.Name = "chkRemoveCharactersAsWellBefore";
            this.chkRemoveCharactersAsWellBefore.Size = new System.Drawing.Size(208, 17);
            this.chkRemoveCharactersAsWellBefore.TabIndex = 34;
            this.chkRemoveCharactersAsWellBefore.Text = "Remove Searched Characters As Well";
            this.chkRemoveCharactersAsWellBefore.UseVisualStyleBackColor = true;
            // 
            // txtAfterToken
            // 
            this.txtAfterToken.Location = new System.Drawing.Point(187, 301);
            this.txtAfterToken.Name = "txtAfterToken";
            this.txtAfterToken.Size = new System.Drawing.Size(100, 20);
            this.txtAfterToken.TabIndex = 36;
            // 
            // chkRemoveEverythingAfter
            // 
            this.chkRemoveEverythingAfter.AutoSize = true;
            this.chkRemoveEverythingAfter.Location = new System.Drawing.Point(6, 302);
            this.chkRemoveEverythingAfter.Name = "chkRemoveEverythingAfter";
            this.chkRemoveEverythingAfter.Size = new System.Drawing.Size(144, 17);
            this.chkRemoveEverythingAfter.TabIndex = 35;
            this.chkRemoveEverythingAfter.Text = "Remove Everything After";
            this.chkRemoveEverythingAfter.UseVisualStyleBackColor = true;
            // 
            // txtBeforeToken
            // 
            this.txtBeforeToken.Location = new System.Drawing.Point(187, 278);
            this.txtBeforeToken.Name = "txtBeforeToken";
            this.txtBeforeToken.Size = new System.Drawing.Size(100, 20);
            this.txtBeforeToken.TabIndex = 33;
            // 
            // chkRemoveEverythingBefore
            // 
            this.chkRemoveEverythingBefore.AutoSize = true;
            this.chkRemoveEverythingBefore.Location = new System.Drawing.Point(6, 279);
            this.chkRemoveEverythingBefore.Name = "chkRemoveEverythingBefore";
            this.chkRemoveEverythingBefore.Size = new System.Drawing.Size(153, 17);
            this.chkRemoveEverythingBefore.TabIndex = 32;
            this.chkRemoveEverythingBefore.Text = "Remove Everything Before";
            this.chkRemoveEverythingBefore.UseVisualStyleBackColor = true;
            // 
            // chkRename
            // 
            this.chkRename.AutoSize = true;
            this.chkRename.Location = new System.Drawing.Point(6, 414);
            this.chkRename.Name = "chkRename";
            this.chkRename.Size = new System.Drawing.Size(255, 17);
            this.chkRename.TabIndex = 51;
            this.chkRename.Text = "Rename Files (BE SURE TO SIMULATE FIRST)";
            this.chkRename.UseVisualStyleBackColor = true;
            // 
            // chkExcludeFileExtensions
            // 
            this.chkExcludeFileExtensions.AutoSize = true;
            this.chkExcludeFileExtensions.Location = new System.Drawing.Point(7, 44);
            this.chkExcludeFileExtensions.Name = "chkExcludeFileExtensions";
            this.chkExcludeFileExtensions.Size = new System.Drawing.Size(215, 17);
            this.chkExcludeFileExtensions.TabIndex = 2;
            this.chkExcludeFileExtensions.Text = "Remove File Extensions From Filenames";
            this.chkExcludeFileExtensions.UseVisualStyleBackColor = true;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(7, 20);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(167, 17);
            this.chkRecursive.TabIndex = 0;
            this.chkRecursive.Text = "Recursive (Enter Sub-Folders)";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcess.Location = new System.Drawing.Point(471, 484);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(471, 9);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 1;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(552, 39);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(686, 439);
            this.grpOutput.TabIndex = 8;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(680, 420);
            this.txtOutput.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1163, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Output";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1082, 484);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkAutoClear
            // 
            this.chkAutoClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoClear.AutoSize = true;
            this.chkAutoClear.Checked = true;
            this.chkAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoClear.Location = new System.Drawing.Point(359, 487);
            this.chkAutoClear.Name = "chkAutoClear";
            this.chkAutoClear.Size = new System.Drawing.Size(110, 17);
            this.chkAutoClear.TabIndex = 3;
            this.chkAutoClear.Text = "Auto Clear Output";
            this.chkAutoClear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = ">>> = Simulated Rename, --- = Skipped Rename, ==> Renamed";
            // 
            // txtStringLength
            // 
            this.txtStringLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStringLength.Location = new System.Drawing.Point(555, 13);
            this.txtStringLength.Name = "txtStringLength";
            this.txtStringLength.Size = new System.Drawing.Size(559, 20);
            this.txtStringLength.TabIndex = 13;
            this.txtStringLength.TextChanged += new System.EventHandler(this.txtStringLength_TextChanged);
            // 
            // lblStringLength
            // 
            this.lblStringLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStringLength.AutoSize = true;
            this.lblStringLength.Location = new System.Drawing.Point(1120, 16);
            this.lblStringLength.Name = "lblStringLength";
            this.lblStringLength.Size = new System.Drawing.Size(82, 13);
            this.lblStringLength.TabIndex = 14;
            this.lblStringLength.Text = "String Length: 0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(106, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "billkamm@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Email Developer:";
            // 
            // txtSaveExtension
            // 
            this.txtSaveExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveExtension.Location = new System.Drawing.Point(1026, 485);
            this.txtSaveExtension.Name = "txtSaveExtension";
            this.txtSaveExtension.Size = new System.Drawing.Size(48, 20);
            this.txtSaveExtension.TabIndex = 17;
            // 
            // lblSaveExtension
            // 
            this.lblSaveExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveExtension.AutoSize = true;
            this.lblSaveExtension.Location = new System.Drawing.Point(916, 489);
            this.lblSaveExtension.Name = "lblSaveExtension";
            this.lblSaveExtension.Size = new System.Drawing.Size(104, 13);
            this.lblSaveExtension.TabIndex = 54;
            this.lblSaveExtension.Text = "Extension for Saves:";
            // 
            // chkHideSkippedFilesInOutput
            // 
            this.chkHideSkippedFilesInOutput.AutoSize = true;
            this.chkHideSkippedFilesInOutput.Location = new System.Drawing.Point(303, 414);
            this.chkHideSkippedFilesInOutput.Name = "chkHideSkippedFilesInOutput";
            this.chkHideSkippedFilesInOutput.Size = new System.Drawing.Size(161, 17);
            this.chkHideSkippedFilesInOutput.TabIndex = 51;
            this.chkHideSkippedFilesInOutput.Text = "Hide Skipped Files In Output";
            this.chkHideSkippedFilesInOutput.UseVisualStyleBackColor = true;
            // 
            // FolderPrinterAndRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 516);
            this.Controls.Add(this.lblSaveExtension);
            this.Controls.Add(this.txtSaveExtension);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblStringLength);
            this.Controls.Add(this.txtStringLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAutoClear);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtSource);
            this.MinimumSize = new System.Drawing.Size(800, 477);
            this.Name = "FolderPrinterAndRenamer";
            this.Text = "Folder Printer and Renamer";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkRemoveCharactersAsWellAfter;
        private System.Windows.Forms.CheckBox chkRemoveCharactersAsWellBefore;
        private System.Windows.Forms.TextBox txtAfterToken;
        private System.Windows.Forms.CheckBox chkRemoveEverythingAfter;
        private System.Windows.Forms.TextBox txtBeforeToken;
        private System.Windows.Forms.CheckBox chkRemoveEverythingBefore;
        private System.Windows.Forms.CheckBox chkRename;
        private System.Windows.Forms.CheckBox chkExcludeFileExtensions;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtSubstringStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubstringLength;
        private System.Windows.Forms.CheckBox chkSubstring;
        private System.Windows.Forms.TextBox txtRemoveStartIndex;
        private System.Windows.Forms.Label lblCharactersStartingAt;
        private System.Windows.Forms.TextBox txtRemoveLength;
        private System.Windows.Forms.CheckBox chkRemove;
        private System.Windows.Forms.TextBox txtInsertLocation;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.TextBox txtInsertString;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.TextBox txtReplaceWithString;
        private System.Windows.Forms.Label lblWith;
        private System.Windows.Forms.CheckBox chkReplace;
        private System.Windows.Forms.TextBox txtReplaceString;
        private System.Windows.Forms.TextBox txtRegEx;
        private System.Windows.Forms.CheckBox chkRegEx;
        private System.Windows.Forms.RadioButton radTitle;
        private System.Windows.Forms.RadioButton radUnderscores;
        private System.Windows.Forms.RadioButton radCamel;
        private System.Windows.Forms.RadioButton radProper;
        private System.Windows.Forms.RadioButton radLower;
        private System.Windows.Forms.RadioButton radUpper;
        private System.Windows.Forms.CheckBox chkChangeCase;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.FolderBrowserDialog chooseSourceFolderDialog;
        private System.Windows.Forms.SaveFileDialog saveOutputFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRegExMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkShowOriginalFilename;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkAutoClear;
        private System.Windows.Forms.CheckBox chkAddQuotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnklblRegExHelp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStringLength;
        private System.Windows.Forms.Label lblStringLength;
        private System.Windows.Forms.TextBox txtExcludeFilesContaining;
        private System.Windows.Forms.CheckBox chkExcludeFilesContaining;
        private System.Windows.Forms.TextBox txtExcludeFilesStartingWith;
        private System.Windows.Forms.CheckBox chkExcludeFilesStartingWith;
        private System.Windows.Forms.Label lblCommaSeparate;
        private System.Windows.Forms.TextBox txtExcludedExtensions;
        private System.Windows.Forms.CheckBox chkExcludeExtensions;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkExcludeFolderNameHeaders;
        private System.Windows.Forms.CheckBox chkNoAlphanumeric;
        private System.Windows.Forms.TextBox txtSaveExtension;
        private System.Windows.Forms.Label lblSaveExtension;
        private System.Windows.Forms.CheckBox chkUrlDecodeAndRename;
        private System.Windows.Forms.CheckBox chkHideSkippedFilesInOutput;
    }
}

