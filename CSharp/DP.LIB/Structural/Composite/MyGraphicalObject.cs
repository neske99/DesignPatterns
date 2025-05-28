using System.Collections;

namespace DP.LIB.Structural;

public abstract class GraphicalObject : IEnumerable<GraphicalObject>
{
    public virtual IEnumerator<GraphicalObject> GetEnumerator(){
      yield return this;
    }

    public void Display(){
      DisplayMe();
    }

    protected abstract void DisplayMe();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class ComposedGraphicalObject : GraphicalObject
{
  public List<GraphicalObject>Children= new List<GraphicalObject>();//{get;set;}=new List<GraphicalObject>(){};

    public override IEnumerator<GraphicalObject> GetEnumerator()
    {
      return Children.GetEnumerator();
    }

    protected override void DisplayMe()
    {
      foreach(GraphicalObject c in Children)
      {
        c.Display();
      }
    }
}


