using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationClient;

namespace HuntAndPeck.Extensions
{
    public static class IUIAutomationTreeWalkerExtensions
    {
        public static IEnumerable<IUIAutomationElement> EnumerateChildren(this IUIAutomationTreeWalker source,
            IUIAutomationElement element)
        {
            for (var curElem = source.GetFirstChildElement(element);
                curElem != null;
                curElem = source.GetNextSiblingElement(curElem))
            {
                yield return curElem;
            }
        }

        public static IEnumerable<IUIAutomationElement> EnumerateChildrenBuildCache(this IUIAutomationTreeWalker source,
            IUIAutomationElement element, IUIAutomationCacheRequest cacheRequest)
        {
            for (var curElem = source.GetFirstChildElementBuildCache(element, cacheRequest);
                curElem != null;
                curElem = source.GetNextSiblingElementBuildCache(curElem, cacheRequest))
            {
                yield return curElem;
            }
        }

        public static IEnumerable<IUIAutomationElement> EnumerateChildrenBackwardBuildCache(this IUIAutomationTreeWalker source,
            IUIAutomationElement element, IUIAutomationCacheRequest cacheRequest)
        {
            for (var curElem = source.GetLastChildElementBuildCache(element, cacheRequest);
                curElem != null;
                curElem = source.GetPreviousSiblingElementBuildCache(curElem, cacheRequest))
            {
                yield return curElem;
            }
        }

        public static IEnumerable<IUIAutomationElement> EnumerateSiblingsFrom(this IUIAutomationTreeWalker source,
            IUIAutomationElement element)
        {
            for (var curElem = element;
                curElem != null;
                curElem = source.GetNextSiblingElement(curElem))
            {
                yield return curElem;
            }
        }

        public static IEnumerable<IUIAutomationElement> EnumerateSiblingsFromBuildCache(this IUIAutomationTreeWalker source,
            IUIAutomationElement element, IUIAutomationCacheRequest cacheRequest)
        {
            for (var curElem = element;
                curElem != null;
                curElem = source.GetNextSiblingElementBuildCache(curElem, cacheRequest))
            {
                yield return curElem;
            }
        }

        public static IEnumerable<IUIAutomationElement> EnumerateSiblingsFromBackwardBuildCache(this IUIAutomationTreeWalker source,
            IUIAutomationElement element, IUIAutomationCacheRequest cacheRequest)
        {
            for (var curElem = element;
                curElem != null;
                curElem = source.GetPreviousSiblingElementBuildCache(curElem, cacheRequest))
            {
                yield return curElem;
            }
        }
    }
}
