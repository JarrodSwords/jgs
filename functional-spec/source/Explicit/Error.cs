namespace Jgs.Functional.Spec.Explicit
{
    public record Error(string Code, string Message)
    {
        public static Error Bar =
            new("bar", "this is also not the success you're looking for, but at least there's a bar now");

        public static Error Foo = new("foo", "this is not the success you're looking for");
    }
}
