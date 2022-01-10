namespace Jgs.Functional.Spec.Explicit
{
    public record Error(string Code, string Message)
    {
        public static Error Foo = new("foo", "this is not the success you're looking for");
    }
}
