﻿namespace RealEstates.Web.Helpers
{
    using System.Security.Principal;
    using RealEstates.Common.Constants;

    public static class PrincipalExtensions
    {
        public static bool IsLoggedIn(this IPrincipal principal)
        {
            return principal.Identity.IsAuthenticated;
        }

        public static bool IsAdmin(this IPrincipal principal)
        {
            return principal.IsInRole(GlobalConstants.AdministratorRoleName);
        }
    }
}