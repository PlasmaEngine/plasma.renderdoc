// #pl-version 1
//
// Makes this package directory buildable on its own, outside the engine checkout.

using PlasmaBuild.Core.Configuration;
using PlasmaBuild.Core.Rules;

public class PlasmaRenderDocWorkspace : WorkspaceRules
{
    public PlasmaRenderDocWorkspace(BuildContext context) : base(context)
    {
        TargetNames.Add("RenderDocPlugin");
    }
}
