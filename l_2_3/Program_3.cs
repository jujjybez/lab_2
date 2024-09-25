using System;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is open.");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Editing the document is available in the Pro version.");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Saving the document is available in the Pro version.");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Document is edited.");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document is saved in the old format, saving in other formats is available in the Expert version.");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Document is saved in the new format.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter user access key: ");
        string userAccessKey = Console.ReadLine();

        DocumentWorker documentWorker;

        switch (userAccessKey)
        {
            case "pro":
                documentWorker = new ProDocumentWorker();
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}
