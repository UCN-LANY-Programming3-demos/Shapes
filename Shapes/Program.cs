using Shapes;

List<BaseShape> shapes = new();
shapes.Add(new Square());
shapes.Add(new Triangle());
shapes.Add(new Circle());
shapes.Add(new Pentagon());

foreach (var shape in shapes)
{
    shape.Draw();
}