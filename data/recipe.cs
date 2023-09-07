public class Recipe
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<Rating> Ratings { get; set; }
    public ICollection<UsageDate> UsageDates { get; set; }
    public string Difficulty { get; set; }
    public string Portion { get; set; }
    public string Time { get; set; }
    public string Description { get; set; }
    public List<Dictionary<string, string>> Method { get; set; }
    public string Image { get; set; }
}

public class Comment
{
    public int CommentId { get; set; }
    public string Text { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}

public class Rating
{
    public int RatingId { get; set; }
    public int Stars { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}

public class UsageDate
{
    public int UsageDateId { get; set; }
    public DateTime Date { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
