/// <summary>
/// Represents a reminder with text and date.
/// </summary>
internal class Reminders
{
    /// <summary>
    /// Gets or sets the text of the reminder.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets the date of the reminder.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Reminders"/> class with the specified text and date.
    /// </summary>
    /// <param name="text">The text of the reminder.</param>
    /// <param name="date">The date of the reminder.</param>
    public Reminders(string text, DateTime date)
    {
        Text = text;
        Date = date;
    }
}