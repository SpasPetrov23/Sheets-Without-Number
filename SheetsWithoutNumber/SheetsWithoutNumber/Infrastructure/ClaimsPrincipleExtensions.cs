namespace SheetsWithoutNumber.Infrastructure
{
    using System.Security.Claims;

    public static class ClaimsPrincipleExtensions
    {
        public static string GetId(this ClaimsPrincipal user) => user.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
