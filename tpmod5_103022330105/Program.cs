using System;

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tesimpan adalah : {data}");
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> dataNim = new DataGeneric<string>("103022330105");
        dataNim.PrintData();
    }
}
