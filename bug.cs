public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a null object reference
        Console.WriteLine(MyObject.SomeProperty);
    }

    private MyClass MyObject = null; //This is the issue; the object is not instantiated.
}

public class MyClass
{
    public string SomeProperty { get; set; } = "Hello";
}