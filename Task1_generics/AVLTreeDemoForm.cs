using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_generics
{
    public partial class AVLTreeDemoForm : Form
    {
        private ITree<int> treeInt;
        private ITree<string> treeString;

        private bool isCreated = false;
        private enum TreeType
        {
            LinkedTree,
            ArrayTree,
            UnmutableTree
        }
        private TreeType type;

        private static CheckDelegate<char> isVowel = (char letter) =>
        {
            string vowels = "aeiouAEIOUаоуэыяёеюиАОУЭЫЯЁЕЮИ";
            return vowels.Contains(letter);
        };
        private static CheckDelegate<char> isConsonant = (char letter) =>
        {
            return !isVowel(letter) && (letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z');
        };

        public AVLTreeDemoForm()
        {
            InitializeComponent();
            treeInt = null;
            treeString = null;
            isCreated = false;
        }

        private void DisplayControls()
        {
            btnAdd.Visible = true;
            btnClear.Visible = true;
            btnContains.Visible = true;
            btnRemove.Visible = true;
            lblIsEmpty.Visible = true;
            lblCount.Visible = true;
            lblMethods.Visible = true;
            lblProperties.Visible = true;
            txtInputAddingValue.Visible = true;
            txtInputRemovingValue.Visible = true;
            txtInputValueContains.Visible = true;
            txtDisplayIsEmpty.Visible = true;
            txtDisplayCount.Visible = true;
        }

        private void linkedTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayControls();

            linkedTreeView.Visible = true;
            arrayTreeView.Visible = false;
            dataGridView.Visible = false;

            if (type == TreeType.ArrayTree)
                btnClear_Click(sender, e);
            else if (type == TreeType.UnmutableTree)
                ClearUnmutableTreeView();

            type = TreeType.LinkedTree;

            RefreshProperties();
        }

        private void arrayTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayControls();

            linkedTreeView.Visible = false;
            arrayTreeView.Visible = true;
            dataGridView.Visible = true;

            if (type == TreeType.LinkedTree)
                btnClear_Click(sender, e);
            else if (type == TreeType.UnmutableTree)
                ClearUnmutableTreeView();

            type = TreeType.ArrayTree;

            RefreshProperties();
        }

        private void ClearUnmutableTreeView()
        {
            linkedTreeView.Nodes.Clear();
            arrayTreeView.Nodes.Clear();
            dataGridView.Rows.Clear();

            treeInt = null;
            treeString = null;

            isCreated = false;
            RefreshProperties();
        }

        private void unmutableTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCreated)
                return;

            if (treeInt != null)
                treeInt = new UnmutableTree<int>(treeInt);
            else if (treeString != null)
                treeString = new UnmutableTree<string>(treeString);

            type = TreeType.UnmutableTree;
        }

        private void RefreshProperties()
        {
            bool isEmpty;
            int count;

            if (!isCreated)
            {
                isEmpty = true;
                count = 0;
            }
            else if (treeInt != null)
            {
                isEmpty = treeInt.IsEmpty;
                count = treeInt.Count;
            }
            else 
            {
                isEmpty = treeString.IsEmpty;
                count = treeString.Count;
            }

            txtDisplayIsEmpty.Text = isEmpty.ToString();
            txtDisplayCount.Text = count.ToString();
        }

        private void RefreshTreeView<T>(ITree<T> tree) where T : IComparable<T>
        {         
            if (tree is LinkedTree<T> linkedTree)
            {
                linkedTreeView.Nodes.Clear();

                if (!linkedTree.IsEmpty)
                {
                    AddNodes(linkedTreeView.Nodes, linkedTree.GetRoot());
                    linkedTreeView.Nodes[0].ExpandAll();
                }
            }
            else if (tree is ArrayTree<T> arrayTree)
            {
                arrayTreeView.Nodes.Clear();

                if (!arrayTree.IsEmpty)
                {
                    AddNodes(arrayTreeView.Nodes, arrayTree.GetNodesArray(), arrayTree.GetRootIndex());
                    arrayTreeView.Nodes[0].ExpandAll();

                    dataGridView.Rows.Clear();
                    var nodes = arrayTree.GetNodesArray();
                    for (int i = 0; i < nodes.Length; ++i)
                    {
                        var node = nodes[i];
                        if (node != null)
                            dataGridView.Rows.Add(i, node.Value, node.LeftChildIndex, node.RightChildIndex, node.Height);
                        else
                            dataGridView.Rows.Add(i, "", "", "", "");
                    }
                }
            }
        }

        private void AddNodes<T>(TreeNodeCollection nodes, LinkedTreeNode<T> node) where T : IComparable<T>
        {
            if (node == null) return;

            var treeNode = nodes.Add(node.Value.ToString());

            AddNodes(treeNode.Nodes, node.Left);
            AddNodes(treeNode.Nodes, node.Right);
        }

        private void AddNodes<T>(TreeNodeCollection nodes, ArrayTreeNode<T>[] array, int nodeIndex) where T : IComparable<T>
        {
            if (nodeIndex == -1) return;

            var treeNode = nodes.Add(array[nodeIndex].Value.ToString());

            AddNodes(treeNode.Nodes, array, array[nodeIndex].LeftChildIndex);
            AddNodes(treeNode.Nodes, array, array[nodeIndex].RightChildIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtInputAddingValue.Text;

            if (input == "")
                return;

            try
            {
                if (!isCreated)
                {
                    if (int.TryParse(input, out int intValue))
                    {
                        if (type == TreeType.LinkedTree)
                            treeInt = new LinkedTree<int>();
                        else if (type == TreeType.ArrayTree)
                            treeInt = new ArrayTree<int>();
                        treeInt.Add(intValue);
                        RefreshTreeView<int>(treeInt);
                    }
                    else
                    {
                        if (type == TreeType.LinkedTree)
                            treeString = new LinkedTree<string>();
                        else if (type == TreeType.ArrayTree)
                            treeString = new ArrayTree<string>();
                        treeString.Add(input);
                        RefreshTreeView<string>(treeString);
                    }

                    isCreated = true;
                    RefreshProperties();
                    SetToolTipsTexts();
                }
                else // isCreated
                {
                    if (treeInt != null)
                    {
                        if (!int.TryParse(input, out int intValue))
                            MessageBox.Show("The value you input must be an integer!");
                        else
                        {
                            treeInt.Add(intValue);
                            RefreshTreeView<int>(treeInt);
                            RefreshProperties();
                        }
                    }
                    else if (treeString != null)
                    {
                        treeString.Add(input);
                        RefreshTreeView<string>(treeString);
                        RefreshProperties();
                    }
                }
            }
            catch (TreeException exc)
            {
                MessageBox.Show(exc.Message);
            }

            txtInputAddingValue.Clear();
        }

        private void SetToolTipsTexts()
        {
            if (treeInt != null)
            {
                existsToolStripMenuItem.ToolTipText = "Check if a multiple of 3 exists in the tree.";
                findAllToolStripMenuItem.ToolTipText = "Find all the elements of the tree whose first and last digits match.";
                forEachToolStripMenuItem.ToolTipText = "Print the doubled elements of the tree.";
                checkForAllToolStripMenuItem.ToolTipText = "Check if all the numbers in the tree are even.";
            }
            else if (treeString != null)
            {
                existsToolStripMenuItem.ToolTipText = "Check if the string in which vowels and consonants alternate exists in the tree.";
                findAllToolStripMenuItem.ToolTipText = "Find all the strings in the tree whose length is 3.";
                forEachToolStripMenuItem.ToolTipText = "Print all the elements from the tree atrer adding the letter \'A\' to the beginning of each tree element.";
                checkForAllToolStripMenuItem.ToolTipText = "Check if all the strings in the tree start with a vowel.";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string input = txtInputRemovingValue.Text;

            if (input == "" || !isCreated)
                return;

            try
            {
                if (treeInt != null)
                {
                    if (!int.TryParse(input, out int intValue))
                        MessageBox.Show("The value you input must be an integer!");
                    else
                    {
                        treeInt.Remove(intValue);
                        RefreshTreeView<int>(treeInt);
                        RefreshProperties();
                    }
                }
                else if (treeString != null)
                {
                    treeString.Remove(input);
                    RefreshTreeView<string>(treeString);
                    RefreshProperties();
                }
            }
            catch (TreeException exc)
            {
                MessageBox.Show(exc.Message);
            }

            txtInputRemovingValue.Clear();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            string input = txtInputValueContains.Text;

            if (input == "" || !isCreated)
                return;

            bool contains;

            if (treeInt != null)
            {
                if (!int.TryParse(input, out int intValue))
                    MessageBox.Show("The value you input must be an integer!");
                else
                {
                    contains = treeInt.Contains(intValue);
                    MessageBox.Show(contains ? "The tree contains the value" : "The tree doesn't contain the value");
                }
            }
            else if (treeString != null)
            {
                contains = treeString.Contains(input);
                MessageBox.Show(contains ? "The tree contains the value" : "The tree doesn't contain the value");
            }

            txtInputValueContains.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!isCreated)
                return;

            try
            {
                if (treeInt != null)
                {
                    treeInt.Clear();
                    RefreshTreeView<int>(treeInt);
                    RefreshProperties();
                    treeInt = null;
                }
                else if (treeString != null)
                {
                    treeString.Clear();
                    RefreshTreeView<string>(treeString);
                    RefreshProperties();
                    treeString = null;
                }
            }
            catch (TreeException exc)
            {
                MessageBox.Show(exc.Message);
            }

            isCreated = false;
        }

        private void existsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool exists;

            if (treeInt != null)
            {
                exists = TreeUtils<int>.Exists(treeInt, (int num) => num % 3 == 0);
                MessageBox.Show(exists ? "A multiple of 3 exists in the tree." : "A multiple of 3 doesn't exist in the tree.");
            }
            else if (treeString != null)
            {
                exists = TreeUtils<string>.Exists(treeString, (string str) =>
                {
                    for (int i = 0; i < str.Length - 1; ++i)
                    {
                        if (isVowel(str[i]) && isVowel(str[i + 1])
                            || isConsonant(str[i]) && isConsonant(str[i + 1]))
                            return false;
                    }
                    return true;
                });
                MessageBox.Show(exists ? "The string in which vowels and consonants alternate exists in the tree." : "The string in which vowels and consonants alternate doesn't exist in the tree.");
            }
        }

        private void findAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "The tree doesn't contain suitable elements.";

            if (treeInt != null)
            {
                TreeUtils<int>.TreeConstructorDelegate intTreeConstructor = (type == TreeType.LinkedTree) ? TreeUtils<int>.LinkedTreeConstructor : TreeUtils<int>.ArrayTreeConstructor;

                ITree<int> goodNodes = TreeUtils<int>.FindAll(treeInt, (int num) =>
                {
                    string numStr = num.ToString();
                    return numStr[0] == numStr[numStr.Length - 1];
                },
                intTreeConstructor);

                if (!goodNodes.IsEmpty)
                {
                    text = "All the elements of the tree whose first and last digits match: ";
                    foreach (int node in goodNodes)
                    {
                        if (text[text.Length - 1] != ' ')
                            text += "; ";
                        text += node;
                    }
                    text += ".";
                }
            }
            else if (treeString != null)
            {
                TreeUtils<string>.TreeConstructorDelegate stringTreeConstructor = (type == TreeType.LinkedTree) ? TreeUtils<string>.LinkedTreeConstructor : TreeUtils<string>.ArrayTreeConstructor;

                ITree<string> goodNodes = TreeUtils<string>.FindAll(treeString, (string str) => str.Length == 3, stringTreeConstructor);

                if (!goodNodes.IsEmpty)
                {
                    text = "All the strings in the tree whose length is 3: ";
                    foreach (string node in goodNodes)
                    {
                        if (text[text.Length - 1] != ' ')
                            text += "; ";
                        text += node;
                    }
                    text += ".";
                }
            }

            MessageBox.Show(text);
        }

        private void forEachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "";

            if (treeInt != null)
            {
                text += "The doubled elements of the tree: ";
                TreeUtils<int>.ForEach(treeInt, (int num) =>
                {
                    if (text[text.Length - 1] != ' ')
                        text += "; ";
                    text += (num *= 2);
                });
            }
            else if (treeString != null)
            {
                text += "All the elements from the tree atrer adding the letter \'A\' to the beginning of each tree element: ";
                TreeUtils<string>.ForEach(treeString, (string str) =>
                {
                    if (text[text.Length - 1] != ' ')
                        text += "; ";
                    text += str.Insert(0, "A");
                });
            }

            text += ".";
            MessageBox.Show(text);
        }

        private void checkForAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool allAreGood;

            if (treeInt != null)
            {
                allAreGood = TreeUtils<int>.CheckForAll(treeInt, (int num) => num % 2 == 0);
                MessageBox.Show(allAreGood ? "All the numbers in the tree are even." : "Not all the numbers in the tree are even.");
            }
            else if (treeString != null)
            {
                allAreGood = TreeUtils<string>.CheckForAll(treeString, (string str) => isVowel(str[0]));
                MessageBox.Show(allAreGood ? "All the strings in the tree start with a vowel." : "Not all the strings in the tree start with a vowel.");
            }
        }
    }
}
