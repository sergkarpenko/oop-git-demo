Console.OutputEncoding = System.Text.Encoding.UTF8;

var counter = new ClickCounter("Кнопка");
counter.Click();
counter.Click();
Console.WriteLine(counter);

class ClickCounter(string name)
{
    public int Count { get; private set; }
    public void Click() => Count++;
    public override string ToString() => $"{name}: {Count} натискання";
}
