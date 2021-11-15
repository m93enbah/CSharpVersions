using System;

namespace AwaitInCatchandFinallyPro
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //since C#5
                //await service.InitializeAsync();
            }
            catch (Exception e)
            {
                //since C#6
                //await logger.LogAsync(e);
            }
            finally
            {
                //since C#6
                //await service.CloseAsync();
            }



            //in the previous version of C# 6.0 we have to use

            bool error = false;
            Exception ex = null;

            try
            {
                // Since C#5
                //await service.InitializeAsync();
            }
            catch (Exception e)
            {
                // Declare bool or place exception inside variable
                error = true;
                ex = e;
            }

            // If you don't use the exception
            if (error)
            {
                // Handle async task
            }

            // If want to use information from the exception
            if (ex != null)
            {
                //await logger.LogAsync(e);
            }

            // Close the service, since this isn't possible in the finally
            //await service.CloseAsync();
        }
    }
}
