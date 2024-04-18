using UnrealBuildTool;

public class ParalangsVRServerTarget : TargetRules
{
	public ParalangsVRServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ParalangsVR");
	}
}
