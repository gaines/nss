namespace DemoLibrary
{
    public class DemoClass
    {
        // This is an auto-implemented property
        // https://msdn.microsoft.com/en-us/library/bb384054.aspx
        public string Name { get; set; }

        // Having more than one method with the same name but different parameters is called overloading.
        // Here we are overloading the constructor, so it can be initialized with or without a name.
        // https://msdn.microsoft.com/en-us/library/ace5hbzh.aspx
        public DemoClass() { }
        public DemoClass(string name)
        {
            Name = name;
        }
    }
}
