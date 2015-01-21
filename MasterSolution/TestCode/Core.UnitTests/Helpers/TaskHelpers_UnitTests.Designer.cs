using System;
using System.Threading;
using System.Threading.Tasks;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class TaskHelpers_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CancellableAction_UnitTest()
        {
            TimeSpan time = default(TimeSpan);
            Action action = default(Action);
            CancellationTokenSource _retVal = default(CancellationTokenSource);
            ExecuteMethod(
                () =>
                {
                    time = default(TimeSpan); //No Constructor
                    action = default(Action); //No Constructor
                    CancellableAction_PreCondition(ref time, ref action);
                },
                () => { _retVal = TaskHelpers.CancellableAction(time, action); },
                () => { CancellableAction_PostValidate(time, action, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CancellableDelay_UnitTest()
        {
            TimeSpan time = default(TimeSpan);
            CancellationToken token = default(CancellationToken);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () =>
                {
                    time = default(TimeSpan); //No Constructor
                    token = default(CancellationToken); //No Constructor
                    CancellableDelay_PreCondition(ref time, ref token);
                },
                () => { _retVal = TaskHelpers.CancellableDelay(time, token); },
                () => { CancellableDelay_PostValidate(time, token, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DeadmanAction_UnitTest()
        {
            TimeSpan time = default(TimeSpan);
            Action action = default(Action);
            TaskHelpers.DeadmanHandle _retVal = default(TaskHelpers.DeadmanHandle);
            ExecuteMethod(
                () =>
                {
                    time = default(TimeSpan); //No Constructor
                    action = default(Action); //No Constructor
                    DeadmanAction_PreCondition(ref time, ref action);
                },
                () => { _retVal = TaskHelpers.DeadmanAction(time, action); },
                () => { DeadmanAction_PostValidate(time, action, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void DeferredAction_UnitTest()
        {
            TimeSpan time = default(TimeSpan);
            Action action = default(Action);
            Task _retVal = default(Task);
            ExecuteMethod(
                () =>
                {
                    time = default(TimeSpan); //No Constructor
                    action = default(Action); //No Constructor
                    DeferredAction_PreCondition(ref time, ref action);
                },
                () => { _retVal = TaskHelpers.DeferredAction(time, action); },
                () => { DeferredAction_PostValidate(time, action, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Delay_UnitTest()
        {
            TimeSpan time = default(TimeSpan);
            Task _retVal = default(Task);
            ExecuteMethod(
                () =>
                {
                    time = default(TimeSpan); //No Constructor
                    Delay_PreCondition(ref time);
                },
                () => { _retVal = TaskHelpers.Delay(time); },
                () => { Delay_PostValidate(time, _retVal); });
        }

        partial void CancellableAction_PostValidate(TimeSpan time, Action action, CancellationTokenSource _retVal);
        partial void CancellableAction_PreCondition(ref TimeSpan time, ref Action action);
        partial void CancellableDelay_PostValidate(TimeSpan time, CancellationToken token, Boolean _retVal);
        partial void CancellableDelay_PreCondition(ref TimeSpan time, ref CancellationToken token);
        partial void DeadmanAction_PostValidate(TimeSpan time, Action action, TaskHelpers.DeadmanHandle _retVal);
        partial void DeadmanAction_PreCondition(ref TimeSpan time, ref Action action);
        partial void DeferredAction_PostValidate(TimeSpan time, Action action, Task _retVal);
        partial void DeferredAction_PreCondition(ref TimeSpan time, ref Action action);
        partial void Delay_PostValidate(TimeSpan time, Task _retVal);
        partial void Delay_PreCondition(ref TimeSpan time);
    }
}