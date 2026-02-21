using UnrealBuildTool;

public class ProtocolAuroraRemakeTarget : TargetRules
{
	public ProtocolAuroraRemakeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProtocolAuroraRemake");
	}
}
