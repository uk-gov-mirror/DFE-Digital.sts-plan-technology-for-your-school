using Dfe.PlanTech.Core.Models;

namespace Dfe.PlanTech.Infrastructure.SignIn.Models;

public record UserAuthorisationResult(
    bool PageRequiresAuthorisation,
    UserAuthorisationStatus UserAuthorisationStatus,
    bool WasRedirected = false
)
{
    public const string HttpContextKey = "UserAuthorisationResult";

    public bool AuthenticationMatches =>
        !PageRequiresAuthorisation || UserAuthorisationStatus.IsAuthenticated;

    public bool CanViewPage => !PageRequiresAuthorisation || UserAuthorisationStatus.IsAuthorised;
}
