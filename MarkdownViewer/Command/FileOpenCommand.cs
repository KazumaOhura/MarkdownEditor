using Microsoft.Win32;
using System;
using System.Windows.Input;

namespace MarkdownViewer.Command
{
    // ファイルを開く
    public class FileOpenCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            OpenFileDialog dialog = new();
            dialog.FileName = "";
            dialog.InitialDirectory = @"F:\";
            dialog.Filter = "All(*.*)|*.*";
            dialog.FilterIndex = 0;
            dialog.RestoreDirectory = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;

            if(dialog.ShowDialog() is true)
            {
                using (var stream = dialog.OpenFile())
                {

                }
            }
        }
    }
}
