partial class Program
{
  // In projects that use top-level statements, defining a partial Program class
    // lets you add new methods that belong to the same generated Program class.
    // This avoids using local functions inside Main, which are limited in scope
    // and cannot be accessed from other files or classes.
    static void WhatsMyNamespace()
    {
        WriteLine("Namespace of Program class: {0}", typeof(Program).Namespace ?? "null");
    }
}