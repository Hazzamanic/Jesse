using System.Web.Routing;
using Hazza.Amp.Services;
using Orchard.Themes;

namespace AmpBase {
    public class AmpThemeSelector : IThemeSelector {
        private readonly IAmpAccessor _ampAccessor;

        public AmpThemeSelector(IAmpAccessor ampAccessor) {
            _ampAccessor = ampAccessor;
        }

        public ThemeSelectorResult GetTheme(RequestContext context) {
            if (_ampAccessor.IsAmpRequest)
                return new ThemeSelectorResult() {
                    Priority = 1,
                    ThemeName = "Jesse"
                };

            return null;
        }
    }
}