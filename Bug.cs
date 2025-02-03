public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // This line will throw a NullReferenceException if MyProperty is not initialized.
        Console.WriteLine(MyProperty.ToString());
    }
}