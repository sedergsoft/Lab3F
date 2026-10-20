namespace MiniListApp;

public sealed class Form1 : Form
{
    private readonly FlowLayoutPanel _itemsPanel = new()
    {
        Dock = DockStyle.Fill,
        AutoScroll = true,
        Padding = new Padding(12),
        WrapContents = true
    };
    private readonly ToolStripStatusLabel _status = new();
    private MiniList<CheckBox>? _items;
    private int _nextLabel;

    public Form1()
    {
        Text = "Лабораторная работа №3 — MiniList<T>";
        Width = 820;
        Height = 480;
        StartPosition = FormStartPosition.CenterScreen;

        var menu = new MenuStrip();
        AddMenuItem(menu, "Создать список", (_, _) => CreateList());
        AddMenuItem(menu, "Добавить элемент", (_, _) => AddItem());
        AddMenuItem(menu, "Перебор кнопок", (_, _) => CountVisualControls());
        AddMenuItem(menu, "Перебор объектов", (_, _) => CountListItems());

        var statusStrip = new StatusStrip();
        statusStrip.Items.Add(_status);
        Controls.Add(_itemsPanel);
        Controls.Add(statusStrip);
        Controls.Add(menu);
        MainMenuStrip = menu;
    }

    private static void AddMenuItem(MenuStrip menu, string title, EventHandler action)
    {
        var item = new ToolStripMenuItem(title);
        item.Click += action;
        menu.Items.Add(item);
    }

    private void CreateList()
    {
        _items = new MiniList<CheckBox>();
        _itemsPanel.Controls.Clear();
        _nextLabel = 0;
        _status.Text = "Список создан.";
    }

    private void AddItem()
    {
        if (_items is null)
        {
            _status.Text = "Сначала создайте список.";
            return;
        }

        var checkBox = new CheckBox
        {
            Appearance = Appearance.Button,
            AutoSize = true,
            Text = $"Элемент {_nextLabel + 1}",
            Margin = new Padding(6)
        };

        _items.Append(checkBox);
        _itemsPanel.Controls.Add(checkBox);
        _nextLabel++;
        _status.Text = $"Добавлен элемент. Всего: {_items.Count}.";
    }

    private void CountVisualControls()
    {
        int count = _itemsPanel.Controls.OfType<CheckBox>().Count();
        _status.Text = $"Перебор кнопок: {count} элементов.";
    }

    private void CountListItems()
    {
        if (_items is null)
        {
            _status.Text = "Сначала создайте список.";
            return;
        }

        int count = 0;
        foreach (CheckBox item in _items)
        {
            _ = item.Checked;
            count++;
        }

        _status.Text = $"Перебор объектов: {count} элементов.";
    }
}
