using PlasmaBuild.Core.Configuration;
using PlasmaBuild.Core.Rules;

public class RenderDocPluginModule : ModuleRules
{
    public RenderDocPluginModule(BuildContext context) : base(context)
    {
        PlasmaPackageSdk.ConfigurePackageModule(this, context, "Source/RenderDocPlugin", "RenderDocPluginPCH.h",
            "BUILDSYSTEM_BUILDING_RENDERDOCPLUGIN_LIB");

        // renderdoc_app.h is included as <RenderDocPlugin/ThirdParty/renderdoc_app.h>, so the
        // directory holding RenderDocPlugin has to be on the path.
        PublicIncludePaths.Add(System.IO.Path.Combine(context.ProjectRoot, "Source"));
    }
}
