static class Extensions{

    public static int GetWordCount(this string text)
    {
        return text.Split(" ").Length;
    }
}