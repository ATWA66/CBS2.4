//task 5

Title title = new Title();
title.Content = "Контракт";

Body body = new Body();
body.Content = "Тело контракта...";

Footer footer = new Footer();
footer.Content = "Директор: Иванов И.И.";

Document document = new Document(title, body, footer);
document.Show();
Console.WriteLine("//////");
title.show();
body.show();
footer.show();

// Delay.
Console.ReadKey();
abstract class doc
{
    public string content;
    public string Content
    {
        private get
        {
            if (content != null)
                return content;
            else
                return "Тело документа отсутствует.";
        }
        set
        {
            content = value;
        }
    }
    public void show() {
        Console.WriteLine(Content);
     }
}
class Body : doc
{
    public string Content
    {
        private get
        {
            if (content != null)
                return content;
            else
                return "Тело документа отсутствует.";
        }
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
class Footer : doc
{
    public string Content
    {
        private get
        {
            if (content != null)
                return content;
            else
                return "Нижний колонтитул отсутствует.";
        }
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
class Title : doc
{
    public string Content
    {
        private get
        {
            if (content != null)
                return content;
            else
                return "Заголовок отсутствует.";
        }
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
class Document
{
    // Поля
    Title title;
    Body body;
    Footer footer;

    public Document(Title title, Body body, Footer footer)
    {
        this.title = title;
        this.body = body;
        this.footer = footer;
    }

    public void Show()
    {
        this.title.Show();
        this.body.Show();
        this.footer.Show();
    }
}