public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyObject before use
        MyObject = new MyClass();
        Console.WriteLine(MyObject.SomeProperty);
    }

    private MyClass MyObject; //Fixed: the object is now instantiated. 
}

public class MyClass
{
    public string SomeProperty { get; set; } = "Hello";
}