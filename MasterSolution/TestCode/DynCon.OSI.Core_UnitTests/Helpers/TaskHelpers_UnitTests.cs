using System;
using System.Threading;
using DynCon.OSI.DynTest;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    public partial class TaskHelpers_UnitTests : DynTestClassBase
    {
        partial void CancellableAction_PreCondition(ref TimeSpan time, ref Action action)
        {
            time = TimeSpan.FromMilliseconds(1);
            action = () => { };
        }


        partial void CancellableDelay_PreCondition(ref TimeSpan time, ref CancellationToken token) { time = TimeSpan.FromMilliseconds(1); }

        partial void DeadmanAction_PreCondition(ref TimeSpan time, ref Action action)
        {
            time = TimeSpan.FromMilliseconds(1);
            action = () => { };
        }

        partial void DeferredAction_PreCondition(ref TimeSpan time, ref Action action)
        {
            time = TimeSpan.FromMilliseconds(1);
            action = () => { };
        }

        partial void Delay_PreCondition(ref TimeSpan time) { time = TimeSpan.FromMilliseconds(1); }
    }
}