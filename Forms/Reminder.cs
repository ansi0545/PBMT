internal class Reminders
{
    public string Text { get; set; }
    public DateTime Date { get; set; }

    public Reminders(string text, DateTime date)
    {
        Text = text;
        Date = date;
    }
}