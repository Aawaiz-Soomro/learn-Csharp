
using System;

public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Write(string data)
    {
        try
        {
            database.BeginTransaction();
            database.Write(data);
            database.EndTransaction();
        }
        finally
        {
            // The finally block ensures the database is disposed of (Closed) 
            // whether the transaction succeeds or throws an exception.
            database.Dispose();
        }
    }

    public bool WriteSafely(string data)
    {
        try
        {
            // Re-use the Write method so we don't duplicate logic
            Write(data);
            return true; // Success
        }
        catch
        {
            // If any exception was thrown in Write(), we catch it here and return false
            return false;
        }
    }
}