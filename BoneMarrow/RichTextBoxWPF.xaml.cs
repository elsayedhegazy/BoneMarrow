using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;

namespace BoneMarrow
{
    /// <summary>
    /// Interaction logic for RichTextBoxWPF.xaml
    /// </summary>
    public partial class RichTextBoxWPF : UserControl
    {
        public RichTextBoxWPF()
        {
            InitializeComponent();
            richTextBox1.SpellCheck.IsEnabled = true;
        }
    }
}
