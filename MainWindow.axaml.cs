using Avalonia.Controls;

namespace Dual;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DragEvent(object sender, PointerPressedEventArgs e)
    {
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
            this.BeginMoveDrag(e);
    }

    private void MenuButtonEvent(object sender, RoutedEventArgs e)
    {
        if (sender is Button button)
        {
            this.GetVisualDescendants()
                .Where(x => x.Classes.Contains("Pressed"))
                .SingleOrDefault()?
                .Classes.Remove("Pressed");

            // 在这里发癫

            button.Classes.Add("Pressed");
        }
    }

    private void Search(object sender, KeyEventArgs e)
    {
        if (sender is TextBox box && !string.IsNullOrEmpty(box.Text) && e.Key == Key.Enter)
        {
            this.FindControl<TextBlock>("MainTitle")!.Text = box.Text;
        }
    }
}