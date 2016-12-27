using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PxP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var parameter1 = new List<String>();
            parameter1.AddRange(parameter1TextBox.Lines);

            var parameter2 = new List<String>();
            parameter2.AddRange(parameter2TextBox.Lines);

            var parameterList = new List<List<string>>();
            parameterList.Add(parameter1);
            parameterList.Add(parameter2);

            // all pare pattern
            var pairs = new List<string>();
            foreach (var each in parameterList)
            {
                pairs = MakePairs(each, pairs);
            }

            var sb = new StringBuilder();
            foreach (var each in pairs)
            {
                sb.AppendLine(each);
            }

            resultTextBox.Text = sb.ToString();
        }

        private List<string> MakePairs(List<String> parameter, List<String> pairs)
        {
            // parameter1か空の場合
            var newPairs = new List<string>();
            if (parameter.Count == 0)
            {
                foreach (var each2 in pairs)
                {
                    if (String.IsNullOrWhiteSpace(each2)) { continue; }
                    newPairs.Add(each2);
                }
                return newPairs;
            }

            // parameter2か空の場合
            if (pairs.Count == 0)
            {
                foreach (var each1 in parameter)
                {
                    if (String.IsNullOrWhiteSpace(each1)) { continue; }
                    newPairs.Add(each1);
                }
                return newPairs;
            }

            // 通常
            foreach (var each1 in parameter)
            {
                foreach (var each2 in pairs)
                {
                    if (String.IsNullOrWhiteSpace(each1)) { continue; }
                    if (String.IsNullOrWhiteSpace(each2)) { continue; }
                    var p = each2 + "," + each1;

                    newPairs.Add(p);
                }
            }

            return newPairs;
        }
    }
}
