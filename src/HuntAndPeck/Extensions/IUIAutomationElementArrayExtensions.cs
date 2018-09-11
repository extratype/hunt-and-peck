using System.Collections.Generic;
using UIAutomationClient;

namespace HuntAndPeck.Extensions
{
    public static class IUIAutomationElementArrayExtensions
    {
        public static IEnumerable<IUIAutomationElement> AsEnumerable(this IUIAutomationElementArray source)
        {
            for (var i = 0; i < source.Length; ++i)
            {
                yield return source.GetElement(i);
            }
        }
    }
}
