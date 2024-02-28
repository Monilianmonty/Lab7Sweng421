
using System.ComponentModel;

public interface NovelElementIF2
{

}

public interface NovelElementIF:NovelElementIF2
{

    
}


public class Character : NovelElementIF
{

}

public class Image : NovelElementIF
{

}

public class CompositeNovelElement:NovelElementIF
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


}

public class Column : CompositeNovelElement
{

}

public class Frame : CompositeNovelElement
{

    



}

public class Novel : NovelElementIF2
{
    NovelElementIF2 nL2;



}






public class MyProg
{
    static void main(String[] args)
    {
        CompositeNovelElement cne = new CompositeNovelElement();
        cne.GetNL().Add(new Frame());
    }

}