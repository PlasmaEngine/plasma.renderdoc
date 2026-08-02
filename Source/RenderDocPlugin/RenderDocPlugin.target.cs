using PlasmaBuild.Core.Configuration;
using PlasmaBuild.Core.Rules;

public class RenderDocPluginTarget : TargetRules
{
    public RenderDocPluginTarget(BuildContext context) : base(context)
    {
        Type = TargetType.SharedLibrary;
        OutputName = "plRenderDocPlugin";
        OutputDirectory = PlasmaPackageSdk.PackageBinaryDirectory(context);

        UsePCHFiles = true;
        UseUnityBuild = true;
        UseAdaptiveUnityBuild = true;
        UseIncrementalLinking = true;

        ExtraModules.Add("RenderDocPluginModule");
    }
}
