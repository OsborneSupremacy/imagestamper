using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageStamper.Utility;

public static class StaExecutor
{
    public static void Execute(Action delegateAction)
    {
        Thread thread = new(() =>
        {
            delegateAction.Invoke();
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();
    }

    /// <summary>
    /// Some dialogs needs to be accessed in STA threads. This should be used for those.
    /// </summary>
    /// <param name="dialogDelegate"></param>
    /// <returns></returns>
    public static T Execute<T>(Func<T> dialogDelegate, T defaultValue)
    {
        T valueOut = defaultValue;

        Thread thread = new(() =>
        {
            valueOut = dialogDelegate.Invoke();
        });
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        thread.Join();

        return valueOut;
    }

}
