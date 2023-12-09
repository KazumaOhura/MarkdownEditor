using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Markdown
{
    public class MarkdownTextBox : TextBox
    {
        static MarkdownTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MarkdownTextBox), new FrameworkPropertyMetadata(typeof(MarkdownTextBox)));
        }
    }
}
