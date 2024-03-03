
using System.Collections;
using System.ComponentModel;


using System.Runtime.CompilerServices;

public interface NovelElementIF2
{
    public void delete() { }

    public void save() { }
    public void retrieve() { }

    public void view() { }
    public void edit() { }

}

public interface NovelElementIF:NovelElementIF2
{

}
public interface NovelIF
{
    public void delete() { }
    public void save() { }
    public void retrieve() { }
    public void view() { }
    public void edit() { }
}
public class Novel: NovelIF 
{
    List<NovelElementIF2> nL2;

    public void delete() { }
    public void save() { }
    public void retrieve() { }
    public void view() { }
    public void edit() { }

}


public interface ReadOnlyEditor 
{
    public  void delete();

    public void save();
    public void retrieve();


}

public interface ReadOnlyWriter 
{
    public void view();
    public void edit();



}



public class Administrator
{
    Novel novel;

    public void doit() 
    { 
    
        novel.edit();
    
    }


}



public class Character : NovelElementIF
{
    private List<NovelElementIF> nL;

    public void doit()
    {

    }

}

public class Image : NovelElementIF
{
    private List<NovelElementIF> nL;
}

public class CompositeNovelElement:NovelElementIF,NovelIF
{
    private List<NovelElementIF> nL;
    public List<NovelElementIF> GetNL()
    {
        return nL;
    }
 
    public void SetNL(List<NovelElementIF> newList)
    {
        nL = newList;
    }
}


public class Page: CompositeNovelElement
{
    private List<NovelElementIF> nL;
    public Page() { 
        
    }    
    public Page retrieve()
    {
        return null;

    }
    public void view()
    {

    }
}

public class Column : CompositeNovelElement
{
    private List<NovelElementIF> nL;    public void save(Column column)
    {

    }
}

public class Frame : CompositeNovelElement
{
    private List<NovelElementIF> nL;
}



public class LineOfText:CompositeNovelElement
{
    private List<NovelElementIF> nl;
    private string text;
    public void save(LineOfText lot) {

        lot.save(lot);
    
    }

    public LineOfText(string t)
    {
        this.text = t;
    }



}
public class MyProg
{
    static void main(String[] args)
    {
        CompositeNovelElement cne = new CompositeNovelElement();
        cne.GetNL().Add(new Page());
        cne.GetNL().Add(new Column());

      
       

    }
}