using System.Windows.Controls;

namespace MarkdownViewer.ViewModel
{
    public class MainWindowViewModel
    {
        public Command.FileOpenCommand FileOpenCommand { get; }
        public string Document { get; set; } = "";
        public MainWindowViewModel() 
        {
            FileOpenCommand = new Command.FileOpenCommand();
        }

        // テキストボックスが変わったとき
        public void OnSourceTextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender is TextBox textBox)
            {
                // HTMLへ変換
                this.Document = ToHtml(textBox.Text);
            }else{
                // TODO: ログ出力(引数の型が異なるとき)
            }
        }
    }
}
