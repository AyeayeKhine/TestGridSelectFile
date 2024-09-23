using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc
{
     public static class UrlHelperExtensions
    {
        public static string WelcomeLink(this IUrlHelper urlHelper,string action, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: action,
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }

        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string action, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: action,
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }

        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string action, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: action,
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }
    }

	public static class StringExtensions
    {
        public static void Switch(this string @this, params Expression<Action>[] cases)
        {
            Expression<Action> matchingAction = cases.SingleOrDefault(@case => @case.Parameters[0].Name == @this);
            if (matchingAction == null) return; // no matching action

            matchingAction.Compile()();
        }
    }
}

