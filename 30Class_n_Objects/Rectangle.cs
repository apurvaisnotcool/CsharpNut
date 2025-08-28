namespace _30Class_n_Objects;

public class Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }

    //computed Property
    public double Area { get { return Height * Width; } }
    //This is a Computed property in which we are only getting the Height and the width of the 
    //property
    //We cannot set the value here because the setter is not defined
}
