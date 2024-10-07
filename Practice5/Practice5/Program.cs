using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class SendItemHelper { 

    public delegate void ItemEvent();
    public event ItemEvent NewEvent;

    public SendItemHelper() 
    { 
    
    }

    public void SendCoins(int coins)
    {
        if (NewEvent != null) {
            NewEvent();
        }
        Console.WriteLine(coins + " coins");
    }

    public void SendKeys(int keys)
    {
        if (NewEvent != null)
        {
            NewEvent();
        }
        Console.WriteLine(keys + " keys");
    }

    public void SendBombs(int bombs)
    {
        if (NewEvent != null)
        {
            NewEvent();
        }
        Console.WriteLine(bombs + " bombs");
    }
}

class Item {
    
    private SendItemHelper _SendItemHelper;

    public Item(int item)
    {
        _item = item;

        _SendItemHelper = new SendItemHelper();
        _SendItemHelper.NewEvent += SendItemHelper_ItemEvent;

    }

    void SendItemHelper_ItemEvent()
    {
        Console.WriteLine("Item has been sent!");
    }

    private int _item;

    public int item
    {
        get { return _item; }
        set { _item = value; }
    }

    public void SendItem()
    {
        _SendItemHelper.SendKeys(_item);
    }

}

class Program
{
    public static void Main(string[] args)
    {
        Item item = new Item(2000);
        item.SendItem();

    }
}



