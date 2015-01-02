using System;
using System.Collections.Generic;
using DynCon.OSI.DynTest.Comparisions;

namespace DynCon.OSI.DynTest.ChangeTracking
{
    /// <summary>
    ///     Class GraphCompare.
    /// </summary>
    public class GraphCompare
    {
        /// <summary>
        ///     Reports the changes.
        /// </summary>
        /// <param name="initialGraph">The initial graph.</param>
        /// <param name="finalGraph">The final graph.</param>
        /// <returns>ChangeList.</returns>
        public static ChangeList ReportChanges(CaptureResults initialGraph, CaptureResults finalGraph)
        {
            var instance = new GraphCompare();
            return instance.Execute(initialGraph, finalGraph);
        }

        /// <summary>
        ///     Arrays the compare.
        /// </summary>
        /// <param name="retVal">The ret value.</param>
        /// <param name="originalElement">The original element.</param>
        /// <param name="finalElement">The final element.</param>
        private void ArrayCompare(ChangeList retVal, ObjectGraphCapture.ReferenceElement originalElement, ObjectGraphCapture.ReferenceElement finalElement)
        {
            Compare(retVal, originalElement, finalElement);
            var originalArray = (Array) originalElement.Value;
            var finalArray = (Array) finalElement.Value;
            if ((originalArray == null) || (finalArray == null))
                return;
            var finalList = new List<Tuple<object, int>>();
            var originalList = new List<Tuple<object, int>>();

            for (int index = 0; index < Math.Min(originalArray.Length, finalArray.Length); ++index)
            {
                object originalItem = originalArray.GetValue(index);
                object finalItem = finalArray.GetValue(index);
                if (originalItem != null)
                {
                    if (finalItem != null)
                    {
                        // Both Live!
                        if (!CheckSame(originalItem, finalItem))
                        {
                            originalList.Add(new Tuple<object, int>(originalItem, index));
                            finalList.Add(new Tuple<object, int>(finalItem, index));
                        }
                    }
                    else
                    {
                        //! Original Only
                        originalList.Add(new Tuple<object, int>(originalItem, index));
                    }
                }
                else
                {
                    if (finalItem != null)
                    {
                        // Final Only
                        finalList.Add(new Tuple<object, int>(finalItem, index));
                    }
                }
            }

            var match = new List<Tuple<Tuple<object, int>, Tuple<object, int>>>();
            foreach (Tuple<object, int> originalItem in originalList)
            {
                foreach (Tuple<object, int> finalItem in finalList)
                {
                    if (CheckSame(originalItem.Item1, finalItem.Item1))
                        match.Add(new Tuple<Tuple<object, int>, Tuple<object, int>>(originalItem, finalItem));
                }
            }
            foreach (Tuple<Tuple<object, int>, Tuple<object, int>> item in match)
            {
                if (item.Item1.Item2 != item.Item2.Item2)
                {
                    retVal.Add(new MiscGraphChange("ArrayIndewx,{0}=>{1})", item.Item1.Item2 != item.Item2.Item2));
                }
                originalList.Remove(item.Item1);
                finalList.Remove(item.Item2);
            }
            if (originalList.Count > 0)
                foreach (Tuple<object, int> pair in originalList)
                {
                    object item = pair.Item1;
                    retVal.Add(new MiscGraphChange("ArrayRemove,{0}@{1})", (item != null) ? item.GetType().Name : "{null}", IndexOf(originalArray, item)));
                }
            if (finalList.Count > 0)
                foreach (Tuple<object, int> pair in finalList)
                {
                    object item = pair.Item1;
                    retVal.Add(new MiscGraphChange("ArrayAdd,{0}@{1})", (item != null) ? item.GetType().Name : "{null}", IndexOf(finalArray, item)));
                }
        }

        private static bool CheckSame(object originalItem, object finalItem)
        {
            if (originalItem.GetType().IsValueType)
            {
                return originalItem.Equals(finalItem);
            }
            return ReferenceEquals(originalItem, finalItem);
        }

