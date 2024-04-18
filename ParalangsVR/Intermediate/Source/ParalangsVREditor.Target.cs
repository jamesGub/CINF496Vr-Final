using UnrealBuildTool;

public class ParalangsVREditorTarget : TargetRules
{
	public ParalangsVREditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ParalangsVR");
	}
}
