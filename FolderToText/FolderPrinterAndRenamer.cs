using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace FolderToText
{
    public partial class FolderPrinterAndRenamer : Form
    {
        private const string NO_RENAME_SYMBOL = " >>> ";
        private const string RENAME_SYMBOL = " ==> ";
        private const string SKIPPED_SYMBOL = " --- ";

        public FolderPrinterAndRenamer()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Process();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("One of the files being processed does not contain an index you have chosen in either Insert, Remove, or Substring");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not read or write files because: " + ex.Message);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("You put a letter or symbol where only a number should go.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }

        private void Process()
        {
            string sourcePath = txtSource.Text;

            if (String.IsNullOrWhiteSpace(sourcePath) )
            {
                MessageBox.Show("Source Folder is required. Please select a valid folder path using the Browse or enter a path manually.", "Source Folder is required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Could not locate the Source Folder provided.", "Source Folder not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkAutoClear.Checked)
            {
                txtOutput.Text = String.Empty;
            }

            // If recursive checked process everything in the sub-folders
            if (chkRecursive.Checked)
            {
                ProcessDirectory(sourcePath);
            }
            else
            {
                string[] filePaths = Directory.GetFiles(sourcePath);
                ProcessFiles(filePaths, sourcePath);
            }

        }

        private void ProcessDirectory(string directoryPath)
        {
            String[] directoryPaths = Directory.GetDirectories(directoryPath);
            if (directoryPaths.Length > 0)
            {
                foreach (string directory in directoryPaths)
                {
                    ProcessDirectory(directory);
                }
            }

            string[] filePaths = Directory.GetFiles(directoryPath);
            if (filePaths.Length > 0)
            {
                ProcessFiles(filePaths, directoryPath);
            }
        }

        private class AlphanumComparatorFast : IComparer
        {
            public int Compare(object x, object y)
            {
                string s1 = x as string;
                if (s1 == null)
                {
                    return 0;
                }
                string s2 = y as string;
                if (s2 == null)
                {
                    return 0;
                }

                int len1 = s1.Length;
                int len2 = s2.Length;
                int marker1 = 0;
                int marker2 = 0;

                // Walk through two the strings with two markers.
                while (marker1 < len1 && marker2 < len2)
                {
                    char ch1 = s1[marker1];
                    char ch2 = s2[marker2];

                    // Some buffers we can build up characters in for each chunk.
                    char[] space1 = new char[len1];
                    int loc1 = 0;
                    char[] space2 = new char[len2];
                    int loc2 = 0;

                    // Walk through all following characters that are digits or
                    // characters in BOTH strings starting at the appropriate marker.
                    // Collect char arrays.
                    do
                    {
                        space1[loc1++] = ch1;
                        marker1++;

                        if (marker1 < len1)
                        {
                            ch1 = s1[marker1];
                        }
                        else
                        {
                            break;
                        }
                    } while (char.IsDigit(ch1) == char.IsDigit(space1[0]));

                    do
                    {
                        space2[loc2++] = ch2;
                        marker2++;

                        if (marker2 < len2)
                        {
                            ch2 = s2[marker2];
                        }
                        else
                        {
                            break;
                        }
                    } while (char.IsDigit(ch2) == char.IsDigit(space2[0]));

                    // If we have collected numbers, compare them numerically.
                    // Otherwise, if we have strings, compare them alphabetically.
                    string str1 = new string(space1);
                    string str2 = new string(space2);

                    int result;

                    if (char.IsDigit(space1[0]) && char.IsDigit(space2[0]))
                    {
                        int thisNumericChunk = int.Parse(str1);
                        int thatNumericChunk = int.Parse(str2);
                        result = thisNumericChunk.CompareTo(thatNumericChunk);
                    }
                    else
                    {
                        result = str1.CompareTo(str2);
                    }

                    if (result != 0)
                    {
                        return result;
                    }
                }
                return len1 - len2;
            }
        }

        private void ProcessFiles(string[] filePaths, string folderPath)
        {
            if (!chkExcludeFolderNameHeaders.Checked)
            {
                txtOutput.AppendText(folderPath + ":" + Environment.NewLine);
            }

            if (!chkNoAlphanumeric.Checked)
            {
                Array.Sort(filePaths, new AlphanumComparatorFast());    
            }

            foreach (string fullFilePath in filePaths)
            {
                // Separate the path and filename, so that we only process on the filename
                string fileName = Path.GetFileName(fullFilePath);

                if (IncludeFile(fileName))
                {
                    // Remove the extension if requested
                    if (chkExcludeFileExtensions.Checked)
                    {
                        fileName = Path.GetFileNameWithoutExtension(fileName);
                    }

                    // Process Remove, Replace, Insert, or Regular Expression operations before changing case or renaming
                    if (chkReplace.Checked)
                    {
                        fileName = fileName.Replace(txtReplaceString.Text, txtReplaceWithString.Text);
                    }

                    if (chkInsert.Checked)
                    {
                        fileName = fileName.Insert(Int32.Parse(txtInsertLocation.Text) + 1, txtInsertString.Text);
                    }

                    if (chkRemove.Checked)
                    {
                        fileName = fileName.Remove(Int32.Parse(txtRemoveStartIndex.Text) + 1, Int32.Parse(txtRemoveLength.Text));
                    }

                    if (chkSubstring.Checked)
                    {
                        fileName = fileName.Substring(Int32.Parse(txtSubstringStart.Text) + 1, Int32.Parse(txtSubstringLength.Text));
                    }

                    if (chkRemoveEverythingBefore.Checked)
                    {
                        int tokenIndex = fileName.IndexOf(txtBeforeToken.Text);

                        if (tokenIndex >= 0)
                        {
                            if (chkRemoveCharactersAsWellBefore.Checked)
                            {
                                fileName = fileName.Remove(0, tokenIndex + txtBeforeToken.Text.Length);
                            }
                            else
                            {
                                fileName = fileName.Remove(0, tokenIndex);
                            }
                        }
                    }

                    if (chkRemoveEverythingAfter.Checked)
                    {
                        int tokenIndex = fileName.IndexOf(txtAfterToken.Text);

                        if (tokenIndex >= 0)
                        {
                            if (chkRemoveCharactersAsWellAfter.Checked)
                            {
                                fileName = fileName.Remove(tokenIndex, fileName.Length - tokenIndex);
                            }
                            else
                            {
                                fileName = fileName.Remove(tokenIndex + txtAfterToken.Text.Length, fileName.Length - (tokenIndex + txtAfterToken.Text.Length));
                            }
                        }
                    }

                    if (chkRegEx.Checked)
                    {
                        fileName = Regex.Replace(fileName, txtRegEx.Text, txtRegExMatch.Text);
                    }

                    if (chkUrlDecodeAndRename.Checked)
                    {
                        fileName = HttpUtility.UrlDecode(fileName);
                    }

                    // Change case if requested
                    if (chkChangeCase.Checked)
                    {
                        fileName = ChangeCase(fileName);
                    }

                    // Output Results and rename if requested
                    string newPath = Path.Combine(folderPath, fileName);
                    if (chkRename.Checked)
                    {

                        if (!String.Equals(fullFilePath, newPath, StringComparison.InvariantCultureIgnoreCase))
                        {
                            File.Move(fullFilePath, newPath);
                            OutputResults(fullFilePath, fileName, RENAME_SYMBOL);
                        }
                        else if (!chkHideSkippedFilesInOutput.Checked)
                        {
                            OutputResults(fullFilePath, fileName, SKIPPED_SYMBOL);
                        }
                    }
                    else
                    {
                        if (!String.Equals(fullFilePath, newPath, StringComparison.InvariantCultureIgnoreCase))
                        {
                            OutputResults(fullFilePath, fileName, NO_RENAME_SYMBOL);
                        }
                        else if (!chkHideSkippedFilesInOutput.Checked)
                        {
                            OutputResults(fullFilePath, fileName, SKIPPED_SYMBOL);
                        }
                    }
                }
            }
            // Separate each folder output with a new line, so everything doesn't run together
            // Don't append a new line if there are already two prior. This helps with no spamming new lines
            // when "Exclude Folder Name Headers" are checked and you are recurses through the folders and
            // those folders are either empty or the user has chosen to hide skipped files
            if (!txtOutput.Text.EndsWith(Environment.NewLine + Environment.NewLine))
            {
                txtOutput.AppendText(Environment.NewLine);
            }
        }

        private bool IncludeFile(string fileName)
        {
            // Include the file unless one of the following checks excludes it
            bool includeFile = true;

            // Check if any file extensions are excluded
            if (chkExcludeExtensions.Checked)
            {
                string excludedExtensions = txtExcludedExtensions.Text.Trim();

                if (!String.IsNullOrEmpty(excludedExtensions))
                {
                    excludedExtensions = excludedExtensions.Replace(" ", "");
                    string[] extensions = excludedExtensions.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string extension in extensions)
                    {
                        // Add the leading period if it was not included
                        string extensionToTest = extension;
                        if (!extensionToTest.StartsWith("."))
                        {
                            extensionToTest = "." + extensionToTest;
                        }

                        // Check if the filename ends with the extension provided
                        if (fileName.EndsWith(extensionToTest))
                        {
                            includeFile = false;
                            break;
                        }
                    }
                }
            }

            if (chkExcludeFilesStartingWith.Checked)
            {
                if (fileName.StartsWith(txtExcludeFilesStartingWith.Text))
                {
                    includeFile = false;
                }
            }

            if (chkExcludeFilesContaining.Checked)
            {
                if (fileName.Contains(txtExcludeFilesContaining.Text))
                {
                    includeFile = false;
                }
            }

            return includeFile;
        }

        private void OutputResults(string fullFilePath, string fileName, string symbol)
        {
            if (chkShowOriginalFilename.Checked)
            {
                if (chkAddQuotes.Checked)
                {
                    txtOutput.AppendText("\"" + Path.GetFileName(fullFilePath) + "\"" + symbol);
                }
                else
                {
                    txtOutput.AppendText(Path.GetFileName(fullFilePath) + symbol);
                }
            }

            if (chkAddQuotes.Checked)
            {
                txtOutput.AppendText("\"" + fileName + "\"" + Environment.NewLine);
            }
            else
            {
                txtOutput.AppendText(fileName + Environment.NewLine);
            }

            Application.DoEvents();
        }

        private string ChangeCase(string fileName)
        {
            if (radUpper.Checked) fileName = fileName.ToUpper();
            else if (radLower.Checked) fileName = fileName.ToLower();
            else if (radTitle.Checked) fileName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fileName.ToLower());
            else if (radProper.Checked) fileName = ToTitleCase(fileName);
            else if (radCamel.Checked) fileName = ToCamelCase(fileName);
            else if (radUnderscores.Checked) fileName = fileName.Replace(" ", "_");

            return fileName;
        }

        private static string ToCamelCase(string stringToChange)
        {
            string updatedString = ToTitleCase(stringToChange);
            updatedString = updatedString.Replace(" ", "");
            string firstCharacter = updatedString[0].ToString();
            updatedString = updatedString.Remove(0, 1);
            updatedString = updatedString.Insert(0, firstCharacter.ToLower());

            return updatedString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveOutputFileDialog.InitialDirectory = txtSource.Text;
            saveOutputFileDialog.FileName = Path.GetFileName(txtSource.Text);
            saveOutputFileDialog.DefaultExt = txtSaveExtension.Text;
            DialogResult dialogResult = saveOutputFileDialog.ShowDialog();

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    string savePath = saveOutputFileDialog.FileName;
                    SaveOutput(savePath);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not save the output because: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }

        private void SaveOutput(string savePath)
        {
            txtOutput.Text = txtOutput.Text.TrimEnd();
            File.WriteAllText(savePath, txtOutput.Text);
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = chooseSourceFolderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                txtSource.Text = chooseSourceFolderDialog.SelectedPath;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = String.Empty;
        }

        private void lnklblRegExHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mikesdotnetting.com/Article/46/CSharp-Regular-Expressions-Cheat-Sheet");
        }

        private void txtStringLength_TextChanged(object sender, EventArgs e)
        {
            lblStringLength.Text = "String Length: " + txtStringLength.Text.Length.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:billkamm@gmail.com");
        }

        #region ToTitleCase

        /// <summary>
        /// This method will convert a string into title case where the first letter of every word is uppercase and
        /// the remaining characters are lowercase.
        /// </summary>
        /// <remarks>
        /// Title case is where the first letter of every word is capitalized.  This method does not take English grammer
        /// rules into account such as not capitializing the O in "of".  Any character followed by a space, tab, new line, or
        /// beginning the string will be capitialized.  All other letters will be converted to lowercase.  This method may
        /// also have the side effect converting the trailing letters of acronyms to lowercase.
        /// </remarks>
        /// <param name="textToConvert">The text to convert to title case</param>
        /// <returns>The string in title case</returns>
        public static string ToTitleCase(string textToConvert)
        {
            StringBuilder titleCaseString = new StringBuilder();

            if (!String.IsNullOrEmpty(textToConvert))
            {
                // The first character should always be capitalized
                titleCaseString.Append(textToConvert.Substring(0, 1).ToUpper());

                // Make the remaining characters upper case if a space, tab, or new line preceeds them or
                // lower case if proceeded by any other character
                for (int currentCharacter = 1; currentCharacter < textToConvert.Length; currentCharacter++)
                {
                    // Get the previous character
                    string previousCharacter = textToConvert.Substring(currentCharacter - 1, 1);

                    // Make the character upper case if a space, tab, or new line preceeds it or
                    // lower case if proceeded by any other character
                    if (previousCharacter == " " || previousCharacter == "\n" || previousCharacter == "\t")
                    {
                        titleCaseString.Append(textToConvert.Substring(currentCharacter, 1).ToUpper());
                    }
                    else
                    {
                        titleCaseString.Append(textToConvert.Substring(currentCharacter, 1).ToLower());
                    }
                }
            }

            return titleCaseString.ToString();
        }

        #endregion

        public static string CamelCaseToTitleCase(string camelCaseText)
        {
            return CamelCaseToTitleCase(camelCaseText, true);
        }

        public static string CamelCaseToTitleCase(string camelCaseText, bool capitalizeFirstCharacter)
        {
            string titleCaseText = String.Empty;

            if (!String.IsNullOrEmpty(camelCaseText))
            {
                // Capitalize the first character of the text
                if (capitalizeFirstCharacter)
                {
                    if (camelCaseText.Length > 1)
                    {
                        camelCaseText = camelCaseText.Substring(0, 1).ToUpper() + camelCaseText.Substring(1);
                    }
                    else
                    {
                        camelCaseText = camelCaseText.ToUpper();
                    }
                }

                // Add spaces before each captial letter not at the beginning of the string
                titleCaseText = Regex.Replace(camelCaseText, @"(\B[A-Z])", @" $1");
            }

            return titleCaseText;
        }
    }
}