        /// <summary>
        ///     Compares the specified results.
        /// </summary>
        /// <param name="results">The results.</param>
        /// <param name="originalElement">The original element.</param>
        /// <param name="finalElement">The final element.</param>
        private void Compare(ChangeList results, ObjectGraphCapture.ValueElement originalElement, ObjectGraphCapture.ValueElement finalElement)
        {
            bool areEqual;
            if ((originalElement.Value == null) ^ (finalElement.Value == null))
                areEqual = false;
            else if ((originalElement.Value == null) && (finalElement.Value == null))
                areEqual = true;
            else
// ReSharper disable once PossibleNullReferenceException
                areEqual = originalElement.Value.Equals(finalElement.Value);
            if (!areEqual)
            {
                var diff = new ValueGraphChange
                {
                    Path = originalElement.Path,
                    DeclaredType = originalElement.DeclaredType,
                    OldValue = originalElement.Value,
                    NewValue = finalElement.Value
                };
                results.Add(diff);
            }
        }

        /// <summary>
        ///     Compares the specified results.
        /// </summary>
        /// <param name="results">The results.</param>
        /// <param name="originalElement">The original element.</param>
        /// <param name="finalElement">The final element.</param>
        private void Compare(ChangeList results, ObjectGraphCapture.ReferenceElement originalElement, ObjectGraphCapture.ReferenceElement finalElement)
        {
            bool areEqual = ReferenceEquals(originalElement.Value, finalElement.Value);
            if (!areEqual)
            {
                var diff = new ReferenceGraphChange
                {
                    Path = originalElement.Path,
                    DeclaredType = originalElement.DeclaredType
                };
                results.Add(diff);
            }
        }

        /// <summary>
        ///     Executes the specified initial graph.
        /// </summary>
        /// <param name="initialGraph">The initial graph.</param>
        /// <param name="finalGraph">The final graph.</param>
        /// <returns>ChangeList.</returns>
        /// <exception cref="System.Exception"></exception>
        private ChangeList Execute(CaptureResults initialGraph, CaptureResults finalGraph)
        {
            var retVal = new ChangeList();
            var unusedOriginalKeys = new List<string>(initialGraph.Elements.Keys);
            var unusedFinalKeys = new List<string>(finalGraph.Elements.Keys);
            foreach (KeyValuePair<string, Element> pair in initialGraph.Elements)
            {
                Element originalElement = pair.Value;
                Element finalElement;
                if (finalGraph.Elements.TryGetValue(pair.Key, out finalElement))
                {
                    unusedOriginalKeys.Remove(pair.Key);
                    unusedFinalKeys.Remove(pair.Key);
                    if (originalElement.GetType() != finalElement.GetType())
                        throw new Exception();
                    if (originalElement is ObjectGraphCapture.ReferenceElement)
                    {
                        if (originalElement.DeclaredType.IsArray)
                        {
                            ArrayCompare(retVal, (ObjectGraphCapture.ReferenceElement) originalElement, (ObjectGraphCapture.ReferenceElement) finalElement);
                        }
                        else
                        {
                            Compare(retVal, (ObjectGraphCapture.ReferenceElement) originalElement, (ObjectGraphCapture.ReferenceElement) finalElement);
                        }
                    }
                    else
                    {
                        Compare(retVal, (ObjectGraphCapture.ValueElement) originalElement, (ObjectGraphCapture.ValueElement) finalElement);
                    }
                }
            }
            foreach (string key in unusedOriginalKeys)
            {
                Element item = initialGraph.Elements[key];
                var diff = new MissingGraphChange
                {
                    Path = item.Path,
                    DeclaredType = item.DeclaredType,
                };
                var asValueChange = item as ObjectGraphCapture.ValueElement;
                if (asValueChange != null)
                    diff.OldValue = asValueChange.Value;
                retVal.Add(diff);
            }
            foreach (string key in unusedFinalKeys)
            {
                Element item = finalGraph.Elements[key];
                var diff = new AddedGraphChange
                {
                    Path = item.Path,
                    DeclaredType = item.DeclaredType,
                };
                var asValueChange = item as ObjectGraphCapture.ValueElement;
                if (asValueChange != null)
                    diff.NewValue = asValueChange.Value;
                retVal.Add(diff);
            }
            return retVal;
        }

        private object IndexOf(Array array, object item)
        {
            for (int index = 0; index < array.Length; ++index)
                if (ReferenceEquals(array.GetValue(index), item))
                    return index;
            return -1;
        }
    }
}