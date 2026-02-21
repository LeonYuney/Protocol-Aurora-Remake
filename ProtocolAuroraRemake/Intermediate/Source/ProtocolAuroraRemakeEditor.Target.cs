using UnrealBuildTool;

public class ProtocolAuroraRemakeEditorTarget : TargetRules
{
	public ProtocolAuroraRemakeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProtocolAuroraRemake");
	}
}
