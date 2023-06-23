using Avalonia.Controls;

namespace Dual;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.Icon = new("./Assets/avalonia-logo.ico");
    }

    private void DragEvent(object sender, PointerPressedEventArgs e)
    {
        if (e.GetCurrentPoint(this).Properties.IsLeftButtonPressed)
            this.BeginMoveDrag(e);
    }
}